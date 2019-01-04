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
using System.Text.RegularExpressions;

namespace smkmm52
{
    public partial class fr_add_guru : Form
    {
        public fr_add_guru()
        {
            InitializeComponent();
        }
        public String jk;
        public int kondisi;

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
    private void tampil_guru()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select * from tb_guru";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(coman);
            sda.Fill(ds, "guru");
            dgv_guru.DataSource = ds;
            dgv_guru.DataMember = "guru";
        }

        private void simpan_guru()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "insert into tb_guru values('" + tb_nip.Text +
                "','" + tb_nmguru.Text +
                "','" + jk +
                "','" + cb_agama.Text +
                "','" + rtb_tpt.Text +
                "','" + dt_lhr.Value.ToString("yyyy-MM-dd") +
                "','" + rtb_alamat.Text +
                "','" + tb_kel.Text +
                "','" + tb_kec.Text +
                "','" + tb_kab.Text +
                "','" + tb_prov.Text +
                "','" + cb_sttm.Text +
                "','" + cb_sttk.Text +
                "','" + tb_jbt.Text +
                "','" + tb_hp.Text +
                "','" + tb_email.Text + "')";

            coman.ExecuteNonQuery();
            con.Close();
            tb_nip.Enabled = true;
            tb_nip.Focus();
        }
        public void edit_guru()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "update tb_guru set nm_guru='" + tb_nmguru.Text +
                "',jk='" + jk +
                "',agama='" + cb_agama.Text +
                "',tpt_lhr='" + rtb_tpt.Text +
                "',tgl_lhr='" + dt_lhr.Value.ToString("yyyy-MM-dd") +
                "',alamat='" + rtb_alamat.Text +
                "',prov='" + tb_prov.Text +
                "',kab='" + tb_kab.Text +
                "',kec='" + tb_kec.Text +
                "',kel='" + tb_kel.Text +
                "',stts_menikah='" + cb_sttm.Text +
                "',stts_kepegawaian='" + cb_sttk.Text +
                "',jabatan='" + tb_jbt.Text +
                "',no_hp_guru='" + tb_hp.Text +
                "',email='" + tb_email.Text +
                "'where nip='" + tb_nip.Text + "'";

            coman.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil Terupdate");
            tb_nip.Enabled = true;
        }
        private void bersih_guru()
        {
            tb_nip.Clear();
            tb_nmguru.Clear();
            rtb_tpt.Clear();
            rtb_alamat.Clear();
            tb_prov.Clear();
            tb_kab.Clear();
            tb_kec.Clear();
            tb_kel.Clear();
            tb_jbt.Clear();
            tb_hp.Clear();
            tb_email.Clear();

        }
        private void hapus_guru()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "delete from tb_guru where nip='" + tb_nip.Text + "'";
            coman.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil Terhapus");
            tampil_guru();
            bersih_guru();
        }
        private void fr_add_guru_Load(object sender, EventArgs e)
        {
            provinsi();
            kabupaten();
            kecamatan();
            kelurahan();
            
            tb_nip.Enabled = false;
            tb_nmguru.Enabled = false;
            cb_agama.Enabled = false;
            rtb_tpt.Enabled = false;
            dt_lhr.Enabled = false;
            rtb_alamat.Enabled = false;
            tb_kel.Enabled = false;
            tb_kec.Enabled = false;
            tb_kab.Enabled = false;
            tb_prov.Enabled = false;
            cb_sttm.Enabled = false;
            cb_sttk.Enabled = false;
            tb_jbt.Enabled = false;
            tb_hp.Enabled = false;
            tb_email.Enabled = false;
            bt_load.Enabled = false;
            bt_print.Enabled = false;
            tampil_guru();
        }

        private void bt_simpan_Click(object sender, EventArgs e)
        {
            if (tb_nip.Text == "" || tb_nmguru.Text == "" || rtb_alamat.Text == "" || tb_prov.Text == "" || tb_kab.Text == "" ||
                tb_kec.Text == "" || tb_kel.Text == "" || rtb_tpt.Text == "" || tb_jbt.Text == "" || tb_hp.Text == "" || tb_email.Text == "")
            {
                MessageBox.Show("Data (*) Tidak Boleh Kosong", "Info", MessageBoxButtons.OK);
            }
            else
            {
                string query = "select * from tb_guru where nip='" + tb_nip.Text + "'";
                if (!fungsi.cekdata(query))
                {
                    query = "insert into tb_guru values('" + tb_nip.Text +
                "','" + tb_nmguru.Text +
                "','" + jk +
                "','" + cb_agama.Text +
                "','" + rtb_tpt.Text +
                "','" + dt_lhr.Value.ToString("yyyy-MM-dd") +
                "','" + rtb_alamat.Text +
                "','" + tb_prov.Text +
                "','" + tb_kab.Text +
                "','" + tb_kec.Text +
                "','" + tb_kel.Text +
                "','" + cb_sttm.Text +
                "','" + cb_sttk.Text +
                "','" + tb_jbt.Text +
                "','" + tb_hp.Text +
                "','" + tb_email.Text + "')";

                    int x = fungsi.Equery(query);
                    if (x == 1)
                    {
                        MessageBox.Show("Data Berhasil Tersimpan");
                        tampil_guru();
                    }
                    else
                    {
                        MessageBox.Show("Data Gagal Tersimpan");
                    }
                }
                else
                {
                    MessageBox.Show("NIP Telah Terdaftar", tb_nip.Text);
                    tb_nip.Focus();
                    tampil_guru();
                }
            }
        }


        private void bt_update_Click(object sender, EventArgs e)
        {
            if (tb_nip.Text != "" && tb_nmguru.Text != "" && rtb_alamat.Text != "" && tb_prov.Text != "" && tb_kab.Text != "" &&
                tb_kec.Text != "" && tb_kel.Text != "" && rtb_tpt.Text != "" && tb_jbt.Text != "" && tb_hp.Text != "" && tb_email.Text != "")
            {
                edit_guru();
                MessageBox.Show("Data Berhasil Terupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tampil_guru();

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
                    hapus_guru();
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

        private void dgv_guru_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_nip.Text = dgv_guru.CurrentRow.Cells[0].Value.ToString();
            tb_nmguru.Text = dgv_guru.CurrentRow.Cells[1].Value.ToString();
            jk = dgv_guru.CurrentRow.Cells[2].Value.ToString();
            cb_agama.Text = dgv_guru.CurrentRow.Cells[3].Value.ToString();
            rtb_tpt.Text = dgv_guru.CurrentRow.Cells[4].Value.ToString();
            dt_lhr.Value = DateTime.Parse(dgv_guru.CurrentRow.Cells[5].Value.ToString());
            rtb_alamat.Text = dgv_guru.CurrentRow.Cells[6].Value.ToString();
            tb_prov.Text = dgv_guru.CurrentRow.Cells[7].Value.ToString();
            tb_kab.Text = dgv_guru.CurrentRow.Cells[8].Value.ToString();
            tb_kec.Text = dgv_guru.CurrentRow.Cells[9].Value.ToString();
            tb_kel.Text = dgv_guru.CurrentRow.Cells[10].Value.ToString();
            cb_sttm.Text = dgv_guru.CurrentRow.Cells[11].Value.ToString();
            cb_sttk.Text = dgv_guru.CurrentRow.Cells[12].Value.ToString();
            tb_jbt.Text = dgv_guru.CurrentRow.Cells[13].Value.ToString();
            tb_hp.Text = dgv_guru.CurrentRow.Cells[14].Value.ToString();
            tb_email.Text = dgv_guru.CurrentRow.Cells[15].Value.ToString();
     
        }

        private void tabel_guru()
        {
            dgv_guru.Columns[0].HeaderText = "NIP";
            dgv_guru.Columns[0].Width = 110;
            dgv_guru.Columns[1].HeaderText = "Nama Guru";
            dgv_guru.Columns[1].Width = 130;
            dgv_guru.Columns[2].HeaderText = "JK";
            dgv_guru.Columns[2].Width = 30;
            dgv_guru.Columns[3].HeaderText = "Agama";
            dgv_guru.Columns[3].Width = 90;
            dgv_guru.Columns[4].HeaderText = "Tempat Lahir";
            dgv_guru.Columns[4].Width = 110;
            dgv_guru.Columns[5].HeaderText = "Tanggal Lahir";
            dgv_guru.Columns[5].Width = 120;
            dgv_guru.Columns[6].HeaderText = "Alamat";
            dgv_guru.Columns[6].Width = 110;
            dgv_guru.Columns[7].HeaderText = "Provinsi";
            dgv_guru.Columns[7].Width = 110;
            dgv_guru.Columns[8].HeaderText = "Kabupaten";
            dgv_guru.Columns[8].Width = 110;
            dgv_guru.Columns[9].HeaderText = "Kecamatan";
            dgv_guru.Columns[9].Width = 110;
            dgv_guru.Columns[10].HeaderText = "Kelurahan";
            dgv_guru.Columns[10].Width = 110;
            dgv_guru.Columns[11].HeaderText = "Status Menikah";
            dgv_guru.Columns[11].Width = 110;
            dgv_guru.Columns[12].HeaderText = "Status Kepegawaian";
            dgv_guru.Columns[12].Width = 130;
            dgv_guru.Columns[13].HeaderText = "Jabatan";
            dgv_guru.Columns[13].Width = 110;
            dgv_guru.Columns[14].HeaderText = "No. Handphone";
            dgv_guru.Columns[14].Width = 110;
            dgv_guru.Columns[15].HeaderText = "Email";
            dgv_guru.Columns[15].Width = 130;

        }
        private void rb_lk_CheckedChanged(object sender, EventArgs e)
        {
            jk = "L";
        }

        private void rb_pr_CheckedChanged(object sender, EventArgs e)
        {
            jk = "P";
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
                coman.CommandText = "select * from tb_guru where nip like '" + cari1 + "%'";
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(coman);
                sda.Fill(ds, "nip");
                dgv_guru.DataSource = ds;
                dgv_guru.DataMember = "nip";

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
                coman.CommandText = "select * from tb_guru where nm_guru like '" + cari2 + "%'";
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(coman);
                sda.Fill(ds, "nm_guru");
                dgv_guru.DataSource = ds;
                dgv_guru.DataMember = "nm_guru";

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
                coman.CommandText = "select * from tb_guru where jabatan like '" + cari3 + "%'";
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(coman);
                sda.Fill(ds, "jabatan");
                dgv_guru.DataSource = ds;
                dgv_guru.DataMember = "jabatan";

            }
            catch (Exception err)
            {
                MessageBox.Show("Data Tidak Ditemukan\n" + err.Message);
            }
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            tb_nip.Enabled = true;
            tb_nmguru.Enabled = true;
            cb_agama.Enabled = true;
            rtb_tpt.Enabled = true;
            rtb_alamat.Enabled = true;
            tb_kel.Enabled = true;
            tb_kec.Enabled = true;
            tb_kab.Enabled = true;
            tb_prov.Enabled = true;
            cb_sttm.Enabled = true;
            cb_sttk.Enabled = true;
            tb_jbt.Enabled = true;
            tb_hp.Enabled = true;
            tb_email.Enabled = true;
            dt_lhr.Enabled = true;
            tampil_guru();
            bersih_guru();
        }

        private void bt_tambah_Click(object sender, EventArgs e)
        {
            tb_nip.Enabled = true;
            tb_nmguru.Enabled = true;
            cb_agama.Enabled = true;
            rtb_tpt.Enabled = true;
            rtb_alamat.Enabled = true;
            tb_kel.Enabled = true;
            tb_kec.Enabled = true;
            tb_kab.Enabled = true;
            tb_prov.Enabled = true;
            cb_sttm.Enabled = true;
            cb_sttk.Enabled = true;
            tb_jbt.Enabled = true;
            tb_hp.Enabled = true;
            tb_email.Enabled = true;
            dt_lhr.Enabled = true;
            bersih_guru();
        }

        private void fr_add_guru_Activated(object sender, EventArgs e)
        {
            tabel_guru();
        }

        private void tb_nip_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Masukan NIP Dengan Benar !");
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

        Boolean checkemail(String value)
        {
            string pattern = @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$";

            if (Regex.Match(value, pattern).Success)
            {
                return
                    true;
            }
            else
            {
                return
                    false;
            }
        }

        private void tb_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (checkemail(tb_email.Text) == true)
                {
                    MessageBox.Show("Email Valid", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                MessageBox.Show("Email Tidak Valid", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        internal void SetDataSource(DataSet ds)
        {
            throw new NotImplementedException();
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

        private void bt_load_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection MyConnection;
            System.Data.DataSet DtSet;
            System.Data.OleDb.OleDbDataAdapter MyCommand;
            MyConnection = new System.Data.OleDb.OleDbConnection(@"provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + tb_file.Text + ";Extended Properties=Excel 8.0;");
            MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection);
            MyCommand.TableMappings.Add("Table", "Net-informations.com");
            DtSet = new System.Data.DataSet();
            MyCommand.Fill(DtSet);
            dgv_guru.DataSource = DtSet.Tables[0];
            MyConnection.Close();
        }
    }
}
