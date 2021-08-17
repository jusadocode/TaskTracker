using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracker.Classes;
using System.Windows.Forms;
using System.Configuration;

namespace TaskTracker
{
    public partial class DemoViewerForm : Form, IBugRequester
    {

        private List<Bug> bugList = new List<Bug>();
        private List<Bug> finishedBugs = new List<Bug>();
        private List<Bug> failedBugs = new List<Bug>();
        private Project currentProject;
        private bool balloonShown = false;



        private ListViewColumnSorter lvwColumnSorter;

        Timer mainTimer;

        public DemoViewerForm()
        {
            InitializeComponent();
            lvwColumnSorter = new ListViewColumnSorter();
            this.BugListView.ListViewItemSorter = lvwColumnSorter;

            mainTimer = new Timer();
            mainTimer.Interval = 500; // 1 sec
            mainTimer.Tick += new EventHandler(timer_Tick);
            mainTimer.Start();

            currentProject = new Project() { Title = "Tasks_Demo" };

            label5.Text = currentProject.Title;

            PopulateSecondList();
            UpdateFailedBugListView();
            InitializeListViewer();
            InitializeSecondListViewer();
            InitializeThirdListViewer();


            InitializeListOfTasks();
            PopulateFirstList();

            this.FormClosed += new FormClosedEventHandler(TrackerViewerForm_FormClosed);


        }
        private void InitializeListOfTasks()
        {
            if (currentProject.Tasks != null)
                bugList = currentProject.Tasks;

        }
       
        private void timer_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();

            UpdateListViewer();
            AddToFailedBugList();
            UpdatePriorityColors();
            UpdateDifficultyColors();

        }

