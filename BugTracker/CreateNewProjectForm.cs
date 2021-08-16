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
    public partial class CreateNewProjectForm : Form
    {
        IProjectRequester callingForm;
        public CreateNewProjectForm(IProjectRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
        }


        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (NewProjectNameBox.Text != string.Empty)
            {
                Project project = new Project();
                project.Title = NewProjectNameBox.Text;
                GlobalConfig.Connection.CreateProject(project);
                callingForm.ProjectComplete(project);
                this.Close();
            }
            else
                MessageBox.Show("Please insert the name of the new project/activity", "Invalid input", MessageBoxButtons.OK);
        }

        private void CreateNewProjectForm_SizeChanged(object sender, EventArgs e)
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
