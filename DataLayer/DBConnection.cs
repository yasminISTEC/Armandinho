using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace DataLayer
{
    public class DBConnection
        
    {
        private static string connectionString = "Data Source=localhost;Initial Catalog=REDACTED_DB_NAME;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
