using EmployeeSystemWinform.PropClasses;
using EmployeeSystemWinform.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSystemWinform.Classes
{
    public class Payroll : BaseClass
    {
        public void AddPayrollData(AddPayrollItem item)
        {
            try
            {
                SqlCommand cm = base.OpenConnection("AddPayroll");
                cm.CommandType = CommandType.StoredProcedure;

                var issueDate = item.IssueDate;
                var amount = item.Amount;
                var employeeId = item.EmployeeId;
                var workdays = item.TotalWorkDays;
                var month = item.IssueDate.Month;
                var year = item.IssueDate.Year;

                cm.Parameters.Add(new SqlParameter("@EmployeeId", employeeId));
                cm.Parameters.Add(new SqlParameter("@IssueDate", issueDate));
                cm.Parameters.Add(new SqlParameter("@Amount", amount));
                cm.Parameters.Add(new SqlParameter("@TotalWorkDays", workdays));
                cm.Parameters.Add(new SqlParameter("@PaidMonth", month));
                cm.Parameters.Add(new SqlParameter("@PaidYear", year));

                cm.ExecuteNonQuery();
                base.CloseConnection();
                MessageBox.Show("Payroll Has Been Added");
            }
            catch (Exception e)
            {
                if (e.Message.Contains("duplicate"))
                {
                    MessageBox.Show("The employee already has a leave on this day!");
                }
                else
                {
                    MessageBox.Show("Recieved an error while inserting the data!");
                }

            }
        }
        public bool IsPaid(int id)
        {
            bool response = false;
            var leaveData = $"select * from Payroll where (PaidYear = {DateTime.Now.Year} and EmployeeId = {id} and PaidMonth = {DateTime.Now.Month})";
            SqlCommand lData = base.OpenConnection(leaveData);
            lData.CommandType = CommandType.Text;
            SqlDataReader dr = lData.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    response = true;
                }
            }
            base.CloseConnection();
            return response;
        }

        public List<PayrollViewModel> GetAllPayrolls()
        {
            var payrollList = new List<PayrollViewModel>();
            string SqlQuery = $"select * from Payroll";

            SqlCommand cmd = base.OpenConnection(SqlQuery);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    var payroll = new PayrollViewModel
                    {
                        EmployeeId = Convert.ToInt32(dr["EmployeeId"].ToString()),
                        IssueDate = dr.GetDateTime(dr.GetOrdinal("IssueDate")).ToString("dd/MM/yy"),
                        Amount = (double)dr["Amount"]
                    };
                    //employee.Address = dr["empAddress"].ToString();
                    //employee.PersonalNumber =(long) dr["PersonalNumber"];
                    //
                    payrollList.Add(payroll);
                }
            }
            base.CloseConnection();

            return payrollList;
        }
    }
}
