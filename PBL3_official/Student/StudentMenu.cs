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

namespace PBL3_official.Student
{
    public partial class StudentMenu : Form
    {
        public StudentMenu()
        {
            InitializeComponent();                               
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
            OpenChildform(new Student.St_Forms.Student_PI());
            butPI.BackColor = Color.FromArgb(43, 57, 103);
            butMark.BackColor = Color.FromArgb(235, 69, 95);
            butSchedule.BackColor = Color.FromArgb(235, 69, 95);
        }

        private void butMark_Click(object sender, EventArgs e)
        {
            OpenChildform(new Student.St_Forms.Student_Mark());
            butPI.BackColor = Color.FromArgb(235, 69, 95);
            butMark.BackColor = Color.FromArgb(43, 57, 103);
            butSchedule.BackColor = Color.FromArgb(235, 69, 95);
        }

        private void butSchedule_Click(object sender, EventArgs e)
        {
            OpenChildform(new Student.St_Forms.Student_Schedule());
            butPI.BackColor = Color.FromArgb(235, 69, 95);
            butMark.BackColor = Color.FromArgb(235, 69, 95);
            butSchedule.BackColor = Color.FromArgb(43, 57, 103);
        }

        private void StudentMenu_Load(object sender, EventArgs e)
        {
            OpenChildform(new Student.St_Forms.Student_PI());
            butPI.BackColor = Color.FromArgb(43, 57, 103);
        }

        private void butLogout_Click(object sender, EventArgs e)
        {
            Login_Form f = new Login_Form();
            f.Show();
        }
    }
}
