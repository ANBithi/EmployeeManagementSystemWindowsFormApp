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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void ExitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddEmployeepictureBox_Click(object sender, EventArgs e)
        {
            new AddEmployee().Show();
            this.Hide();
        }

        private void SearchEmployeepictureBox_Click(object sender, EventArgs e)
        {
            new ViewEmployees().Show();
            this.Hide();
        }

        private void IssueSalarypictureBox_Click(object sender, EventArgs e)
        {
            new ViewAllPayrolls().Show();
            this.Hide();
        }

        private void CreateUserLabel_Click(object sender, EventArgs e)
        {
                new AddUser().Show();
                this.Hide();
        }
    }
}
