using EmployeeSystemWinform.Classes;
using EmployeeSystemWinform.PropClasses;
using EmployeeSystemWinform.ViewModels;
using System;
using System.Windows.Forms;

namespace EmployeeSystemWinform
{
    public partial class AddPayrollWindow : Form
    {
        private readonly RemainingLeaveResponse _response;
        private readonly EmployeeComboViewModel _currentEmployee;
        private bool _backSpacePressed = false;
        public AddPayrollWindow(EmployeeComboViewModel item)
        {
            InitializeComponent();
            EmployeeNameLabel.Text = item.EmployeeName;
            var leave = new Leave();
            _response = leave.GetRemainingLeave(item.EmployeeId);
            RemainingLeaveTxt.Text = _response.RemainingLeave.ToString();
            ExcessLeaveTxt.Text = _response.ExcessLeave.ToString();
            _currentEmployee = item;
        }


        private void ExitIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPayrollWindow_Load(object sender, EventArgs e)
        {
            if (!_response.HaveData)
            {
                // Add.Enabled = false;
                MessageBox.Show("Please add Payroll Info for this employee!");
                this.Close();
            }
            if(new Payroll().IsPaid(_currentEmployee.EmployeeId))
            {
                MessageBox.Show("The employee is already paid!");
                this.Close();
            }
        }

        private void TotalWorksDaysTxt_TextChanged(object sender, EventArgs e)
        {
            int number = 0;
            var workdays = 0;
            if (TotalWorksDaysTxt.Text == "")
            {
                _backSpacePressed = false;
                TotalWorksDaysTxt.KeyPress -= TotalWorksDaysTxt_KeyPress;
                return;
            }
            TotalWorksDaysTxt.KeyPress += TotalWorksDaysTxt_KeyPress;
            if (_backSpacePressed == true)
            {
                _backSpacePressed = false;
                TotalWorksDaysTxt.KeyPress -= TotalWorksDaysTxt_KeyPress;
                return;
            }
            if (int.TryParse(TotalWorksDaysTxt.Text.Trim(), out number))
            {
                workdays = Convert.ToInt32(TotalWorksDaysTxt.Text);
            }
            else
            {
                //not a number
                MessageBox.Show("Please insert correct number.");
                return;
            }
            number = Convert.ToInt32(TotalWorksDaysTxt.Text);
            //textBox value is a number
            var payroll = new PayrollInfo();
            var calculatedPayment = payroll.PayrollCalculation(workdays, _currentEmployee.EmployeeId);
            AmountLabel.Text = calculatedPayment.ToString("0.00");
        }

        private void TotalWorksDaysTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                _backSpacePressed = true;
            }
        }

        private void Issuebtn_Click(object sender, EventArgs e)
        {
            var item = new AddPayrollItem
            {
                EmployeeId = _currentEmployee.EmployeeId,
                Amount = float.Parse(AmountLabel.Text),
                IssueDate = IssueDatePicker.Value,
                TotalWorkDays = int.Parse(TotalWorksDaysTxt.Text)
            };
            var payroll = new Payroll();
            payroll.AddPayrollData(item);
        }
    }
}
