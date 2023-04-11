
namespace EmployeeSystemWinform
{
    partial class AddLeaveWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLeaveWindow));
            this.ExitIcon = new System.Windows.Forms.PictureBox();
            this.WindowLabel = new System.Windows.Forms.Label();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.ReasonLabel = new System.Windows.Forms.Label();
            this.RemainingLeaveLabel = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.ReasonTxt = new System.Windows.Forms.TextBox();
            this.RemainingLeaveTxt = new System.Windows.Forms.TextBox();
            this.Addbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitIcon
            // 
            this.ExitIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitIcon.Image = ((System.Drawing.Image)(resources.GetObject("ExitIcon.Image")));
            this.ExitIcon.Location = new System.Drawing.Point(521, 9);
            this.ExitIcon.Name = "ExitIcon";
            this.ExitIcon.Size = new System.Drawing.Size(20, 20);
            this.ExitIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitIcon.TabIndex = 13;
            this.ExitIcon.TabStop = false;
            this.ExitIcon.Click += new System.EventHandler(this.ExitIcon_Click);
            // 
            // WindowLabel
            // 
            this.WindowLabel.AutoSize = true;
            this.WindowLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WindowLabel.Location = new System.Drawing.Point(12, 9);
            this.WindowLabel.Name = "WindowLabel";
            this.WindowLabel.Size = new System.Drawing.Size(101, 25);
            this.WindowLabel.TabIndex = 12;
            this.WindowLabel.Text = "Add Leave";
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmployeeNameLabel.Location = new System.Drawing.Point(238, 41);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(70, 28);
            this.EmployeeNameLabel.TabIndex = 37;
            this.EmployeeNameLabel.Text = "label7";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateLabel.Location = new System.Drawing.Point(12, 100);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(49, 25);
            this.DateLabel.TabIndex = 38;
            this.DateLabel.Text = "Date";
            // 
            // ReasonLabel
            // 
            this.ReasonLabel.AutoSize = true;
            this.ReasonLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReasonLabel.Location = new System.Drawing.Point(12, 147);
            this.ReasonLabel.Name = "ReasonLabel";
            this.ReasonLabel.Size = new System.Drawing.Size(69, 25);
            this.ReasonLabel.TabIndex = 39;
            this.ReasonLabel.Text = "Reason";
            // 
            // RemainingLeaveLabel
            // 
            this.RemainingLeaveLabel.AutoSize = true;
            this.RemainingLeaveLabel.Location = new System.Drawing.Point(12, 193);
            this.RemainingLeaveLabel.Name = "RemainingLeaveLabel";
            this.RemainingLeaveLabel.Size = new System.Drawing.Size(144, 25);
            this.RemainingLeaveLabel.TabIndex = 40;
            this.RemainingLeaveLabel.Text = "Remaining Leave";
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(204, 100);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(337, 31);
            this.DatePicker.TabIndex = 41;
            this.DatePicker.Value = new System.DateTime(2023, 4, 4, 20, 59, 31, 0);
            // 
            // ReasonTxt
            // 
            this.ReasonTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReasonTxt.Location = new System.Drawing.Point(204, 141);
            this.ReasonTxt.Multiline = true;
            this.ReasonTxt.Name = "ReasonTxt";
            this.ReasonTxt.Size = new System.Drawing.Size(337, 36);
            this.ReasonTxt.TabIndex = 42;
            // 
            // RemainingLeaveTxt
            // 
            this.RemainingLeaveTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RemainingLeaveTxt.Enabled = false;
            this.RemainingLeaveTxt.Location = new System.Drawing.Point(204, 189);
            this.RemainingLeaveTxt.Multiline = true;
            this.RemainingLeaveTxt.Name = "RemainingLeaveTxt";
            this.RemainingLeaveTxt.Size = new System.Drawing.Size(337, 36);
            this.RemainingLeaveTxt.TabIndex = 43;
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
            this.Addbtn.FlatAppearance.BorderSize = 0;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Addbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.Addbtn.Location = new System.Drawing.Point(431, 259);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(110, 40);
            this.Addbtn.TabIndex = 44;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // AddLeaveWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(553, 418);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.RemainingLeaveTxt);
            this.Controls.Add(this.ReasonTxt);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.RemainingLeaveLabel);
            this.Controls.Add(this.ReasonLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.ExitIcon);
            this.Controls.Add(this.WindowLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddLeaveWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddLeaveWindow";
            this.Load += new System.EventHandler(this.AddLeaveWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ExitIcon;
        private System.Windows.Forms.Label WindowLabel;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label ReasonLabel;
        private System.Windows.Forms.Label RemainingLeaveLabel;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.TextBox ReasonTxt;
        private System.Windows.Forms.TextBox RemainingLeaveTxt;
        private System.Windows.Forms.Button Addbtn;
    }
}