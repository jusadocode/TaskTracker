using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskTracker.Classes;

namespace TaskTracker
{
    
    public partial class CreateNewTaskForm : Form
    {

        IBugRequester callingForm;
        Project currentProject;
        public CreateNewTaskForm(IBugRequester caller, Project model)
        {
            InitializeComponent();
            InitializeDropDowns();
            callingForm = caller;
            currentProject = model;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void InitializeDropDowns()
        {
            DifficultyBox.DataSource = new List<string> { "Easy", "Medium", "Hard" };
            PriotityComboBox.DataSource = new List<string> { "Low", "Medium", "High" };
        }

        private void CreateBugButton_Click(object sender, EventArgs e)
        {
            DateTime deadline = new DateTime();

            string error = BugIsValid(ref deadline);

            if (error == "")
            {              
                Bug model = new Bug(BugTitleText.Text, DateTime.Now, deadline, PriotityComboBox.SelectedItem.ToString(), DifficultyBox.SelectedItem.ToString());
                model.ProjectID = currentProject.ID;
                if(!GlobalConfig.DemoModeEnabled)
                    GlobalConfig.Connection.CreateTask(model);
                callingForm.BugComplete(model);
                this.Close();
            }
            else
            {
                MessageBox.Show(error);
            }
           
        }
        private string BugIsValid(ref DateTime deadline)
        {
            double hour = 0;
            double minute = 0;
            bool validHours = double.TryParse(hourTextBox.Text, out hour);
            bool validMins = double.TryParse(minuteTextBox.Text, out minute);

            deadline = new DateTime(DeadlinePicker.Value.Year, DeadlinePicker.Value.Month, DeadlinePicker.Value.Day);

            deadline = deadline.AddHours(hour).AddMinutes(minute);


            if (BugTitleText.Text == string.Empty)
                return "Please name your bug.";
            if (deadline.Subtract(DateTime.Now) < TimeSpan.Zero)
                return "Please pick a valid deadline";
            if(!validHours || hour < 0 || hour > 23)
                return "Please pick a valid specific time (hours)";
            if (!validMins || minute < 0 || minute > 59)
                return "Please pick a valid specific time (minutes)";
            return "";
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void SpecificTimeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SpecificTimeCheckBox.Checked)
                AdvancedTimeBox.Visible = true;
            else
                AdvancedTimeBox.Visible = false;
        }

        private void CreateNewTaskForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                foreach (Form frm in Application.OpenForms)
                {
                    frm.WindowState = FormWindowState.Minimized;
                }
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                foreach (Form frm in Application.OpenForms)
                {
                    frm.WindowState = FormWindowState.Normal;
                }
            }
        }
    }
}
