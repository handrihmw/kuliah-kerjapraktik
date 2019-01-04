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
    public partial class fr_lap_walikelas : Form
    {
        public fr_lap_walikelas()
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
                cb_kls.DataSource = dt;
                cb_kls.ValueMember = "id_kelas";
                cb_kls.DisplayMember = "kelas";
            }
            catch (Exception err)
            {
                MessageBox.Show("Gagal Koneksi\n" + err.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void addItems(AutoCompleteStringCollection col)
        {
            col.Add("2016 / 2017");
            col.Add("2017 / 2018");
            col.Add("2018 / 2019");
            col.Add("2019 / 2020");
        }
        private void fr_lap_walikelas_Load(object sender, EventArgs e)
        {
            /*Tahun Ajaran Otomatis*/
            tb_thn.AutoCompleteMode = AutoCompleteMode.Suggest;
            tb_thn.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollction = new AutoCompleteStringCollection();
            addItems(DataCollction);
            tb_thn.AutoCompleteCustomSource = DataCollction;

        }

        private void bt_cari_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con;
                con = koneksi.conn;
                SqlCommand coman = new SqlCommand();
                coman.Connection = con;
                coman.CommandType = CommandType.Text;
                //coman.CommandText = "SELECT * FROM dbo.tb_walikelas WHERE (((tb_walikelas.thn_ajaran)='" + tb_thn.Text + "' AND id_kelas='" + tb_idwk.Text + "'))";
                coman.CommandText = "SELECT * FROM lap_walikelas WHERE (((lap_walikelas.thn_ajaran)='" + tb_thn.Text + "' AND kelas='" + cb_kls.Text + "'))";
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(coman);
                sda.Fill(ds, "wk");
                dgv_lapwk.DataSource = ds;
                dgv_lapwk.DataMember = "wk";

                report_wakel rwk = new report_wakel();
                rwk.ShowDialog();

            }
            catch (Exception err)
            {
                MessageBox.Show("Data Tidak ada\n" + err.Message);
            }
            tabel();
        }

        private void tb_idwk_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con;
            con = koneksi.conn;
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select * from tb_walikelas where id_kelas='" + tb_idwk.Text + "'";
            SqlDataReader dbr;
            try
            {
                con.Open();
                dbr = coman.ExecuteReader();
                while (dbr.Read())
                {
                    string kode = (string)dbr["id_kelas"];
                    cb_kls.Text = kode;

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Gagal Tampil\n" + err.Message);
            }
        
        }

        private void cb_kls_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con;
            con = koneksi.conn;
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select * from tb_kelas where kelas='" + cb_kls.Text + "'";
            SqlDataReader dbr;
            try
            {
                con.Open();
                dbr = coman.ExecuteReader();
                while (dbr.Read())
                {
                    string kode = (string)dbr["id_kelas"];
                    tb_idwk.Text = kode;

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Gagal Tampil\n" + err.Message);
            }
        }
        private void tabel()
        {
            dgv_lapwk.Columns[0].HeaderText = "Tahun Ajaran";
            dgv_lapwk.Columns[0].Width = 110;
            dgv_lapwk.Columns[1].HeaderText = "NIP";
            dgv_lapwk.Columns[1].Width = 80;
            dgv_lapwk.Columns[2].HeaderText = "Nama Guru";
            dgv_lapwk.Columns[2].Width = 150;
            dgv_lapwk.Columns[3].HeaderText = "NIPD";
            dgv_lapwk.Columns[3].Width = 80;
            dgv_lapwk.Columns[4].HeaderText = "Nama Siswa";
            dgv_lapwk.Columns[4].Width = 150;
            dgv_lapwk.Columns[5].HeaderText = "JK";
            dgv_lapwk.Columns[5].Width = 40;
            dgv_lapwk.Columns[6].HeaderText = "Jurusan";
            dgv_lapwk.Columns[6].Width = 140;
            dgv_lapwk.Columns[7].HeaderText = "Kelas";
            dgv_lapwk.Columns[7].Width = 150;
            dgv_lapwk.Columns[8].HeaderText = "Semester";
            dgv_lapwk.Columns[8].Width = 80;
        }

        private void bt_lpg_Click(object sender, EventArgs e)
        {
            //print printer = new print();
            //printer.ShowDialog();
           // string query = "select * from view_walikelas";
            //laporan.laporan_guru(query, "view_walikelas");
            //laporan_wakel lw = new laporan_wakel();
           //lw.ShowDialog();
           
        }
    }
}
