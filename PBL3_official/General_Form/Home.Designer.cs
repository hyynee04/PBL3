namespace PBL3_official.General_Form
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butLogin = new System.Windows.Forms.Button();
            this.butCourses = new System.Windows.Forms.Button();
            this.butHome = new System.Windows.Forms.Button();
            this.panelHomeMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(69)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 189);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(269, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 162);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENGLSIH CENTER\r\nHAHYWU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(57)))), ((int)(((byte)(103)))));
            this.panel2.Controls.Add(this.butLogin);
            this.panel2.Controls.Add(this.butCourses);
            this.panel2.Controls.Add(this.butHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1112, 84);
            this.panel2.TabIndex = 1;
            // 
            // butLogin
            // 
            this.butLogin.FlatAppearance.BorderSize = 0;
            this.butLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLogin.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.butLogin.Location = new System.Drawing.Point(535, 0);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(212, 84);
            this.butLogin.TabIndex = 2;
            this.butLogin.Text = "Login";
            this.butLogin.UseVisualStyleBackColor = true;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // butCourses
            // 
            this.butCourses.FlatAppearance.BorderSize = 0;
            this.butCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCourses.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.butCourses.Location = new System.Drawing.Point(267, 0);
            this.butCourses.Name = "butCourses";
            this.butCourses.Size = new System.Drawing.Size(212, 84);
            this.butCourses.TabIndex = 1;
            this.butCourses.Text = "Courses";
            this.butCourses.UseVisualStyleBackColor = true;
            this.butCourses.Click += new System.EventHandler(this.butCourses_Click);
            // 
            // butHome
            // 
            this.butHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.butHome.FlatAppearance.BorderSize = 0;
            this.butHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butHome.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.butHome.Location = new System.Drawing.Point(0, 0);
            this.butHome.Name = "butHome";
            this.butHome.Size = new System.Drawing.Size(212, 84);
            this.butHome.TabIndex = 0;
            this.butHome.Text = "Home";
            this.butHome.UseVisualStyleBackColor = true;
            this.butHome.Click += new System.EventHandler(this.butHome_Click);
            // 
            // panelHomeMain
            // 
            this.panelHomeMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.panelHomeMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHomeMain.Location = new System.Drawing.Point(0, 273);
            this.panelHomeMain.Name = "panelHomeMain";
            this.panelHomeMain.Size = new System.Drawing.Size(1112, 473);
            this.panelHomeMain.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 746);
            this.Controls.Add(this.panelHomeMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelHomeMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.Button butCourses;
        private System.Windows.Forms.Button butHome;
    }
}