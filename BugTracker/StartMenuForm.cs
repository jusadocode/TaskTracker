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
    public partial class StartMenuForm : Form
    {
        public StartMenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProjectSelectionForm frm = new ProjectSelectionForm();
            GlobalConfig.DemoModeEnabled = false;
            this.Hide();
            frm.Show();
        }

        private void DemoButton_Click(object sender, EventArgs e)
        {
            DemoViewerForm frm = new DemoViewerForm();
            GlobalConfig.DemoModeEnabled = true;
            frm.Show();
        }
    }
}
