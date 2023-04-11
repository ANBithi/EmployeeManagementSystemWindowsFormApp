using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSystemWinform
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void ExitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddUserbtn_Click(object sender, EventArgs e)
        {
            string connetionstring = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            SqlConnection cnn = new(connetionstring);
            cnn.Open();
            string command = $"insert into Users(UserEmail, UserPassword) values ('{txtEmail.Text}','{txtPassword.Text}')";
            SqlCommand cmd = new (command, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
            txtEmail.Text = "";
            txtPassword.Text = "";
        }

        private void BackPicturebox_Click(object sender, EventArgs e)
        {
            new Home().Show();
            Hide();
        }
    }
}
