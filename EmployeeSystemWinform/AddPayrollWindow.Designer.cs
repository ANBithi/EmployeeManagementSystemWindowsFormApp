
namespace EmployeeSystemWinform
{
    partial class AddPayrollWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPayrollWindow));
            this.WindowLabel = new System.Windows.Forms.Label();
            this.ExitIcon = new System.Windows.Forms.PictureBox();
            this.IssueDateLabel = new System.Windows.Forms.Label();
            this.RemainingLeaveLabel = new System.Windows.Forms.Label();
            this.ExcessLeaveLabel = new System.Windows.Forms.Label();
            this.TotalAmountLabel = new System.Windows.Forms.Label();
            this.RemainingLeaveTxt = new System.Windows.Forms.TextBox();
            this.IssueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ExcessLeaveTxt = new System.Windows.Forms.TextBox();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.TotalWorksDaysTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.Issuebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // WindowLabel
            // 
            this.WindowLabel.AutoSize = true;
            this.WindowLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WindowLabel.Location = new System.Drawing.Point(12, 9);
            this.WindowLabel.Name = "WindowLabel";
            this.WindowLabel.Size = new System.Drawing.Size(119, 25);
            this.WindowLabel.TabIndex = 0;
            this.WindowLabel.Text = "Issue Payroll";
            // 
            // ExitIcon
            // 
            this.ExitIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitIcon.Image = ((System.Drawing.Image)(resources.GetObject("ExitIcon.Image")));
            this.ExitIcon.Location = new System.Drawing.Point(462, 12);
            this.ExitIcon.Name = "ExitIcon";
            this.ExitIcon.Size = new System.Drawing.Size(20, 20);
            this.ExitIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitIcon.TabIndex = 11;
            this.ExitIcon.TabStop = false;
            this.ExitIcon.Click += new System.EventHandler(this.ExitIcon_Click);
            // 
            // IssueDateLabel
            // 
            this.IssueDateLabel.AutoSize = true;
            this.IssueDateLabel.Location = new System.Drawing.Point(12, 96);
            this.IssueDateLabel.Name = "IssueDateLabel";
            this.IssueDateLabel.Size = new System.Drawing.Size(94, 25);
            this.IssueDateLabel.TabIndex = 13;
            this.IssueDateLabel.Text = "Issue Date";
            // 
            // RemainingLeaveLabel
            // 
            this.RemainingLeaveLabel.AutoSize = true;
            this.RemainingLeaveLabel.Location = new System.Drawing.Point(12, 181);
            this.RemainingLeaveLabel.Name = "RemainingLeaveLabel";
            this.RemainingLeaveLabel.Size = new System.Drawing.Size(144, 25);
            this.RemainingLeaveLabel.TabIndex = 14;
            this.RemainingLeaveLabel.Text = "Remaining Leave";
            // 
            // ExcessLeaveLabel
            // 
            this.ExcessLeaveLabel.AutoSize = true;
            this.ExcessLeaveLabel.Location = new System.Drawing.Point(12, 227);
            this.ExcessLeaveLabel.Name = "ExcessLeaveLabel";
            this.ExcessLeaveLabel.Size = new System.Drawing.Size(111, 25);
            this.ExcessLeaveLabel.TabIndex = 15;
            this.ExcessLeaveLabel.Text = "Excess Leave";
            // 
            // TotalAmountLabel
            // 
            this.TotalAmountLabel.AutoSize = true;
            this.TotalAmountLabel.Location = new System.Drawing.Point(57, 289);
            this.TotalAmountLabel.Name = "TotalAmountLabel";
            this.TotalAmountLabel.Size = new System.Drawing.Size(119, 25);
            this.TotalAmountLabel.TabIndex = 16;
            this.TotalAmountLabel.Text = "Total Amount";
            // 
            // RemainingLeaveTxt
            // 
            this.RemainingLeaveTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RemainingLeaveTxt.Enabled = false;
            this.RemainingLeaveTxt.Location = new System.Drawing.Point(162, 170);
            this.RemainingLeaveTxt.Multiline = true;
            this.RemainingLeaveTxt.Name = "RemainingLeaveTxt";
            this.RemainingLeaveTxt.Size = new System.Drawing.Size(320, 36);
            this.RemainingLeaveTxt.TabIndex = 29;
            // 
            // IssueDatePicker
            // 
            this.IssueDatePicker.Location = new System.Drawing.Point(162, 91);
            this.IssueDatePicker.Name = "IssueDatePicker";
            this.IssueDatePicker.Size = new System.Drawing.Size(320, 31);
            this.IssueDatePicker.TabIndex = 32;
            // 
            // ExcessLeaveTxt
            // 
            this.ExcessLeaveTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExcessLeaveTxt.Enabled = false;
            this.ExcessLeaveTxt.Location = new System.Drawing.Point(162, 216);
            this.ExcessLeaveTxt.Multiline = true;
            this.ExcessLeaveTxt.Name = "ExcessLeaveTxt";
            this.ExcessLeaveTxt.Size = new System.Drawing.Size(320, 36);
            this.ExcessLeaveTxt.TabIndex = 34;
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(215, 42);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(59, 25);
            this.EmployeeNameLabel.TabIndex = 36;
            this.EmployeeNameLabel.Text = "label7";
            // 
            // TotalWorksDaysTxt
            // 
            this.TotalWorksDaysTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalWorksDaysTxt.Location = new System.Drawing.Point(162, 128);
            this.TotalWorksDaysTxt.Multiline = true;
            this.TotalWorksDaysTxt.Name = "TotalWorksDaysTxt";
            this.TotalWorksDaysTxt.Size = new System.Drawing.Size(320, 36);
            this.TotalWorksDaysTxt.TabIndex = 38;
            this.TotalWorksDaysTxt.TextChanged += new System.EventHandler(this.TotalWorksDaysTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Total WorkDays";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountLabel.Location = new System.Drawing.Point(267, 282);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(63, 32);
            this.AmountLabel.TabIndex = 39;
            this.AmountLabel.Text = "0.00";
            // 
            // Issuebtn
            // 
            this.Issuebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(84)))), ((int)(((byte)(85)))));
            this.Issuebtn.FlatAppearance.BorderSize = 0;
            this.Issuebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Issuebtn.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Issuebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.Issuebtn.Location = new System.Drawing.Point(372, 359);
            this.Issuebtn.Name = "Issuebtn";
            this.Issuebtn.Size = new System.Drawing.Size(110, 40);
            this.Issuebtn.TabIndex = 45;
            this.Issuebtn.Text = "Issue";
            this.Issuebtn.UseVisualStyleBackColor = false;
            this.Issuebtn.Click += new System.EventHandler(this.Issuebtn_Click);
            // 
            // AddPayrollWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(494, 502);
            this.Controls.Add(this.Issuebtn);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.TotalWorksDaysTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.ExcessLeaveTxt);
            this.Controls.Add(this.IssueDatePicker);
            this.Controls.Add(this.RemainingLeaveTxt);
            this.Controls.Add(this.TotalAmountLabel);
            this.Controls.Add(this.ExcessLeaveLabel);
            this.Controls.Add(this.RemainingLeaveLabel);
            this.Controls.Add(this.IssueDateLabel);
            this.Controls.Add(this.ExitIcon);
            this.Controls.Add(this.WindowLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPayrollWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPayrollWindow";
            this.Load += new System.EventHandler(this.AddPayrollWindow_Load);
            this.TextChanged += new System.EventHandler(this.TotalWorksDaysTxt_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WindowLabel;
        private System.Windows.Forms.PictureBox ExitIcon;
        private System.Windows.Forms.Label IssueDateLabel;
        private System.Windows.Forms.Label RemainingLeaveLabel;
        private System.Windows.Forms.Label ExcessLeaveLabel;
        private System.Windows.Forms.Label TotalAmountLabel;
        private System.Windows.Forms.TextBox RemainingLeaveTxt;
        private System.Windows.Forms.DateTimePicker IssueDatePicker;
        private System.Windows.Forms.TextBox ExcessLeaveTxt;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.TextBox TotalWorksDaysTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Button Issuebtn;
    }
}