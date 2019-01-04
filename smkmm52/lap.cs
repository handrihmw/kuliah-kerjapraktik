using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.ReportingServices.DataProcessing;

namespace smkmm52
{
    class lap
    {
       // private static string _connstring = @"Data Source";
        public static DataSet loadreport()
        {
            /*SqlConnection mycon = new SqlConnection(_connstring);
            SqlDataAdapter da = new SqlDataAdapter("select * from lap_guru", mycon);
            DataSet ds = new DataSet();
            da.Fill(ds, "nip");
            return ds;*/


            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            //coman.CommandType = CommandType.Text;
            coman.CommandText = "select * from lap_guru";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(coman);
            sda.Fill(ds, "nip");
            return ds;
        }

        internal void SetDataSource(DataSet ds)
        {
            throw new NotImplementedException();
        }
    }
}
