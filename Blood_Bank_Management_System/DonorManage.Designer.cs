
namespace BloodBankManagementSystem
{
    partial class DonorManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonorManage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDonorName = new System.Windows.Forms.Label();
            this.lblDonorContact = new System.Windows.Forms.Label();
            this.lblDonorUserID = new System.Windows.Forms.Label();
            this.lblDonorAddress = new System.Windows.Forms.Label();
            this.lblDonorEmail = new System.Windows.Forms.Label();
            this.lblManageDonorName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtDonorName = new System.Windows.Forms.TextBox();
            this.txtDonorEmail = new System.Windows.Forms.TextBox();
            this.txtDonorContact = new System.Windows.Forms.TextBox();
            this.txtDonorAddress = new System.Windows.Forms.TextBox();
            this.lblDonorSearch = new System.Windows.Forms.Label();
            this.txtDonorSearch = new System.Windows.Forms.TextBox();
            this.dgvDonorSearch = new System.Windows.Forms.DataGridView();
            this.btnDonorAdd = new System.Windows.Forms.Button();
            this.btnDonorUpdate = new System.Windows.Forms.Button();
            this.btnDonorDelete = new System.Windows.Forms.Button();
            this.btnDonorClear = new System.Windows.Forms.Button();
            this.btnDonorBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonorSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 63);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(-1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1100, 65);
            this.panel3.TabIndex = 47;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1066, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
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
            this.panel2.Size = new System.Drawing.Size(1098, 14);
            this.panel2.TabIndex = 1;
            // 
            // lblDonorName
            // 
            this.lblDonorName.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorName.Location = new System.Drawing.Point(52, 88);
            this.lblDonorName.Name = "lblDonorName";
            this.lblDonorName.Size = new System.Drawing.Size(629, 37);
            this.lblDonorName.TabIndex = 2;
            this.lblDonorName.Text = "Manage Donor";
            this.lblDonorName.Click += new System.EventHandler(this.lblDonorName_Click);
            // 
            // lblDonorContact
            // 
            this.lblDonorContact.AutoSize = true;
            this.lblDonorContact.BackColor = System.Drawing.Color.Transparent;
            this.lblDonorContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDonorContact.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorContact.ForeColor = System.Drawing.Color.Black;
            this.lblDonorContact.Location = new System.Drawing.Point(63, 254);
            this.lblDonorContact.Name = "lblDonorContact";
            this.lblDonorContact.Size = new System.Drawing.Size(79, 25);
            this.lblDonorContact.TabIndex = 2;
            this.lblDonorContact.Text = "Contact";
            // 
            // lblDonorUserID
            // 
            this.lblDonorUserID.AutoSize = true;
            this.lblDonorUserID.BackColor = System.Drawing.Color.Transparent;
            this.lblDonorUserID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDonorUserID.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorUserID.ForeColor = System.Drawing.Color.Black;
            this.lblDonorUserID.Location = new System.Drawing.Point(63, 148);
            this.lblDonorUserID.Name = "lblDonorUserID";
            this.lblDonorUserID.Size = new System.Drawing.Size(75, 25);
            this.lblDonorUserID.TabIndex = 3;
            this.lblDonorUserID.Text = "User ID";
            this.lblDonorUserID.Click += new System.EventHandler(this.lblDonorUserID_Click);
            // 
            // lblDonorAddress
            // 
            this.lblDonorAddress.AutoSize = true;
            this.lblDonorAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblDonorAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDonorAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorAddress.ForeColor = System.Drawing.Color.Black;
            this.lblDonorAddress.Location = new System.Drawing.Point(63, 290);
            this.lblDonorAddress.Name = "lblDonorAddress";
            this.lblDonorAddress.Size = new System.Drawing.Size(80, 25);
            this.lblDonorAddress.TabIndex = 4;
            this.lblDonorAddress.Text = "Address";
            // 
            // lblDonorEmail
            // 
            this.lblDonorEmail.AutoSize = true;
            this.lblDonorEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblDonorEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDonorEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorEmail.ForeColor = System.Drawing.Color.Black;
            this.lblDonorEmail.Location = new System.Drawing.Point(63, 220);
            this.lblDonorEmail.Name = "lblDonorEmail";
            this.lblDonorEmail.Size = new System.Drawing.Size(59, 25);
            this.lblDonorEmail.TabIndex = 7;
            this.lblDonorEmail.Text = "Email";
            // 
            // lblManageDonorName
            // 
            this.lblManageDonorName.AutoSize = true;
            this.lblManageDonorName.BackColor = System.Drawing.Color.Transparent;
            this.lblManageDonorName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblManageDonorName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageDonorName.ForeColor = System.Drawing.Color.Black;
            this.lblManageDonorName.Location = new System.Drawing.Point(63, 183);
            this.lblManageDonorName.Name = "lblManageDonorName";
            this.lblManageDonorName.Size = new System.Drawing.Size(64, 25);
            this.lblManageDonorName.TabIndex = 8;
            this.lblManageDonorName.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 20);
            this.textBox1.TabIndex = 9;
            // 
            // txtDonorName
            // 
            this.txtDonorName.Location = new System.Drawing.Point(213, 188);
            this.txtDonorName.Name = "txtDonorName";
            this.txtDonorName.Size = new System.Drawing.Size(256, 20);
            this.txtDonorName.TabIndex = 10;
            // 
            // txtDonorEmail
            // 
            this.txtDonorEmail.Location = new System.Drawing.Point(213, 220);
            this.txtDonorEmail.Name = "txtDonorEmail";
            this.txtDonorEmail.Size = new System.Drawing.Size(256, 20);
            this.txtDonorEmail.TabIndex = 11;
            // 
            // txtDonorContact
            // 
            this.txtDonorContact.Location = new System.Drawing.Point(213, 260);
            this.txtDonorContact.Name = "txtDonorContact";
            this.txtDonorContact.Size = new System.Drawing.Size(256, 20);
            this.txtDonorContact.TabIndex = 14;
            // 
            // txtDonorAddress
            // 
            this.txtDonorAddress.Location = new System.Drawing.Point(213, 296);
            this.txtDonorAddress.Multiline = true;
            this.txtDonorAddress.Name = "txtDonorAddress";
            this.txtDonorAddress.Size = new System.Drawing.Size(256, 116);
            this.txtDonorAddress.TabIndex = 15;
            // 
            // lblDonorSearch
            // 
            this.lblDonorSearch.AutoSize = true;
            this.lblDonorSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblDonorSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDonorSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorSearch.ForeColor = System.Drawing.Color.Black;
            this.lblDonorSearch.Location = new System.Drawing.Point(505, 148);
            this.lblDonorSearch.Name = "lblDonorSearch";
            this.lblDonorSearch.Size = new System.Drawing.Size(69, 25);
            this.lblDonorSearch.TabIndex = 16;
            this.lblDonorSearch.Text = "Search";
            // 
            // txtDonorSearch
            // 
            this.txtDonorSearch.Location = new System.Drawing.Point(591, 148);
            this.txtDonorSearch.Name = "txtDonorSearch";
            this.txtDonorSearch.Size = new System.Drawing.Size(451, 20);
            this.txtDonorSearch.TabIndex = 17;
            // 
            // dgvDonorSearch
            // 
            this.dgvDonorSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonorSearch.Location = new System.Drawing.Point(505, 183);
            this.dgvDonorSearch.Name = "dgvDonorSearch";
            this.dgvDonorSearch.Size = new System.Drawing.Size(537, 301);
            this.dgvDonorSearch.TabIndex = 18;
            // 
            // btnDonorAdd
            // 
            this.btnDonorAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDonorAdd.BackgroundImage")));
            this.btnDonorAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonorAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDonorAdd.Location = new System.Drawing.Point(46, 518);
            this.btnDonorAdd.Name = "btnDonorAdd";
            this.btnDonorAdd.Size = new System.Drawing.Size(137, 51);
            this.btnDonorAdd.TabIndex = 19;
            this.btnDonorAdd.Text = "Add";
            this.btnDonorAdd.UseVisualStyleBackColor = true;
            this.btnDonorAdd.Click += new System.EventHandler(this.btnDonorAdd_Click);
            // 
            // btnDonorUpdate
            // 
            this.btnDonorUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDonorUpdate.BackgroundImage")));
            this.btnDonorUpdate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonorUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDonorUpdate.Location = new System.Drawing.Point(213, 518);
            this.btnDonorUpdate.Name = "btnDonorUpdate";
            this.btnDonorUpdate.Size = new System.Drawing.Size(137, 51);
            this.btnDonorUpdate.TabIndex = 20;
            this.btnDonorUpdate.Text = "Update";
            this.btnDonorUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDonorDelete
            // 
            this.btnDonorDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDonorDelete.BackgroundImage")));
            this.btnDonorDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonorDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDonorDelete.Location = new System.Drawing.Point(382, 518);
            this.btnDonorDelete.Name = "btnDonorDelete";
            this.btnDonorDelete.Size = new System.Drawing.Size(137, 51);
            this.btnDonorDelete.TabIndex = 21;
            this.btnDonorDelete.Text = "Delete";
            this.btnDonorDelete.UseVisualStyleBackColor = true;
            // 
            // btnDonorClear
            // 
            this.btnDonorClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDonorClear.BackgroundImage")));
            this.btnDonorClear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonorClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDonorClear.Location = new System.Drawing.Point(544, 518);
            this.btnDonorClear.Name = "btnDonorClear";
            this.btnDonorClear.Size = new System.Drawing.Size(137, 51);
            this.btnDonorClear.TabIndex = 22;
            this.btnDonorClear.Text = "Clear";
            this.btnDonorClear.UseVisualStyleBackColor = true;
            // 
            // btnDonorBack
            // 
            this.btnDonorBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDonorBack.BackgroundImage")));
            this.btnDonorBack.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonorBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDonorBack.Location = new System.Drawing.Point(951, 518);
            this.btnDonorBack.Name = "btnDonorBack";
            this.btnDonorBack.Size = new System.Drawing.Size(137, 51);
            this.btnDonorBack.TabIndex = 23;
            this.btnDonorBack.Text = "Back";
            this.btnDonorBack.UseVisualStyleBackColor = true;
            this.btnDonorBack.Click += new System.EventHandler(this.btnDonorBack_Click);
            // 
            // DonorManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.btnDonorBack);
            this.Controls.Add(this.lblDonorName);
            this.Controls.Add(this.btnDonorClear);
            this.Controls.Add(this.btnDonorDelete);
            this.Controls.Add(this.btnDonorUpdate);
            this.Controls.Add(this.btnDonorAdd);
            this.Controls.Add(this.dgvDonorSearch);
            this.Controls.Add(this.txtDonorSearch);
            this.Controls.Add(this.lblDonorSearch);
            this.Controls.Add(this.txtDonorAddress);
            this.Controls.Add(this.txtDonorContact);
            this.Controls.Add(this.txtDonorEmail);
            this.Controls.Add(this.txtDonorName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblManageDonorName);
            this.Controls.Add(this.lblDonorEmail);
            this.Controls.Add(this.lblDonorAddress);
            this.Controls.Add(this.lblDonorUserID);
            this.Controls.Add(this.lblDonorContact);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DonorManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DonorManage";
            this.Load += new System.EventHandler(this.DonorManage_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonorSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDonorName;
        private System.Windows.Forms.Label lblDonorContact;
        private System.Windows.Forms.Label lblDonorUserID;
        private System.Windows.Forms.Label lblDonorAddress;
        private System.Windows.Forms.Label lblDonorEmail;
        private System.Windows.Forms.Label lblManageDonorName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtDonorName;
        private System.Windows.Forms.TextBox txtDonorEmail;
        private System.Windows.Forms.TextBox txtDonorContact;
        private System.Windows.Forms.TextBox txtDonorAddress;
        private System.Windows.Forms.Label lblDonorSearch;
        private System.Windows.Forms.TextBox txtDonorSearch;
        private System.Windows.Forms.DataGridView dgvDonorSearch;
        private System.Windows.Forms.Button btnDonorAdd;
        private System.Windows.Forms.Button btnDonorUpdate;
        private System.Windows.Forms.Button btnDonorDelete;
        private System.Windows.Forms.Button btnDonorClear;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDonorBack;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}