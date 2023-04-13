namespace PBL3_official.Student
{
    partial class StudentMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pBAva = new System.Windows.Forms.PictureBox();
            this.butLogout = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.butSchedule = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butMark = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butPI = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBAva)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(69)))), ((int)(((byte)(95)))));
            this.panelMenu.Controls.Add(this.panelTop);
            this.panelMenu.Controls.Add(this.butLogout);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(396, 872);
            this.panelMenu.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.txtUsername);
            this.panelTop.Controls.Add(this.pBAva);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(396, 309);
            this.panelTop.TabIndex = 8;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(69)))), ((int)(((byte)(95)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.txtUsername.Location = new System.Drawing.Point(3, 243);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(393, 41);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.Text = "Username";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pBAva
            // 
            this.pBAva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pBAva.Image = ((System.Drawing.Image)(resources.GetObject("pBAva.Image")));
            this.pBAva.Location = new System.Drawing.Point(112, 64);
            this.pBAva.Name = "pBAva";
            this.pBAva.Size = new System.Drawing.Size(162, 166);
            this.pBAva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBAva.TabIndex = 1;
            this.pBAva.TabStop = false;
            // 
            // butLogout
            // 
            this.butLogout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butLogout.BackgroundImage")));
            this.butLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butLogout.FlatAppearance.BorderSize = 0;
            this.butLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLogout.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.butLogout.Location = new System.Drawing.Point(97, 812);
            this.butLogout.Name = "butLogout";
            this.butLogout.Size = new System.Drawing.Size(195, 48);
            this.butLogout.TabIndex = 7;
            this.butLogout.Text = "Log out";
            this.butLogout.UseVisualStyleBackColor = true;
            this.butLogout.Click += new System.EventHandler(this.butLogout_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.butSchedule);
            this.panel3.Location = new System.Drawing.Point(0, 605);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(396, 93);
            this.panel3.TabIndex = 5;
            // 
            // butSchedule
            // 
            this.butSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butSchedule.FlatAppearance.BorderSize = 0;
            this.butSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSchedule.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.butSchedule.Image = ((System.Drawing.Image)(resources.GetObject("butSchedule.Image")));
            this.butSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butSchedule.Location = new System.Drawing.Point(0, 0);
            this.butSchedule.Name = "butSchedule";
            this.butSchedule.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.butSchedule.Size = new System.Drawing.Size(396, 93);
            this.butSchedule.TabIndex = 8;
            this.butSchedule.Text = "  Schedule";
            this.butSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butSchedule.UseVisualStyleBackColor = true;
            this.butSchedule.Click += new System.EventHandler(this.butSchedule_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.butMark);
            this.panel2.Location = new System.Drawing.Point(0, 501);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 93);
            this.panel2.TabIndex = 4;
            // 
            // butMark
            // 
            this.butMark.AutoSize = true;
            this.butMark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butMark.FlatAppearance.BorderSize = 0;
            this.butMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMark.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.butMark.Image = ((System.Drawing.Image)(resources.GetObject("butMark.Image")));
            this.butMark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butMark.Location = new System.Drawing.Point(0, 0);
            this.butMark.Name = "butMark";
            this.butMark.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.butMark.Size = new System.Drawing.Size(396, 93);
            this.butMark.TabIndex = 8;
            this.butMark.Text = "  Mark";
            this.butMark.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butMark.UseVisualStyleBackColor = true;
            this.butMark.Click += new System.EventHandler(this.butMark_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butPI);
            this.panel1.Location = new System.Drawing.Point(0, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 93);
            this.panel1.TabIndex = 3;
            // 
            // butPI
            // 
            this.butPI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butPI.FlatAppearance.BorderSize = 0;
            this.butPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPI.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.butPI.Image = ((System.Drawing.Image)(resources.GetObject("butPI.Image")));
            this.butPI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butPI.Location = new System.Drawing.Point(0, 0);
            this.butPI.Name = "butPI";
            this.butPI.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.butPI.Size = new System.Drawing.Size(396, 93);
            this.butPI.TabIndex = 7;
            this.butPI.Text = "  Personal Information";
            this.butPI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butPI.UseVisualStyleBackColor = true;
            this.butPI.Click += new System.EventHandler(this.butPI_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.ForeColor = System.Drawing.SystemColors.Control;
            this.panelMain.Location = new System.Drawing.Point(396, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(716, 872);
            this.panelMain.TabIndex = 1;
            // 
            // StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 872);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.Name = "StudentMenu";
            this.Text = "StudentMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StudentMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBAva)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pBAva;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butPI;
        private System.Windows.Forms.Button butMark;
        private System.Windows.Forms.Button butSchedule;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button butLogout;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMain;
    }
}