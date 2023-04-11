using EmployeeSystemWinform.Classes;
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
    public partial class ViewEmployees : Form
    {
        
        public ViewEmployees()
        {
            InitializeComponent();
            FillGridView();
        }
        private void FillGridView()
        {
            var em = new Employee();
            var emList = em.GetEmployees();
            dataGridViewEmployees.DataSource = emList;
        }

        private void ExitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackPicturebox_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
        private EmployeeComboViewModel SelectedEmployee()
        {
            var selected = new EmployeeComboViewModel
            {
                EmployeeId = (int)dataGridViewEmployees.CurrentRow.Cells[0].Value,
                EmployeeName = dataGridViewEmployees.CurrentRow.Cells[1].Value.ToString()
            };
            return selected;
        }
        private void ViewEmployees_Activated(object sender, EventArgs e)
        {
            FillGridView();
        }

        private void ViewDetailsBtn_Click(object sender, EventArgs e)
        {
            var selected = SelectedEmployee();
            new ViewMoreOfEmployee(selected).Show();
        }

        private void AddPayrollButton_Click(object sender, EventArgs e)
        {
            var selected = SelectedEmployee();
            new AddPayrollWindow(selected).Show();
        }

        private void AddLeaveBtn_Click(object sender, EventArgs e)
        {
            var selected = SelectedEmployee();
            new AddLeaveWindow(selected).Show();
        }
    }
}
