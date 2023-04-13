using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_official.Student.St_Forms
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }   

        private void butEye_MouseUp(object sender, MouseEventArgs e)
        {
            txtPW.PasswordChar = '*';
            txtPW.UseSystemPasswordChar = true;
        }    

        private void butEye_MouseDown(object sender, MouseEventArgs e)
        {
            txtPW.PasswordChar = '\0';
            txtPW.UseSystemPasswordChar = false;
        }

        private void txtPW_TextChanged(object sender, EventArgs e)
        {
            txtPW.SelectionStart = txtPW.TextLength;
        }

        private void butEye_Click(object sender, EventArgs e)
        {
            butEye.Hide(); 
        }
    }
}
