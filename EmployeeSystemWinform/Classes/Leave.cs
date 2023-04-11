using EmployeeSystemWinform.PropClasses;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeSystemWinform.Classes
{
   public class Leave : BaseClass
    {
        public void AddLeaveData(AddLeaveData item)
        {
            try
            {
                SqlCommand cm = base.OpenConnection("AddLeave");
                cm.CommandType = CommandType.StoredProcedure;

                var leaveDate = item.Date;
                var reason = item.Reason;
                var leaveYear = item.Date.Year;
                var employeeId = item.EmployeeId;

                cm.Parameters.Add(new SqlParameter("@EmployeeId", employeeId));
                cm.Parameters.Add(new SqlParameter("@LeaveDate", leaveDate));
                cm.Parameters.Add(new SqlParameter("@Reason", reason));
                cm.Parameters.Add(new SqlParameter("@LeaveYear", leaveYear));

                cm.ExecuteNonQuery();
                base.CloseConnection();
                MessageBox.Show("Leave Has Been Added");
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
     
        public RemainingLeaveResponse GetRemainingLeave (int id)
        {
            var response = new RemainingLeaveResponse
            {
                RemainingLeave = 0,
                HaveData = false,
            };
            var allLeaveCount = 0;
            var totalLeavePerYear = 0;
            var leaveData = $"select count(*) as Count from Leave where (LeaveYear = {DateTime.Now.Year} and EmployeeId = {id})";
            SqlCommand lData = base.OpenConnection(leaveData);
            lData.CommandType = CommandType.Text;
            SqlDataReader dr = lData.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    allLeaveCount = Convert.ToInt32(dr["Count"]);
                }
            }
            dr.Close();
            var totalLeavePerYearQuery = $"select TotalLeavePerYear from PayrollInfo where  EmployeeId = {id}";
            lData = base.OpenConnection(totalLeavePerYearQuery);
            SqlDataReader leaveDr = lData.ExecuteReader();
            if (leaveDr != null)
            {
                while (leaveDr.Read())
                {
                    totalLeavePerYear = Convert.ToInt32(leaveDr["TotalLeavePerYear"]);
                }
            }
            if (!leaveDr.HasRows)
            {
                response.HaveData = false;
            }
            else
            {
                response.RemainingLeave = totalLeavePerYear - allLeaveCount;
                if(allLeaveCount > totalLeavePerYear)
                {
                    response.ExcessLeave = allLeaveCount - totalLeavePerYear;
                }
                else
                {
                    response.ExcessLeave = 0;
                }
                response.HaveData = true;
            }

            base.CloseConnection();
            return response;
        }
     
    }
    
}
