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
    public partial class fr_lap_siswa : Form
    {
        public fr_lap_siswa()
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
        private void tampil_siswa()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select * from tb_siswa";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(coman);
            sda.Fill(ds, "siswa");
            dgv_laps.DataSource = ds;
            dgv_laps.DataMember = "siswa";

        }
        private void tampil_kelas()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select * from tb_anggota_kelas";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(coman);
            sda.Fill(ds, "siswa");
            dgv_laps.DataSource = ds;
            dgv_laps.DataMember = "siswa";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rb_s_CheckedChanged(object sender, EventArgs e)
        {
            tampil_siswa();
            tabel_semua();
            tc_s.Enabled = true;
            tb_thn.Enabled = false;
            cb_kls.Enabled = false;

           
        }

        private void rb_k_CheckedChanged(object sender, EventArgs e)
        {
            tampil_kelas();
            tabel_kelas();
            
            tc_s.Enabled = false;
            tb_thn.Enabled = true;
            cb_kls.Enabled = true;
        }

        private void rb_ss_CheckedChanged(object sender, EventArgs e)
        {
            tampil_siswa();
            tabel_semua();
            tc_s.Enabled = false;
            tb_thn.Enabled = false;
            cb_kls.Enabled = false;
        }
        private void tb_cari_TextChanged(object sender, EventArgs e)
        {
            string cari = tb_cari.Text;
            try
            {
                SqlConnection con;
                con = koneksi.conn;
                SqlCommand coman = new SqlCommand();
                coman.Connection = con;
                coman.CommandType = CommandType.Text;
                coman.CommandText = "select * from tb_siswa where nipd like '" + cari + "%'";
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(coman);
                sda.Fill(ds, "siswa");
                dgv_laps.DataSource = ds;
                dgv_laps.DataMember = "siswa";
            }
            catch (Exception err)
            {
                MessageBox.Show("Data Tidak ada\n" + err.Message);
            }
        }

        private void tb_cari1_TextChanged(object sender, EventArgs e)
        {
            string cari = tb_cari1.Text;
            try
            {
                SqlConnection con;
                con = koneksi.conn;
                SqlCommand coman = new SqlCommand();
                coman.Connection = con;
                coman.CommandType = CommandType.Text;
                coman.CommandText = "select * from tb_siswa where nm_siswa like '" + cari + "%'";
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(coman);
                sda.Fill(ds, "siswa");
                dgv_laps.DataSource = ds;
                dgv_laps.DataMember = "siswa";
            }
            catch (Exception err)
            {
                MessageBox.Show("Data Tidak ada\n" + err.Message);
            }
        }
        public void addItems(AutoCompleteStringCollection col)
        {
            col.Add("2016 / 2017");
            col.Add("2017 / 2018");
            col.Add("2018 / 2019");
            col.Add("2019 / 2020");
        }
        private void fr_lap_siswa_Load(object sender, EventArgs e)
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
                coman.CommandText = "SELECT nipd,id_anggota,nm_siswa,jk,jurusan,thn_ajaran,kelas,semester FROM dbo.tb_anggota_kelas WHERE (((tb_anggota_kelas.thn_ajaran)='" + tb_thn.Text + "' AND kelas= '" + cb_kls.Text + "'))";
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(coman);
                sda.Fill(ds, "anggota");
                dgv_laps.DataSource = ds;
                dgv_laps.DataMember = "anggota";

            }
            catch (Exception err)
            {
                MessageBox.Show("Data Tidak ada\n" + err.Message);
            }
            tabel_kelas1();
        }


       private void tabel_kelas()
        {
            dgv_laps.Columns[0].HeaderText = "ID Anggota";
            dgv_laps.Columns[0].Width = 90;
            dgv_laps.Columns[1].HeaderText = "NIPD";
            dgv_laps.Columns[1].Width = 80;
            dgv_laps.Columns[2].HeaderText = "Nama Siswa";
            dgv_laps.Columns[2].Width = 160;
            dgv_laps.Columns[3].HeaderText = "JK";
            dgv_laps.Columns[3].Width = 30;
            dgv_laps.Columns[4].HeaderText = "Jurusan";
            dgv_laps.Columns[4].Width = 160;
            dgv_laps.Columns[5].HeaderText = "Tahun Ajaran";
            dgv_laps.Columns[5].Width = 100;
            dgv_laps.Columns[6].HeaderText = "Kelas";
            dgv_laps.Columns[6].Width = 160;
            dgv_laps.Columns[7].HeaderText = "Semester";
            dgv_laps.Columns[7].Width = 90;
        }

       private void tabel_kelas1()
       {
           dgv_laps.Columns[0].HeaderText = "ID Anggota";
           dgv_laps.Columns[0].Width = 90;
           dgv_laps.Columns[1].HeaderText = "NIPD";
           dgv_laps.Columns[1].Width = 80;
           dgv_laps.Columns[2].HeaderText = "Nama Siswa";
           dgv_laps.Columns[2].Width = 160;
           dgv_laps.Columns[3].HeaderText = "JK";
           dgv_laps.Columns[3].Width = 30;
           dgv_laps.Columns[4].HeaderText = "Jurusan";
           dgv_laps.Columns[4].Width = 160;
           dgv_laps.Columns[5].HeaderText = "Tahun Ajaran";
           dgv_laps.Columns[5].Width = 100;
           dgv_laps.Columns[6].HeaderText = "Kelas";
           dgv_laps.Columns[6].Width = 160;
           dgv_laps.Columns[7].HeaderText = "Semester";
           dgv_laps.Columns[7].Width = 90;
       }
       private void tabel_semua()
       {
           dgv_laps.Columns[0].HeaderText = "NIK";
           dgv_laps.Columns[0].Width = 80;
           dgv_laps.Columns[1].HeaderText = "NIPD";
           dgv_laps.Columns[1].Width = 100;
           dgv_laps.Columns[2].HeaderText = "NISN";
           dgv_laps.Columns[2].Width = 120;
           dgv_laps.Columns[3].HeaderText = "SKHUN";
           dgv_laps.Columns[3].Width = 110;
           dgv_laps.Columns[4].HeaderText = "Nama Lengkap";
           dgv_laps.Columns[4].Width = 160;
           dgv_laps.Columns[5].HeaderText = "JK";
           dgv_laps.Columns[5].Width = 30;
           dgv_laps.Columns[6].HeaderText = "Agama";
           dgv_laps.Columns[6].Width = 70;
           dgv_laps.Columns[7].HeaderText = "Tempat Lahir";
           dgv_laps.Columns[7].Width = 130;
           dgv_laps.Columns[8].HeaderText = "Tanggal Lahir";
           dgv_laps.Columns[8].Width = 100;
           dgv_laps.Columns[9].HeaderText = "Alamat";
           dgv_laps.Columns[9].Width = 120;
           dgv_laps.Columns[10].HeaderText = "Kelurahan";
           dgv_laps.Columns[10].Width = 110;
           dgv_laps.Columns[11].HeaderText = "Kecamatan";
           dgv_laps.Columns[11].Width = 110;
           dgv_laps.Columns[12].HeaderText = "Kabupaten";
           dgv_laps.Columns[12].Width = 110;
           dgv_laps.Columns[13].HeaderText = "Provinsi";
           dgv_laps.Columns[13].Width = 100;
           dgv_laps.Columns[14].HeaderText = "Penerima KPS";
           dgv_laps.Columns[14].Width = 110;
           dgv_laps.Columns[15].HeaderText = "Nomor KPS";
           dgv_laps.Columns[15].Width = 120;
           dgv_laps.Columns[16].HeaderText = "No. Handphone";
           dgv_laps.Columns[16].Width = 120;
           dgv_laps.Columns[17].HeaderText = "Email";
           dgv_laps.Columns[17].Width = 120;
           dgv_laps.Columns[18].HeaderText = "ID Ortu";
           dgv_laps.Columns[18].Width = 80;
           dgv_laps.Columns[19].HeaderText = "Nama Ayah";
           dgv_laps.Columns[19].Width = 110;
           dgv_laps.Columns[20].HeaderText = "Pendidikan Ayah";
           dgv_laps.Columns[20].Width = 120;
           dgv_laps.Columns[21].HeaderText = "Pekerjaan Ayah";
           dgv_laps.Columns[21].Width = 120;
           dgv_laps.Columns[22].HeaderText = "Nama Ibu";
           dgv_laps.Columns[22].Width = 110;
           dgv_laps.Columns[23].HeaderText = "Pendidikan Ibu";
           dgv_laps.Columns[23].Width = 110;
           dgv_laps.Columns[24].HeaderText = "Pekerjaan Ibu";
           dgv_laps.Columns[24].Width = 120;
           dgv_laps.Columns[25].HeaderText = "Alamat Ortu";
           dgv_laps.Columns[25].Width = 140;
           dgv_laps.Columns[26].HeaderText = "No. Handphone";
           dgv_laps.Columns[26].Width = 110;
           dgv_laps.Columns[27].HeaderText = "Nama Wali";
           dgv_laps.Columns[27].Width = 110;
           dgv_laps.Columns[28].HeaderText = "Pendidikan Wali";
           dgv_laps.Columns[28].Width = 110;
           dgv_laps.Columns[29].HeaderText = "Pekerjaan Wali";
           dgv_laps.Columns[29].Width = 110;
           dgv_laps.Columns[30].HeaderText = "Alamat Wali";
           dgv_laps.Columns[30].Width = 140;
           dgv_laps.Columns[31].HeaderText = "No. Handphone";
           dgv_laps.Columns[31].Width = 110;
           dgv_laps.Columns[32].HeaderText = "Jurusan";
           dgv_laps.Columns[32].Width = 140;
           dgv_laps.Columns[33].HeaderText = "Tahun Ajaran";
           dgv_laps.Columns[33].Width = 100;
       }

       private void rb_k_Click(object sender, EventArgs e)
       {
           report_kelas rk = new report_kelas();
           rk.ShowDialog();
           tabel_kelas();
           
       }

       private void rb_s_Click(object sender, EventArgs e)
       {
           report_persiswa rps = new report_persiswa();
           rps.ShowDialog();
       }

       private void bt_ctk_Click(object sender, EventArgs e)
       {
           //print printer = new print();
           //printer.ShowDialog();
           //laporan_siswa ls = new laporan_siswa();
           //ls.ShowDialog();
           //report_siswa rs = new report_siswa();
           //rs.ShowDialog();
       }

       private void rb_ss_Click(object sender, EventArgs e)
       {
           report_siswa rs = new report_siswa();
           rs.ShowDialog();
       }

    }
}
