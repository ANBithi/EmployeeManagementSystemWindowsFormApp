
namespace EmployeeSystemWinform
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.ExitIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginpictureBox = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.AddUserbtn = new System.Windows.Forms.Button();
            this.PasswordpictureBox = new System.Windows.Forms.PictureBox();
            this.Passwordpanel = new System.Windows.Forms.Panel();
            this.EmailpictureBox = new System.Windows.Forms.PictureBox();
            this.EmailInputpanel = new System.Windows.Forms.Panel();
            this.BackPicturebox = new System.Windows.Forms.PictureBox();
            this.PageTitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitIcon
            // 
            this.ExitIcon.Image = global::EmployeeSystemWinform.Properties.Resources.exit;
            this.ExitIcon.Location = new System.Drawing.Point(993, 12);
            this.ExitIcon.Name = "ExitIcon";
            this.ExitIcon.Size = new System.Drawing.Size(25, 25);
            this.ExitIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitIcon.TabIndex = 1;
            this.ExitIcon.TabStop = false;
            this.ExitIcon.Click += new System.EventHandler(this.ExitIcon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(46, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee Management System";
            // 
            // LoginpictureBox
            // 
            this.LoginpictureBox.Image = global::EmployeeSystemWinform.Properties.Resources.logo;
            this.LoginpictureBox.Location = new System.Drawing.Point(12, 12);
            this.LoginpictureBox.Name = "LoginpictureBox";
            this.LoginpictureBox.Size = new System.Drawing.Size(28, 30);
            this.LoginpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoginpictureBox.TabIndex = 3;
            this.LoginpictureBox.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.txtPassword.Location = new System.Drawing.Point(301, 263);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(464, 31);
            this.txtPassword.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.txtEmail.Location = new System.Drawing.Point(301, 173);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(464, 31);
            this.txtEmail.TabIndex = 16;
            // 
            // AddUserbtn
            // 
            this.AddUserbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
            this.AddUserbtn.FlatAppearance.BorderSize = 0;
            this.AddUserbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUserbtn.Font = new System.Drawing.Font("Sitka Text", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddUserbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.AddUserbtn.Location = new System.Drawing.Point(265, 347);
            this.AddUserbtn.Name = "AddUserbtn";
            this.AddUserbtn.Size = new System.Drawing.Size(500, 51);
            this.AddUserbtn.TabIndex = 15;
            this.AddUserbtn.Text = "Add User";
            this.AddUserbtn.UseVisualStyleBackColor = false;
            this.AddUserbtn.Click += new System.EventHandler(this.AddUserbtn_Click);
            // 
            // PasswordpictureBox
            // 
            this.PasswordpictureBox.Image = global::EmployeeSystemWinform.Properties.Resources.password;
            this.PasswordpictureBox.Location = new System.Drawing.Point(265, 259);
            this.PasswordpictureBox.Name = "PasswordpictureBox";
            this.PasswordpictureBox.Size = new System.Drawing.Size(30, 30);
            this.PasswordpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PasswordpictureBox.TabIndex = 14;
            this.PasswordpictureBox.TabStop = false;
            // 
            // Passwordpanel
            // 
            this.Passwordpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.Passwordpanel.Location = new System.Drawing.Point(265, 295);
            this.Passwordpanel.Name = "Passwordpanel";
            this.Passwordpanel.Size = new System.Drawing.Size(500, 2);
            this.Passwordpanel.TabIndex = 13;
            // 
            // EmailpictureBox
            // 
            this.EmailpictureBox.Image = global::EmployeeSystemWinform.Properties.Resources.email1;
            this.EmailpictureBox.Location = new System.Drawing.Point(265, 173);
            this.EmailpictureBox.Name = "EmailpictureBox";
            this.EmailpictureBox.Size = new System.Drawing.Size(30, 30);
            this.EmailpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EmailpictureBox.TabIndex = 12;
            this.EmailpictureBox.TabStop = false;
            // 
            // EmailInputpanel
            // 
            this.EmailInputpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.EmailInputpanel.Location = new System.Drawing.Point(265, 209);
            this.EmailInputpanel.Name = "EmailInputpanel";
            this.EmailInputpanel.Size = new System.Drawing.Size(500, 2);
            this.EmailInputpanel.TabIndex = 11;
            // 
            // BackPicturebox
            // 
            this.BackPicturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackPicturebox.Image = ((System.Drawing.Image)(resources.GetObject("BackPicturebox.Image")));
            this.BackPicturebox.Location = new System.Drawing.Point(943, 12);
            this.BackPicturebox.Name = "BackPicturebox";
            this.BackPicturebox.Size = new System.Drawing.Size(35, 25);
            this.BackPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackPicturebox.TabIndex = 18;
            this.BackPicturebox.TabStop = false;
            this.BackPicturebox.Click += new System.EventHandler(this.BackPicturebox_Click);
            // 
            // PageTitleLabel
            // 
            this.PageTitleLabel.AutoSize = true;
            this.PageTitleLabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PageTitleLabel.Location = new System.Drawing.Point(457, 74);
            this.PageTitleLabel.Name = "PageTitleLabel";
            this.PageTitleLabel.Size = new System.Drawing.Size(182, 35);
            this.PageTitleLabel.TabIndex = 19;
            this.PageTitleLabel.Text = "Add New User";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1030, 570);
            this.Controls.Add(this.PageTitleLabel);
            this.Controls.Add(this.BackPicturebox);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.AddUserbtn);
            this.Controls.Add(this.PasswordpictureBox);
            this.Controls.Add(this.Passwordpanel);
            this.Controls.Add(this.EmailpictureBox);
            this.Controls.Add(this.EmailInputpanel);
            this.Controls.Add(this.LoginpictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitIcon);
            this.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeHome";
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ExitIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox LoginpictureBox;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button AddUserbtn;
        private System.Windows.Forms.PictureBox PasswordpictureBox;
        private System.Windows.Forms.Panel Passwordpanel;
        private System.Windows.Forms.PictureBox EmailpictureBox;
        private System.Windows.Forms.Panel EmailInputpanel;
        private System.Windows.Forms.PictureBox BackPicturebox;
        private System.Windows.Forms.Label PageTitleLabel;
    }
}