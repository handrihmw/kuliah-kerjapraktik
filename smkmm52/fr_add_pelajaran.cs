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
    public partial class fr_add_pelajaran : Form
    {
        public fr_add_pelajaran()
        {
            InitializeComponent();
        }
        private string kode
        {
            get
            {
                string kode = "PLJ-01";
                SqlCommand cmd = new SqlCommand
                ("select max(right(id_pelajaran,2)) from tb_pelajaran",
                MyData.Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader[0].ToString() != "")
                    kode = "PLJ-" + (int.Parse(reader[0].ToString()) + 1).ToString("00");
                reader.Close();
                return kode;
            }
        }

        private void tampil_pelajaran()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select * from tb_pelajaran";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(coman);
            sda.Fill(ds, "pelajaran");
            dgv_plj.DataSource = ds;
            dgv_plj.DataMember = "pelajaran";
            tb_idpel.Focus();
        }


        private void simpan_pelajaran()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "insert into tb_pelajaran values('" + tb_idpel.Text + "','" + tb_pel.Text + "','" + cb_tipe.Text + "')";
            coman.ExecuteNonQuery();
            con.Close();
            tb_pel.Enabled = true;
            tampil_pelajaran();
        }

        private void hapus_pelajaran()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "delete from tb_pelajaran where id_pelajaran='" + tb_idpel.Text + "'";
            coman.ExecuteNonQuery();
            con.Close();
            tampil_pelajaran();
            bersih_pelajaran();
        }

        private void bersih_pelajaran()
        {
            tb_pel.Clear();
            tb_idpel.Clear();
            tampil_pelajaran();
        }

        private void ubah_pelajaran()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "update  tb_pelajaran set pelajaran='" + tb_pel.Text + "',tipe='" + cb_tipe.Text +
                "' where id_pelajaran='" + tb_idpel.Text + "'";
            coman.ExecuteNonQuery(); ;
            coman.ExecuteNonQuery();
            con.Close();
            tampil_pelajaran();
            bersih_pelajaran();
        }
        private void fr_add_pelajaran_Load(object sender, EventArgs e)
        {
            tb_idpel.Text = kode;
            tampil_pelajaran();
            tb_idpel.Enabled = false;
            tb_pel.Enabled = false;
            cb_tipe.Enabled = false;
        }

        private void bt_simpan_Click(object sender, EventArgs e)
        {
            if (tb_idpel.Text == "")
            {
                MessageBox.Show("Isikan ID Pelajaran!");
                tb_idpel.Focus();
            }
            else if (tb_pel.Text == "")
            {
                MessageBox.Show("Isikan Pelajaran!");
                tb_pel.Focus();
            }
            else if (cb_tipe.Text == "")
            {
                MessageBox.Show("Isikan Tipe Pelajaran!");
                cb_tipe.Focus();
            }
            else
            {
                string query = "select * from tb_pelajaran where id_pelajaran='" + tb_idpel.Text + "'";
                if (!fungsi.cekdata(query))
                {
                    query = "insert into tb_pelajaran values('" + tb_idpel.Text + "','" + tb_pel.Text + "','" + cb_tipe.Text + "')";
                    
                    int x = fungsi.Equery(query);
                    if (x == 1)
                    {
                        MessageBox.Show("Data Berhasil Tersimpan");
                        tampil_pelajaran();
                    }
                    else
                    {
                        MessageBox.Show("Data Gagal Tersimpan");
                    }
                }
                else
                {
                    MessageBox.Show("ID Pelajaran Telah Terdaftar",tb_idpel.Text);
                    tb_idpel.Focus();
                    tampil_pelajaran();
                }
            }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            if (tb_idpel.Text != "" && tb_pel.Text != "" && cb_tipe.Text != "")
            {
               ubah_pelajaran();
               MessageBox.Show("Data Berhasil Terupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
               tampil_pelajaran();
               
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
                    hapus_pelajaran();
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

        private void dgv_plj_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_idpel.Text = dgv_plj.CurrentRow.Cells[0].Value.ToString();
            tb_pel.Text = dgv_plj.CurrentRow.Cells[1].Value.ToString();
            cb_tipe.Text = dgv_plj.CurrentRow.Cells[2].Value.ToString();
        }

        private void tabel_plajaran()
        {
            dgv_plj.Columns[0].HeaderText = "ID Pelajaran";
            dgv_plj.Columns[0].Width = 90;
            dgv_plj.Columns[1].HeaderText = "Pelajaran";
            dgv_plj.Columns[1].Width = 150;
            dgv_plj.Columns[2].HeaderText = "Tipe";
            dgv_plj.Columns[2].Width = 100;
        }
        private bool tambah = false;
        private void bt_tambah_Click(object sender, EventArgs e)
        {
            tb_idpel.Enabled = true;
            tb_pel.Enabled = true;
            cb_tipe.Enabled = true;
            bersih_pelajaran();
            tambah = true;
            tb_idpel.Text = kode;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = MyData.Connection;
            cmd.CommandType = CommandType.Text;
            tb_idpel.Text = kode;
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            tb_idpel.Enabled = true;
            tb_pel.Enabled = true;
            cb_tipe.Enabled = true;
            tampil_pelajaran();
            bersih_pelajaran();
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
                coman.CommandText = "select * from tb_pelajaran where id_pelajaran like '" + cari + "%'";
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(coman);
                sda.Fill(ds, "pelajaran");
                dgv_plj.DataSource = ds;
                dgv_plj.DataMember = "pelajaran";
            }
            catch (Exception err)
            {
                MessageBox.Show("Data Tidak Ditemukan\n" + err.Message);
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
                coman.CommandText = "select * from tb_pelajaran where pelajaran like '" + cari + "%'";
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(coman);
                sda.Fill(ds, "pelajaran");
                dgv_plj.DataSource = ds;
                dgv_plj.DataMember = "pelajaran";
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
                coman.CommandText = "select * from tb_pelajaran where tipe like '" + cari3 + "%'";
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(coman);
                sda.Fill(ds, "kls");
                dgv_plj.DataSource = ds;
                dgv_plj.DataMember = "kls";
            }
            catch (Exception err)
            {
                MessageBox.Show("Data Tidak Ditemukan\n" + err.Message);
            }
        }

        private void fr_add_pelajaran_Activated(object sender, EventArgs e)
        {
            tabel_plajaran();
        }
    }
}
