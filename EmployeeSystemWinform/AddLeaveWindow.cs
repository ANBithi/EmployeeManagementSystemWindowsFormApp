using EmployeeSystemWinform.Classes;
using EmployeeSystemWinform.PropClasses;
using EmployeeSystemWinform.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSystemWinform
{
    public partial class AddLeaveWindow : Form
    {
        private readonly EmployeeComboViewModel _currentEmployee;
        private readonly RemainingLeaveResponse _response;
        public AddLeaveWindow(EmployeeComboViewModel item)
        {
            var leave = new Leave();
             _response = leave.GetRemainingLeave(item.EmployeeId);
            _currentEmployee = item;
            InitializeComponent();
            RemainingLeaveTxt.Text = _response.RemainingLeave.ToString();
            EmployeeNameLabel.Text = item.EmployeeName;
        }

        private void ExitIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (DatePicker.Value > DateTime.Now && ReasonTxt.Text != "")
            {
                var p = new AddLeaveData
                {
                    EmployeeId = _currentEmployee.EmployeeId,
                    Date = DatePicker.Value,
                    Reason = ReasonTxt.Text
                };
                var lv = new Leave();
                lv.AddLeaveData(p);
                this.Close();
            }
            else
            {
                if(ReasonTxt.Text == "")
                {
                    MessageBox.Show("Please provide a reason.");
                }
                if (DatePicker.Value < DateTime.Now)
                {
                    MessageBox.Show("No leave can be added from past days!");
                }
            }
        }

        private void AddLeaveWindow_Load(object sender, EventArgs e)
        {
            if (!_response.HaveData)
            {
                // Add.Enabled = false;
                MessageBox.Show("Please add Payroll Info for this employee before adding any leave");
                this.Close();
            }
        }
    }
}
