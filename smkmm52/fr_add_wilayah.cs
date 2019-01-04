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
    public partial class fr_add_wilayah : Form
    {
        public fr_add_wilayah()
        {
            InitializeComponent();
            InitializeCbProv1();
            InitializeCbKab1();
            InitializeCbKec1();

        }
        private string kode_prov
        {
            get
            {
                string kode = "PROV-0001";
                SqlCommand cmd = new SqlCommand
                ("select max(right(id_prov,4)) from tb_prov",
                MyData.Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader[0].ToString() != "")
                    kode = "PROV-" + (int.Parse(reader[0].ToString()) + 1).ToString("0000");

                reader.Close();
                return kode;
            }
        }
        private string kode_kab
        {
            get
            {
                string kode = "KAB-0001";
                SqlCommand cmd = new SqlCommand
                ("select max(right(id_kab,4)) from tb_kab",
                MyData.Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader[0].ToString() != "")
                    kode = "KAB-" + (int.Parse(reader[0].ToString()) + 1).ToString("0000");

                reader.Close();
                return kode;
            }
        }
        private string kode_kec
        {
            get
            {
                string kode = "KEC-0001";
                SqlCommand cmd = new SqlCommand
                ("select max(right(id_kec,4)) from tb_kec",
                MyData.Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader[0].ToString() != "")
                    kode = "KEC-" + (int.Parse(reader[0].ToString()) + 1).ToString("0000");

                reader.Close();
                return kode;
            }
        }
        private string kode_kel
        {
            get
            {
                string kode = "KEL-0001";
                SqlCommand cmd = new SqlCommand
                ("select max(right(id_kel,4)) from tb_kel",
                MyData.Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader[0].ToString() != "")
                    kode = "KEL-" + (int.Parse(reader[0].ToString()) + 1).ToString("0000");

                reader.Close();
                return kode;
            }
        }
        private void InitializeCbProv1()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select id_prov,provinsi from tb_prov", con);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                cb_prov.DataSource = dt;
                cb_prov.ValueMember = "id_prov";
                cb_prov.DisplayMember = "provinsi";
            }
            catch (Exception err)
            {
                MessageBox.Show("Gagal Koneksi\n" + err.Message);
            }
        }


        private void InitializeCbKab1()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select id_kab,kabupaten from tb_kab", con);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                cb_kab.DataSource = dt;
                cb_kab.ValueMember = "id_kab";
                cb_kab.DisplayMember = "kabupaten";
            }
            catch (Exception err)
            {
                MessageBox.Show("Gagal Koneksi\n" + err.Message);
            }
        }
        private void InitializeCbKec1()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select id_kec,kecamatan from tb_kec", con);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                cb_kec.DataSource = dt;
                cb_kec.ValueMember = "id_kec";
                cb_kec.DisplayMember = "kecamatan";
            }
            catch (Exception err)
            {
                MessageBox.Show("Gagal Koneksi\n" + err.Message);
            }
        }
        private void tampil_prov()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select * from tb_prov";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(coman);
            sda.Fill(ds, "prov");
            dgv_prov.DataSource = ds;
            dgv_prov.DataMember = "prov";
            tb_idprov.Focus();
        }
        private void tampil_kab()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select * from tb_kab";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(coman);
            sda.Fill(ds, "kab");
            dgv_kab.DataSource = ds;
            dgv_kab.DataMember = "kab";
            tb_idkab.Focus();
        }
        private void tampil_kec()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select * from tb_kec";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(coman);
            sda.Fill(ds, "kec");
            dgv_kec.DataSource = ds;
            dgv_kec.DataMember = "kec";
            tb_idkec.Focus();
        }
        private void tampil_kel()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select * from tb_kel";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(coman);
            sda.Fill(ds, "kel");
            dgv_kel.DataSource = ds;
            dgv_kel.DataMember = "kel";
            tb_idkel.Focus();
        }
        private void simpan_prov()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "insert into tb_prov values ('" + tb_idprov.Text + "','" + tb_prov.Text + "')";
            coman.ExecuteNonQuery();
            con.Close();
            tb_idprov.Enabled = true;
            tampil_prov();
        }
        private void simpan_kab()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "insert into tb_kab values('" + tb_idkab.Text + "','" + tb_kab.Text + "','" + tb_idp.Text + "')";
            coman.ExecuteNonQuery();
            con.Close();
            tb_idkab.Enabled = true;
            tampil_kab();
        }
        private void simpan_kec()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "insert into tb_kec values('" + tb_idkec.Text + "','" + tb_kec.Text + "','" + tb_idkb.Text + "')";
            coman.ExecuteNonQuery();
            con.Close();
            tb_idkec.Enabled = true;
            tampil_kec();
        }
        private void simpan_kel()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "insert into tb_kel values('" + tb_idkel.Text + "','" + tb_kel.Text + "','" + tb_idkc.Text + "')";
            coman.ExecuteNonQuery();
            con.Close();
            tb_idkel.Enabled = true;
            tampil_kel();
        }
        private void hapus_prov()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "delete from tb_prov where id_prov='" + tb_idprov.Text + "'";
            coman.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Apakah Anda Ingin Menghapus?", "Pilihan", MessageBoxButtons.YesNo);
            MessageBox.Show("Berhasil");
            tampil_prov();
            bersih_prov();
        }
        private void hapus_kab()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "delete from tb_kab where id_kab='" + tb_idkab.Text + "'";
            coman.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Apakah Anda Ingin Menghapus?", "Pilihan", MessageBoxButtons.YesNo);
            MessageBox.Show("Berhasil");
            tampil_kab();
            bersih_kab();
        }
        private void hapus_kec()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "delete from tb_kec where id_kec='" + tb_idkec.Text + "'";
            coman.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Apakah Anda Ingin Menghapus?", "Pilihan", MessageBoxButtons.YesNo);
            MessageBox.Show("Berhasil");
            tampil_kec();
            bersih_kec();
        }
        private void hapus_kel()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "delete from tb_kel where id_kel='" + tb_idkel.Text + "'";
            coman.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Apakah Anda Ingin Menghapus?", "Pilihan", MessageBoxButtons.YesNo);
            MessageBox.Show("Berhasil");
            tampil_kel();
            bersih_kel();
        }
        private void bersih_prov()
        {
            tb_idprov.Clear();
            tb_idprov.Clear();
            tampil_prov();
        }
        private void bersih_kab()
        {
            tb_idkab.Clear();
            tb_kab.Clear();
            tampil_kab();
        }
        private void bersih_kec()
        {
            tb_idkec.Clear();
            tb_kec.Clear();
            tampil_kab();
        }
        private void bersih_kel()
        {
            tb_idkel.Clear();
            tb_kel.Clear();
            tampil_kel();
        }
        private void ubah_prov()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "update tb_prov set prov='" + tb_prov.Text + "' where id_prov='" + tb_idprov.Text + "'";
            coman.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" Data Berhasil Berubah");
            tampil_prov();
            bersih_prov();
            tb_idprov.Enabled = true;
        }
        private void ubah_kab()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "update  tb_kab set kabupaten='" + tb_kab.Text + "',provinsi='" + cb_prov.Text + "'where id_kab='" + tb_idkab.Text + "'";
            coman.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" Data Berhasil Berubah");
            tampil_kab();
            bersih_kab();
            tb_idkab.Enabled = true;
        }
        private void ubah_kec()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "update  tb_kec set kecamatan='" + tb_kec.Text + "',kabupaten='" + cb_kab.Text + "'where id_kec='" + tb_idkec.Text + "'";
            coman.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" Data Berhasil Berubah");
            tampil_kec();
            bersih_kec();
            tb_idkec.Enabled = true;
        }
        private void ubah_kel()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "update  tb_kel set kelurahan='" + tb_kel.Text + "',kecamatan='" + cb_kec.Text + "'where id_kel='" + tb_idkel.Text + "'";
            coman.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" Data Berhasil Berubah");
            tampil_kel();
            bersih_kel();
            tb_idkel.Enabled = true;
        }

        private void fr_add_wilayah_Load(object sender, EventArgs e)
        {
            tb_idprov.Text = kode_prov;
            tb_idkab.Text = kode_kab;
            tb_idkec.Text = kode_kec;
            tb_idkel.Text = kode_kel;
            tb_idprov.Enabled = false;
            tb_prov.Enabled = false;
            tb_idkab.Enabled = false;
            tb_kab.Enabled = false;
            tb_idkec.Enabled = false;
            tb_kec.Enabled = false;
            tb_idkel.Enabled = false;
            tb_kel.Enabled = false;
            cb_prov.Enabled = false;
            cb_kab.Enabled = false;
            cb_kec.Enabled = false;
            tb_idp.Enabled = false;
            tb_idkb.Enabled = false;
            tb_idkc.Enabled = false;
            tampil_prov();
            tampil_kab();
            tampil_kec();
            tampil_kel();
        }

        private void bt_simpan_Click(object sender, EventArgs e)
        {
            if (tb_idkab.Text == "")
            {
                MessageBox.Show("Isikan ID Kabupaten!");
                tb_idkab.Focus();
            }
            else if (tb_kab.Text == "")
            {
                MessageBox.Show("Isikan Kabupaten!");
                tb_kab.Focus();
            }
            else
            {
                MessageBox.Show("Tersimpan");
                simpan_kab();
                tampil_kab();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tb_idkec.Text == "")
            {
                MessageBox.Show("Isikan ID Kecamatan!");
                tb_idkec.Focus();
            }
            else if (tb_kec.Text == "")
            {
                MessageBox.Show("Isikan Kecamatan!");
                tb_kec.Focus();
            }
            else
            {
                MessageBox.Show("Tersimpan");
                simpan_kec();
                tampil_kec();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (tb_idkel.Text == "")
            {
                MessageBox.Show("Isikan ID Kelurahan!");
                tb_idkel.Focus();
            }
            else if (tb_kel.Text == "")
            {
                MessageBox.Show("Isikan Kelurahan!");
                tb_kel.Focus();
            }
            else
            {
                MessageBox.Show("Tersimpan");
                simpan_kel();
                tampil_kel();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (tb_idprov.Text == "")
            {
                MessageBox.Show("Isikan ID Provinsi!");
                tb_idprov.Focus();
            }
            else if (tb_prov.Text == "")
            {
                MessageBox.Show("Isikan Provinsi!");
                tb_prov.Focus();
            }
            else
            {
                MessageBox.Show("Tersimpan");
                simpan_prov();
                tampil_prov();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (tb_idprov.Text != "" && tb_prov.Text != "")
            {
                ubah_prov();
                MessageBox.Show("Data Berhasil Terupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tampil_prov();

            }
            else
            {
                MessageBox.Show("Data Gagal Terupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {

            if (tb_idp.Text != "" && cb_prov.Text != "" && tb_idkab.Text != "" && tb_kab.Text !="")
            {
                ubah_kab();
                MessageBox.Show("Data Berhasil Terupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tampil_kab();

            }
            else
            {
                MessageBox.Show("Data Gagal Terupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tb_idkb.Text != "" && cb_kab.Text != "" && tb_idkec.Text != "" && tb_kec.Text != "")
            {
                ubah_kec();
                MessageBox.Show("Data Berhasil Terupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tampil_kec();

            }
            else
            {
                MessageBox.Show("Data Gagal Terupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tb_idkc.Text != "" && cb_kec.Text != "" && tb_idkel.Text != "" && tb_kel.Text != "")
            {
                ubah_kel();
                MessageBox.Show("Data Berhasil Terupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tampil_kel();

            }
            else
            {
                MessageBox.Show("Data Gagal Terupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda Ingin Menghapus Data Ini?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                ) == DialogResult.Yes)
            {
                try
                {
                    hapus_prov();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Gagal Hapus\n" + err.Message);
                }
            }
        }

        private void bt_hapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda Ingin Menghapus Data Ini?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                ) == DialogResult.Yes)
            {
                try
                {
                    hapus_kab();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Gagal Hapus\n" + err.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda Ingin Menghapus Data Ini?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                ) == DialogResult.Yes)
            {
                try
                {
                    hapus_kec();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Gagal Hapus\n" + err.Message);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda Ingin Menghapus Data Ini?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                ) == DialogResult.Yes)
            {
                try
                {
                    hapus_kel();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Gagal Hapus\n" + err.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_prov_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_idprov.Text = dgv_prov.CurrentRow.Cells[0].Value.ToString();
            tb_prov.Text = dgv_prov.CurrentRow.Cells[1].Value.ToString();
        }

        private void tab_pro()
        {
            dgv_prov.Columns[0].HeaderText = "ID Provinsi";
            dgv_prov.Columns[0].Width = 90;
            dgv_prov.Columns[1].HeaderText = "Provinsi";
            dgv_prov.Columns[1].Width = 160;
        }

        private void dgv_kab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_idkab.Text = dgv_kab.CurrentRow.Cells[0].Value.ToString();
            tb_kab.Text = dgv_kab.CurrentRow.Cells[1].Value.ToString();
            tb_idp.Text = dgv_kab.CurrentRow.Cells[2].Value.ToString();
        }

        private void tab_kab()
        {
            dgv_kab.Columns[0].HeaderText = "ID Kabupaten";
            dgv_kab.Columns[0].Width = 110;
            dgv_kab.Columns[1].HeaderText = "Kabupaten";
            dgv_kab.Columns[1].Width = 160;
            dgv_kab.Columns[1].HeaderText = "Kabupaten";
            dgv_kab.Columns[1].Width = 160;
            dgv_kab.Columns[2].HeaderText = "ID Provinsi";
            dgv_kab.Columns[2].Width = 90;
        }
        private void dgv_kec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_idkec.Text = dgv_kec.CurrentRow.Cells[0].Value.ToString();
            tb_kec.Text = dgv_kec.CurrentRow.Cells[1].Value.ToString();
            tb_idkb.Text = dgv_kec.CurrentRow.Cells[2].Value.ToString();
        }

        private void tab_kec()
        {
            dgv_kec.Columns[0].HeaderText = "ID Kecamatan";
            dgv_kec.Columns[0].Width = 110;
            dgv_kec.Columns[1].HeaderText = "Kecamatan";
            dgv_kec.Columns[1].Width = 160;
            dgv_kec.Columns[2].HeaderText = "ID Kabupaten";
            dgv_kec.Columns[2].Width = 110;
        }
        private void dgv_kel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_idkel.Text = dgv_kel.CurrentRow.Cells[0].Value.ToString();
            tb_kel.Text = dgv_kel.CurrentRow.Cells[1].Value.ToString();
            tb_idkc.Text = dgv_kel.CurrentRow.Cells[2].Value.ToString();
        }

       private void tab_kel()
        {
            dgv_kel.Columns[0].HeaderText = "ID Kelurahan";
            dgv_kel.Columns[0].Width = 110;
            dgv_kel.Columns[1].HeaderText = "Kelurahan";
            dgv_kel.Columns[1].Width = 160;
            dgv_kel.Columns[2].HeaderText = "ID Kecamatan";
            dgv_kel.Columns[2].Width = 110;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tampil_prov();
            tampil_kab();
            tampil_kel();
            tampil_kec();
        }
        private bool tambah_prov = false;
        private void bt_tbhprov_Click(object sender, EventArgs e)
        {
            tb_idprov.Enabled = true;
            tb_prov.Enabled = true;
            bersih_prov();
            tambah_prov = true;
            tb_idprov.Text = kode_prov;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = MyData.Connection;
            cmd.CommandType = CommandType.Text;
            tb_idprov.Text = kode_prov;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tb_idprov.Enabled = true;
            tb_prov.Enabled = true;
            tb_idkab.Enabled = true;
            tb_kab.Enabled = true;
            tb_idkec.Enabled = true;
            tb_kec.Enabled = true;
            tb_idkel.Enabled = true;
            tb_kel.Enabled = true;
            cb_prov.Enabled = true;
            cb_kab.Enabled = true;
            cb_kec.Enabled = true;
            tampil_prov();
            tampil_kab();
            tampil_kec();
            tampil_kel();
            bersih_prov();
            bersih_kab();
            bersih_kec();
            bersih_kel();
        }
        private bool tambah_kab = false;
        private void bt_tbhkab_Click(object sender, EventArgs e)
        {
            tb_idkab.Enabled = true;
            tb_kab.Enabled = true;
            cb_prov.Enabled = true;
            bersih_kab();
            tambah_prov = true;
            tb_idkab.Text = kode_kab;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = MyData.Connection;
            cmd.CommandType = CommandType.Text;
            tb_idkab.Text = kode_kab;
        }
        private bool tambah_kec = false;
        private void bt_tbhkec_Click(object sender, EventArgs e)
        {
            tb_idkec.Enabled = true;
            tb_kec.Enabled = true;
            cb_kab.Enabled = true;
            bersih_kec();
            tambah_kec = true;
            tb_idkec.Text = kode_kec;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = MyData.Connection;
            cmd.CommandType = CommandType.Text;
            tb_idkec.Text = kode_kec;
        }
        private bool tambah_kel = false;
        private void bt_tbhkel_Click(object sender, EventArgs e)
        {
            tb_idkel.Enabled = true;
            tb_kel.Enabled = true;
            cb_kec.Enabled = true;
            bersih_kel();
            tambah_kel = true;
            tb_idkel.Text = kode_kel;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = MyData.Connection;
            cmd.CommandType = CommandType.Text;
            tb_idkel.Text = kode_kel;
        }

        private void cb_prov_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con;
            con = koneksi.conn;
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select * from tb_prov where provinsi='" + cb_prov.Text + "'";
            SqlDataReader dbr;
            try
            {
                con.Open();
                dbr = coman.ExecuteReader();
                while (dbr.Read())
                {
                    string kode = (string)dbr["id_prov"];
                    tb_idp.Text = kode;

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Gagal Tampil\n" + err.Message);
            }
        }

        private void cb_kab_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con;
            con = koneksi.conn;
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select * from tb_kab where kabupaten='" + cb_kab.Text + "'";
            SqlDataReader dbr;
            try
            {
                con.Open();
                dbr = coman.ExecuteReader();
                while (dbr.Read())
                {
                    string kode = (string)dbr["id_kab"];
                    tb_idkb.Text = kode;

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Gagal Tampil\n" + err.Message);
            }
        }

        private void cb_kec_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con;
            con = koneksi.conn;
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select * from tb_kec where kecamatan='" + cb_kec.Text + "'";
            SqlDataReader dbr;
            try
            {
                con.Open();
                dbr = coman.ExecuteReader();
                while (dbr.Read())
                {
                    string kode = (string)dbr["id_kec"];
                    tb_idkc.Text = kode;

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Gagal Tampil\n" + err.Message);
            }
        }

        private void tb_idp_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con;
            con = koneksi.conn;
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select * from tb_prov where id_prov='" + tb_idp.Text + "'";
            SqlDataReader dbr;
            try
            {
                con.Open();
                dbr = coman.ExecuteReader();
                while (dbr.Read())
                {
                    string kode = (string)dbr["provinsi"];
                    cb_prov.Text = kode;

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Gagal Tampil\n" + err.Message);
            }
        }

        private void tb_idkb_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con;
            con = koneksi.conn;
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select * from tb_kab where id_kab='" + tb_idkb.Text + "'";
            SqlDataReader dbr;
            try
            {
                con.Open();
                dbr = coman.ExecuteReader();
                while (dbr.Read())
                {
                    string kode = (string)dbr["kabupaten"];
                    cb_kab.Text = kode;

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Gagal Tampil\n" + err.Message);
            }
        }

        private void tb_idkc_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con;
            con = koneksi.conn;
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select * from tb_kec where id_kec='" + tb_idkc.Text + "'";
            SqlDataReader dbr;
            try
            {
                con.Open();
                dbr = coman.ExecuteReader();
                while (dbr.Read())
                {
                    string kode = (string)dbr["kecamatan"];
                    cb_kec.Text = kode;

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Gagal Tampil\n" + err.Message);
            }
        }

        private void fr_add_wilayah_Activated(object sender, EventArgs e)
        {
            tab_pro();
            tab_kab();
            tab_kec();
            tab_kel();
        }
        
    }
}
