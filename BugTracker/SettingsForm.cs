using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTracker
{
   
    public partial class SettingsForm : Form
    {
        private TimeSpan alertTime;
        

        public SettingsForm()
        {
            InitializeComponent();
            InitializeEmailSettings();
       
         
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(EmailCheckBox.Checked)
            {
                string errorMessage = ValidateAlertSettings();
                if (errorMessage == "")
                {
                    // Save settings
                    GlobalConfig.EmailTime = alertTime;
                  
                }
                else
                {
                    MessageBox.Show(errorMessage, "Invalid input", MessageBoxButtons.OK);
                    return;
                }
            }
            SaveEmailSettings();
            DialogResult dr = MessageBox.Show("Changes will be made after application restart.\n Restart now?", "Save changes", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                Application.Restart();
            else
                this.Close();


        }
        /// <summary>
        /// Loads settings from properties
        /// </summary>
        private void InitializeEmailSettings()
        {
           
            EmailCheckBox.Checked = Properties.Settings.Default.EmailCheckBox;       

            TimeCheckedListBox.SetItemCheckState(0, Properties.Settings.Default.DayCheckBox);
            TimeCheckedListBox.SetItemCheckState(1, Properties.Settings.Default.HourCheckBox);
            TimeCheckedListBox.SetItemCheckState(2, Properties.Settings.Default.MinuteCheckBox);

            TimeCheckedListBox_SelectedValueChanged(new object(), new EventArgs());

            DaysTextBox.Text = Properties.Settings.Default.DayValue;
            HoursTextBox.Text = Properties.Settings.Default.HourValue;
            MinutesTextBox.Text = Properties.Settings.Default.MinuteValue;

            EmailTextBox.Text = Properties.Settings.Default.Email;

            GlobalConfig.EmailTime = Properties.Settings.Default.EmailTime;

        }
        /// <summary>
        /// Saves settings to properties
        /// </summary>
        private void SaveEmailSettings()
        {

            if(EmailCheckBox.Checked)
            {
                Properties.Settings.Default.EmailCheckBox = EmailCheckBox.Checked;

                Properties.Settings.Default.DayCheckBox = TimeCheckedListBox.GetItemCheckState(0);
                Properties.Settings.Default.HourCheckBox = TimeCheckedListBox.GetItemCheckState(1);
                Properties.Settings.Default.MinuteCheckBox = TimeCheckedListBox.GetItemCheckState(2);

                

                Properties.Settings.Default.DayValue = alertTime.Days.ToString();
                Properties.Settings.Default.HourValue = alertTime.Hours.ToString();
                Properties.Settings.Default.MinuteValue = alertTime.Minutes.ToString();

                Properties.Settings.Default.Email = EmailTextBox.Text;

                Properties.Settings.Default.EmailTime = alertTime;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.EmailCheckBox = EmailCheckBox.Checked;

                Properties.Settings.Default.DayCheckBox = TimeCheckedListBox.GetItemCheckState(0);
                Properties.Settings.Default.HourCheckBox = TimeCheckedListBox.GetItemCheckState(1);
                Properties.Settings.Default.MinuteCheckBox = TimeCheckedListBox.GetItemCheckState(2);

                Properties.Settings.Default.DayValue = "00";
                Properties.Settings.Default.HourValue = "00";
                Properties.Settings.Default.MinuteValue = "00";

                Properties.Settings.Default.Email = "";

                Properties.Settings.Default.EmailTime = TimeSpan.MinValue;
                Properties.Settings.Default.Save();
            }
          

        }

        private void EmailCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EmailCheckBox.Checked)
                AlertGroupBox.Visible = true;
            else
                AlertGroupBox.Visible = false;
        }

        private void TimeCheckedListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (TimeCheckedListBox.GetItemCheckState(0) == CheckState.Checked)
                DaysTextBox.Visible = true;
            else
            {
                DaysTextBox.Visible = false;
                //DaysTextBox.Text = "00";
            }

            if (TimeCheckedListBox.GetItemCheckState(1) == CheckState.Checked)
                HoursTextBox.Visible = true;
            else
            {
                HoursTextBox.Visible = false;
                //HoursTextBox.Text = "00";
            }

            if (TimeCheckedListBox.GetItemCheckState(2) == CheckState.Checked)
                MinutesTextBox.Visible = true;
            else
            {
                MinutesTextBox.Visible = false;
                //MinutesTextBox.Text = "00";
            }
        }
        private string ValidateAlertSettings()
        {
            string errorMessage = "";
            int days = 0;
            int hours = 0;
            int mins = 0;

            if (!EmailTextBox.Text.Contains("@"))
                return "Please specify a valid email address";
            bool success1 = int.TryParse(DaysTextBox.Text, out days);
            bool success2 = int.TryParse(HoursTextBox.Text, out hours);
            bool success3 = int.TryParse(MinutesTextBox.Text, out mins);
            if(!success1)
                return "Please specify a valid day number";
            if (!success2 || hours > 23 || hours < 0)
                return "Please specify a valid hour number";
            if (!success3 || mins > 59 || mins < 0)
                return "Please specify a valid minute number";

            TimeSpan time = new TimeSpan(days, hours, mins, 0);
            TimeSpan minTime = new TimeSpan(0, 0, 10, 0);
            if (time < minTime)
                return "Alert time cannot be less than 10 minutes";

            alertTime = time;
            

            return errorMessage;
        }

        private void SettingsForm_SizeChanged(object sender, EventArgs e)
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
