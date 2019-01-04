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

namespace smkmm52
{
    public partial class report_wakel : Form
    {
        public report_wakel()
        {
            InitializeComponent();
            initializeCbKls();
        }

        private void initializeCbKls()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select id_kelas,kelas from tb_kelas", con);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                cb_kelas.DataSource = dt;
                cb_kelas.ValueMember = "id_kelas";
                cb_kelas.DisplayMember = "kelas";
            }
            catch (Exception err)
            {
                MessageBox.Show("Gagal Koneksi\n" + err.Message);
            }
        }
        private void report_wakel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dasetwali.lap_walikelas' table. You can move, or remove it, as needed.
           // this.lap_walikelasTableAdapter.Fill(this.dasetwali.lap_walikelas);

           // this.reportViewer1.RefreshReport();
        }

        private void bt_cari_Click(object sender, EventArgs e)
        {
            this.lap_walikelasTableAdapter.Fill(this.dasetwali.lap_walikelas,tb_thn.Text,cb_kelas.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
