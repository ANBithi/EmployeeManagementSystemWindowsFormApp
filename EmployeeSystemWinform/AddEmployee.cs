using EmployeeSystemWinform.Classes;
using EmployeeSystemWinform.PropClasses;
using EmployeeSystemWinform.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace EmployeeSystemWinform
{
    public enum AddDataTabs
    {
        NewEmployee,
        NewContact,
        NewPayroll
    }

    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
            GetEmployeeIdListForComboBox();
            ClearFields(AddDataTabs.NewContact);
            ClearFields(AddDataTabs.NewEmployee);
            ClearFields(AddDataTabs.NewPayroll);
        }

        private void ExitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            bool disabledAdd = true;
            if (!disabledAdd) {
                MessageBox.Show("Please fill up the other forms too!");     
                    }
            else
            {
                ConfigureAddEmployeeData();
                ClearFields(AddDataTabs.NewEmployee);
                GetEmployeeIdListForComboBox();
            }

        }

        private void GetEmployeeIdListForComboBox()
        {
            EmployeeIdComboBox.Items.Clear();
            EmployeeIdComboBox2.Items.Clear();
            var employee = new Employee();
            List<EmployeeComboViewModel> EmployeeIdList = employee.GetAllEmployeeId();
            foreach(EmployeeComboViewModel a in EmployeeIdList)
            {
                EmployeeIdComboBox.Items.Add($"{a.EmployeeId} ({a.EmployeeName})");
                EmployeeIdComboBox2.Items.Add($"{a.EmployeeId} ({a.EmployeeName})");
            }
        }

        private void ConfigureAddEmployeeData()
        {
            var item = new AddEmployeeItem
            {
                Name = EmployeeNameTextBox.Text,
                Designation = (string)DesignationCombo.SelectedItem,
                DateOfBirth = BirthDateTimePicker.Value,
                Nationality = (string)NationalityCombo.SelectedItem,
                NID = long.Parse(NIDTxt.Text)
            };
            if (MaleRadioButton.Checked)
            {
                item.Gender = MaleRadioButton.Text;
            }
            else if (FemaleRadioButton.Checked)
            {
                item.Gender = FemaleRadioButton.Text;
            }
            var employee = new Employee();
            employee.AddEmployeeData(item);
        }

        void ClearFields(AddDataTabs tab)
        {
            switch (tab)
            {
                case AddDataTabs.NewEmployee:
                    EmployeeNameTextBox.Text = "";
                    DesignationCombo.SelectedIndex = -1;
                    BirthDateTimePicker.Value = DateTime.Now;
                    MaleRadioButton.Checked = true;
                    NationalityCombo.SelectedIndex = -1;
                    NIDTxt.Text = "";
                    break;
                case AddDataTabs.NewContact:
                    PersonalNumberTxtbx.Text = "";
                    AddressTxtbx.Text = "";
                    EmerRelationCombx.SelectedIndex = -1;
                    EmerNumberTxtbx.Text = "";
                    EmerNameTxtbx.Text = "";
                    EmployeeIdComboBox.SelectedIndex = -1;
                    break;
                case AddDataTabs.NewPayroll:
                    PaymentPerDayTxtbx.Text = "";
                    YearlyInceramentTxtbx.Text = "";
                    JoiningDateTimePicker.Value = DateTime.Now;
                    TotalLeavePerYearTxtBox.Text = "";
                    LeaveDeductRateTxtBox.Text = "";
                    BonusPerExtraLeaveTxtbx.Text = "";
                    EmployeeIdComboBox2.SelectedIndex = -1;
                    break;
                default:
                    break;
            }
        }

        private void AddContactBtn_Click(object sender, EventArgs e)
        {

            ConfigureAddContactData();
            ClearFields(AddDataTabs.NewContact);
        }

        private static int GetSelectedEmployeeId (string selected)
        {
            var p = selected.Split(" ");
            var id = Convert.ToInt32(p[0]);
            return id;
        }
        private void ConfigureAddContactData()
        {
            var item = new AddEmployeeContactItem
            {
                PersonalNumber = Convert.ToInt64(PersonalNumberTxtbx.Text),
                Address = AddressTxtbx.Text,
                EmergencyName = EmerNameTxtbx.Text,
                EmergencyRelation = EmerRelationCombx.Text,
                EmergencyNumber = Convert.ToInt64(EmerNumberTxtbx.Text),
            };

            item.EmployeeId = GetSelectedEmployeeId(EmployeeIdComboBox.Text);
            var con = new EmployeeContact();
            con.AddEmployeeContactData(item);
        }

        private void ConfigureAddPayrollData()
        {
            var item = new AddPayrollInfoItem
            {
                YearlyIncreament = float.Parse(float.Parse(YearlyInceramentTxtbx.Text).ToString("0.00")),
                PaymentPerday = float.Parse(float.Parse(PaymentPerDayTxtbx.Text).ToString("0.00")),
                JoiningDate = JoiningDateTimePicker.Value,
                TotalLeavePerYear = int.Parse(TotalLeavePerYearTxtBox.Text),
                LeaveDeductionRate = float.Parse(float.Parse(LeaveDeductRateTxtBox.Text).ToString("0.00")),
                BonusPerExtraLeave = float.Parse(float.Parse(BonusPerExtraLeaveTxtbx.Text).ToString("0.00")),
            };
            item.EmployeeId = GetSelectedEmployeeId(EmployeeIdComboBox2.Text);
            var con = new PayrollInfo();
            con.AddPayrollInfoData(item);
        }

        private void AddPayrollInfoBtn_Click(object sender, EventArgs e)
        {
            ConfigureAddPayrollData();
            ClearFields(AddDataTabs.NewPayroll);
        }

        private void BackPicturebox_Click(object sender, EventArgs e)
        {
            new Home().Show();
            Hide();
        }

    }
}
