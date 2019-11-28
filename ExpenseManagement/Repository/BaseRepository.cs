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
        protected SqlConnection sqlConnection;
        protected MessageStatus messageStatus;
        protected string Query;
        
        public BaseRepository()
        {
            string connection = ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString;
            messageStatus = new MessageStatus();
            Query = "";
            sqlConnection = new SqlConnection(connection);
        }
    }
}
