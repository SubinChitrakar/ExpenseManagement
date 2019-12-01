using ExpenseManagement.Model;
using ExpenseManagement.Utilities;
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
        public MessageStatus AddUser(User user)
        {
            Query = "INSERT INTO Users([FirstName],[LastName],[Username],[Password]) VALUES(@FirstName, @LastName, @Username, @Password);";

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
                sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = user.FirstName;
                sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = user.LastName;
                sqlCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = user.UserName;
                sqlCommand.Parameters.Add("@Password", SqlDbType.VarChar).Value = user.Password;         
                
                var i = sqlCommand.ExecuteNonQuery();
                if (i > 0)
                {
                    messageStatus.Message = "Added Successfully!!";
                    messageStatus.ErrorStatus = false;
                }
                else
                    throw new Exception("Error, Data Not Added!");
            }
            catch (Exception ex)
            {
                messageStatus.Message = ex.Message;
                messageStatus.ErrorStatus = true;
            }
            finally
            {
                sqlConnection.Close();
            }
            return messageStatus;
        }

        //Get Username
        public User GetUserFromUsername(string username)
        {

            User user = new User();
            Query = "SELECT * FROM Users WHERE [Username] = @Username";

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
                sqlCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = username;

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleRow);

                while (sqlDataReader.Read())
                {
                    user.Id = (int)sqlDataReader["Id"];
                    user.FirstName = sqlDataReader["FirstName"].ToString();
                    user.LastName = sqlDataReader["LastName"].ToString();
                    user.UserName = sqlDataReader["Username"].ToString();
                    user.Password = sqlDataReader["Password"].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: "+ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
            return user;
        }
    }
}
