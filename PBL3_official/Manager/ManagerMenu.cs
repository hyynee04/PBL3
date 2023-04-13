using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_official.Manager
{
    public partial class ManagerMenu : Form
    {
        public ManagerMenu()
        {
            InitializeComponent();
            OpenChildform(new Manager.Mn_Forms.Manager_PI());
            butPI.BackColor = Color.FromArgb(43, 57, 103);
        }

        public void OpenChildform(Form childform)
        {
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(childform);
            this.panelMain.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void butPI_Click(object sender, EventArgs e)
        {
            OpenChildform(new Manager.Mn_Forms.Manager_PI());
            butPI.BackColor = Color.FromArgb(43, 57, 103);
            butAM.BackColor = Color.FromArgb(235, 69, 95);
            butSchedule.BackColor = Color.FromArgb(235, 69, 95);
            butRevenue.BackColor = Color.FromArgb(235, 69, 95);
        }
        
        private void butAM_Click_1(object sender, EventArgs e)
        {
            OpenChildform(new Manager.Mn_Forms.Manager_AM());
            butPI.BackColor = Color.FromArgb(235, 69, 95);
            butAM.BackColor = Color.FromArgb(43, 57, 103);
            butSchedule.BackColor = Color.FromArgb(235, 69, 95);
            butRevenue.BackColor = Color.FromArgb(235, 69, 95);
        }

        private void butSchedule_Click(object sender, EventArgs e)
        {
            OpenChildform(new Manager.Mn_Forms.Manager_Schedule());
            butPI.BackColor = Color.FromArgb(235, 69, 95);
            butAM.BackColor = Color.FromArgb(235, 69, 95);
            butSchedule.BackColor = Color.FromArgb(43, 57, 103);
            butRevenue.BackColor = Color.FromArgb(235, 69, 95);
        }

        private void butRevenue_Click(object sender, EventArgs e)
        {
            OpenChildform(new Manager.Mn_Forms.Manager_Revenue());
            butPI.BackColor = Color.FromArgb(235, 69, 95);
            butAM.BackColor = Color.FromArgb(235, 69, 95);
            butSchedule.BackColor = Color.FromArgb(235, 69, 95);
            butRevenue.BackColor = Color.FromArgb(43, 57, 103);
        }
    }
}
