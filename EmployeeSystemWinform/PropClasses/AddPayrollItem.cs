using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystemWinform.PropClasses
{
    public class AddPayrollItem
    {
        public int EmployeeId { get; set; }
        public float Amount { get; set; }
        public DateTime IssueDate { get; set; }
        public int TotalWorkDays { get; set; }
    }
}
