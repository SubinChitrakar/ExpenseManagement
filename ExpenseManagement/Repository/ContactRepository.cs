using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using ExpenseManagement.Model;
using System.Data;

namespace ExpenseManagement.Repository
{
    class ContactRepository : BaseRepository
    {
        private string Message;
        private string Query;

        //Constructor
        public ContactRepository() :  base() { }

        //Read All Contacts
        public List<Contact> GetContacts()
        {
            List<Contact> ContactList = new List<Contact>();
            Query = "SELECT * FROM CONTACTS";

            try
            {
                SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();

                sqlConnection.Open();
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();

                ContactList = (from DataRow dataRow in dataTable.Rows
                               select new Contact()
                               {
                                   Id = Convert.ToInt32(dataRow["Id"]),
                                   Name = Convert.ToString(dataRow["Name"])
                               }).ToList();
            }
            catch (Exception ex)
            {
                
            }
            return ContactList;
        }

        //Add Contact 
        public string AddContact(Contact contact)
        {
            Message = "";
            Query = "INSERT INTO CONTACTS([Name]) VALUES(@Name);";

            try
            {
                SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = contact.Name;

                sqlConnection.Open();
                var i = sqlCommand.ExecuteNonQuery();
                if (i > 0)
                   Message = "Added Successfully!!";
                else
                   Message = "Error, Data Not Added!";
                sqlConnection.Close();
            }
            catch(Exception ex)
            {
                Message = "Exception: "+ex.Message;
            }

            return Message;
        }

        //Update Contact
        public string UpdateContact(Contact contact)
        {
            Message = "";
            Query = "UPDATE CONTACTS SET [Name] = @Name WHERE [Id] = @Id ;";

            try
            {
                SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = contact.Name;
                sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = contact.Id;

                sqlConnection.Open();
                var i = sqlCommand.ExecuteNonQuery();
                if (i > 0)
                    Message = "Updated Successfully!!";
                else
                    Message = "Error, Data Not Updated!";
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                Message = "Exception: " + ex.Message;
            }

            return Message;
        }

        //Delete Contact
        public string DeleteContact(Contact contact)
        {
            Message = "";
            Query = "DELETE FROM Contacts WHERE [Id] = @Id;";

            try
            {
                SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
                sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = contact.Id;

                sqlConnection.Open();
                var i = sqlCommand.ExecuteNonQuery();
                if (i > 0)
                    Message = "Deleted Successfully!!";
                else
                    Message = "Error, Data Not Deleted!";
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
