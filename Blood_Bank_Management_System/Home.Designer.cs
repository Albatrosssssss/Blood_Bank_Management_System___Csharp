
namespace BloodBankManagementSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHomeDashboardName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblHomeExit = new System.Windows.Forms.LinkLabel();
            this.lblHomeAboutName = new System.Windows.Forms.LinkLabel();
            this.lblHomeManageDonorName = new System.Windows.Forms.LinkLabel();
            this.lblHomeManageUserName = new System.Windows.Forms.LinkLabel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1100, 65);
            this.panel3.TabIndex = 48;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1066, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Blood Bank Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(1, 586);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 14);
            this.panel2.TabIndex = 49;
            // 
            // lblHomeDashboardName
            // 
            this.lblHomeDashboardName.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeDashboardName.Location = new System.Drawing.Point(13, 112);
            this.lblHomeDashboardName.Name = "lblHomeDashboardName";
            this.lblHomeDashboardName.Size = new System.Drawing.Size(629, 37);
            this.lblHomeDashboardName.TabIndex = 50;
            this.lblHomeDashboardName.Text = "Dashboard";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Controls.Add(this.lblHomeExit);
            this.panel4.Controls.Add(this.lblHomeAboutName);
            this.panel4.Controls.Add(this.lblHomeManageDonorName);
            this.panel4.Controls.Add(this.lblHomeManageUserName);
            this.panel4.Location = new System.Drawing.Point(0, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1101, 44);
            this.panel4.TabIndex = 52;
            // 
            // lblHomeExit
            // 
            this.lblHomeExit.ActiveLinkColor = System.Drawing.Color.Black;
            this.lblHomeExit.AutoSize = true;
            this.lblHomeExit.BackColor = System.Drawing.Color.Transparent;
            this.lblHomeExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHomeExit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblHomeExit.LinkColor = System.Drawing.Color.White;
            this.lblHomeExit.Location = new System.Drawing.Point(1037, 3);
            this.lblHomeExit.Name = "lblHomeExit";
            this.lblHomeExit.Size = new System.Drawing.Size(50, 30);
            this.lblHomeExit.TabIndex = 55;
            this.lblHomeExit.TabStop = true;
            this.lblHomeExit.Text = "Exit";
            this.lblHomeExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblHomeExit_LinkClicked);
            // 
            // lblHomeAboutName
            // 
            this.lblHomeAboutName.ActiveLinkColor = System.Drawing.Color.Black;
            this.lblHomeAboutName.AutoSize = true;
            this.lblHomeAboutName.BackColor = System.Drawing.Color.Transparent;
            this.lblHomeAboutName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeAboutName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHomeAboutName.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblHomeAboutName.LinkColor = System.Drawing.Color.White;
            this.lblHomeAboutName.Location = new System.Drawing.Point(347, 3);
            this.lblHomeAboutName.Name = "lblHomeAboutName";
            this.lblHomeAboutName.Size = new System.Drawing.Size(75, 30);
            this.lblHomeAboutName.TabIndex = 54;
            this.lblHomeAboutName.TabStop = true;
            this.lblHomeAboutName.Text = "About";
            this.lblHomeAboutName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblHomeAboutName_LinkClicked);
            // 
            // lblHomeManageDonorName
            // 
            this.lblHomeManageDonorName.ActiveLinkColor = System.Drawing.Color.Black;
            this.lblHomeManageDonorName.AutoSize = true;
            this.lblHomeManageDonorName.BackColor = System.Drawing.Color.Transparent;
            this.lblHomeManageDonorName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeManageDonorName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHomeManageDonorName.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblHomeManageDonorName.LinkColor = System.Drawing.Color.White;
            this.lblHomeManageDonorName.Location = new System.Drawing.Point(172, 3);
            this.lblHomeManageDonorName.Name = "lblHomeManageDonorName";
            this.lblHomeManageDonorName.Size = new System.Drawing.Size(160, 30);
            this.lblHomeManageDonorName.TabIndex = 54;
            this.lblHomeManageDonorName.TabStop = true;
            this.lblHomeManageDonorName.Text = "Manage Donor";
            this.lblHomeManageDonorName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblHomeManageDonorName_LinkClicked);
            // 
            // lblHomeManageUserName
            // 
            this.lblHomeManageUserName.ActiveLinkColor = System.Drawing.Color.Black;
            this.lblHomeManageUserName.AutoSize = true;
            this.lblHomeManageUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblHomeManageUserName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeManageUserName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHomeManageUserName.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblHomeManageUserName.LinkColor = System.Drawing.Color.White;
            this.lblHomeManageUserName.Location = new System.Drawing.Point(14, 3);
            this.lblHomeManageUserName.Name = "lblHomeManageUserName";
            this.lblHomeManageUserName.Size = new System.Drawing.Size(141, 30);
            this.lblHomeManageUserName.TabIndex = 53;
            this.lblHomeManageUserName.TabStop = true;
            this.lblHomeManageUserName.Text = "Manage User";
            this.lblHomeManageUserName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblHomeManageUserName_LinkClicked);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblHomeDashboardName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHome";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHomeDashboardName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel lblHomeManageUserName;
        private System.Windows.Forms.LinkLabel lblHomeAboutName;
        private System.Windows.Forms.LinkLabel lblHomeManageDonorName;
        private System.Windows.Forms.LinkLabel lblHomeExit;
    }
}