using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace smkmm52
{
    class laporan
    {
        static SqlConnection conn;
        static SqlDataAdapter sda;
        static DataSet ds;

        public static void laporan_guru(string query, string tabel)
        {
           /* conn = koneksi.conn;
            try
            {
                conn.Open();
                sda = new SqlDataAdapter(query, conn);

                ds = new DataSet();
                sda.Fill(ds, tabel);

                DataSet myreport = new DataSet();
                myreport.SetDataSource(ds);
                report_perguru lg = new report_perguru();
                lg.crystalReportViewer1.ReportSource = myreport;
                lg.Show();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }*/
        }
    }
}
