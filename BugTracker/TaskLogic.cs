using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracker.Classes;
using System.Windows.Forms;

namespace TaskTracker
{
    /// <summary>
    /// Class used for various higher scope procedures involving tasks
    /// </summary>
    public static class TaskLogic
    {
        public static void SendEmail(Bug task, Project currentProject)
        {
            StringBuilder body = new StringBuilder();
            string subject = $"Task is nearing to an End";
            body.AppendLine($"<h1>Hello, looks like your task \"{ task.Title }\" from { currentProject.Title } is close to the deadline!</h1>");
            body.AppendLine($"<p>Time left: { task.TimeLeft() }</p>");

            body.AppendLine("<p>Make sure to take a look at it while you can.</p>");

            body.AppendLine("Have a great day!");
            body.AppendLine("~Task Tracker");

            string to = Properties.Settings.Default.Email;

            EmailLogic.SendEmail(to, to, subject, body.ToString());
        }
        public static void SortListView(ref List<Bug> bugList, ListViewColumnSorter lvwColumnSorter, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            //// Perform the sort with these new sort options.

            switch (e.Column)
            {
                case 0:
                    {
                        if (lvwColumnSorter.Order == SortOrder.Descending)
                            bugList = bugList.OrderByDescending(x => x.Title).ToList();
                        else
                            bugList = bugList.OrderBy(x => x.Title).ToList();
                        break;
                    }
                case 1:
                    {
                        if (lvwColumnSorter.Order == SortOrder.Descending)
                            bugList = bugList.OrderByDescending(x => x.StartingDate).ToList();
                        else
                            bugList = bugList.OrderBy(x => x.StartingDate).ToList();
                        break;
                    }
                case 2:
                    {
                        if (lvwColumnSorter.Order == SortOrder.Descending)
                            bugList = bugList.OrderByDescending(x => x.TimeToFinish).ToList();
                        else
                            bugList = bugList.OrderBy(x => x.TimeToFinish).ToList();
                        break;
                    }
                case 3:
                    {
                        if (lvwColumnSorter.Order == SortOrder.Descending)
                            bugList = bugList.OrderByDescending(x => x.Priority).ToList();
                        else
                            bugList = bugList.OrderBy(x => x.Priority).ToList();
                        break;
                    }
                case 4:
                    {
                        if (lvwColumnSorter.Order == SortOrder.Descending)
                            bugList = bugList.OrderByDescending(x => x.Difficulty).ToList();
                        else
                            bugList = bugList.OrderBy(x => x.Difficulty).ToList();
                        break;
                    }

            }
        }
    }
}
