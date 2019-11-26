using ExpenseManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagement.Repository
{
    class UserRepository : BaseRepository
    {
        public UserRepository() : base() { }

        //Add Contact 
        public string AddUser(User user)
        {
            Message = "";
            Query = "INSERT INTO Users([FirstName],[LastName],[Email],[Password]) VALUES(@FirstName, @LastName, @Email, @Password);";

            try
            {
                SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
                sqlCommand.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = user.FirstName;
                sqlCommand.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = user.LastName;
                sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar).Value = user.UserName;
                sqlCommand.Parameters.Add("@Password", SqlDbType.NVarChar).Value = user.Password;
                               
                sqlConnection.Open();
                var i = sqlCommand.ExecuteNonQuery();
                if (i > 0)
                    Message = "Added Successfully!!";
                else
                    throw new Exception("Error, Data Not Added!");
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                Message = "Exception: " + ex.Message;
            }

            return Message;
        }
    }
}
