using EmployeeSystemWinform.PropClasses;
using EmployeeSystemWinform.ViewModels;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeSystemWinform.Classes
{
    public class PayrollInfo : BaseClass
    {
        public void AddPayrollInfoData(AddPayrollInfoItem item)
        {
            try
            {
                SqlCommand cm = base.OpenConnection("AddPayrollInfo");
                cm.CommandType = CommandType.StoredProcedure;

                var paymentPerDay = item.PaymentPerday;
                var yearlyIncrement = item.YearlyIncreament;
                var joiningDate = item.JoiningDate;
                var totalLeavePerYear = item.TotalLeavePerYear;
                var leaveDeductionRate = item.LeaveDeductionRate;
                var bonusPerExtraLeave = item.BonusPerExtraLeave;
                var employeeId = item.EmployeeId;

                cm.Parameters.Add(new SqlParameter("@EmployeeId", employeeId));
                cm.Parameters.Add(new SqlParameter("@YearlyIncreament", yearlyIncrement));
                cm.Parameters.Add(new SqlParameter("PaymentPerDay", paymentPerDay));
                cm.Parameters.Add(new SqlParameter("@JoininigDate", joiningDate));
                cm.Parameters.Add(new SqlParameter("@TotalLeavePerYear", totalLeavePerYear));
                cm.Parameters.Add(new SqlParameter("@LeaveDeductionRate", leaveDeductionRate));
                cm.Parameters.Add(new SqlParameter("@BonusPerExtraLeave", bonusPerExtraLeave));

                cm.ExecuteNonQuery();
                base.CloseConnection();
            }
            catch
            {
                MessageBox.Show("Recieved an error while inserting the data!");
            }
        }
        public EmployeePayrollInfoViewModel GetEmployeePayrollInfo (int id)
        {
            var employee = new EmployeePayrollInfoViewModel();
            string SqlQuery = $"select * from GetEmployeePayrollInfo where employeeId = {id}";

            SqlCommand cmd = base.OpenConnection(SqlQuery);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    employee.EmployeeName = dr["EmployeeName"].ToString();
                    employee.JoiningDate = dr.GetDateTime(dr.GetOrdinal("JoiningDate")).ToString("dd/MM/yy");
                    employee.PaymentPerDay = (double)dr["PaymentPerDay"];
                    employee.YearlyIncrement = (double)dr["YearlyIncrement"];
                    employee.TotalLeavePerYear = (int)dr["TotalLeavePerYear"];
                    employee.LeaveReductionRate = (double)dr["LeaveDeductionRate"];
                    employee.BonusPerExtraLeave = (double)dr["BonusPerExtraLeave"];

                }
            }
            base.CloseConnection();
            return employee;
        }
        public void UpdatePayrollInfo(AddPayrollInfoItem item)
        {
            SqlCommand cm = base.OpenConnection("UpdatePayrollInfo");
            cm.CommandType = CommandType.StoredProcedure;

            var paymentPerDay = item.PaymentPerday;
            var yearlyIncrement = item.YearlyIncreament;
            var leaveDeductionRate = item.LeaveDeductionRate;
            var bonusPerExtraLeave = item.BonusPerExtraLeave;
            var employeeId = item.EmployeeId;

            cm.Parameters.Add(new SqlParameter("@EmployeeId", employeeId));
            cm.Parameters.Add(new SqlParameter("@YearlyIncreament", yearlyIncrement));
            cm.Parameters.Add(new SqlParameter("PaymentPerDay", paymentPerDay));
            cm.Parameters.Add(new SqlParameter("@LeaveDeductionRate", leaveDeductionRate));
            cm.Parameters.Add(new SqlParameter("@BonusPerExtraLeave", bonusPerExtraLeave));

            cm.ExecuteNonQuery();
            base.CloseConnection();
        }
        public double PayrollCalculation(int workingDays, int id)
        {
            var payrollModel = new PayrollInfoModel();
            var leave = new Leave();
            var leaveData = leave.GetRemainingLeave(id);
            var totalLeavePerYearQuery = $"select PaymentPerDay, LeaveDeductionRate, BonusPerExtraLeave from PayrollInfo where  EmployeeId = {id}";
            SqlCommand lData = base.OpenConnection(totalLeavePerYearQuery);
            SqlDataReader leaveDr = lData.ExecuteReader();
            if (leaveDr != null)
            {
                while (leaveDr.Read())
                {
                    payrollModel.PaymentPerDay = (double)(leaveDr["PaymentPerDay"]);
                    payrollModel.LeaveReductionRate = (double)(leaveDr["LeaveDeductionRate"]);
                    payrollModel.BonusPerLeave = (double)(leaveDr["BonusPerExtraLeave"]);
                }
            }
            double reductionOfExcessLeave = 0, bonusFromExtraLeave = 0;
            if(leaveData.ExcessLeave > 0)
            {
                reductionOfExcessLeave = leaveData.ExcessLeave * payrollModel.LeaveReductionRate;
            }
            if(leaveData.RemainingLeave > 0 && leaveData.RemainingLeave < 13)
            {
                bonusFromExtraLeave = leaveData.RemainingLeave * payrollModel.BonusPerLeave;
            }
            var payment = (workingDays * payrollModel.PaymentPerDay) + bonusFromExtraLeave - reductionOfExcessLeave;
            base.CloseConnection();
            return payment;
        }
    
    }
}
