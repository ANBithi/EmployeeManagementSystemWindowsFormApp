using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystemWinform.PropClasses
{
    public class GetUserByEmailResponse
    {
        public bool Found { get; set; }
        public bool MatchPassword { get; set; }
    }
}
