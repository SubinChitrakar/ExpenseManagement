using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ExpenseManagement.Model;
using System.Data;
using ExpenseManagement.Utilities;

namespace ExpenseManagement.Repository
{
    class ContactRepository : BaseRepository
    {
        //Constructor
        public ContactRepository() :  base() { }

        //Read All Contacts
        public List<Contact> GetContacts(int userId)
        {
            List<Contact> ContactList = new List<Contact>();
            Query = "SELECT * FROM CONTACTS WHERE [UserId] = @UserId";

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    ContactList.Add(new Contact
                    {
                        Id = (int)sqlDataReader["Id"],
                        Name = sqlDataReader["Name"].ToString(),
                        UserId = (int)sqlDataReader["UserId"]
                    });
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
            return ContactList;
        }

        public Contact GetContactFromName(string contactName)
        {
            Contact contact = new Contact();
            Query = "SELECT * FROM Contacts WHERE UPPER(Name) = @ContactName AND [UserId] = @UserId";

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
                sqlCommand.Parameters.Add("@ContactName", SqlDbType.VarChar).Value = contactName.ToUpper();
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = UserSession.UserData.Id;

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleRow);

                while (sqlDataReader.Read())
                {
                    contact.Id = (int)sqlDataReader["Id"];
                    contact.UserId = (int)sqlDataReader["UserId"];
                    contact.Name = sqlDataReader["Name"].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
            return contact;
        }

        //Add Contact 
        public MessageStatus AddContact(Contact contact)
        {
            Query = "INSERT INTO CONTACTS([Name], [UserId]) VALUES(@Name, @UserId);";

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
                sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = contact.Name;
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = contact.UserId;

                var i = sqlCommand.ExecuteNonQuery();
                if (i > 0)
                {
                    messageStatus.Message = "Added Successfully!!";
                    messageStatus.ErrorStatus = false;
                }
                else
                    throw new Exception("Error, Data Not Added!");    
            }
            catch(Exception ex)
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

        //Update Contact
        public MessageStatus UpdateContact(Contact contact)
        {
            Query = "UPDATE CONTACTS SET [Name] = @Name WHERE [Id] = @Id AND [UserId] = @UserId;";

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
                sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = contact.Name;
                sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = contact.Id;
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = contact.UserId;
                                
                var i = sqlCommand.ExecuteNonQuery();
                if (i > 0)
                {
                    messageStatus.Message = "Updated Successfully!!";
                    messageStatus.ErrorStatus = false;
                }
                else
                    throw new Exception("Error, Data Not Updated!");
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

        //Delete Contact
        public MessageStatus DeleteContact(Contact contact)
        {
            Query = "DELETE FROM Contacts WHERE [Id] = @Id AND [UserId] = @UserId;";

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
                sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = contact.Id;
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = contact.UserId;
                
                var i = sqlCommand.ExecuteNonQuery();
                if (i > 0)
                {
                    messageStatus.Message = "Deleted Successfully!!";
                    messageStatus.ErrorStatus = false;
                }
                else
                    throw new Exception("Error, Data Not Deleted!");
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
