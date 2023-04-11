
namespace EmployeeSystemWinform
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.EmployeeTitlelabel = new System.Windows.Forms.Label();
            this.ExitpictureBox = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.PasswordpictureBox = new System.Windows.Forms.PictureBox();
            this.Passwordpanel = new System.Windows.Forms.Panel();
            this.EmailpictureBox = new System.Windows.Forms.PictureBox();
            this.EmailInputpanel = new System.Windows.Forms.Panel();
            this.LoginTitlelabel = new System.Windows.Forms.Label();
            this.LoginpictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.splitContainer1.Panel1.Controls.Add(this.EmployeeTitlelabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.splitContainer1.Panel2.Controls.Add(this.ExitpictureBox);
            this.splitContainer1.Panel2.Controls.Add(this.txtPassword);
            this.splitContainer1.Panel2.Controls.Add(this.txtEmail);
            this.splitContainer1.Panel2.Controls.Add(this.btnLogIn);
            this.splitContainer1.Panel2.Controls.Add(this.PasswordpictureBox);
            this.splitContainer1.Panel2.Controls.Add(this.Passwordpanel);
            this.splitContainer1.Panel2.Controls.Add(this.EmailpictureBox);
            this.splitContainer1.Panel2.Controls.Add(this.EmailInputpanel);
            this.splitContainer1.Panel2.Controls.Add(this.LoginTitlelabel);
            this.splitContainer1.Panel2.Controls.Add(this.LoginpictureBox);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.splitContainer1.Size = new System.Drawing.Size(1030, 570);
            this.splitContainer1.SplitterDistance = 342;
            this.splitContainer1.TabIndex = 0;
            // 
            // EmployeeTitlelabel
            // 
            this.EmployeeTitlelabel.AutoSize = true;
            this.EmployeeTitlelabel.Font = new System.Drawing.Font("Sitka Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmployeeTitlelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.EmployeeTitlelabel.Location = new System.Drawing.Point(29, 145);
            this.EmployeeTitlelabel.MaximumSize = new System.Drawing.Size(400, 0);
            this.EmployeeTitlelabel.Name = "EmployeeTitlelabel";
            this.EmployeeTitlelabel.Size = new System.Drawing.Size(282, 174);
            this.EmployeeTitlelabel.TabIndex = 3;
            this.EmployeeTitlelabel.Text = "Employee Management System";
            this.EmployeeTitlelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ExitpictureBox
            // 
            this.ExitpictureBox.Image = global::EmployeeSystemWinform.Properties.Resources.exit;
            this.ExitpictureBox.Location = new System.Drawing.Point(645, 12);
            this.ExitpictureBox.Name = "ExitpictureBox";
            this.ExitpictureBox.Size = new System.Drawing.Size(25, 25);
            this.ExitpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitpictureBox.TabIndex = 11;
            this.ExitpictureBox.TabStop = false;
            this.ExitpictureBox.Click += new System.EventHandler(this.ExitpictureBox_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.txtPassword.Location = new System.Drawing.Point(132, 345);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(464, 31);
            this.txtPassword.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.txtEmail.Location = new System.Drawing.Point(132, 255);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(464, 31);
            this.txtEmail.TabIndex = 9;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Sitka Text", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.btnLogIn.Location = new System.Drawing.Point(96, 429);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(500, 51);
            this.btnLogIn.TabIndex = 8;
            this.btnLogIn.Text = "LOG IN";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // PasswordpictureBox
            // 
            this.PasswordpictureBox.Image = global::EmployeeSystemWinform.Properties.Resources.password;
            this.PasswordpictureBox.Location = new System.Drawing.Point(96, 341);
            this.PasswordpictureBox.Name = "PasswordpictureBox";
            this.PasswordpictureBox.Size = new System.Drawing.Size(30, 30);
            this.PasswordpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PasswordpictureBox.TabIndex = 7;
            this.PasswordpictureBox.TabStop = false;
            // 
            // Passwordpanel
            // 
            this.Passwordpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.Passwordpanel.Location = new System.Drawing.Point(96, 377);
            this.Passwordpanel.Name = "Passwordpanel";
            this.Passwordpanel.Size = new System.Drawing.Size(500, 2);
            this.Passwordpanel.TabIndex = 6;
            // 
            // EmailpictureBox
            // 
            this.EmailpictureBox.Image = global::EmployeeSystemWinform.Properties.Resources.email1;
            this.EmailpictureBox.Location = new System.Drawing.Point(96, 255);
            this.EmailpictureBox.Name = "EmailpictureBox";
            this.EmailpictureBox.Size = new System.Drawing.Size(30, 30);
            this.EmailpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EmailpictureBox.TabIndex = 5;
            this.EmailpictureBox.TabStop = false;
            // 
            // EmailInputpanel
            // 
            this.EmailInputpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.EmailInputpanel.Location = new System.Drawing.Point(96, 291);
            this.EmailInputpanel.Name = "EmailInputpanel";
            this.EmailInputpanel.Size = new System.Drawing.Size(500, 2);
            this.EmailInputpanel.TabIndex = 4;
            // 
            // LoginTitlelabel
            // 
            this.LoginTitlelabel.AutoSize = true;
            this.LoginTitlelabel.Font = new System.Drawing.Font("Sitka Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginTitlelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.LoginTitlelabel.Location = new System.Drawing.Point(242, 172);
            this.LoginTitlelabel.Name = "LoginTitlelabel";
            this.LoginTitlelabel.Size = new System.Drawing.Size(201, 69);
            this.LoginTitlelabel.TabIndex = 2;
            this.LoginTitlelabel.Text = "LOG IN";
            // 
            // LoginpictureBox
            // 
            this.LoginpictureBox.Image = global::EmployeeSystemWinform.Properties.Resources.logo;
            this.LoginpictureBox.Location = new System.Drawing.Point(267, 41);
            this.LoginpictureBox.Name = "LoginpictureBox";
            this.LoginpictureBox.Size = new System.Drawing.Size(149, 128);
            this.LoginpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoginpictureBox.TabIndex = 1;
            this.LoginpictureBox.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1030, 570);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExitpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label EmployeeTitlelabel;
        private System.Windows.Forms.Panel EmailInputpanel;
        private System.Windows.Forms.Label LoginTitlelabel;
        private System.Windows.Forms.PictureBox LoginpictureBox;
        private System.Windows.Forms.PictureBox EmailpictureBox;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.PictureBox PasswordpictureBox;
        private System.Windows.Forms.Panel Passwordpanel;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox ExitpictureBox;
    }
}

