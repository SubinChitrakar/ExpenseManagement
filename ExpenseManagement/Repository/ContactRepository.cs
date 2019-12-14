using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ExpenseManagement.Model;
using System.Data;
using ExpenseManagement.Utilities;
using NLog;

namespace ExpenseManagement.Repository
{
    class ContactRepository : BaseRepository
    {
        private Logger _logger = LogManager.GetCurrentClassLogger();

        //Constructor
        public ContactRepository() :  base() { }

        //Read All Contacts
        public List<Contact> GetContacts(int userId)
        {
            List<Contact> contactList = new List<Contact>();
            Query = "SELECT * FROM CONTACTS WHERE [UserId] = @UserId";

            try
            {
                SqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    contactList.Add(new Contact
                    {
                        Id = (int)sqlDataReader["ContactId"],
                        Name = sqlDataReader["ContactName"].ToString(),
                        UserId = (int)sqlDataReader["UserId"]
                    });
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
            }
            finally
            {
                SqlConnection.Close();
            }
            return contactList;
        }

        public Contact GetContactFromName(string contactName)
        {
            Contact contact = new Contact();
            Query = "SELECT * FROM Contacts WHERE UPPER(ContactName) = @ContactName AND [UserId] = @UserId";

            try
            {
                SqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                sqlCommand.Parameters.Add("@ContactName", SqlDbType.VarChar).Value = contactName.ToUpper();
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = UserSession.UserData.Id;

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleRow);

                while (sqlDataReader.Read())
                {
                    contact.Id = (int)sqlDataReader["ContactId"];
                    contact.UserId = (int)sqlDataReader["UserId"];
                    contact.Name = sqlDataReader["ContactName"].ToString();
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
            }
            finally
            {
                SqlConnection.Close();
            }
            return contact;
        }

        //Add Contact 
        public int AddContact(Contact contact)
        {
            Query = "INSERT INTO CONTACTS([ContactName], [UserId]) OUTPUT INSERTED.ContactId VALUES(@Name,@UserId)";
            int id = 0;
            try
            {
                SqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = contact.Name;
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = contact.UserId;

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    id = (int)sqlDataReader["ContactId"];
                }
            }
            catch(Exception ex)
            {
                _logger.Error(ex);
                id = 0;
            }
            finally
            {
                SqlConnection.Close();
            }
            return id;
        }

        //Update Contact
        public int UpdateContact(Contact contact)
        {
            Query = "UPDATE CONTACTS SET [ContactName] = @Name WHERE [ContactId] = @Id AND [UserId] = @UserId;";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = contact.Name;
                sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = contact.Id;
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = contact.UserId;

                SqlConnection.Open();
                var i = sqlCommand.ExecuteNonQuery();
                SqlConnection.Close();

                return i;
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                return 0;
            }
        }

        //Delete Contact
        public MessageStatus DeleteContact(Contact contact)
        {
            Query = "DELETE FROM Contacts WHERE [ContactId] = @Id AND [UserId] = @UserId;";

            try
            {
                SqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = contact.Id;
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = contact.UserId;
                
                var i = sqlCommand.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageStatus.Message = "Contact Deleted Successfully!!";
                    MessageStatus.ErrorStatus = false;
                }
                else
                    throw new Exception("Error, Data Not Deleted!");
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                MessageStatus.Message = ex.Message;
                MessageStatus.ErrorStatus = true;
            }
            finally
            {
                SqlConnection.Close();
            }
            return MessageStatus;
        }
    }
}
