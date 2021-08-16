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
    public partial class ProjectSelectionForm : Form, IProjectRequester
    {
        List<Project> Projects = GlobalConfig.Connection.Get_Projects();
        public ProjectSelectionForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        public void ProjectComplete(Project model)
        {
            Projects.Add(model);
            WireUpLists();
        }

        private void button1_Click(object sender, EventArgs e)
        {
  
            CreateNewProjectForm frm = new CreateNewProjectForm(this);
            frm.ShowDialog();

        }
        private void WireUpLists()
        {
            TaskDropDownList.DataSource = null;
            TaskDropDownList.DataSource = Projects;
            TaskDropDownList.DisplayMember = "Title";
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            Project selectedProject = (Project)TaskDropDownList.SelectedItem;

            if (selectedProject != null)
            {
                TrackerViewerForm frm = new TrackerViewerForm(selectedProject);
                frm.Text = "TaskTracker";
                frm.Show();
                
            }
            else
                MessageBox.Show("Select a project", "Invalid input", MessageBoxButtons.OK);

        }

        private void TaskDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProjectSelectionForm_SizeChanged(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Minimized)
            //{
            //    foreach (Form frm in Application.OpenForms)
            //    {
            //        frm.WindowState = FormWindowState.Minimized;
            //    }
            //}
            //else if (this.WindowState == FormWindowState.Normal)
            //{
            //    foreach (Form frm in Application.OpenForms)
            //    {
            //        frm.WindowState = FormWindowState.Normal;
            //    }
            //}
        }
    }
}
