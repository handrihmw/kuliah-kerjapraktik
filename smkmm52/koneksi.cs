using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace smkmm52
{
    class koneksi
    {
        static string con;

        public static SqlConnection conn
        {
            get
            {
                return new SqlConnection(con);
            }
        }
        static koneksi()
        {
            string conSTR = (@"Data Source=HANDRI;
            Initial Catalog=db_smkmm52; Integrated Security=true");
            con = conSTR;
        }
    }
}
