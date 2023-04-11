using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystemWinform.ViewModels
{
   public class EmployeePayrollInfoViewModel
    {
        public string EmployeeName { get; set; }
        public string JoiningDate { get; set; }
        public double PaymentPerDay { get; set; }
        public double YearlyIncrement { get; set; }
        public int TotalLeavePerYear { get; set; }
        public double LeaveReductionRate { get; set; }
        public double BonusPerExtraLeave { get; set; }
    }
}
