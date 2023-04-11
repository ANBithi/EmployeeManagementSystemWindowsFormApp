using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystemWinform.PropClasses
{
    public class RemainingLeaveResponse
    {
        public int RemainingLeave { get; set; }
        public int ExcessLeave { get; set; }
        public bool HaveData { get; set; }
    }
}
