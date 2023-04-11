using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using EmployeeSystemWinform.Classes;

namespace EmployeeSystemWinform
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            var user = new User();
            var userResponse = user.FindUserByMail(txtEmail.Text, txtPassword.Text);
            if (userResponse.Found)
            {
                if (userResponse.MatchPassword)
                {
                    new Home().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("The password is incorrect!");
                    txtPassword.Clear();
                    txtPassword.Focus();

                }

            }
            else
            {
                MessageBox.Show("The user does not exits!");
                txtEmail.Clear();
                txtPassword.Clear();
                txtEmail.Focus();
            }
        }

        private void ExitpictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

   
}