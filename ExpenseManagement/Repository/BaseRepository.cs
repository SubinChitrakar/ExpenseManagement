using ExpenseManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagement.Repository
{
    public class BaseRepository
    {
        protected SqlConnection SqlConnection;
        protected MessageStatus MessageStatus;
        protected string Query;
        
        public BaseRepository()
        {
            string connection = ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString;
            //string connection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
            MessageStatus = new MessageStatus();
            Query = "";
            SqlConnection = new SqlConnection(connection);
        }
    }
}
