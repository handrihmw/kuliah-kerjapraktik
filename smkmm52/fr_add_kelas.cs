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
    public partial class fr_add_kelas : Form
    {
        public fr_add_kelas()
        {
            InitializeComponent();
        }
        private string kode
        {
            get
            {
                string kode = "KLS-01";
                SqlCommand cmd = new SqlCommand
                ("select max(right(id_kelas,2)) from tb_kelas",
                MyData.Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader[0].ToString() != "")
                    kode = "KLS-" + (int.Parse(reader[0].ToString()) + 1).ToString("00");

                reader.Close();
                return kode;
            }
        }

        private void tampil_kelas()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select * from tb_kelas";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(coman);
            sda.Fill(ds, "kelas");
            dgv_kls.DataSource = ds;
            dgv_kls.DataMember = "kelas";
            tb_kls.Focus();
        }


        private void simpan_kelas()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "insert into tb_kelas values('" + tb_idKelas.Text + "','" + tb_kls.Text + "')";
            coman.ExecuteNonQuery();
            con.Close();
            tb_kls.Enabled = true;
            tampil_kelas();
        }

        private void hapus_kelas()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "delete from tb_kelas where id_kelas='" + tb_idKelas.Text + "'";
            coman.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil Terhapus");
            tampil_kelas();
            bersih_kelas();
        }

        private void bersih_kelas()
        {
            tb_kls.Clear();
            tb_idKelas.Clear();
            tampil_kelas();
        }

        private void ubah_kelas()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "update  tb_kelas set kelas='" + tb_kls.Text +
                "' where id_kelas='" + tb_idKelas.Text + "'";
            coman.ExecuteNonQuery();
            coman.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil Terupdate");
            tampil_kelas();
            bersih_kelas();
        }
        private void fr_add_kelas_Load(object sender, EventArgs e)
        {
            tb_idKelas.Text = kode;
            tampil_kelas();
            tb_idKelas.Enabled = false;
            tb_kls.Enabled = false;
        }

        private void bt_simpan_Click(object sender, EventArgs e)
        {
                if (tb_kls.Text == "")
            {
                MessageBox.Show("Isikan ID Kelas!");
                tb_kls.Focus();
            }
                else if (tb_idKelas.Text == "")
                {
                    MessageBox.Show("Isikan Kelas!");
                    tb_idKelas.Focus();
                }

                else
                {
                    string query = "select * from tb_kelas where id_kelas='" + tb_idKelas.Text + "'";
                    if (!fungsi.cekdata(query))
                    {
                        query = "insert into tb_kelas values('" + tb_idKelas.Text + "','" + tb_kls.Text + "')";

                        int x = fungsi.Equery(query);
                        if (x == 1)
                        {
                            MessageBox.Show("Data Berhasil Tersimpan");
                            tampil_kelas();
                        }
                        else
                        {
                            MessageBox.Show("Data Gagal Tersimpan");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID Kelas Telah Terdaftar", tb_idKelas.Text);
                        tb_idKelas.Focus();
                        tampil_kelas();
                    }
                }
        }
        private void bt_update_Click(object sender, EventArgs e)
        {

            if (tb_idKelas.Text != "" && tb_kls.Text != "")
            {
                ubah_kelas();
                MessageBox.Show("Data Berhasil Terupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tampil_kelas();

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
                    hapus_kelas();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Data Gagal Terhapus\n" + err.Message);
                }
            }
        }

        private void bt_kembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            tb_idKelas.Enabled = true;
            tb_kls.Enabled = true;
            tampil_kelas();
            bersih_kelas();
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
                coman.CommandText = "select * from tb_kelas where id_kelas like '" + cari + "%'";
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(coman);
                sda.Fill(ds, "id");
                dgv_kls.DataSource = ds;
                dgv_kls.DataMember = "id";
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
                coman.CommandText = "select * from tb_kelas where kelas like '" + cari2 + "%'";
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(coman);
                sda.Fill(ds, "kls");
                dgv_kls.DataSource = ds;
                dgv_kls.DataMember = "kls";
            }
            catch (Exception err)
            {
                MessageBox.Show("Data Tidak Ditemukan\n" + err.Message);
            }
        }
        private void dgv_kls_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_idKelas.Text = dgv_kls.CurrentRow.Cells[0].Value.ToString();
            tb_kls.Text = dgv_kls.CurrentRow.Cells[1].Value.ToString();
            
        }

        private void tabel_kelas()
        {
            dgv_kls.Columns[0].HeaderText = "ID Kelas";
            dgv_kls.Columns[0].Width = 70;
            dgv_kls.Columns[1].HeaderText = "Kelas";
            dgv_kls.Columns[1].Width = 200;

        }
        private bool tambah = false;
        private void bt_tambah_Click(object sender, EventArgs e)
        {
            tb_kls.Enabled = true;
            bersih_kelas();
            tambah = true;
            tb_idKelas.Text = kode;
            tb_idKelas.Enabled = true;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = MyData.Connection;
            cmd.CommandType = CommandType.Text;
        }

        private void fr_add_kelas_Activated(object sender, EventArgs e)
        {
            tabel_kelas();
        }
    }
}
