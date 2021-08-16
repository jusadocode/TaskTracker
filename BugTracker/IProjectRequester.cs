using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracker.Classes;

namespace TaskTracker
{
    /// <summary>
    /// Interface for processing methods with a project across forms
    /// </summary>
    public interface IProjectRequester
    {
        void ProjectComplete(Project model);
    }
}
