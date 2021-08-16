using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracker.Classes
{
    /// <summary>
    /// Class of a project
    /// </summary>
    public class Project
    {
        /// <summary>
        /// ID of the project
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Name of the project/activity
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// A list of tasks to accomplish
        /// </summary>
        public List<Bug> Tasks { get; set; }

        //public Project() { }
        //public Project(string title)
        //{
        //    this.Title = title;
            

        //}


    }
}
