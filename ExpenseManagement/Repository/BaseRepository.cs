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
        public SqlConnection sqlConnection;
        public BaseRepository()
        {
            string connection = ConfigurationManager.ConnectionStrings["AzureConnection"].ConnectionString;
            sqlConnection = new SqlConnection(connection);
        }
    }
}
