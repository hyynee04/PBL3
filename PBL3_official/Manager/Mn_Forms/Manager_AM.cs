using PBL3_official.Manager.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_official.Manager.Mn_Forms
{
    public partial class Manager_AM : Form
    {
        public Manager_AM()
        {
            InitializeComponent();
        }
        public void Openform(Form childform)
        {
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelForm.Controls.Add(childform);
            this.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }        

        private void butAdd_Click_1(object sender, EventArgs e)
        {
            Openform(new Manager.Functions.Add_Edit_Acc());
        }
    }
}
