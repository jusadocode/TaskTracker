using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracker.Classes;

namespace TaskTracker.DataAccess
{
    /// <summary>
    /// Interface for various methods processed in SQL (and other) connections
    /// </summary>
    public interface IDataConnection
    {

        void FinishTask(Bug model);
        void EndTask(Bug model);
        void DeleteTask(Bug model);
        void UpdatePriorities(Project model);
        void UpdateTask(Bug model);

        //List<Bug> Get_Tasks(Project model);
        List<Project> Get_Projects();
        List<Bug> GetRecentlyFinishedTasks(Project model);
        void CreateTask(Bug model);
        void CreateProject(Project model);
    }
}
