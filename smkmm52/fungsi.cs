using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace smkmm52
{
    class fungsi
    {
        static SqlDataReader myreader;
        static SqlDataAdapter sda;
        static DataSet ds;
        static SqlCommand cmd;
        static SqlConnection conne;

        public static int Equery(string query)
        {
            conne = koneksi.conn;
            cmd = new SqlCommand();
            try
            {
                conne.Open();
                cmd.Connection = conne;
                cmd.CommandText = query;

                int i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (SqlException ex)
            {
                return 0;
            }
            finally
            {
                conne.Close();
            }
        }

        public static bool cekdata(string query)
        {
            conne = koneksi.conn;
            bool cek = true;
            SqlCommand cmd = new SqlCommand(query, conne);

            try
            {
                conne.Open();
                myreader = cmd.ExecuteReader();
                myreader.Read();
                if (myreader.HasRows)
                {
                    cek = true;
                }
                else
                {
                    cek = false;
                }
            }
            catch (Exception exc)
            {
               // Mess ("Pengecekan Data Error" + exc.Message);
            }
            finally
            {
                if (myreader != null)
                    myreader.Close();
                conne.Close();
            }
            return cek;
        }
        
    }
}
