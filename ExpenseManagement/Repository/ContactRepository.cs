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
    class ContactRepository
    {
        public void AddContact(Contact contact)
        {
            string query = "INSERT INTO CONTACTS([Name]) VALUES(@Name);";

            string conn = ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString;

            SqlConnection sqlConnection = new SqlConnection(conn);


            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = contact.Name;

            var i = sqlCommand.ExecuteNonQuery();

            if (i > 0)
                Console.WriteLine("Added");
            else
                Console.WriteLine("Fuck Off");

            sqlConnection.Close();
        }
    }
}
