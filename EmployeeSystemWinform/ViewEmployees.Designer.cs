
namespace EmployeeSystemWinform
{
    partial class ViewEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmployees));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BackPicturebox = new System.Windows.Forms.PictureBox();
            this.AppPictureBox = new System.Windows.Forms.PictureBox();
            this.AppTitleLabel = new System.Windows.Forms.Label();
            this.ExitIcon = new System.Windows.Forms.PictureBox();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.ViewMoreBtn = new System.Windows.Forms.Button();
            this.AddPayrollButton = new System.Windows.Forms.Button();
            this.AddLeaveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BackPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // BackPicturebox
            // 
            this.BackPicturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackPicturebox.Image = ((System.Drawing.Image)(resources.GetObject("BackPicturebox.Image")));
            this.BackPicturebox.Location = new System.Drawing.Point(940, 9);
            this.BackPicturebox.Name = "BackPicturebox";
            this.BackPicturebox.Size = new System.Drawing.Size(35, 25);
            this.BackPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackPicturebox.TabIndex = 13;
            this.BackPicturebox.TabStop = false;
            this.BackPicturebox.Click += new System.EventHandler(this.BackPicturebox_Click);
            // 
            // AppPictureBox
            // 
            this.AppPictureBox.Image = global::EmployeeSystemWinform.Properties.Resources.logo;
            this.AppPictureBox.Location = new System.Drawing.Point(13, 9);
            this.AppPictureBox.Name = "AppPictureBox";
            this.AppPictureBox.Size = new System.Drawing.Size(28, 30);
            this.AppPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AppPictureBox.TabIndex = 11;
            this.AppPictureBox.TabStop = false;
            // 
            // AppTitleLabel
            // 
            this.AppTitleLabel.AutoSize = true;
            this.AppTitleLabel.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AppTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.AppTitleLabel.Location = new System.Drawing.Point(47, 9);
            this.AppTitleLabel.Name = "AppTitleLabel";
            this.AppTitleLabel.Size = new System.Drawing.Size(288, 26);
            this.AppTitleLabel.TabIndex = 10;
            this.AppTitleLabel.Text = "Employee Management System";
            // 
            // ExitIcon
            // 
            this.ExitIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitIcon.Image = global::EmployeeSystemWinform.Properties.Resources.exit;
            this.ExitIcon.Location = new System.Drawing.Point(993, 9);
            this.ExitIcon.Name = "ExitIcon";
            this.ExitIcon.Size = new System.Drawing.Size(25, 25);
            this.ExitIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitIcon.TabIndex = 9;
            this.ExitIcon.TabStop = false;
            this.ExitIcon.Click += new System.EventHandler(this.ExitIcon_Click);
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.AllowUserToDeleteRows = false;
            this.dataGridViewEmployees.AllowUserToResizeColumns = false;
            this.dataGridViewEmployees.AllowUserToResizeRows = false;
            this.dataGridViewEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.dataGridViewEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEmployees.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEmployees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.dataGridViewEmployees.Location = new System.Drawing.Point(13, 68);
            this.dataGridViewEmployees.MultiSelect = false;
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.ReadOnly = true;
            this.dataGridViewEmployees.RowHeadersWidth = 62;
            this.dataGridViewEmployees.RowTemplate.Height = 33;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(1005, 433);
            this.dataGridViewEmployees.TabIndex = 14;
            // 
            // ViewMoreBtn
            // 
            this.ViewMoreBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.ViewMoreBtn.FlatAppearance.BorderSize = 0;
            this.ViewMoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewMoreBtn.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewMoreBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.ViewMoreBtn.Location = new System.Drawing.Point(804, 518);
            this.ViewMoreBtn.Name = "ViewMoreBtn";
            this.ViewMoreBtn.Size = new System.Drawing.Size(214, 40);
            this.ViewMoreBtn.TabIndex = 15;
            this.ViewMoreBtn.Text = "View More";
            this.ViewMoreBtn.UseVisualStyleBackColor = false;
            this.ViewMoreBtn.Click += new System.EventHandler(this.ViewDetailsBtn_Click);
            // 
            // AddPayrollButton
            // 
            this.AddPayrollButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.AddPayrollButton.FlatAppearance.BorderSize = 0;
            this.AddPayrollButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPayrollButton.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddPayrollButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.AddPayrollButton.Location = new System.Drawing.Point(573, 518);
            this.AddPayrollButton.Name = "AddPayrollButton";
            this.AddPayrollButton.Size = new System.Drawing.Size(214, 40);
            this.AddPayrollButton.TabIndex = 16;
            this.AddPayrollButton.Text = "Add Payroll";
            this.AddPayrollButton.UseVisualStyleBackColor = false;
            this.AddPayrollButton.Click += new System.EventHandler(this.AddPayrollButton_Click);
            // 
            // AddLeaveBtn
            // 
            this.AddLeaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.AddLeaveBtn.FlatAppearance.BorderSize = 0;
            this.AddLeaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddLeaveBtn.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddLeaveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.AddLeaveBtn.Location = new System.Drawing.Point(340, 518);
            this.AddLeaveBtn.Name = "AddLeaveBtn";
            this.AddLeaveBtn.Size = new System.Drawing.Size(214, 40);
            this.AddLeaveBtn.TabIndex = 17;
            this.AddLeaveBtn.Text = "Add Leave";
            this.AddLeaveBtn.UseVisualStyleBackColor = false;
            this.AddLeaveBtn.Click += new System.EventHandler(this.AddLeaveBtn_Click);
            // 
            // ViewEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1030, 570);
            this.Controls.Add(this.AddLeaveBtn);
            this.Controls.Add(this.AddPayrollButton);
            this.Controls.Add(this.ViewMoreBtn);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Controls.Add(this.BackPicturebox);
            this.Controls.Add(this.AppPictureBox);
            this.Controls.Add(this.AppTitleLabel);
            this.Controls.Add(this.ExitIcon);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.ViewEmployees_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.BackPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BackPicturebox;
        private System.Windows.Forms.PictureBox AppPictureBox;
        private System.Windows.Forms.Label AppTitleLabel;
        private System.Windows.Forms.PictureBox ExitIcon;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Button ViewMoreBtn;
        private System.Windows.Forms.Button AddPayrollButton;
        private System.Windows.Forms.Button AddLeaveBtn;
    }
}