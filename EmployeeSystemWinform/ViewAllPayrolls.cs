using EmployeeSystemWinform.Classes;
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
    public partial class ViewAllPayrolls : Form
    {
        public ViewAllPayrolls()
        {
            InitializeComponent();
            FillGridView();
        }
        private void FillGridView()
        {
            var payrolls = new Payroll();
            var list = payrolls.GetAllPayrolls();
            dataGridViewPayrolls.DataSource = list;
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
    }
}
