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
    public partial class fr_add_mengajar : Form
    {
        public fr_add_mengajar()
        {
            InitializeComponent();
            initializeCbPlj();
            initializeCbGr();
            initializeCbKls();
        }
        private string kode
        {
            get
            {
                string kode = "MG-01";
                SqlCommand cmd = new SqlCommand
                ("select max(right(id_mengajar,2)) from tb_mengajar",
                MyData.Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader[0].ToString() != "")
                    kode = "MG-" + (int.Parse(reader[0].ToString()) + 1).ToString("00");

                reader.Close();
                return kode;
            }
        }
        private void initializeCbGr()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select nip,nm_guru from tb_guru", con);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                cb_gr.DataSource = dt;
                cb_gr.ValueMember = "nip";
                cb_gr.DisplayMember = "nm_guru";
            }
            catch (Exception err)
            {
                MessageBox.Show("Gagal Koneksi\n" + err.Message);
            }
        }
        private void initializeCbPlj()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select id_pelajaran,pelajaran from tb_pelajaran", con);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                cb_plj.DataSource = dt;
                cb_plj.ValueMember = "id_pelajaran";
                cb_plj.DisplayMember = "pelajaran";
            }
            catch (Exception err)
            {
                MessageBox.Show("Gagal Koneksi\n" + err.Message);
            }
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
        private void tampil_mengajar()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select * from tb_mengajar";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(coman);
            sda.Fill(ds, "mengajar");
            dgv_mengajar.DataSource = ds;
            dgv_mengajar.DataMember = "mengajar";
        }

        private void simpan_mengajar()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "insert into tb_mengajar values('"+tb_idmengajar.Text+"','" + tb_nip.Text + "','" + tb_idpl.Text + "','"+tb_idkl.Text+"','" + tb_thn.Text + "','" + tb_sem.Text + "')";
            coman.ExecuteNonQuery();
            con.Close();
            cb_gr.Enabled = true;
            tampil_mengajar();
        }

        private void ubah_mengajar()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "UPDATE tb_mengajar set nip='" + tb_nip.Text + "',id_pelajaran='" + tb_idpl.Text + "',id_kelas='" + tb_idkl.Text + "',thn_ajaran='" + tb_thn.Text + "',semester='" + tb_sem.Text + "'WHERE id_mengajar='" + tb_idmengajar.Text + "'";
            coman.ExecuteNonQuery();
            con.Close();
            tb_sem.Enabled = true;
        }
        private void bersih_mengajar()
        {

            tb_thn.Clear();
            tb_sem.Clear();

        }
        private void hapus_mengajar()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "delete from tb_mengajar where id_mengajar='" + tb_idmengajar.Text + "'";
            coman.ExecuteNonQuery();
            con.Close();
            tampil_mengajar();
            bersih_mengajar();
        }

        private void fr_tambah_datamengajar_Load(object sender, EventArgs e)
        {
            tampil_mengajar();
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            tampil_mengajar();
        }

        public void addItems(AutoCompleteStringCollection col)
        {
            col.Add("2016 / 2017");
            col.Add("2017 / 2018");
            col.Add("2018 / 2019");
            col.Add("2019 / 2020");
        }
        private void fr_add_mengajar_Load(object sender, EventArgs e)
        {
            /*Tahun Ajaran Otomatis*/
            tb_thn.AutoCompleteMode = AutoCompleteMode.Suggest;
            tb_thn.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollction = new AutoCompleteStringCollection();
            addItems(DataCollction);
            tb_thn.AutoCompleteCustomSource = DataCollction;

            tb_idmengajar.Text = kode;
            tb_idmengajar.Enabled = false;
            cb_gr.Enabled = false;
            cb_plj.Enabled = false;
            tb_thn.Enabled = false;
            tb_sem.Enabled = false;
            cb_kls.Enabled = false;
            tampil_mengajar();
        }

        private void bt_simpan_Click_1(object sender, EventArgs e)
        {
            if (tb_thn.Text == "")
            {
                MessageBox.Show("Isikan Tahun Ajaran!");
                tb_thn.Focus();
            }
            else if (tb_sem.Text == "")
            {
                MessageBox.Show("Isikan Semester!");
                tb_sem.Focus();
            }
            else
            {
                string query = "select * from tb_mengajar where id_mengajar='" + tb_idmengajar.Text + "'";
                if (!fungsi.cekdata(query))
                {
                    query = "insert into tb_mengajar values('" + tb_idmengajar.Text + "','" + tb_nip.Text + "','" + tb_idpl.Text + "','" + tb_idkl.Text + "','" + tb_thn.Text + "','" + tb_sem.Text + "')";

                    int x = fungsi.Equery(query);
                    if (x == 1)
                    {
                        MessageBox.Show("Data Berhasil Tersimpan");
                        tampil_mengajar();
                    }
                    else
                    {
                        MessageBox.Show("Data Gagal Tersimpan");
                    }
                }
                else
                {
                    MessageBox.Show("ID Mengajar Telah Terdaftar", tb_idmengajar.Text);
                    tb_idmengajar.Focus();
                    tampil_mengajar();
                }
            }
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {

            if (tb_idmengajar.Text != "" && cb_gr.Text != "" && cb_kls.Text != "" && cb_kls.Text !="" && tb_thn.Text !="" && tb_sem.Text !="")
            {
                ubah_mengajar();
                MessageBox.Show("Data Berhasil Terupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tampil_mengajar();

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
                    hapus_mengajar();
                    {
                        MessageBox.Show("Data Berhasil Terhapus\n");
                       
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Gagal Hapus\n" + err.Message);
                }
            }    
        }

        private void bt_kembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool tambah = false;
        private void bt_tambah_Click(object sender, EventArgs e)
        {
            tb_idmengajar.Enabled = true;
            cb_gr.Enabled = true;
            cb_plj.Enabled = true;
            tb_thn.Enabled = true;
            tb_sem.Enabled = true;
            cb_kls.Enabled = true;
            bersih_mengajar();
            tambah = true;
            tb_idmengajar.Text = kode;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = MyData.Connection;
            cmd.CommandType = CommandType.Text;
            tb_idmengajar.Text = kode;
        }

        private void bt_refresh_Click_1(object sender, EventArgs e)
        {
            tb_idmengajar.Enabled = true;
            cb_gr.Enabled = true;
            cb_plj.Enabled = true;
            tb_thn.Enabled = true;
            tb_sem.Enabled = true;
            cb_kls.Enabled = true;
            tampil_mengajar();
            bersih_mengajar();
        }

        private void dgv_mengajar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_idmengajar.Text = dgv_mengajar.CurrentRow.Cells[0].Value.ToString();
            tb_nip.Text = dgv_mengajar.CurrentRow.Cells[1].Value.ToString();
            tb_idpl.Text = dgv_mengajar.CurrentRow.Cells[2].Value.ToString();
            tb_idkl.Text = dgv_mengajar.CurrentRow.Cells[3].Value.ToString();
            tb_thn.Text = dgv_mengajar.CurrentRow.Cells[4].Value.ToString();
            tb_sem.Text = dgv_mengajar.CurrentRow.Cells[5].Value.ToString();
           
        }
        private void tabel_mengajar()
        {
            dgv_mengajar.Columns[0].HeaderText = "ID Mengajar";
            dgv_mengajar.Columns[0].Width = 90;
            dgv_mengajar.Columns[1].HeaderText = "NIP";
            dgv_mengajar.Columns[1].Width = 110;
            dgv_mengajar.Columns[2].HeaderText = "ID Pelajaran";
            dgv_mengajar.Columns[2].Width = 90;
            dgv_mengajar.Columns[3].HeaderText = "ID Kelas";
            dgv_mengajar.Columns[3].Width = 90;
            dgv_mengajar.Columns[4].HeaderText = "Tahun Ajaran";
            dgv_mengajar.Columns[4].Width = 100;
            dgv_mengajar.Columns[5].HeaderText = "Semester";
            dgv_mengajar.Columns[5].Width = 70;

        }

        private void tb_cari1_TextChanged(object sender, EventArgs e)
        {
            string cari1 = tb_cari1.Text;
            try
            {
                SqlConnection con;
                con = koneksi.conn;
                SqlCommand coman = new SqlCommand();
                coman.Connection = con;
                coman.CommandType = CommandType.Text;
                coman.CommandText = "select * from tb_mengajar where nama_guru like '" + cari1 + "%'";
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(coman);
                sda.Fill(ds, "mengajar");
                dgv_mengajar.DataSource = ds;
                dgv_mengajar.DataMember = "mengajar";
            }
            catch (Exception err)
            {
                MessageBox.Show("Data Tidak Ditemukan\n" + err.Message);
            }
        }

        private void tb_cari2_TextChanged(object sender, EventArgs e)
        {
            string cari2 = tb_cari2.Text;
            try
            {
                SqlConnection con;
                con = koneksi.conn;
                SqlCommand coman = new SqlCommand();
                coman.Connection = con;
                coman.CommandType = CommandType.Text;
                coman.CommandText = "select * from tb_mengajar where pelajaran like '" + cari2 + "%'";
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(coman);
                sda.Fill(ds, "mengajar");
                dgv_mengajar.DataSource = ds;
                dgv_mengajar.DataMember = "mengajar";
            }
            catch (Exception err)
            {
                MessageBox.Show("Data Tidak Ditemukan\n" + err.Message);
            }
        }

        private void tb_cari3_TextChanged(object sender, EventArgs e)
        {
            string cari3 = tb_cari3.Text;
            try
            {
                SqlConnection con;
                con = koneksi.conn;
                SqlCommand coman = new SqlCommand();
                coman.Connection = con;
                coman.CommandType = CommandType.Text;
                coman.CommandText = "select * from tb_mengajar where thn_ajaran like '" + cari3 + "%'";
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(coman);
                sda.Fill(ds, "mengajar");
                dgv_mengajar.DataSource = ds;
                dgv_mengajar.DataMember = "mengajar";
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
                coman.CommandText = "select * from tb_mengajar where semester like '" + cari4 + "%'";
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(coman);
                sda.Fill(ds, "mengajar");
                dgv_mengajar.DataSource = ds;
                dgv_mengajar.DataMember = "mengajar";
            }
            catch (Exception err)
            {
                MessageBox.Show("Data Tidak Ditemukan\n" + err.Message);
            }
        }

        private void cb_gr_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con;
            con = koneksi.conn;
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select * from tb_guru where nm_guru='" + cb_gr.Text + "'";
            SqlDataReader dbr;
            try
            {
                con.Open();
                dbr = coman.ExecuteReader();
                while (dbr.Read())
                {
                    string kode = (string)dbr["nip"];
                    tb_nip.Text = kode;

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Gagal Menampilkan Data\n" + err.Message);
            }
        }

        private void cb_plj_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con;
            con = koneksi.conn;
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select * from tb_pelajaran where pelajaran ='" + cb_plj.Text + "'";
            SqlDataReader dbr;
            try
            {
                con.Open();
                dbr = coman.ExecuteReader();
                while (dbr.Read())
                {
                    string kode = (string)dbr["id_pelajaran"];
                    tb_idpl.Text = kode;

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Gagal Menampilkan Data\n" + err.Message);
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
                    tb_idkl.Text = kode;

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Gagal Menampilkan Data\n" + err.Message);
            }
        }

        private void tb_nip_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con;
            con = koneksi.conn;
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select * from tb_guru where nip='" + tb_nip.Text + "'";
            SqlDataReader dbr;
            try
            {
                con.Open();
                dbr = coman.ExecuteReader();
                while (dbr.Read())
                {
                    string kode = (string)dbr["nm_guru"];
                    cb_gr.Text = kode;

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Gagal Menampilkan Data\n" + err.Message);
            }
        }

        private void tb_idpl_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con;
            con = koneksi.conn;
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select * from tb_pelajaran where id_pelajaran='" + tb_idpl.Text + "'";
            SqlDataReader dbr;
            try
            {
                con.Open();
                dbr = coman.ExecuteReader();
                while (dbr.Read())
                {
                    string kode = (string)dbr["pelajaran"];
                    cb_plj.Text = kode;

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Gagal Menampilkan Data\n" + err.Message);
            }
        }

        private void tb_idkl_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con;
            con = koneksi.conn;
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select * from tb_kelas where id_kelas='" + tb_idkl.Text + "'";
            SqlDataReader dbr;
            try
            {
                con.Open();
                dbr = coman.ExecuteReader();
                while (dbr.Read())
                {
                    string kode = (string)dbr["kelas"];
                    cb_kls.Text = kode;

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Gagal Menampilkan Data\n" + err.Message);
            }
        }

        private void fr_add_mengajar_Activated(object sender, EventArgs e)
        {
            tabel_mengajar();
        }

       
    }
}