        private void InitializeListViewer()
        {
            BugListView.View = View.Details;
            BugListView.Columns.Add("Name", 200, HorizontalAlignment.Left);
            BugListView.Columns.Add("Addition time", 100, HorizontalAlignment.Left);
            BugListView.Columns.Add("Time left", 100, HorizontalAlignment.Left);
            BugListView.Columns.Add("Priority", 100, HorizontalAlignment.Left);
            BugListView.Columns.Add("Difficulty", 100, HorizontalAlignment.Left);

            BugListView
            .GetType()
            .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
            .SetValue(BugListView, true, null);

        }
        private void UpdatePriorityColors()
        {
            foreach (Bug bug in bugList.ToList())
            {
                int index = bugList.IndexOf(bug);
                BugListView.Items[index].UseItemStyleForSubItems = false;
                if (bug.Priority != "High")
                {
                    if (bug.TimeToFinish <= TimeSpan.FromMinutes(60))
                    {
                        bugList.ElementAt(index).Priority = "High";
                        BugListView.Items[index].SubItems[3].Text = bug.Priority;

                    }
                    else if (bug.TimeToFinish <= TimeSpan.FromHours(24))
                    {
                        bugList.ElementAt(index).Priority = "Medium";
                        BugListView.Items[index].SubItems[3].BackColor = Color.LightGoldenrodYellow;
                    }
                    else
                    {
                        if (bug.Priority != "Medium")
                        {
                            BugListView.Items[index].SubItems[3].BackColor = Color.LightSeaGreen;
                        }
                        else
                            BugListView.Items[index].SubItems[3].BackColor = Color.LightGoldenrodYellow;
                    }

                }
                else
                {
                    BugListView.Items[index].SubItems[3].BackColor = Color.LightPink;
                }


            }
        }
        private void UpdateDifficultyColors()
        {
            foreach (Bug bug in bugList.ToList())
            {
                int index = bugList.IndexOf(bug);
                switch (bug.Difficulty)
                {
                    case "Hard":
                        BugListView.Items[index].SubItems[4].BackColor = Color.IndianRed;
                        break;
                    case "Medium":
                        BugListView.Items[index].SubItems[4].BackColor = Color.LightGoldenrodYellow;
                        break;
                    case "Easy":
                        BugListView.Items[index].SubItems[4].BackColor = Color.LawnGreen;
                        break;
                    default:
                        break;

                }

            }
        }
        private void InitializeSecondListViewer()
        {
            finishedBugListView.View = View.Details;
            finishedBugListView.Columns.Add("Name", 200, HorizontalAlignment.Left);
            finishedBugListView.Columns.Add("Finish time", 100, HorizontalAlignment.Left);
            SetFinishedListColor();

        }
        private void SetFailedListColor()
        {
            if (failedBugs.Count > 0)
                FailedBugListView.BackColor = Color.OrangeRed;
            else
                FailedBugListView.BackColor = Color.Gray;
        }
        private void SetFinishedListColor()
        {
            if (finishedBugs.Count > 0)
                finishedBugListView.BackColor = Color.LightGreen;
            else
                finishedBugListView.BackColor = Color.Gray;
        }
        private void InitializeThirdListViewer()
        {
            FailedBugListView.View = View.Details;
            FailedBugListView.Columns.Add("Name", 200, HorizontalAlignment.Left);
            FailedBugListView.Columns.Add("End time", 100, HorizontalAlignment.Left);
            SetFailedListColor();

        }
        private void PopulateFirstList()
        {
            BugListView.Items.Clear();

            foreach (Bug bug in bugList)
            {
                BugListView.Items.Add(new ListViewItem(new string[] { bug.Title, bug.StartingDate.ToString(), bug.TimeLeft(), bug.Priority, bug.Difficulty }));
            }
        }
        private void AddToFailedBugList()
        {
            foreach (Bug bug in bugList.ToList())
            {
                if (bug.TimeToFinish <= TimeSpan.Zero)
                {
                    int index = bugList.IndexOf(bug);
                    failedBugs.Add(bug);
                    SetFailedListColor();
                    bugList.Remove(bug);
                    BugListView.Items[index].Remove();
                    string hours = bug.Deadline.Hour.ToString();
                    if (bug.Deadline.Hour < 10)
                        hours = "0" + hours;
                    string mins = bug.Deadline.Minute.ToString();
                    if (bug.Deadline.Minute < 10)
                        mins = "0" + mins;
                    string day = "";
                    if (bug.Deadline.Day == DateTime.Now.AddDays(-1).Day)
                        day = "( yesterday )";
                    else if (bug.Deadline.Day == DateTime.Now.Day)
                        day = "( today )";
                    FailedBugListView.Items.Add(new ListViewItem(new string[] { bug.Title, $"{ hours }:{ mins } { day }" }));

                }

            }
        }
        private void UpdateListViewer()
        {

            BugListView.BeginUpdate();
            try
            {
                for (int i = 0; i < BugListView.Items.Count; i++)
                {
                    BugListView.Items[i].SubItems[0].Text = bugList.ElementAt(i).Title;
                    BugListView.Items[i].SubItems[1].Text = bugList.ElementAt(i).StartingDate.ToString();
                    BugListView.Items[i].SubItems[2].Text = bugList.ElementAt(i).TimeLeft();
                    BugListView.Items[i].SubItems[3].Text = bugList.ElementAt(i).Priority;
                    BugListView.Items[i].SubItems[4].Text = bugList.ElementAt(i).Difficulty;
                }
            }
            finally { BugListView.EndUpdate(); }

        }



        private void PopulateSecondList()
        {
            finishedBugListView.Items.Clear();
            foreach (Bug bug in finishedBugs)
            {
                string hours = bug.FinishTime.Hour.ToString();
                if (bug.FinishTime.Hour < 10)
                    hours = "0" + hours;
                string mins = bug.FinishTime.Minute.ToString();
                if (bug.FinishTime.Minute < 10)
                    mins = "0" + mins;
                string day = "";
                if (bug.FinishTime.Day == DateTime.Now.AddDays(-1).Day)
                    day = "( yesterday )";
                else if (bug.FinishTime.Day == DateTime.Now.Day)
                    day = "( today )";
                finishedBugListView.Items.Add(new ListViewItem(new string[] { bug.Title, $"{ hours }:{ mins } { day }" }));
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Remove from the list and listView
            RemoveBugs();
        }
        private void RemoveBugs()
        {
            if (BugListView.SelectedItems.Count > 0)
            {
                var box = MessageBox.Show("Are you sure you want to remove selected items?", "Delete", MessageBoxButtons.YesNo);

                if (box == DialogResult.Yes)
                {
                    foreach (ListViewItem item in BugListView.SelectedItems)
                    {
                        Bug toRemove = bugList.Where(x => x.Title == item.SubItems[0].Text).First();
                        bugList.Remove(toRemove);
                    }
                    PopulateFirstList();
                    MessageBox.Show("Selected tasks removed successfully.");
                }

            }
            else
                MessageBox.Show("Select the items you want to remove.");
        }

        private void FinishBugs()
        {
            if (BugListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in BugListView.SelectedItems)
                {
                    Bug toRemove = bugList.Where(x => x.Title == item.SubItems[0].Text).First();
                    toRemove.FinishTime = DateTime.Now;
                    bugList.Remove(toRemove);
                    finishedBugs.Add(toRemove);
                    SetFinishedListColor();
                }
                PopulateSecondList();
                PopulateFirstList();

            }

            else
                MessageBox.Show("Select the items you want to finish.");
        }

