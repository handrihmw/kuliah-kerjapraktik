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
    public partial class fr_konfigurasi : Form
    {
        public fr_konfigurasi()
        {
            InitializeComponent();
            initializeCbKls();
        }
        public String jk;
        private string kode
        {
            get
            {
                string kode = "AK-01";
                SqlCommand cmd = new SqlCommand
                ("select max(right(id_anggota,2)) from tb_anggota_kelas",
                MyData.Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader[0].ToString() != "")
                    kode = "AK-" + (int.Parse(reader[0].ToString()) + 1).ToString("00");

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
        private void tampil_siswa()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select nipd,nik,nisn,skhun,nm_siswa,jk,agama,tpt_lhr,tgl_lhr,alamat,kel,kec,kab,prov,penerima_kps,no_kps,no_hp_siswa,email,jurusan,thn_ajaran from tb_siswa";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(coman);
            sda.Fill(ds, "siswa");
            dgv_dsb.DataSource = ds;
            dgv_dsb.DataMember = "siswa";

        }
        private void tampil_anggota()
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
            sda.Fill(ds, "anggota");
            dgv_anggota.DataSource = ds;
            dgv_anggota.DataMember = "anggota";

        }
        
        private void simpan_anggota()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "insert into tb_anggota_kelas values('" + tb_idak.Text + 
                "','" + tb_nipd.Text +
                "','" + tb_nmsiswa.Text +
                "','" + jk +
                "','" + cb_jurusans.Text +
                "','" + thn_ajarans.Text +
                "','" + cb_kls.Text +
                "','" + tb_semester.Text +"')";
            coman.ExecuteNonQuery();
            con.Close();
            tb_idak.Enabled = true;
        }

        private void edit_anggota()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "update tb_anggota_kelas set nipd='" + tb_nipd.Text +
                "',nm_siswa='" + tb_nmsiswa.Text +
                "',jk='" + jk +
                "',jurusan='" + cb_jurusans.Text +
                "',thn_ajaran='" + thn_ajarans.Text +
                "',kelas='" + cb_kls.Text +
                "',semester='" + tb_semester.Text +
                "'where id_anggota='"+ tb_idak.Text +"'";
            coman.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Anggota Berhasil Diubah");
            tb_idak.Enabled = true;
            tampil_anggota();
        }
        private void bersih_anggota()
        {

            tb_idak.Clear();
            tb_nipd.Clear();
            tb_nmsiswa.Clear();
            thn_ajarans.Clear();
            tb_semester.Clear();

        }
        private void hapus_anggota()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "delete from tb_anggota_kelas where id_anggota='" + tb_idak.Text + "'";
            coman.ExecuteNonQuery();
            con.Close();
            tampil_anggota();
            bersih_anggota();
        }
        public void addItems(AutoCompleteStringCollection col)
        {
            col.Add("2016 / 2017");
            col.Add("2017 / 2018");
            col.Add("2018 / 2019");
            col.Add("2019 / 2020");
        }
        private void fr_konfigurasi_Load(object sender, EventArgs e)
       {
           /*Tahun Ajaran Otomatis*/
           tb_thn.AutoCompleteMode = AutoCompleteMode.Suggest;
           tb_thn.AutoCompleteSource = AutoCompleteSource.CustomSource;
           tb_thn1.AutoCompleteMode = AutoCompleteMode.Suggest;
           tb_thn1.AutoCompleteSource = AutoCompleteSource.CustomSource;
           thn_ajarans.AutoCompleteMode = AutoCompleteMode.Suggest;
           thn_ajarans.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
           AutoCompleteStringCollection DataCollction = new AutoCompleteStringCollection();
           addItems(DataCollction);
           tb_thn.AutoCompleteCustomSource = DataCollction;
           tb_thn1.AutoCompleteCustomSource = DataCollction;
           thn_ajarans.AutoCompleteCustomSource = DataCollction;

            tampil_siswa();
            
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select nipd from tb_siswa";
            SqlDataReader reader = coman.ExecuteReader();
            AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                mycollection.Add(reader.GetString(0));
            }
            tb_nipd.AutoCompleteCustomSource = mycollection;
            con.Close();
       }

        private void bt_kembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

          private void bt_proses_Click(object sender, EventArgs e)
          {
              tb_idak.Enabled = true;
              tb_nipd.Enabled = true;
              tb_nmsiswa.Enabled = true;
              cb_jurusans.Enabled = true;
              thn_ajarans.Enabled = true;
              cb_kls.Enabled = true;
              dgv_ak.Enabled = true;
              bt_simpananggota.Enabled = true;

              try
              {
                  SqlConnection con;
                  con = koneksi.conn;
                  SqlCommand coman = new SqlCommand();
                  coman.Connection = con;
                  coman.CommandType = CommandType.Text;
                  coman.CommandText = "SELECT TOP " + (Convert.ToInt32(tb_jml.Text))+ " nipd,nm_siswa,jk,jurusan,thn_ajaran FROM dbo.tb_siswa WHERE (((tb_siswa.thn_ajaran)='"+tb_thn.Text+"' AND jurusan= '"+cb_jurusan.Text+"'))";
                  DataSet ds = new DataSet();
                  SqlDataAdapter sda = new SqlDataAdapter(coman);
                  sda.Fill(ds, "ak");
                  dgv_ak.DataSource = ds;
                  dgv_ak.DataMember = "ak";

              }
              catch (Exception err)
              {
                  MessageBox.Show("Data Tidak ada\n" + err.Message);
                  cb_jurusan.Focus();
              }
              tab_ak();
          }
          private void bt_ket_Click(object sender, EventArgs e)
          {
              if (tb_thn1.Text == "" || cb_jurusan1.Text == "--Pilihan--")
                  MessageBox.Show("Data Harus Diisi!");
              cb_jurusan1.Focus();
              
              try
              {
                  SqlDataReader dr = null;
                  SqlConnection con;
                  con = koneksi.conn;
                  SqlCommand coman = new SqlCommand();
                  coman.Connection = con;
                  coman.CommandType = CommandType.Text;
                  coman.CommandText = "SELECT COUNT (*) FROM dbo.tb_siswa WHERE (((tb_siswa.thn_ajaran)='" + tb_thn1.Text + "' AND jurusan= '" + cb_jurusan1.Text + "'))";
                  DataSet ds = new DataSet();
                  SqlDataAdapter sda = new SqlDataAdapter(coman);
                  con.Open();
                  dr = coman.ExecuteReader();
                  while (dr.Read())
                  {
                      tb_total.AppendText(dr[""].ToString());
                  }
                  con.Close();

              }
              catch (Exception err)
              {
                  MessageBox.Show("Data Tidak ada\n" + err.Message);
              }
          }
          private bool tambah = false;
          private void dgv_ak_CellClick(object sender, DataGridViewCellEventArgs e)
          {
              tb_nipd.Text = dgv_ak.CurrentRow.Cells[0].Value.ToString();
              tb_nmsiswa.Text = dgv_ak.CurrentRow.Cells[1].Value.ToString();
              jk = dgv_ak.CurrentRow.Cells[2].Value.ToString();
              cb_jurusans.Text = dgv_ak.CurrentRow.Cells[3].Value.ToString();
              thn_ajarans.Text = dgv_ak.CurrentRow.Cells[4].Value.ToString();
              
              
              tambah = true;
              tb_idak.Text = kode;
              SqlCommand cmd = new SqlCommand();
              cmd.Connection = MyData.Connection;
              cmd.CommandType = CommandType.Text;
              tb_idak.Text = kode;
          }

        private void tab_ak()
          {
              dgv_ak.Columns[0].HeaderText = "NIPD";
              dgv_ak.Columns[0].Width = 110;
              dgv_ak.Columns[1].HeaderText = "Nama Siswa";
              dgv_ak.Columns[1].Width = 160;
              dgv_ak.Columns[2].HeaderText = "JK";
              dgv_ak.Columns[2].Width = 30;
              dgv_ak.Columns[3].HeaderText = "Jurusan";
              dgv_ak.Columns[3].Width = 150;
              dgv_ak.Columns[4].HeaderText = "Tahun Ajaran";
              dgv_ak.Columns[4].Width = 100;

          }

          private void rb_lk_CheckedChanged(object sender, EventArgs e)
          {
              jk = "L";
          }

          private void rb_pr_CheckedChanged(object sender, EventArgs e)
          {
              jk = "P";
          }

          private void bt_simpananggota_Click(object sender, EventArgs e)
          {
              /*if (tb_idak.Text == "" || tb_nipd.Text == "" || tb_nmsiswa.Text == "" ||
                  jk == "" || cb_jurusan.Text == "" || thn_ajarans.Text == "" || cb_kls.Text == "" || tb_semester.Text == "")
              {
                  MessageBox.Show("Data (*) Tidak Boleh Kosong", "Info", MessageBoxButtons.OK);
              }
              else
              {
                  simpan_anggota();
                  {
                      MessageBox.Show("Berhasil Menyimpan\n");
                  }
                  tampil_anggota();
              }
              tab_akb();*/
              if (tb_idak.Text == "" || tb_nipd.Text == "" || tb_nmsiswa.Text == "" ||
                  jk == "" || cb_jurusan.Text == "" || thn_ajarans.Text == "" || cb_kls.Text == "" || tb_semester.Text == "")
              {
                  MessageBox.Show("Data (*) Tidak Boleh Kosong", "Info", MessageBoxButtons.OK);
              }
              else
              {
                  string query = "select * from tb_anggota_kelas where id_anggota='" + tb_idak.Text + "'";
                  if (!fungsi.cekdata(query))
                  {
                      query = "insert into tb_anggota_kelas values('" + tb_idak.Text +
                                "','" + tb_nipd.Text +
                                "','" + tb_nmsiswa.Text +
                                "','" + jk +
                                "','" + cb_jurusans.Text +
                                "','" + thn_ajarans.Text +
                                "','" + cb_kls.Text +
                                "','" + tb_semester.Text + "')";

                      int x = fungsi.Equery(query);
                      if (x == 1)
                      {
                          MessageBox.Show("Data Berhasil Tersimpan");
                          tampil_anggota();
                      }
                      else
                      {
                          MessageBox.Show("Data Gagal Tersimpan");
                      }
                  }
                  else
                  {
                      MessageBox.Show("ID Walikelas Telah Terdaftar", tb_idak.Text);
                      tb_idak.Focus();
                      tampil_anggota();
                  }
              }
          }

          private void bt_refresh_Click(object sender, EventArgs e)
          {
              tb_thn1.Clear();
              tb_total.Clear();
          }

          private void button1_Click(object sender, EventArgs e)
          {
              tb_thn.Clear();
              tb_jml.Clear();
          }
          private void bt_hapus_Click(object sender, EventArgs e)
          {
              if (MessageBox.Show("Apakah Anda Ingin Menghapus Data Ini?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                ) == DialogResult.Yes)
                  {
                      try
                      {
                          hapus_anggota();
                      }
                      catch (Exception err)
                      {
                          MessageBox.Show("Gagal Hapus\n" + err.Message);
                      }
                  }
          }

          private void bt_edit_Click(object sender, EventArgs e)
          {
              if (tb_idak.Text != "" && tb_nipd.Text != "" && tb_nmsiswa.Text != "" && cb_jurusan.Text != "" && thn_ajarans.Text !="" && cb_kls.Text !="" && tb_semester.Text !="")
              {
                  edit_anggota();
                  MessageBox.Show("Data Berhasil Terupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  tampil_anggota();

              }
              else
              {
                  MessageBox.Show("Data Gagal Terupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              }
          }

          private void button2_Click(object sender, EventArgs e)
          {
              tampil_anggota();
              tab_akb();
          }

          private void dgv_anggota_CellClick(object sender, DataGridViewCellEventArgs e)
          {
              tb_idak.Text = dgv_anggota.CurrentRow.Cells[0].Value.ToString();
              tb_nipd.Text = dgv_anggota.CurrentRow.Cells[1].Value.ToString();
              tb_nmsiswa.Text = dgv_anggota.CurrentRow.Cells[2].Value.ToString();
              jk = dgv_anggota.CurrentRow.Cells[3].Value.ToString();
              cb_jurusans.Text = dgv_anggota.CurrentRow.Cells[4].Value.ToString();
              thn_ajarans.Text = dgv_anggota.CurrentRow.Cells[5].Value.ToString();
              cb_kls.Text = dgv_anggota.CurrentRow.Cells[6].Value.ToString();
              tb_semester.Text = dgv_anggota.CurrentRow.Cells[7].Value.ToString();
          }

          private void tab_akb()
          {
              dgv_anggota.Columns[0].HeaderText = "ID Anggota";
              dgv_anggota.Columns[0].Width = 90;
              dgv_anggota.Columns[1].HeaderText = "NIPD";
              dgv_anggota.Columns[1].Width = 110;
              dgv_anggota.Columns[2].HeaderText = "Nama Siswa";
              dgv_anggota.Columns[2].Width = 160;
              dgv_anggota.Columns[3].HeaderText = "JK";
              dgv_anggota.Columns[3].Width = 30;
              dgv_anggota.Columns[4].HeaderText = "Jurusan";
              dgv_anggota.Columns[4].Width = 160;
              dgv_anggota.Columns[5].HeaderText = "Tahun Ajaran";
              dgv_anggota.Columns[5].Width = 100;
              dgv_anggota.Columns[6].HeaderText = "Kelas";
              dgv_anggota.Columns[6].Width = 160;
              dgv_anggota.Columns[7].HeaderText = "Semester";
              dgv_anggota.Columns[7].Width = 70;
          }

          private void tab_siswa()
          {
              dgv_dsb.Columns[0].HeaderText = "NIK";
              dgv_dsb.Columns[0].Width = 80;
              dgv_dsb.Columns[1].HeaderText = "NIPD";
              dgv_dsb.Columns[1].Width = 100;
              dgv_dsb.Columns[2].HeaderText = "NISN";
              dgv_dsb.Columns[2].Width = 120;
              dgv_dsb.Columns[3].HeaderText = "SKHUN";
              dgv_dsb.Columns[3].Width = 110;
              dgv_dsb.Columns[4].HeaderText = "Nama Lengkap";
              dgv_dsb.Columns[4].Width = 160;
              dgv_dsb.Columns[5].HeaderText = "JK";
              dgv_dsb.Columns[5].Width = 30;
              dgv_dsb.Columns[6].HeaderText = "Agama";
              dgv_dsb.Columns[6].Width = 70;
              dgv_dsb.Columns[7].HeaderText = "Tempat Lahir";
              dgv_dsb.Columns[7].Width = 130;
              dgv_dsb.Columns[8].HeaderText = "Tanggal Lahir";
              dgv_dsb.Columns[8].Width = 100;
              dgv_dsb.Columns[9].HeaderText = "Alamat";
              dgv_dsb.Columns[9].Width = 120;
              dgv_dsb.Columns[10].HeaderText = "Kelurahan";
              dgv_dsb.Columns[10].Width = 110;
              dgv_dsb.Columns[11].HeaderText = "Kecamatan";
              dgv_dsb.Columns[11].Width = 110;
              dgv_dsb.Columns[12].HeaderText = "Kabupaten";
              dgv_dsb.Columns[12].Width = 110;
              dgv_dsb.Columns[13].HeaderText = "Provinsi";
              dgv_dsb.Columns[13].Width = 100;
              dgv_dsb.Columns[14].HeaderText = "Penerima KPS";
              dgv_dsb.Columns[14].Width = 110;
              dgv_dsb.Columns[15].HeaderText = "Nomor KPS";
              dgv_dsb.Columns[15].Width = 120;
              dgv_dsb.Columns[16].HeaderText = "No. Handphone";
              dgv_dsb.Columns[16].Width = 120;
              dgv_dsb.Columns[17].HeaderText = "Email";
              dgv_dsb.Columns[17].Width = 120;
              dgv_dsb.Columns[18].HeaderText = "Jurusan";
              dgv_dsb.Columns[18].Width = 140;
              dgv_dsb.Columns[19].HeaderText = "Tahun Ajaran";
              dgv_dsb.Columns[19].Width = 100;
          }
          private void bt_tambah_Click(object sender, EventArgs e)
          {
              bersih_anggota();
              dgv_dsb.Enabled = false;
              cb_jurusan1.Enabled = false;
              tb_thn1.Enabled = false;
              tb_total.Enabled = false;
              dgv_ak.Enabled = false;
              tb_idak.Enabled = false;
              tb_nipd.Enabled = false;
              tb_nmsiswa.Enabled = false;
              cb_jurusans.Enabled = false;
              thn_ajarans.Enabled = false;
              cb_kls.Enabled = false;
              tb_semester.Enabled = false;
              cb_jurusan.Focus();
              bt_simpananggota.Enabled = false;
              bt_ket.Enabled = false;
          }

          private void fr_konfigurasi_Activated(object sender, EventArgs e)
          {
              tab_siswa();
          }

    }
}
