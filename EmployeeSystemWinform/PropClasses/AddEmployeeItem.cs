using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystemWinform.PropClasses
{
   public class AddEmployeeItem
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public long NID { get; set; }
    }
}
