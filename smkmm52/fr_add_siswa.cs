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
using System.Data.OleDb;

namespace smkmm52
{
    public partial class fr_add_siswa : Form
    {
        public fr_add_siswa()
        {
            InitializeComponent();
        }
        public int kondisi;
        public String jk;

       private string kode
        {
            get
            {
                string kode = "OR-01";
                SqlCommand cmd = new SqlCommand
                ("select max(right(nipd,2)) from tb_siswa",
                MyData.Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader[0].ToString() != "")
                    kode = "OR-" + (int.Parse(reader[0].ToString()) + 1).ToString("00");

                reader.Close();
                return kode;
            }
        }
      //------------------------------------------------------WILAYAH--------------------------------------------//
        private void provinsi()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select provinsi from tb_prov";
            SqlDataReader reader = coman.ExecuteReader();
            AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                mycollection.Add(reader.GetString(0));
            }
            tb_prov.AutoCompleteCustomSource = mycollection;
            con.Close();
        }
        private void kabupaten()
        {
             SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select kabupaten from tb_kab";
            SqlDataReader reader = coman.ExecuteReader();
            AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                mycollection.Add(reader.GetString(0));
            }
            tb_kab.AutoCompleteCustomSource = mycollection;
            con.Close();
        }
        private void kecamatan()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select kecamatan from tb_kec";
            SqlDataReader reader = coman.ExecuteReader();
            AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                mycollection.Add(reader.GetString(0));
            }
            tb_kec.AutoCompleteCustomSource = mycollection;
            con.Close();
        }
        private void kelurahan()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select kelurahan from tb_kel";
            SqlDataReader reader = coman.ExecuteReader();
            AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                mycollection.Add(reader.GetString(0));
            }
            tb_kel.AutoCompleteCustomSource = mycollection;
            con.Close();
        }
        //------------------------------------------------------WILAYAH--------------------------------------------//
        public void tampil_siswa()
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
            dgv_siswa.DataSource = ds;
            dgv_siswa.DataMember = "siswa";

        }
        private void simpan_siswa()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "insert into tb_siswa values('" + tb_nipd.Text +
                "','" + tb_nik.Text +
                "','" + tb_nisn.Text +
                "','" + tb_skhun.Text +
                "','" + tb_nmsiswa.Text +
                "','" + jk +
                "','" + cb_agama.Text +
                "','" + rtb_tpt.Text +
                "','" + dtm_lahir.Value.ToString("yyyy-MM-dd") +
                "','" + rtb_alamat.Text +
                "','" + tb_kel.Text +
                "','" + tb_kec.Text +
                "','" + tb_kab.Text +
                "','" + tb_prov.Text +
                "','" + cb_kps.Text +
                "','" + tb_nokps.Text +
                "','" + tb_hp.Text +
                "','" + tb_email.Text +
                "','" + tb_idortu.Text +
                "','" + tb_nmayah.Text +
                "','" + tb_pddayah.Text +
                "','" + tb_pkrayah.Text +
                "','" + tb_nmibu.Text +
                "','" + tb_pddibu.Text +
                "','" + tb_pkribu.Text +
                "','" + rtb_almtortu.Text +
                "','" + tb_hportu.Text +
                "','" + tb_nmwali.Text +
                "','" + tb_pddwali.Text +
                "','" + tb_pkrwali.Text +
                "','" + rtb_almtwali.Text +
                "','" + tb_nohpwali.Text + 
                "','" + cb_jurusan.Text+
                "','" + tb_thn.Text+"')";

            coman.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil Tersimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tampil_siswa();
            tb_nipd.Enabled = true;

        }

        private void edit_siswa()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "update tb_siswa set nik='" + tb_nik.Text +
                "',nisn='" + tb_nisn.Text +
                "',skhun='" + tb_skhun.Text +
                "',nm_siswa='" + tb_nmsiswa.Text +
                "',jk='" + jk +
                "',agama='" + cb_agama.Text +
                "',tpt_lhr='" + rtb_tpt.Text +
                "',tgl_lhr='" + dtm_lahir.Value.ToString("yyyy-MM-dd") +
                "',alamat='" + rtb_alamat.Text +
                "',kel='" + tb_kel.Text +
                "',kec='" + tb_kec.Text +
                "',kab='" + tb_kab.Text +
                "',prov='" + tb_prov.Text +
                "',penerima_kps='" + cb_kps.Text +
                "',no_kps='" + tb_nokps.Text +
                "',no_hp_siswa='" + tb_hp.Text +
                "',email='" + tb_email.Text +
                "',id_ortu='" + tb_idortu.Text +
                "',nm_ayah='" + tb_nmayah.Text +
                "',pdd_ayah='" + tb_pddayah.Text +
                "',pkr_ayah='" + tb_pkrayah.Text +
                "',nm_ibu='" + tb_nmibu.Text +
                "',pdd_ibu='" + tb_pddibu.Text +
                "',pkr_ibu='" + tb_pkribu.Text +
                "',alamat_ortu='" + rtb_almtortu.Text +
                "',no_hp_ortu='" + tb_hportu.Text +
                "',nm_wali='" + tb_nmwali.Text +
                "',pdd_wali='" + tb_pddwali.Text +
                "',pkr_wali='" + tb_pkrwali.Text +
                "',alamat_wali='" + rtb_almtwali.Text +
                "',no_hp_wali='" + tb_nohpwali.Text +
                "',jurusan='" + cb_jurusan.Text +
                "',thn_ajaran='" +tb_thn.Text+
                "' where nipd='" + tb_nipd.Text + "'";

            coman.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil Terupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tb_nipd.Enabled = true;
        }
        private void bersih_siswa()
        {
            tb_nipd.Clear();
            tb_nik.Clear();
            tb_nisn.Clear();
            tb_skhun.Clear();
            tb_nmsiswa.Clear();
            rtb_tpt.Clear();
            rtb_alamat.Clear();
            tb_kel.Clear();
            tb_kec.Clear();
            tb_kab.Clear();
            tb_prov.Clear();
            tb_nokps.Clear();
            tb_hp.Clear();
            tb_email.Clear();
            tb_idortu.Clear();
            tb_nmayah.Clear();
            tb_pddayah.Clear();
            tb_pkrayah.Clear();
            tb_nmibu.Clear();
            tb_pddibu.Clear();
            tb_pkribu.Clear();
            rtb_almtortu.Clear();
            tb_hportu.Clear();
            tb_nmwali.Clear();
            tb_pddwali.Clear();
            tb_pkrwali.Clear();
            rtb_almtwali.Clear();
            tb_nohpwali.Clear();
            tb_thn.Clear();

        }
        private void hapus_siswa()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "delete from tb_siswa where nipd='" + tb_nipd.Text + "'";
            coman.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Siswa Berhasil Terhapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tampil_siswa();
            bersih_siswa();
        }
        private void bt_kembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_simpan_Click(object sender, EventArgs e)
        {
            if (tb_nipd.Text == "" || tb_nisn.Text == "" || tb_nik.Text == "" || tb_skhun.Text == "" || rtb_alamat.Text == "" ||
                    tb_prov.Text == "" || tb_kab.Text == "" || tb_kec.Text == "" || tb_kel.Text == "" ||
                    rtb_tpt.Text == "" || tb_nokps.Text == "" || tb_hp.Text == "" || tb_email.Text == "" || tb_idortu.Text == "" || 
                    tb_nmayah.Text == "" || tb_pkrayah.Text == "" || tb_pddayah.Text == "" || tb_nmibu.Text == "" || tb_pddibu.Text == "" || 
                    tb_pkribu.Text == "" || rtb_almtortu.Text == "" || tb_nmwali.Text == "" || tb_pddwali.Text == "" || tb_pkrwali.Text == "" ||
                    rtb_almtwali.Text == "" || tb_nohpwali.Text == "" || cb_jurusan.Text == "" || tb_thn.Text == "")
                {
                    MessageBox.Show("Data (*) Tidak Boleh Kosong", "Info", MessageBoxButtons.OK);
                }
                else
            {
                string query = "select * from tb_siswa where nipd='" + tb_nipd.Text + "'";
                if (!fungsi.cekdata(query))
                {
                    query = "insert into tb_siswa values('" + tb_nipd.Text +
                "','" + tb_nik.Text +
                "','" + tb_nisn.Text +
                "','" + tb_skhun.Text +
                "','" + tb_nmsiswa.Text +
                "','" + jk +
                "','" + cb_agama.Text +
                "','" + rtb_tpt.Text +
                "','" + dtm_lahir.Value.ToString("yyyy-MM-dd") +
                "','" + rtb_alamat.Text +
                "','" + tb_kel.Text +
                "','" + tb_kec.Text +
                "','" + tb_kab.Text +
                "','" + tb_prov.Text +
                "','" + cb_kps.Text +
                "','" + tb_nokps.Text +
                "','" + tb_hp.Text +
                "','" + tb_email.Text +
                "','" + tb_idortu.Text +
                "','" + tb_nmayah.Text +
                "','" + tb_pddayah.Text +
                "','" + tb_pkrayah.Text +
                "','" + tb_nmibu.Text +
                "','" + tb_pddibu.Text +
                "','" + tb_pkribu.Text +
                "','" + rtb_almtortu.Text +
                "','" + tb_hportu.Text +
                "','" + tb_nmwali.Text +
                "','" + tb_pddwali.Text +
                "','" + tb_pkrwali.Text +
                "','" + rtb_almtwali.Text +
                "','" + tb_nohpwali.Text +
                "','" + cb_jurusan.Text +
                "','" + tb_thn.Text + "')";

                    int x = fungsi.Equery(query);
                    if (x == 1)
                    {
                        MessageBox.Show("Data Berhasil Tersimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tampil_siswa();
                    }
                    else
                    {
                        MessageBox.Show("Data Gagal Tersimpan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("NIPD Telah Terdaftar", tb_nipd.Text);
                    tb_nipd.Focus();
                    tampil_siswa();
                }
            }
            }
        private void bt_update_Click(object sender, EventArgs e)
        {
            if (tb_nipd.Text != "" && tb_nisn.Text != "" && tb_nik.Text != "" && tb_skhun.Text != "" && rtb_alamat.Text != "" &&
                   tb_prov.Text != "" && tb_kab.Text != "" && tb_kec.Text != "" && tb_kel.Text != "" &&
                   rtb_tpt.Text != "" && tb_nokps.Text != "" && tb_hp.Text != "" && tb_email.Text != "" && tb_idortu.Text != "" &&
                   tb_nmayah.Text != "" && tb_pkrayah.Text != "" && tb_pddayah.Text != "" && tb_nmibu.Text != "" && tb_pddibu.Text != "" &&
                   tb_pkribu.Text != "" && rtb_almtortu.Text != "" && tb_nmwali.Text != "" && tb_pddwali.Text != "" && tb_pkrwali.Text != "" &&
                   rtb_almtwali.Text != "" && tb_nohpwali.Text != "" && cb_jurusan.Text != "" && tb_thn.Text != "")
            {
                edit_siswa();
                MessageBox.Show("Data Berhasil Terupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tampil_siswa();

            }
            else
            {
                MessageBox.Show("Data Gagal Terupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void bt_hapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda Ingin Menghapus Data Ini?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                ) == DialogResult.Yes)
            {
                try
                {
                    hapus_siswa();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Gagal Hapus\n" + err.Message);
                }
            }
        }
        public void addItems (AutoCompleteStringCollection col)
        {
            col.Add("2016 / 2017");
            col.Add("2017 / 2018");
            col.Add("2018 / 2019");
            col.Add("2019 / 2020");
        }
        private void fr_add_siswa_Load(object sender, EventArgs e)
        {
            tb_idortu.Text = kode;
            /*Tahun Ajaran Otomatis*/
            tb_thn.AutoCompleteMode = AutoCompleteMode.Suggest;
            tb_thn.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollction = new AutoCompleteStringCollection();
            addItems(DataCollction);
            tb_thn.AutoCompleteCustomSource = DataCollction;
        
            /*Wilayah Otomatis*/
            provinsi();
            kabupaten();
            kecamatan();
            kelurahan();

            tb_nipd.Enabled = false;
            tb_nisn.Enabled = false;
            tb_nik.Enabled = false;
            tb_skhun.Enabled = false;
            tb_nmsiswa.Enabled = false;
            cb_agama.Enabled = false;
            rtb_tpt.Enabled = false;
            dtm_lahir.Enabled = false;
            rtb_alamat.Enabled = false;
            tb_kel.Enabled = false;
            tb_kec.Enabled = false;
            tb_kab.Enabled = false;
            tb_prov.Enabled = false;
            cb_kps.Enabled = false;
            tb_nokps.Enabled = false;
            tb_hp.Enabled = false;
            tb_email.Enabled = false;
            tb_idortu.Enabled = false;
            tb_nmayah.Enabled = false;
            tb_pddayah.Enabled = false;
            tb_pkrayah.Enabled = false;
            tb_nmibu.Enabled = false;
            tb_pddibu.Enabled = false;
            tb_pkribu.Enabled = false;
            rtb_almtortu.Enabled = false;
            tb_hportu.Enabled = false;
            tb_nmwali.Enabled = false;
            tb_pddwali.Enabled = false;
            tb_pkrwali.Enabled = false;
            rtb_almtwali.Enabled = false;
            tb_nohpwali.Enabled = false;
            cb_jurusan.Enabled = false;
            tb_thn.Enabled = false;
            bt_load.Enabled = false;
            bt_print.Enabled = false;
            tampil_siswa();
        }
        private void bt_refresh_Click(object sender, EventArgs e)
        {
            tb_nipd.Enabled = true;
            tb_nisn.Enabled = true;
            tb_nik.Enabled = true;
            tb_skhun.Enabled = true;
            tb_nmsiswa.Enabled = true;
            cb_agama.Enabled = true;
            rtb_tpt.Enabled = true;
            dtm_lahir.Enabled = true;
            rtb_alamat.Enabled = true;
            tb_kel.Enabled = true;
            tb_kec.Enabled = true;
            tb_kab.Enabled = true;
            tb_prov.Enabled = true;
            cb_kps.Enabled = true;
            tb_nokps.Enabled = true;
            tb_hp.Enabled = true;
            tb_email.Enabled = true;
            tb_idortu.Enabled = true;
            tb_nmayah.Enabled = true;
            tb_pddayah.Enabled = true;
            tb_pkrayah.Enabled = true;
            tb_nmibu.Enabled = true;
            tb_pddibu.Enabled = true;
            tb_pkribu.Enabled = true;
            rtb_almtortu.Enabled = true;
            tb_hportu.Enabled = true;
            tb_nmwali.Enabled = true;
            tb_pddwali.Enabled = true;
            tb_pkrwali.Enabled = true;
            rtb_almtwali.Enabled = true;
            tb_nohpwali.Enabled = true;
            cb_jurusan.Enabled = true;
            tb_thn.Enabled = true;
            tampil_siswa();
            bersih_siswa();
        }

        private void dgv_siswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_nipd.Text = dgv_siswa.CurrentRow.Cells[0].Value.ToString();
            tb_nisn.Text = dgv_siswa.CurrentRow.Cells[1].Value.ToString();
            tb_nik.Text = dgv_siswa.CurrentRow.Cells[2].Value.ToString();
            tb_skhun.Text = dgv_siswa.CurrentRow.Cells[3].Value.ToString();
            tb_nmsiswa.Text = dgv_siswa.CurrentRow.Cells[4].Value.ToString();
            jk = dgv_siswa.CurrentRow.Cells[5].Value.ToString();
            cb_agama.Text = dgv_siswa.CurrentRow.Cells[6].Value.ToString();
            rtb_tpt.Text = dgv_siswa.CurrentRow.Cells[7].Value.ToString();
            dtm_lahir.Value = DateTime.Parse(dgv_siswa.CurrentRow.Cells[8].Value.ToString());
            rtb_alamat.Text = dgv_siswa.CurrentRow.Cells[9].Value.ToString();
            tb_kel.Text = dgv_siswa.CurrentRow.Cells[10].Value.ToString();
            tb_kec.Text = dgv_siswa.CurrentRow.Cells[11].Value.ToString();
            tb_kab.Text = dgv_siswa.CurrentRow.Cells[12].Value.ToString();
            tb_prov.Text = dgv_siswa.CurrentRow.Cells[13].Value.ToString();
            cb_kps.Text = dgv_siswa.CurrentRow.Cells[14].Value.ToString();
            tb_nokps.Text = dgv_siswa.CurrentRow.Cells[15].Value.ToString();
            tb_hp.Text = dgv_siswa.CurrentRow.Cells[16].Value.ToString();
            tb_email.Text = dgv_siswa.CurrentRow.Cells[17].Value.ToString();
            tb_idortu.Text = dgv_siswa.CurrentRow.Cells[18].Value.ToString();
            tb_nmayah.Text = dgv_siswa.CurrentRow.Cells[19].Value.ToString();
            tb_pddayah.Text = dgv_siswa.CurrentRow.Cells[20].Value.ToString();
            tb_pkrayah.Text = dgv_siswa.CurrentRow.Cells[21].Value.ToString();
            tb_nmibu.Text = dgv_siswa.CurrentRow.Cells[22].Value.ToString();
            tb_pddibu.Text = dgv_siswa.CurrentRow.Cells[23].Value.ToString();
            tb_pkribu.Text = dgv_siswa.CurrentRow.Cells[24].Value.ToString();
            rtb_almtortu.Text = dgv_siswa.CurrentRow.Cells[25].Value.ToString();
            tb_hportu.Text = dgv_siswa.CurrentRow.Cells[26].Value.ToString();
            tb_nmwali.Text = dgv_siswa.CurrentRow.Cells[27].Value.ToString();
            tb_pddwali.Text = dgv_siswa.CurrentRow.Cells[28].Value.ToString();
            tb_pkrwali.Text = dgv_siswa.CurrentRow.Cells[29].Value.ToString();
            rtb_almtwali.Text = dgv_siswa.CurrentRow.Cells[30].Value.ToString();
            tb_nohpwali.Text = dgv_siswa.CurrentRow.Cells[31].Value.ToString();
            cb_jurusan.Text = dgv_siswa.CurrentRow.Cells[32].Value.ToString();
            tb_thn.Text = dgv_siswa.CurrentRow.Cells[33].Value.ToString();
        }
        private void tabel_siswa()
        {
            dgv_siswa.Columns[0].HeaderText = "NIPD";
            dgv_siswa.Columns[0].Width = 60;
            dgv_siswa.Columns[1].HeaderText = "NIK";
            dgv_siswa.Columns[1].Width = 120;
            dgv_siswa.Columns[2].HeaderText = "NISN";
            dgv_siswa.Columns[2].Width = 120;
            dgv_siswa.Columns[3].HeaderText = "SKHUN";
            dgv_siswa.Columns[3].Width = 110;
            dgv_siswa.Columns[4].HeaderText = "Nama Lengkap";
            dgv_siswa.Columns[4].Width = 160;
            dgv_siswa.Columns[5].HeaderText = "JK";
            dgv_siswa.Columns[5].Width = 30;
            dgv_siswa.Columns[6].HeaderText = "Agama";
            dgv_siswa.Columns[6].Width = 70;
            dgv_siswa.Columns[7].HeaderText = "Tempat Lahir";
            dgv_siswa.Columns[7].Width = 130;
            dgv_siswa.Columns[8].HeaderText = "Tanggal Lahir";
            dgv_siswa.Columns[8].Width = 100;
            dgv_siswa.Columns[9].HeaderText = "Alamat";
            dgv_siswa.Columns[9].Width = 120;
            dgv_siswa.Columns[10].HeaderText = "Kelurahan";
            dgv_siswa.Columns[10].Width = 110;
            dgv_siswa.Columns[11].HeaderText = "Kecamatan";
            dgv_siswa.Columns[11].Width = 110;
            dgv_siswa.Columns[12].HeaderText = "Kabupaten";
            dgv_siswa.Columns[12].Width = 110;
            dgv_siswa.Columns[13].HeaderText = "Provinsi";
            dgv_siswa.Columns[13].Width = 100;
            dgv_siswa.Columns[14].HeaderText = "Penerima KPS";
            dgv_siswa.Columns[14].Width = 110;
            dgv_siswa.Columns[15].HeaderText = "Nomor KPS";
            dgv_siswa.Columns[15].Width = 120;
            dgv_siswa.Columns[16].HeaderText = "No. Handphone";
            dgv_siswa.Columns[16].Width = 120;
            dgv_siswa.Columns[17].HeaderText = "Email";
            dgv_siswa.Columns[17].Width = 120;
            dgv_siswa.Columns[18].HeaderText = "ID Ortu";
            dgv_siswa.Columns[18].Width = 80;
            dgv_siswa.Columns[19].HeaderText = "Nama Ayah";
            dgv_siswa.Columns[19].Width = 110;
            dgv_siswa.Columns[20].HeaderText = "Pendidikan Ayah";
            dgv_siswa.Columns[20].Width = 120;
            dgv_siswa.Columns[21].HeaderText = "Pekerjaan Ayah";
            dgv_siswa.Columns[21].Width = 120;
            dgv_siswa.Columns[22].HeaderText = "Nama Ibu";
            dgv_siswa.Columns[22].Width = 110;
            dgv_siswa.Columns[23].HeaderText = "Pendidikan Ibu";
            dgv_siswa.Columns[23].Width = 110;
            dgv_siswa.Columns[24].HeaderText = "Pekerjaan Ibu";
            dgv_siswa.Columns[24].Width = 120;
            dgv_siswa.Columns[25].HeaderText = "Alamat Ortu";
            dgv_siswa.Columns[25].Width = 140;
            dgv_siswa.Columns[26].HeaderText = "No. Handphone";
            dgv_siswa.Columns[26].Width = 110;
            dgv_siswa.Columns[27].HeaderText = "Nama Wali";
            dgv_siswa.Columns[27].Width = 110;
            dgv_siswa.Columns[28].HeaderText = "Pendidikan Wali";
            dgv_siswa.Columns[28].Width = 110;
            dgv_siswa.Columns[29].HeaderText = "Pekerjaan Wali";
            dgv_siswa.Columns[29].Width = 110;
            dgv_siswa.Columns[30].HeaderText = "Alamat Wali";
            dgv_siswa.Columns[30].Width = 140;
            dgv_siswa.Columns[31].HeaderText = "No. Handphone";
            dgv_siswa.Columns[31].Width = 110;
            dgv_siswa.Columns[32].HeaderText = "Jurusan";
            dgv_siswa.Columns[32].Width = 140;
            dgv_siswa.Columns[33].HeaderText = "Tahun Ajaran";
            dgv_siswa.Columns[33].Width = 100;
        }
        
        private void cb_kps_TextChanged(object sender, EventArgs e)
        {
            if (cb_kps.Text == "Penerima KPS")
            {
                tb_nokps.Enabled = true;
            }
            else
            {
                tb_nokps.Enabled = false;
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
                coman.CommandText = "select * from tb_siswa where nipd like '" + cari + "%'";
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(coman);
                sda.Fill(ds, "siswa");
                dgv_siswa.DataSource = ds;
                dgv_siswa.DataMember = "siswa";
            }
            catch (Exception err)
            {
                MessageBox.Show("Data Tidak ada\n" + err.Message);
            }
        }

        private void tb_cari2_TextChanged(object sender, EventArgs e)
        {
            string cari = tb_cari2.Text;
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
                dgv_siswa.DataSource = ds;
                dgv_siswa.DataMember = "siswa";
            }
            catch (Exception err)
            {
                MessageBox.Show("Data Tidak Ditemukan\n" + err.Message);
            }
        }

        private void tb_cari3_TextChanged(object sender, EventArgs e)
        {
            string cari = tb_cari3.Text;
            try
            {
                SqlConnection con;
                con = koneksi.conn;
                SqlCommand coman = new SqlCommand();
                coman.Connection = con;
                coman.CommandType = CommandType.Text;
                coman.CommandText = "select * from tb_siswa where nm_ayah like '" + cari + "%'";
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(coman);
                sda.Fill(ds, "siswa");
                dgv_siswa.DataSource = ds;
                dgv_siswa.DataMember = "siswa";
            }
            catch (Exception err)
            {
                MessageBox.Show("Data Tidak Ditemukan\n" + err.Message);
            }
        }

        private void tb_cari4_TextChanged(object sender, EventArgs e)
        {
            string cari4 = tb_cari4.Text;
            try
            {
                SqlConnection con;
                con = koneksi.conn;
                SqlCommand coman = new SqlCommand();
                coman.Connection = con;
                coman.CommandType = CommandType.Text;
                coman.CommandText = "select * from tb_siswa where nm_wali like '" + cari4 + "%'";
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(coman);
                sda.Fill(ds, "wali");
                dgv_siswa.DataSource = ds;
                dgv_siswa.DataMember = "wali";
            }
            catch (Exception err)
            {
                MessageBox.Show("Data Tidak Ditemukan\n" + err.Message);
            }
        }

        private void rb_lk_CheckedChanged(object sender, EventArgs e)
        {
            jk = "L";
        }

        private void rb_pr_CheckedChanged(object sender, EventArgs e)
        {
            jk = "P";
        }
        private bool tambah_id = false;
        private void bt_tambah_Click(object sender, EventArgs e)
        {
            tb_nipd.Enabled = true;
            tb_nisn.Enabled = true;
            tb_nik.Enabled = true;
            tb_skhun.Enabled = true;
            tb_nmsiswa.Enabled = true;
            cb_agama.Enabled = true;
            rtb_tpt.Enabled = true;
            dtm_lahir.Enabled = true;
            rtb_alamat.Enabled = true;
            tb_kel.Enabled = true;
            tb_kec.Enabled = true;
            tb_kab.Enabled = true;
            tb_prov.Enabled = true;
            cb_kps.Enabled = true;
            tb_nokps.Enabled = true;
            tb_hp.Enabled = true;
            tb_email.Enabled = true;
            tb_idortu.Enabled = true;
            tb_nmayah.Enabled = true;
            tb_pddayah.Enabled = true;
            tb_pkrayah.Enabled = true;
            tb_nmibu.Enabled = true;
            tb_pddibu.Enabled = true;
            tb_pkribu.Enabled = true;
            rtb_almtortu.Enabled = true;
            tb_hportu.Enabled = true;
            tb_nmwali.Enabled = true;
            tb_pddwali.Enabled = true;
            tb_pkrwali.Enabled = true;
            rtb_almtwali.Enabled = true;
            tb_nohpwali.Enabled = true;
            cb_jurusan.Enabled = true;
            tb_thn.Enabled = true;
            tampil_siswa();
            bersih_siswa();

            tambah_id = true;
            tb_idortu.Text = kode;
            tb_idortu.Enabled = true;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = MyData.Connection;
            cmd.CommandType = CommandType.Text;
            tb_idortu.Text = kode;
        }

        private void fr_add_siswa_Activated(object sender, EventArgs e)
        {
            tabel_siswa();
        }

        private void tb_nohpwali_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Masukan Nomor Dengan Benar !");
            }
        }

        private void tb_hportu_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Masukan Nomor Dengan Benar !");
            }
        }

        private void tb_hp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Masukan Nomor Dengan Benar !");
            }
        }

        private void tb_nipd_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Masukan NIPD Dengan Benar !");
            }
        }

        private void tb_nisn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Masukan NIK Dengan Benar !");
            }
        }

        private void tb_nik_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Masukan NISN Dengan Benar !");
            }
        }

        private void bt_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.tb_file.Text = ofd.FileName;
            }
        }

        private void bt_load_Click(object sender, EventArgs e)
        {
            /*string cont = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= "+tb_import.Text+";Extend Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection cone = new OleDbConnection(cont);
            OleDbDataAdapter adp = new OleDbDataAdapter("SELECT * FROM [" + tb_load.Text + "$]", cone);
            DataTable dt = new DataTable();
            dgv_siswa.DataSource = dt;*/

            /*if (System.IO.File.Exists(tb_import.Text))
            {
                string constring = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};
                Extended Properties=""Excel 8.0;HDR=Yes;IMEX=1;""", tb_import.Text);
                string query = String.Format("select * from [{0}$]", "Sheet1");
                OleDbDataAdapter adp = new OleDbDataAdapter(query, constring);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                dgv_siswa.DataSource = ds.Tables[0];
            }
            else
            {
             MessageBox.Show("Tidak Ada File Yang Di Load");
            }*/
            /*if (System.IO.File.Exists(tb_import.Text))
            {
                string connectionString = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""", tb_import.Text);

                //string connectionString = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""", txtPath.Text);
                string query = String.Format("select * from [{0}$]", tb_import);
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connectionString);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                //DataTable dtView = dataSet.Tables[0];
                dgv_siswa.DataSource = dataSet.Tables[0];
           }*/
            System.Data.OleDb.OleDbConnection MyConnection;
            System.Data.DataSet DtSet;
            System.Data.OleDb.OleDbDataAdapter MyCommand;
            MyConnection = new System.Data.OleDb.OleDbConnection(@"provider=Microsoft.ACE.OLEDB.12.0;Data Source="+tb_file.Text+";Extended Properties=Excel 8.0;");
            MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection);
            MyCommand.TableMappings.Add("Table", "Net-informations.com");
            DtSet = new System.Data.DataSet();
            MyCommand.Fill(DtSet);
            dgv_siswa.DataSource = DtSet.Tables[0];
            MyConnection.Close();
        }

        private void bt_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.tb_file.Text = ofd.FileName;
            }
            bt_load.Enabled = true;
            bt_print.Enabled = true;
        }

        private void bt_load_Click_1(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection MyConnection;
            System.Data.DataSet DtSet;
            System.Data.OleDb.OleDbDataAdapter MyCommand;
            MyConnection = new System.Data.OleDb.OleDbConnection(@"provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + tb_file.Text + ";Extended Properties=Excel 8.0;");
            MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection);
            MyCommand.TableMappings.Add("Table", "Net-informations.com");
            DtSet = new System.Data.DataSet();
            MyCommand.Fill(DtSet);
            dgv_siswa.DataSource = DtSet.Tables[0];
            MyConnection.Close();
        }
    }
}