        private void MarkButton_Click(object sender, EventArgs e)
        {
            FinishBugs();
        }


        private void AddBugButton_Click(object sender, EventArgs e)
        {
            CreateNewTaskForm frm = new CreateNewTaskForm(this, currentProject);
            frm.ShowDialog();
        }

        private void TrackerViewerForm_Load(object sender, EventArgs e)
        {

        }

        public void BugComplete(Bug model)
        {
            bugList.Add(model);
            PopulateFirstList();
        }

        private void finishedBugListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm frm = new SettingsForm();
            
            foreach(Control ctrl in frm.Controls)
            {
                ctrl.Enabled = false;
            }
            frm.ShowDialog();
            
        }

        private void TrackerViewerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainTimer.Stop();
        }

        private void FailedBugListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FailedBugListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (FailedBugListView.SelectedItems.Count > 0)
                MoveTasksButton.Visible = true;
            else
                MoveTasksButton.Visible = false;
        }
        private void UpdateFailedBugListView()
        {
            FailedBugListView.Items.Clear();
            foreach (Bug bug in failedBugs)
            {
                string day = "";
                if (bug.Deadline.Day == DateTime.Now.AddDays(-1).Day)
                    day = "( yesterday )";
                else if (bug.Deadline.Day == DateTime.Now.Day)
                    day = "( today )";
                FailedBugListView.Items.Add(new ListViewItem(new string[] { bug.Title, $"{ bug.Deadline.Hour }:{ bug.Deadline.Minute } { day }" }));
            }
        }

        private void MoveTasksButton_Click(object sender, EventArgs e)
        {
            if (FailedBugListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in FailedBugListView.SelectedItems)
                {
                    Bug toRemove = failedBugs.Where(x => x.Title == item.SubItems[0].Text).First();
                    toRemove.FinishTime = DateTime.Now;
                    failedBugs.Remove(toRemove);
                    SetFailedListColor();
                    finishedBugs.Add(toRemove);
                    SetFinishedListColor();
                    PopulateSecondList();
                    MoveTasksButton.Visible = false;
                    UpdateFailedBugListView();
                }
            }
        }

        private void BugListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = BugListView.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MarkButton_Click(sender, e);
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EditBugButton_Click(sender, e);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }

        private void BugListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            TaskLogic.SortListView(ref bugList, lvwColumnSorter, e);
        }

        public void BugUpdated(Bug model)
        {
            foreach (Bug task in bugList)
            {
                if (task.ID == model.ID)
                {
                    task.Title = model.Title;
                    task.Deadline = model.Deadline;
                    task.Priority = model.Priority;
                    task.Difficulty = model.Difficulty;
                    break;
                }
            }
        }

        private void EditBugButton_Click(object sender, EventArgs e)
        {
            if (BugListView.SelectedItems.Count > 0)
            {
                int index = BugListView.SelectedItems[0].Index;
                EditTaskForm frm = new EditTaskForm(bugList.ElementAt(index), this);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select the item you want to edit.");
            }


        }

        private void TrackerViewerForm_SizeChanged(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)   
            if (this.WindowState == FormWindowState.Minimized)
            {
                foreach (Form frm in Application.OpenForms)
                {
                    frm.Hide();
                    //frm.WindowState = FormWindowState.Minimized;

                }
                notifyIcon1.Visible = true;
                if (!balloonShown)
                {
                    notifyIcon1.ShowBalloonTip(5);
                    balloonShown = true;
                }


            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                foreach (Form frm in Application.OpenForms)
                {
                    //frm.WindowState = FormWindowState.Normal;
                    frm.Show();
                }
            }
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                notifyIcon1.Visible = false;
            }

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
