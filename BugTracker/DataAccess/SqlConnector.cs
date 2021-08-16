using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracker.Classes;
using Dapper;
using System.Data;
using System.Globalization;

namespace TaskTracker.DataAccess
{
    /// <summary>
    /// Connector class for sql operations/methods
    /// </summary>

    public class SqlConnector : IDataConnection
    {
        private const string database = "TaskTracker";

        public void CreateProject(Project model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnVal(database)))
            {
                var p = new DynamicParameters();

                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@name", model.Title);

                connection.Execute("dbo.Project_Insert", p, commandType: CommandType.StoredProcedure);

                model.ID = p.Get<int>("@Id");

            }
        }

        public void CreateTask(Bug model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnVal(database)))
            {
                var p = new DynamicParameters();
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@ProjectID", model.ProjectID);
                p.Add("@Title", model.Title);
                p.Add("@startDate", model.StartingDate);
                p.Add("@Deadline", model.Deadline);
                p.Add("@Difficulty", model.Difficulty);
                p.Add("@Priority", model.Priority);

                connection.Execute("dbo.Task_Insert", p, commandType: CommandType.StoredProcedure);

                model.ID = p.Get<int>("@id");
            
            }
        }
        public void EndTask(Bug model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnVal(database)))
            {
                var p = new DynamicParameters();

                p.Add("id",model.ID);

                connection.Execute("dbo.Task_End", p, commandType: CommandType.StoredProcedure);


            }
        }
        public void FinishTask(Bug model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnVal(database)))
            {
                var p = new DynamicParameters();

                p.Add("id",model.ID);
                p.Add("finishTime", model.FinishTime);

                connection.Execute("dbo.Task_Complete", p, commandType: CommandType.StoredProcedure);


            }
        }
        public void UpdatePriorities(Project model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnVal(database)))
            {

                foreach (Bug task in model.Tasks)
                {
                    var p = new DynamicParameters();
                    p.Add("@ProjectID", model.ID);
                    p.Add("@id", task.ID);
                    p.Add("@priority", task.Priority);

                    connection.Execute("dbo.Tasks_Update_Priorities", p, commandType: CommandType.StoredProcedure);
                }

            }
        }

        public List<Project> Get_Projects()
        {
            List<Project> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnVal(database)))
            {
                output = connection.Query<Project>("dbo.Get_Projects_All").ToList();
              
                foreach (Project proj in output)
                {
                    var p = new DynamicParameters();
                    p.Add("@ProjectID", proj.ID);

                    proj.Tasks = connection.Query<Bug>("dbo.Tasks_GetByProjectID",
                        p, commandType: CommandType.StoredProcedure).ToList();
                }
                return output;
            }
        }

        //public List<Bug> Get_Tasks(Project model)
        //{
        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnVal(database)))
        //    {

        //        return connection.Query<Bug>("dbo.Tasks_GetByProjectID").ToList();
        //    }
        //}

        public List<Bug> GetRecentlyFinishedTasks(Project model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnVal(database)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@projectID", model.ID);

                return connection.Query<Bug>("dbo.Tasks_Get_ByActivity", p, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public void UpdateTask(Bug model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnVal(database)))
            {
                var p = new DynamicParameters();
                p.Add("@id", model.ID);
                p.Add("@projectID", model.ProjectID);
                p.Add("@title", model.Title);
                p.Add("@deadline", model.Deadline);
                p.Add("@difficulty", model.Difficulty);
                p.Add("@priority", model.Priority);

                connection.Execute("dbo.Task_Update", p, commandType: CommandType.StoredProcedure);



            }
        }

        public void DeleteTask(Bug model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnVal(database)))
            {
                var p = new DynamicParameters();

                p.Add("id", model.ID);

                connection.Execute("dbo.Task_Delete", p, commandType: CommandType.StoredProcedure);


            }
        }
    }
}
