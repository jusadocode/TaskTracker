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
    public partial class EditTaskForm : Form
    {
        private Bug taskToModify;
        IBugRequester callingForm;

        public EditTaskForm(Bug task, IBugRequester caller)
        {
            InitializeComponent();
            taskToModify = task;
            callingForm = caller;
            InitializeDropDowns();
            FillInTaskInfo();

        }
        private void FillInTaskInfo()
        {
            titleTextBox.Text = taskToModify.Title;
            deadlinePicker.Value = taskToModify.Deadline;
            priorComboBox.Text = taskToModify.Priority;
            diffComboBox.Text = taskToModify.Difficulty;
            hourTextBox.Text = taskToModify.Deadline.Hour.ToString();
            minuteTextBox.Text = taskToModify.Deadline.Minute.ToString();

        }
        private string BugIsValid(ref DateTime deadline)
        {
            double hour = 0;
            double minute = 0;
            bool validHours = double.TryParse(hourTextBox.Text, out hour);
            bool validMins = double.TryParse(minuteTextBox.Text, out minute);

            deadline = new DateTime(deadlinePicker.Value.Year, deadlinePicker.Value.Month, deadlinePicker.Value.Day);

            deadline = deadline.AddHours(hour).AddMinutes(minute);


            if (titleTextBox.Text == string.Empty)
                return "Please name your bug.";
            if (deadline.Subtract(DateTime.Now) < TimeSpan.Zero)
                return "Please pick a valid deadline";
            if (!validHours || hour < 0 || hour > 23)
                return "Please pick a valid specific time (hours)";
            if (!validMins || minute < 0 || minute > 59)
                return "Please pick a valid specific time (minutes)";
            return "";
        }
        private void InitializeDropDowns()
        {
            diffComboBox.DataSource = new List<string> { "Easy", "Medium", "Hard" };
            priorComboBox.DataSource = new List<string> { "Low", "Medium", "High" };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime deadline = new DateTime();

            string error = BugIsValid(ref deadline);

            if (error == "")
            {
                taskToModify.Title = titleTextBox.Text;
                taskToModify.Deadline = deadline;
                taskToModify.Priority = priorComboBox.SelectedItem.ToString();
                taskToModify.Difficulty = diffComboBox.SelectedItem.ToString();

                GlobalConfig.Connection.UpdateTask(taskToModify);

                callingForm.BugUpdated(taskToModify);
                this.Close();
            }
            else
            {
                MessageBox.Show(error);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SpecificTimeCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (SpecificTimeCheckBox.Checked)
                AdvancedTimeBox.Visible = true;
            else
                AdvancedTimeBox.Visible = false;
        }

        private void EditTaskForm_SizeChanged(object sender, EventArgs e)
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
