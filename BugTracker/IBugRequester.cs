using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracker.Classes;

namespace TaskTracker
{
    /// <summary>
    /// Interface for processing various methods of a task across forms
    /// </summary>
    public interface IBugRequester
    {
        void BugComplete(Bug model);
        void BugUpdated(Bug model);
    }
}
