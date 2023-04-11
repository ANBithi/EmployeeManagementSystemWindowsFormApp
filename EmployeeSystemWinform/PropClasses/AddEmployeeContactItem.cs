using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystemWinform.PropClasses
{
    public class AddEmployeeContactItem
    {
        public long PersonalNumber { get; set; }
        public string Address { get; set; }
        public string EmergencyName { get; set; }
        public string EmergencyRelation { get; set; }
        public long EmergencyNumber { get; set; }
        public int EmployeeId { get; set; }
    }
}
