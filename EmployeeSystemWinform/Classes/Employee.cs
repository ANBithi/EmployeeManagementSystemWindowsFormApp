using EmployeeSystemWinform.PropClasses;
using EmployeeSystemWinform.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeSystemWinform.Classes
{
    public class Employee : BaseClass
    {
       
        public List<EmployeeComboViewModel> GetAllEmployeeId()
        {
            var EmployeeIdList = new List<EmployeeComboViewModel>();

            string SqlQuery = $"select EmployeeId, EmployeeName from Employees order by EmployeeId";

            SqlCommand cmd = base.OpenConnection(SqlQuery);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    var view = new EmployeeComboViewModel
                    {
                        EmployeeId = Convert.ToInt32(dr["EmployeeId"].ToString()),
                        EmployeeName = dr["EmployeeName"].ToString()
                    };
                    EmployeeIdList.Add(view);
                }
            }
            base.CloseConnection();
            return EmployeeIdList;
        }
        public void AddEmployeeData(AddEmployeeItem item)
        {
            try
            {

                SqlCommand cm = base.OpenConnection("AddEmployee");
                cm.CommandType = CommandType.StoredProcedure;

                var employeeName = item.Name;
                var employeeDesignation = item.Designation;
                var dateOfBirth = item.DateOfBirth;
                string gender = item.Gender;

                var nationality = item.Nationality;
                var nid = item.NID;

                cm.Parameters.Add(new SqlParameter("@EmployeeName", employeeName));
                cm.Parameters.Add(new SqlParameter("@Designation", employeeDesignation));
                cm.Parameters.Add(new SqlParameter("@DateOfBirth", dateOfBirth));
                cm.Parameters.Add(new SqlParameter("@Gender", gender));
                cm.Parameters.Add(new SqlParameter("@Nationality", nationality));
                cm.Parameters.Add(new SqlParameter("@NID", nid));

                cm.ExecuteNonQuery();
                base.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show("Recieved an error while inserting the data!");
            }
        }
        public List<EmployeeViewModel> GetEmployees()
        {
            var employeesList = new List<EmployeeViewModel>();
           

            string SqlQuery = $"select * from Employees";

            SqlCommand cmd = base.OpenConnection(SqlQuery);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    var employee = new EmployeeViewModel();
                    employee.EmployeeId = Convert.ToInt32(dr["EmployeeId"].ToString());
                    employee.EmployeeName = dr["EmployeeName"].ToString();
                    employee.Designation = dr["Designation"].ToString();
                    employee.Gender = dr["Gender"].ToString();
                    employee.BirthDate = dr.GetDateTime(dr.GetOrdinal("DateOfBirth")).ToString("dd/MM/yy");
                    employee.Nationality = dr["Nationality"].ToString();
                    employee.NID = (long)dr["NID"];
                    employeesList.Add(employee);
                }
            }
            base.CloseConnection();

            return employeesList;
        } 
        
        public void RemoveEmployee (int id)
        {
            SqlCommand cmd = base.OpenConnection("DeleteEmployee");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@DeleteId", id));
            cmd.ExecuteNonQuery();
            base.CloseConnection();
        }
        
    
    }
}
