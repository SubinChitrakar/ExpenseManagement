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
                SqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = user.FirstName;
                sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = user.LastName;
                sqlCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = user.UserName;
                sqlCommand.Parameters.Add("@Password", SqlDbType.VarChar).Value = user.Password;

                var i = sqlCommand.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageStatus.Message = "User Registered Successfully!!";
                    MessageStatus.ErrorStatus = false;
                }
                else
                    throw new Exception("Error, Data Not Added!");
            }
            catch (Exception ex)
            {
                MessageStatus.Message = ex.Message;
                MessageStatus.ErrorStatus = true;
            }
            finally
            {
                SqlConnection.Close();
            }
            return MessageStatus;
        }

        public MessageStatus UpdateUserAccessDate(User user)
        {
            Query = "UPDATE USERS SET [UserAccessDate] = @LastAccessDate WHERE  [Id]= @UserId";
            try
            {
                SqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                sqlCommand.Parameters.Add("@LastAccessDate", SqlDbType.VarChar).Value = user.LastAccessDate;
                sqlCommand.Parameters.Add("@UserId", SqlDbType.VarChar).Value = user.Id;

                var i = sqlCommand.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageStatus.Message = "User Updated Successfully!!";
                    MessageStatus.ErrorStatus = false;
                }
                else
                    throw new Exception("Error, Data Not Added!");
            }
            catch (Exception ex)
            {
                MessageStatus.Message = ex.Message;
                MessageStatus.ErrorStatus = true;
            }
            finally
            {
                SqlConnection.Close();
            }
            return MessageStatus;
        }

        //Get Username
        public User GetUserFromUsername(string username)
        {

            User user = new User();
            Query = "SELECT * FROM Users WHERE [Username] = @Username";

            try
            {
                SqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                sqlCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = username;

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleRow);

                while (sqlDataReader.Read())
                {
                    user.Id = (int)sqlDataReader["Id"];
                    user.FirstName = sqlDataReader["FirstName"].ToString();
                    user.LastName = sqlDataReader["LastName"].ToString();
                    user.UserName = sqlDataReader["Username"].ToString();
                    user.Password = sqlDataReader["Password"].ToString();
                    user.LastAccessDate = (DateTime)sqlDataReader["UserAccessDate"];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                SqlConnection.Close();
            }
            return user;
        }

        public User VerifyUser(string username, string password)
        {

            User user = new User();
            Query = "SELECT * FROM Users WHERE [Username] = @Username AND [Password] = @Password";

            try
            {
                SqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                sqlCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = username;
                sqlCommand.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleRow);

                while (sqlDataReader.Read())
                {
                    user.Id = (int)sqlDataReader["Id"];
                    user.FirstName = sqlDataReader["FirstName"].ToString();
                    user.LastName = sqlDataReader["LastName"].ToString();
                    user.UserName = sqlDataReader["Username"].ToString();
                    user.Password = sqlDataReader["Password"].ToString();
                    user.LastAccessDate = (DateTime)sqlDataReader["UserAccessDate"];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                SqlConnection.Close();
            }
            return user;
        }
    }
}
