namespace LoginForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labResultToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.labResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMedicalLaboratoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.doctorToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientRecordToolStripMenuItem,
            this.labResultToolStripMenuItem1,
            this.labResultToolStripMenuItem,
            this.updateMedicalLaboratoryToolStripMenuItem,
            this.sendMedicineToolStripMenuItem});
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.doctorToolStripMenuItem.Text = "Doctor";
            this.doctorToolStripMenuItem.Click += new System.EventHandler(this.doctorToolStripMenuItem_Click);
            // 
            // patientRecordToolStripMenuItem
            // 
            this.patientRecordToolStripMenuItem.Name = "patientRecordToolStripMenuItem";
            this.patientRecordToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.patientRecordToolStripMenuItem.Text = "Patient Record";
            this.patientRecordToolStripMenuItem.Click += new System.EventHandler(this.patientRecordToolStripMenuItem_Click);
            // 
            // labResultToolStripMenuItem1
            // 
            this.labResultToolStripMenuItem1.Name = "labResultToolStripMenuItem1";
            this.labResultToolStripMenuItem1.Size = new System.Drawing.Size(217, 22);
            this.labResultToolStripMenuItem1.Text = "Medical Laboratory";
            this.labResultToolStripMenuItem1.Click += new System.EventHandler(this.labResultToolStripMenuItem1_Click);
            // 
            // labResultToolStripMenuItem
            // 
            this.labResultToolStripMenuItem.Name = "labResultToolStripMenuItem";
            this.labResultToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.labResultToolStripMenuItem.Text = "Lab Result";
            this.labResultToolStripMenuItem.Click += new System.EventHandler(this.labResultToolStripMenuItem_Click_1);
            // 
            // updateMedicalLaboratoryToolStripMenuItem
            // 
            this.updateMedicalLaboratoryToolStripMenuItem.Name = "updateMedicalLaboratoryToolStripMenuItem";
            this.updateMedicalLaboratoryToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.updateMedicalLaboratoryToolStripMenuItem.Text = "Update Medical Laboratory";
            this.updateMedicalLaboratoryToolStripMenuItem.Click += new System.EventHandler(this.updateMedicalLaboratoryToolStripMenuItem_Click);
            // 
            // sendMedicineToolStripMenuItem
            // 
            this.sendMedicineToolStripMenuItem.Name = "sendMedicineToolStripMenuItem";
            this.sendMedicineToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.sendMedicineToolStripMenuItem.Text = "Send Medicine";
            this.sendMedicineToolStripMenuItem.Click += new System.EventHandler(this.sendMedicineToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hospital management system";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Welcome to the system we produce better service for you";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoginForm.Properties.Resources.download__2_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 171);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(753, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem patientRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labResultToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem labResultToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem updateMedicalLaboratoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendMedicineToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}