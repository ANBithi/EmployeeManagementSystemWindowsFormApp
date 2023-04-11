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
    public class EmployeeContact : BaseClass
    {
        
        public void AddEmployeeContactData(AddEmployeeContactItem item)
        {
            try
            {
                SqlCommand cm = base.OpenConnection("AddEmployeeContact");
                cm.CommandType = CommandType.StoredProcedure;

                var personalNumber = item.PersonalNumber;
                var address = item.Address;
                var emergencyName = item.EmergencyName;
                var emergencyRelation = item.EmergencyRelation;
                var emergencyNumber = item.EmergencyNumber;
                var employeeId = item.EmployeeId;

                cm.Parameters.Add(new SqlParameter("@EmployeeId", employeeId));
                cm.Parameters.Add(new SqlParameter("@PersonalNumber", personalNumber));
                cm.Parameters.Add(new SqlParameter("@Address", address));
                cm.Parameters.Add(new SqlParameter("@EmergencyName", emergencyName));
                cm.Parameters.Add(new SqlParameter("@EmergencyRelation", emergencyRelation));
                cm.Parameters.Add(new SqlParameter("@EmergencyNumber", emergencyNumber));

                cm.ExecuteNonQuery();
                base.CloseConnection();
            }
            catch
            {
                MessageBox.Show("Recieved an error while inserting the data!");
            }
        }
    
        public EmployeeContactViewModel GetEmployeeContact(int id)
        {
            var employee = new EmployeeContactViewModel();

            string SqlQuery = $"select * from GetEmployeeContact where employeeId = {id}";

            SqlCommand cmd = base.OpenConnection(SqlQuery);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    employee.EmployeeName = dr["EmployeeName"].ToString();
                    employee.Name = dr["EmergencyName"].ToString();
                    employee.Relation = dr["EmergencyRelation"].ToString();
                    employee.PersonalNumber =(long) dr["PersonalNumber"];
                    employee.Address = dr["EmpAddress"].ToString();
                    employee.Contact = (long)dr["EmergencyNumber"];
                   
                }
            }
            base.CloseConnection();


            return employee;
        }
        
        public void UpdateEmployeeContact(AddEmployeeContactItem item)
        {
            SqlCommand cm = base.OpenConnection("UpdateEmployeeContact");
            cm.CommandType = CommandType.StoredProcedure;

            var personalNumber = item.PersonalNumber;
            var address = item.Address;
            var emergencyName = item.EmergencyName;
            var emergencyRelation = item.EmergencyRelation;
            var emergencyNumber = item.EmergencyNumber;
            var employeeId = item.EmployeeId;

            cm.Parameters.Add(new SqlParameter("@EmployeeId", employeeId));
            cm.Parameters.Add(new SqlParameter("@PersonalNumber", personalNumber));
            cm.Parameters.Add(new SqlParameter("@Address", address));
            cm.Parameters.Add(new SqlParameter("@EmergencyName", emergencyName));
            cm.Parameters.Add(new SqlParameter("@EmergencyRelation", emergencyRelation));
            cm.Parameters.Add(new SqlParameter("@EmergencyNumber", emergencyNumber));

            cm.ExecuteNonQuery();
            base.CloseConnection();
        }
    
    }
}
