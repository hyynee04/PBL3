using PBL3_official.Student.St_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_official.General_Form
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            OpenChildform(new General_Form.Home_Forms.Home_Main());
            butHome.BackColor = Color.FromArgb(252, 253, 244);
            butHome.ForeColor = Color.FromArgb(235, 69, 95);
        }       

        public void OpenChildform(Form childform)
        {
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelHomeMain.Controls.Add(childform);
            this.panelHomeMain.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void butHome_Click(object sender, EventArgs e)
        {
            OpenChildform(new General_Form.Home_Forms.Home_Main());
            butHome.BackColor = Color.FromArgb(252, 253, 244);
            butHome.ForeColor = Color.FromArgb(235, 69, 95);
            butCourses.BackColor = Color.FromArgb(43, 57, 103);
            butCourses.ForeColor = Color.FromArgb(252, 253, 244);
            butLogin.BackColor = Color.FromArgb(43, 57, 103);
            butLogin.ForeColor = Color.FromArgb(252, 253, 244);
        }

        private void butCourses_Click(object sender, EventArgs e)
        {
            OpenChildform(new General_Form.Home_Forms.Home_Courses());
            butHome.BackColor = Color.FromArgb(43, 57, 103);
            butHome.ForeColor = Color.FromArgb(252, 253, 244);
            butCourses.BackColor = Color.FromArgb(252, 253, 244);
            butCourses.ForeColor = Color.FromArgb(235, 69, 95);
            butLogin.BackColor = Color.FromArgb(43, 57, 103);
            butLogin.ForeColor = Color.FromArgb(252, 253, 244);
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            Login_Form f = new Login_Form();
            f.Show();            
            butHome.BackColor = Color.FromArgb(43, 57, 103);
            butHome.ForeColor = Color.FromArgb(252, 253, 244);
            butCourses.BackColor = Color.FromArgb(43, 57, 103);
            butCourses.ForeColor = Color.FromArgb(252, 253, 244);
            butLogin.BackColor = Color.FromArgb(252, 253, 244);
            butLogin.ForeColor = Color.FromArgb(235, 69, 95);
        }
    }
}
