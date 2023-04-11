
namespace EmployeeSystemWinform
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
            this.ExitIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddEmployeepictureBox = new System.Windows.Forms.PictureBox();
            this.AddDataLabel = new System.Windows.Forms.Label();
            this.SearchEmployeePanel = new System.Windows.Forms.Panel();
            this.AllEmplyeeLabel = new System.Windows.Forms.Label();
            this.SearchEmployeepictureBox = new System.Windows.Forms.PictureBox();
            this.IssueSalaryPanel = new System.Windows.Forms.Panel();
            this.PayrollLabel = new System.Windows.Forms.Label();
            this.IssueSalarypictureBox = new System.Windows.Forms.PictureBox();
            this.LoginpictureBox = new System.Windows.Forms.PictureBox();
            this.AddEmployeePanel = new System.Windows.Forms.Panel();
            this.CreateUserLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddEmployeepictureBox)).BeginInit();
            this.SearchEmployeePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchEmployeepictureBox)).BeginInit();
            this.IssueSalaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IssueSalarypictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginpictureBox)).BeginInit();
            this.AddEmployeePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitIcon
            // 
            this.ExitIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitIcon.Image = global::EmployeeSystemWinform.Properties.Resources.exit;
            this.ExitIcon.Location = new System.Drawing.Point(993, 12);
            this.ExitIcon.Name = "ExitIcon";
            this.ExitIcon.Size = new System.Drawing.Size(25, 25);
            this.ExitIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitIcon.TabIndex = 0;
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
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Management System";
            // 
            // AddEmployeepictureBox
            // 
            this.AddEmployeepictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEmployeepictureBox.Image = global::EmployeeSystemWinform.Properties.Resources.addEmployee;
            this.AddEmployeepictureBox.Location = new System.Drawing.Point(52, 0);
            this.AddEmployeepictureBox.Name = "AddEmployeepictureBox";
            this.AddEmployeepictureBox.Size = new System.Drawing.Size(132, 136);
            this.AddEmployeepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddEmployeepictureBox.TabIndex = 2;
            this.AddEmployeepictureBox.TabStop = false;
            this.AddEmployeepictureBox.Click += new System.EventHandler(this.AddEmployeepictureBox_Click);
            // 
            // AddDataLabel
            // 
            this.AddDataLabel.AutoSize = true;
            this.AddDataLabel.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddDataLabel.Location = new System.Drawing.Point(52, 148);
            this.AddDataLabel.Name = "AddDataLabel";
            this.AddDataLabel.Size = new System.Drawing.Size(135, 26);
            this.AddDataLabel.TabIndex = 4;
            this.AddDataLabel.Text = "Add New Data";
            // 
            // SearchEmployeePanel
            // 
            this.SearchEmployeePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.SearchEmployeePanel.Controls.Add(this.AllEmplyeeLabel);
            this.SearchEmployeePanel.Controls.Add(this.SearchEmployeepictureBox);
            this.SearchEmployeePanel.Location = new System.Drawing.Point(393, 167);
            this.SearchEmployeePanel.Name = "SearchEmployeePanel";
            this.SearchEmployeePanel.Size = new System.Drawing.Size(244, 185);
            this.SearchEmployeePanel.TabIndex = 5;
            // 
            // AllEmplyeeLabel
            // 
            this.AllEmplyeeLabel.AutoSize = true;
            this.AllEmplyeeLabel.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AllEmplyeeLabel.Location = new System.Drawing.Point(47, 148);
            this.AllEmplyeeLabel.Name = "AllEmplyeeLabel";
            this.AllEmplyeeLabel.Size = new System.Drawing.Size(156, 26);
            this.AllEmplyeeLabel.TabIndex = 4;
            this.AllEmplyeeLabel.Text = "View Employees";
            // 
            // SearchEmployeepictureBox
            // 
            this.SearchEmployeepictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchEmployeepictureBox.Image = global::EmployeeSystemWinform.Properties.Resources.searchEmployee;
            this.SearchEmployeepictureBox.Location = new System.Drawing.Point(58, 0);
            this.SearchEmployeepictureBox.Name = "SearchEmployeepictureBox";
            this.SearchEmployeepictureBox.Size = new System.Drawing.Size(132, 136);
            this.SearchEmployeepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SearchEmployeepictureBox.TabIndex = 2;
            this.SearchEmployeepictureBox.TabStop = false;
            this.SearchEmployeepictureBox.Click += new System.EventHandler(this.SearchEmployeepictureBox_Click);
            // 
            // IssueSalaryPanel
            // 
            this.IssueSalaryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.IssueSalaryPanel.Controls.Add(this.PayrollLabel);
            this.IssueSalaryPanel.Controls.Add(this.IssueSalarypictureBox);
            this.IssueSalaryPanel.Location = new System.Drawing.Point(728, 167);
            this.IssueSalaryPanel.Name = "IssueSalaryPanel";
            this.IssueSalaryPanel.Size = new System.Drawing.Size(244, 185);
            this.IssueSalaryPanel.TabIndex = 6;
            // 
            // PayrollLabel
            // 
            this.PayrollLabel.AutoSize = true;
            this.PayrollLabel.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PayrollLabel.Location = new System.Drawing.Point(84, 148);
            this.PayrollLabel.Name = "PayrollLabel";
            this.PayrollLabel.Size = new System.Drawing.Size(75, 26);
            this.PayrollLabel.TabIndex = 4;
            this.PayrollLabel.Text = "Payroll";
            // 
            // IssueSalarypictureBox
            // 
            this.IssueSalarypictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IssueSalarypictureBox.Image = global::EmployeeSystemWinform.Properties.Resources.issueSalary;
            this.IssueSalarypictureBox.Location = new System.Drawing.Point(58, 0);
            this.IssueSalarypictureBox.Name = "IssueSalarypictureBox";
            this.IssueSalarypictureBox.Size = new System.Drawing.Size(132, 136);
            this.IssueSalarypictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IssueSalarypictureBox.TabIndex = 2;
            this.IssueSalarypictureBox.TabStop = false;
            this.IssueSalarypictureBox.Click += new System.EventHandler(this.IssueSalarypictureBox_Click);
            // 
            // LoginpictureBox
            // 
            this.LoginpictureBox.Image = global::EmployeeSystemWinform.Properties.Resources.logo;
            this.LoginpictureBox.Location = new System.Drawing.Point(12, 12);
            this.LoginpictureBox.Name = "LoginpictureBox";
            this.LoginpictureBox.Size = new System.Drawing.Size(28, 30);
            this.LoginpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoginpictureBox.TabIndex = 7;
            this.LoginpictureBox.TabStop = false;
            // 
            // AddEmployeePanel
            // 
            this.AddEmployeePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.AddEmployeePanel.Controls.Add(this.AddDataLabel);
            this.AddEmployeePanel.Controls.Add(this.AddEmployeepictureBox);
            this.AddEmployeePanel.Location = new System.Drawing.Point(55, 167);
            this.AddEmployeePanel.Name = "AddEmployeePanel";
            this.AddEmployeePanel.Size = new System.Drawing.Size(244, 185);
            this.AddEmployeePanel.TabIndex = 8;
            // 
            // CreateUserLabel
            // 
            this.CreateUserLabel.AutoSize = true;
            this.CreateUserLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateUserLabel.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.CreateUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.CreateUserLabel.Location = new System.Drawing.Point(419, 444);
            this.CreateUserLabel.Name = "CreateUserLabel";
            this.CreateUserLabel.Size = new System.Drawing.Size(153, 25);
            this.CreateUserLabel.TabIndex = 9;
            this.CreateUserLabel.Text = "Create New User";
            this.CreateUserLabel.Click += new System.EventHandler(this.CreateUserLabel_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1030, 570);
            this.Controls.Add(this.CreateUserLabel);
            this.Controls.Add(this.AddEmployeePanel);
            this.Controls.Add(this.LoginpictureBox);
            this.Controls.Add(this.IssueSalaryPanel);
            this.Controls.Add(this.SearchEmployeePanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitIcon);
            this.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddEmployeepictureBox)).EndInit();
            this.SearchEmployeePanel.ResumeLayout(false);
            this.SearchEmployeePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchEmployeepictureBox)).EndInit();
            this.IssueSalaryPanel.ResumeLayout(false);
            this.IssueSalaryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IssueSalarypictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginpictureBox)).EndInit();
            this.AddEmployeePanel.ResumeLayout(false);
            this.AddEmployeePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ExitIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox AddEmployeepictureBox;
        private System.Windows.Forms.Label AddDataLabel;
        private System.Windows.Forms.Panel SearchEmployeePanel;
        private System.Windows.Forms.Label AllEmplyeeLabel;
        private System.Windows.Forms.PictureBox SearchEmployeepictureBox;
        private System.Windows.Forms.Panel IssueSalaryPanel;
        private System.Windows.Forms.Label PayrollLabel;
        private System.Windows.Forms.PictureBox IssueSalarypictureBox;
        private System.Windows.Forms.PictureBox LoginpictureBox;
        private System.Windows.Forms.Panel AddEmployeePanel;
        private System.Windows.Forms.Label CreateUserLabel;
    }
}