using EmployeeSystemWinform.Classes;
using EmployeeSystemWinform.PropClasses;
using EmployeeSystemWinform.ViewModels;
using System;
using System.Windows.Forms;

namespace EmployeeSystemWinform
{
    public partial class ViewMoreOfEmployee : Form
    {
        readonly EmployeeContactViewModel _contactData;
        readonly EmployeePayrollInfoViewModel _payrollData;
        private readonly EmployeeComboViewModel _currentEmployee;
        private readonly EmployeeContact _employeeContact;
        private readonly PayrollInfo _payrollInfo;
        public ViewMoreOfEmployee(EmployeeComboViewModel item)
        {
           _employeeContact = new EmployeeContact();
             _contactData = _employeeContact.GetEmployeeContact(item.EmployeeId);
            _payrollInfo = new PayrollInfo();
          _payrollData = _payrollInfo.GetEmployeePayrollInfo(item.EmployeeId);
            InitializeComponent();
            WindowTitleLabel.Text = item.EmployeeName;
            FillData();
            _currentEmployee = item;
        }

        private void FillData()
        {
            if (_contactData != null)
            {
                PersonalNumbertxt.Text = _contactData.PersonalNumber.ToString();
                Addresstxt.Text = _contactData.Address;
                Nametxt.Text = _contactData.Name;
                Relationtxt.Text = _contactData.Relation;
                Conatcttxt.Text = _contactData.Contact.ToString();
            }
            if(_payrollData != null)
            {
                JoiningDatetxt.Text = _payrollData.JoiningDate;
                PaymentPerDaytxt.Text = _payrollData.PaymentPerDay.ToString();
                YearlyIncrementtxt.Text = _payrollData.YearlyIncrement.ToString("0.00");
                TotalLeavetxt.Text = _payrollData.TotalLeavePerYear.ToString();
                ReductionRatetxt.Text = _payrollData.LeaveReductionRate.ToString("0.00");
                BonusPerLeavetxt.Text = _payrollData.BonusPerExtraLeave.ToString("0.00");
            }
        }

        private void ExitIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            var em = new Employee();
            em.RemoveEmployee(_currentEmployee.EmployeeId);
            this.Close();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EnableFiled();
            DoneIcon.Visible = true;
        }

        private void EnableFiled()
        {
            PersonalNumbertxt.Enabled = true;
            Addresstxt.Enabled = true;
            Nametxt.Enabled = true;
            Relationtxt.Enabled = true;
            Conatcttxt.Enabled = true;
            PaymentPerDaytxt.Enabled = true;
            YearlyIncrementtxt.Enabled = true;
            ReductionRatetxt.Enabled = true;
            BonusPerLeavetxt.Enabled = true;
        }

        private void DisableFields()
        {
            PersonalNumbertxt.Enabled = false;
            Addresstxt.Enabled = false;
            Nametxt.Enabled = false;
            Relationtxt.Enabled = false;
            Conatcttxt.Enabled = false;
            PaymentPerDaytxt.Enabled = false;
            YearlyIncrementtxt.Enabled = false;
            ReductionRatetxt.Enabled = false;
            BonusPerLeavetxt.Enabled = false;
        }

        private void DoneIcon_Click(object sender, EventArgs e)
        {
            var contactItem = new AddEmployeeContactItem
            {
                EmployeeId = _currentEmployee.EmployeeId,
                Address = Addresstxt.Text,
                PersonalNumber = long.Parse(PersonalNumbertxt.Text),
                EmergencyName = Nametxt.Text,
                EmergencyRelation = Relationtxt.Text,
                EmergencyNumber = long.Parse(Conatcttxt.Text),
            };
            var PayrollInfoItem = new AddPayrollInfoItem
            {
                EmployeeId = _currentEmployee.EmployeeId,
                PaymentPerday = float.Parse(PaymentPerDaytxt.Text),
                YearlyIncreament = float.Parse(YearlyIncrementtxt.Text),
                LeaveDeductionRate = float.Parse(ReductionRatetxt.Text),
                BonusPerExtraLeave = float.Parse(BonusPerLeavetxt.Text)
            };
            _employeeContact.UpdateEmployeeContact(contactItem);
            _payrollInfo.UpdatePayrollInfo(PayrollInfoItem);
            DisableFields();
            DoneIcon.Visible = false;
        }
    }
}
