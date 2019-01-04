using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace smkmm52
{
    class MyData
    {
        public static string ConnectionString
        {
            get
            {
                return "Server=localhost; Initial Catalog=db_smkmm52; Integrated Security=true";
            }
        }
        private static SqlConnection _connection;
        public static SqlConnection Connection
    {
        get
        {
            if (_connection == null)
                _connection = new SqlConnection (ConnectionString);
            if (_connection.State == System.Data.ConnectionState.Closed)
                _connection.Open();

            return _connection;
        }
    }
    }
}
