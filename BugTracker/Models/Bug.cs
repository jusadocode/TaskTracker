using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracker.Classes
{
    /// <summary>
    /// Class of a task and its properties
    /// </summary>
    public class Bug
    {
        /// <summary>
        /// Identification number of a bug
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Identification number of the project the task is currently in
        /// </summary>
        public int ProjectID { get; set; }
        /// <summary>
        /// Name of the bug
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Creation date of the bug
        /// </summary>
        public DateTime StartingDate { get; set; }
        /// <summary>
        /// The date bug needs to be fixed
        /// </summary>
        public DateTime Deadline { get; set; }
        /// <summary>
        /// The time this bug was finished
        /// </summary>
        public DateTime FinishTime { get; set; }
        /// <summary>
        /// Difficulty of the bug
        /// </summary>
        public string Difficulty { get; set; }
        /// <summary>
        /// Priority of the bug
        /// </summary>
        public string Priority { get; set; }

        public Bug() { }
        public Bug(string name, DateTime start, DateTime end, string priority, string difficulty) 
        {
            this.Title = name;
            this.StartingDate = start;
            this.Deadline = end;
            this.Priority = priority;
            this.Difficulty = difficulty;
        }
        
        public TimeSpan TimeToFinish
        {
            get
            {
                TimeSpan interval = this.Deadline.Subtract(DateTime.Now);
                return interval;
            }


        }
        public string TimeLeft()
        {
            TimeSpan interval = this.TimeToFinish;
            int daysDiff = interval.Days;
            int hoursDiff = interval.Hours;
            int minutesDiff = interval.Minutes;
            int secondsDiff = interval.Seconds;

            //double minutesTotal = interval.TotalMinutes;
            //double secondsTotal = interval.TotalSeconds;

            if (daysDiff > 1)
                return $"{daysDiff} days {hoursDiff} hours";
            else if (daysDiff == 1)
                return $"{daysDiff} day {hoursDiff} hours";
            if (hoursDiff > 1)
                return $"{hoursDiff} hours { minutesDiff } minutes";
            else if (hoursDiff == 1)
                return $"{hoursDiff} hour {minutesDiff} minutes";
            if (minutesDiff > 1)
                return $"{ minutesDiff } minutes { secondsDiff } seconds";
            else if (minutesDiff == 1)
                return $"{ minutesDiff } minute { secondsDiff } seconds";
            if (secondsDiff > 0)
                return $"{ secondsDiff } seconds";
            return "0";
          

        }

    }

}
