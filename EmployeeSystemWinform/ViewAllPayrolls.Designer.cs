
namespace EmployeeSystemWinform
{
    partial class ViewAllPayrolls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllPayrolls));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BackPicturebox = new System.Windows.Forms.PictureBox();
            this.AppPictureBox = new System.Windows.Forms.PictureBox();
            this.AppTitleLabel = new System.Windows.Forms.Label();
            this.ExitIcon = new System.Windows.Forms.PictureBox();
            this.dataGridViewPayrolls = new System.Windows.Forms.DataGridView();
            this.PageTitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BackPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayrolls)).BeginInit();
            this.SuspendLayout();
            // 
            // BackPicturebox
            // 
            this.BackPicturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackPicturebox.Image = ((System.Drawing.Image)(resources.GetObject("BackPicturebox.Image")));
            this.BackPicturebox.Location = new System.Drawing.Point(619, 10);
            this.BackPicturebox.Name = "BackPicturebox";
            this.BackPicturebox.Size = new System.Drawing.Size(35, 25);
            this.BackPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackPicturebox.TabIndex = 17;
            this.BackPicturebox.TabStop = false;
            this.BackPicturebox.Click += new System.EventHandler(this.BackPicturebox_Click);
            // 
            // AppPictureBox
            // 
            this.AppPictureBox.Image = global::EmployeeSystemWinform.Properties.Resources.logo;
            this.AppPictureBox.Location = new System.Drawing.Point(12, 9);
            this.AppPictureBox.Name = "AppPictureBox";
            this.AppPictureBox.Size = new System.Drawing.Size(28, 30);
            this.AppPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AppPictureBox.TabIndex = 16;
            this.AppPictureBox.TabStop = false;
            // 
            // AppTitleLabel
            // 
            this.AppTitleLabel.AutoSize = true;
            this.AppTitleLabel.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AppTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.AppTitleLabel.Location = new System.Drawing.Point(46, 9);
            this.AppTitleLabel.Name = "AppTitleLabel";
            this.AppTitleLabel.Size = new System.Drawing.Size(288, 26);
            this.AppTitleLabel.TabIndex = 15;
            this.AppTitleLabel.Text = "Employee Management System";
            // 
            // ExitIcon
            // 
            this.ExitIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitIcon.Image = global::EmployeeSystemWinform.Properties.Resources.exit;
            this.ExitIcon.Location = new System.Drawing.Point(672, 10);
            this.ExitIcon.Name = "ExitIcon";
            this.ExitIcon.Size = new System.Drawing.Size(25, 25);
            this.ExitIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitIcon.TabIndex = 14;
            this.ExitIcon.TabStop = false;
            this.ExitIcon.Click += new System.EventHandler(this.ExitIcon_Click);
            // 
            // dataGridViewPayrolls
            // 
            this.dataGridViewPayrolls.AllowUserToAddRows = false;
            this.dataGridViewPayrolls.AllowUserToDeleteRows = false;
            this.dataGridViewPayrolls.AllowUserToResizeColumns = false;
            this.dataGridViewPayrolls.AllowUserToResizeRows = false;
            this.dataGridViewPayrolls.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.dataGridViewPayrolls.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPayrolls.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPayrolls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPayrolls.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPayrolls.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.dataGridViewPayrolls.Location = new System.Drawing.Point(46, 107);
            this.dataGridViewPayrolls.MultiSelect = false;
            this.dataGridViewPayrolls.Name = "dataGridViewPayrolls";
            this.dataGridViewPayrolls.ReadOnly = true;
            this.dataGridViewPayrolls.RowHeadersWidth = 62;
            this.dataGridViewPayrolls.RowTemplate.Height = 33;
            this.dataGridViewPayrolls.Size = new System.Drawing.Size(614, 401);
            this.dataGridViewPayrolls.TabIndex = 18;
            // 
            // PageTitleLabel
            // 
            this.PageTitleLabel.AutoSize = true;
            this.PageTitleLabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PageTitleLabel.Location = new System.Drawing.Point(283, 59);
            this.PageTitleLabel.Name = "PageTitleLabel";
            this.PageTitleLabel.Size = new System.Drawing.Size(150, 35);
            this.PageTitleLabel.TabIndex = 19;
            this.PageTitleLabel.Text = "All Payrolls";
            // 
            // ViewAllPayrolls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(709, 530);
            this.Controls.Add(this.PageTitleLabel);
            this.Controls.Add(this.dataGridViewPayrolls);
            this.Controls.Add(this.BackPicturebox);
            this.Controls.Add(this.AppPictureBox);
            this.Controls.Add(this.AppTitleLabel);
            this.Controls.Add(this.ExitIcon);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewAllPayrolls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAllPayrolls";
            ((System.ComponentModel.ISupportInitialize)(this.BackPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayrolls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BackPicturebox;
        private System.Windows.Forms.PictureBox AppPictureBox;
        private System.Windows.Forms.Label AppTitleLabel;
        private System.Windows.Forms.PictureBox ExitIcon;
        private System.Windows.Forms.DataGridView dataGridViewPayrolls;
        private System.Windows.Forms.Label PageTitleLabel;
    }
}