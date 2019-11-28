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

        public MessageStatus VerifyUser(string username, string password)
        {
            Query = "SELECT * FROM Users WHERE [Username] = @Username AND [Password] = @Password";
            try {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
                sqlCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = username;
                sqlCommand.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                
                if (dataTable.Rows.Count == 0)
                {
                    throw new Exception("USERNAME or PASSWORD incorrect");
                }
                else
                {
                    DataRow dataRow = dataTable.Rows[0];
                    messageStatus.Message = Convert.ToString(dataRow["Id"]);
                    messageStatus.ErrorStatus = false;
                }
            }
            catch(Exception ex) {
                messageStatus.Message = ex.Message;
                messageStatus.ErrorStatus = true;
            }
            finally
            {
                sqlConnection.Close();
            }
            sqlConnection.Close();
            return messageStatus;
        }

        public MessageStatus CheckUserName(String username)
        {
            Query = "SELECT Username FROM Users WHERE [Username] = @Username";

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
                sqlCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = username;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);
                
                if (dataTable.Rows.Count == 0)
                {
                    messageStatus.Message = "Username doesn't Exist";
                    messageStatus.ErrorStatus = false;
                }
                else
                {
                    throw new Exception("USERNAME already Taken!!");
                }
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
    }
}
