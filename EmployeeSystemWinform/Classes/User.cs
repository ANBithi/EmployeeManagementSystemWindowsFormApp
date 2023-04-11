using EmployeeSystemWinform.PropClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystemWinform.Classes
{
    public class User : BaseClass
    {
        public GetUserByEmailResponse FindUserByMail(string email, string password)
        {
            var response = new GetUserByEmailResponse
            {
                Found = false,
                MatchPassword = false,
            };
            SqlCommand cmd = base.OpenConnection("GetUsersByEmail");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Email", email));
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader != null && reader.HasRows)
            {
                if (email == reader["UserEmail"].ToString() && password == reader["UserPassword"].ToString())
                {
                    response.Found = true;
                    response.MatchPassword = true;
                }
                if (email == reader["UserEmail"].ToString() && password != reader["UserPassword"].ToString())
                {
                   response.Found = true;
                }

            }
            base.CloseConnection();
            return response;
        }
    }
}
