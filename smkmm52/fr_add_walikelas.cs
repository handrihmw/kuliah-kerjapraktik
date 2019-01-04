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
    public partial class fr_add_walikelas : Form
    {
        public fr_add_walikelas()
        {
            InitializeComponent();
            initializeCbKls();
            initializeCbWk();
        }
        private string kode
        {
            get
            {
                string kode = "WK-01";
                SqlCommand cmd = new SqlCommand
                ("select max(right(id_walikelas,2)) from tb_walikelas",
                MyData.Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader[0].ToString() != "")
                    kode = "WK-" + (int.Parse(reader[0].ToString()) + 1).ToString("00");

                reader.Close();
                return kode;
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
        private void initializeCbWk()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select nip,nm_guru from tb_guru", con);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                cb_wk.DataSource = dt;
                cb_wk.ValueMember = "nip";
                cb_wk.DisplayMember = "nm_guru";
            }
            catch (Exception err)
            {
                MessageBox.Show("Gagal Koneksi\n" + err.Message);
            }
        }
        private void tampil_walikelas()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select * from tb_walikelas";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(coman);
            sda.Fill(ds, "walikelas");
            dgv_walikls.DataSource = ds;
            dgv_walikls.DataMember = "walikelas";
        }

        private void simpan_walikelas()
        {

            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "insert into tb_walikelas values('" + tb_idwk.Text + "','" + tb_nip.Text + "','" + tb_idkl.Text + "','" + tb_thn.Text + "')";
            coman.ExecuteNonQuery();
            con.Close();
            tb_idwk.Enabled = true;
            tampil_walikelas();
        }

        public void ubah_walikelas()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "UPDATE tb_walikelas set nip='" + tb_nip.Text + "',id_kelas='" + tb_idkl.Text + "',thn_ajaran='" + tb_thn.Text + "'WHERE id_walikelas='" + tb_idwk.Text + "'";
            coman.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil Terupdate");
            cb_wk.Enabled = true;
        }
        private void bersih_walikelas()
        {

            tb_thn.Clear();

        }
        private void hapus_walikelas()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "delete from tb_walikelas where id_walikelas='" + tb_idwk.Text + "'";
            coman.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil Terhapus");
            tampil_walikelas();
            bersih_walikelas();

        }
        public void addItems(AutoCompleteStringCollection col)
        {
            col.Add("2016 / 2017");
            col.Add("2017 / 2018");
            col.Add("2018 / 2019");
            col.Add("2019 / 2020");
        }
        private void fr_add_walikelas_Load(object sender, EventArgs e)
        {
            /*Tahun Ajaran Otomatis*/
            tb_thn.AutoCompleteMode = AutoCompleteMode.Suggest;
            tb_thn.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollction = new AutoCompleteStringCollection();
            addItems(DataCollction);
            tb_thn.AutoCompleteCustomSource = DataCollction;
            
            tb_idwk.Text = kode;
            tb_idwk.Enabled = false;
            cb_kls.Enabled = false;
            cb_wk.Enabled = false;
            tb_thn.Enabled = false;
            tampil_walikelas();
        }

        private void bt_kembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_simpan_Click(object sender, EventArgs e)
        {
            if (tb_idwk.Text == "")
            {
                MessageBox.Show("Isikan ID Walikelas!");
                tb_idwk.Focus();
            }
            else if (tb_thn.Text == "")
            {
                MessageBox.Show("Isikan Tahun Ajaran!");
                tb_thn.Focus();
            }
            else

            {
                string query = "select * from tb_walikelas where id_walikelas='" + tb_idwk.Text + "'";
                if (!fungsi.cekdata(query))
                {
                    query = "insert into tb_walikelas values('" + tb_idwk.Text + "','" + tb_nip.Text + "','" + tb_idkl.Text + "','" + tb_thn.Text + "')";

                    int x = fungsi.Equery(query);
                    if (x == 1)
                    {
                        MessageBox.Show("Data Berhasil Tersimpan");
                        tampil_walikelas();
                    }
                    else
                    {
                        MessageBox.Show("Data Gagal Tersimpan");
                    }
                }
                else
                {
                    MessageBox.Show("ID Walikelas Telah Terdaftar", tb_idwk.Text);
                    tb_idwk.Focus();
                    tampil_walikelas();
                }
            }
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {

            if (tb_idwk.Text != "" && cb_wk.Text != "" && cb_kls.Text != "" && tb_thn.Text !="")
            {
                ubah_walikelas();
                MessageBox.Show("Data Berhasil Terupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tampil_walikelas();

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
                    hapus_walikelas();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Data Gagal Terhapus\n" + err.Message);
                }
            }  
        }

        private void dgv_walikls_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_idwk.Text = dgv_walikls.CurrentRow.Cells[0].Value.ToString();
            tb_nip.Text = dgv_walikls.CurrentRow.Cells[1].Value.ToString();
            tb_idkl.Text = dgv_walikls.CurrentRow.Cells[2].Value.ToString();
            tb_thn.Text = dgv_walikls.CurrentRow.Cells[3].Value.ToString();
        }

        private void tab_wali()
        {
            dgv_walikls.Columns[0].HeaderText = "ID Walikelas";
            dgv_walikls.Columns[0].Width = 90;
            dgv_walikls.Columns[1].HeaderText = "NIP";
            dgv_walikls.Columns[1].Width = 110;
            dgv_walikls.Columns[2].HeaderText = "ID Kelas";
            dgv_walikls.Columns[2].Width = 90;
            dgv_walikls.Columns[3].HeaderText = "Tahun Ajaran";
            dgv_walikls.Columns[3].Width = 100;
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
                coman.CommandText = "select * from tb_walikelas where walikelas like '" + cari1 + "%'";
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(coman);
                sda.Fill(ds, "walikls");
                dgv_walikls.DataSource = ds;
                dgv_walikls.DataMember = "walikls";
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
                coman.CommandText = "select * from tb_walikelas where kelas like '" + cari2 + "%'";
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(coman);
                sda.Fill(ds, "walikls");
                dgv_walikls.DataSource = ds;
                dgv_walikls.DataMember = "walikls";
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
                coman.CommandText = "select * from tb_walikelas where thn_ajaran like '" + cari3 + "%'";
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(coman);
                sda.Fill(ds, "walikls");
                dgv_walikls.DataSource = ds;
                dgv_walikls.DataMember = "walikls";
            }
            catch (Exception err)
            {
                MessageBox.Show("Data Tidak Ditemukan\n" + err.Message);
            }
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            tb_idwk.Enabled = true;
            cb_kls.Enabled = true;
            cb_wk.Enabled = true;
            tb_thn.Enabled = true;
            tampil_walikelas();
            bersih_walikelas();
        }
        private bool tambah = false;
        private void bt_tambah_Click(object sender, EventArgs e)
        {
            tb_idwk.Enabled = true;
            cb_kls.Enabled = true;
            cb_wk.Enabled = true;
            tb_thn.Enabled = true;
            bersih_walikelas();
            tambah = true;
            tb_idwk.Text = kode;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = MyData.Connection;
            cmd.CommandType = CommandType.Text;
            tb_idwk.Text = kode;
        }

        private void cb_wk_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con;
            con = koneksi.conn;
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select * from tb_guru where nm_guru='" + cb_wk.Text + "'";
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
                    cb_wk.Text = kode;

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

        private void fr_add_walikelas_Activated(object sender, EventArgs e)
        {
            tab_wali();
        }
    }
}
