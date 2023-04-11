using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystemWinform.PropClasses
{
   public class AddPayrollInfoItem
    {
        public float YearlyIncreament { get; set; }
        public float PaymentPerday { get; set; }
        public DateTime JoiningDate { get; set; }
        public int TotalLeavePerYear { get; set; }
        public float LeaveDeductionRate { get; set; }
        public float BonusPerExtraLeave { get; set; }
        public int EmployeeId { get; set; }
    }
}
