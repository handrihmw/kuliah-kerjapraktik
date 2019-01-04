using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Text.RegularExpressions;
 


namespace smkmm52
{
    public partial class report_perguru : Form
    {
        //cr_guru cry = new cr_guru();
       private BindingSource bind = new BindingSource(); 
        public report_perguru()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
           /* cry.Load(@"F:\A\smkmm52\smkmm52\CrystalReport1.rpt");

            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select * from lap_guru";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(coman);
            //sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            //sda.SelectCommand.Parameters.Add("@nm_guru", System.Data.SqlDbType.VarChar, 100).Value = tb_cari.Text;
            sda.Fill(ds, "lap_guru");
            cry.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cry;
            */
        }

        private void bt_lihat_Click(object sender, EventArgs e)
        {

        }

        private void report_perguru_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dasetperguru.lap_guru' table. You can move, or remove it, as needed.
            //this.lap_guruTableAdapter.Fill(this.dasetperguru.lap_guru);

            //this.reportViewer1.RefreshReport();
        }

        private void bt_cari_Click(object sender, EventArgs e)
        {
            this.lap_guruTableAdapter.Fill(this.dasetperguru.lap_guru,tb_nama.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
