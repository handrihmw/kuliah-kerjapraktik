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
    public partial class fr_add_anggota : Form
    {
        int nipd = 0;
        public fr_add_anggota()
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
            dgv_ak1.DataSource = ds;
            dgv_ak1.DataMember = "anggota";

        }

       /* private void hapus_anggota()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "delete from tb_anggota_kelas where id_anggota";
            coman.Parameters.AddWithValue("id_anggota");
            coman.ExecuteNonQuery();
            con.Close();
            tampil_anggota();
        }*/
      
        private void bt_kelmbali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_konf_Click(object sender, EventArgs e)
        {
            fr_konfigurasi kon = new fr_konfigurasi();
            kon.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_conf_Click(object sender, EventArgs e)
        {
            fr_konfigurasi kon = new fr_konfigurasi();
            kon.ShowDialog();
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
                coman.CommandText = "SELECT nipd,nm_siswa,jk,jurusan,thn_ajaran,kelas FROM dbo.tb_anggota_kelas WHERE (((tb_anggota_kelas.thn_ajaran)='" + tb_thn.Text + "' AND kelas= '" + cb_kls.Text + "'))";
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(coman);
                sda.Fill(ds, "anggota");
                dgv_ak1.DataSource = ds;
                dgv_ak1.DataMember = "anggota";

            }
            catch (Exception err)
            {
                MessageBox.Show("Data Tidak ada\n" + err.Message);
            }
            tab_anggota();
        }


        private void bt_hapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda Ingin Menghapus Data Ini?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                 ) == DialogResult.Yes)
            {
               /* foreach (DataGridViewRow row in dgv_ak1.SelectedRows)
                {
                    //SqlCommand cmd = new SqlCommand("DELETE FROM tb_anggota_kelas WHERE nipd=?", MyData.Connection);
                    SqlConnection con;
                    con = koneksi.conn;
                    con.Open();
                    SqlCommand coman = new SqlCommand();
                    coman.Connection = con;
                    coman.CommandType = CommandType.Text;
                    coman.CommandText = "delete from tb_anggota_kelas where id_anggota=?";
                    coman.Parameters.Add("id_anggota", SqlDbType.VarChar, 20).Value = row.Cells[0].Value.ToString();
                    coman.ExecuteNonQuery();
                    con.Close();
                }*/
                foreach (DataGridViewCell oneCell in dgv_ak1.SelectedCells)
                {
                    if (oneCell.Selected)
                        dgv_ak1.Rows.RemoveAt(oneCell.RowIndex);
                }
            }
        }
        public void addItems(AutoCompleteStringCollection col)
        {
            col.Add("2016 / 2017");
            col.Add("2017 / 2018");
            col.Add("2018 / 2019");
            col.Add("2019 / 2020");
        }
        private void fr_add_anggota_Load(object sender, EventArgs e)
        {
            /*Tahun Ajaran Otomatis*/
            tb_thn.AutoCompleteMode = AutoCompleteMode.Suggest;
            tb_thn.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollction = new AutoCompleteStringCollection();
            addItems(DataCollction);
            tb_thn.AutoCompleteCustomSource = DataCollction;

        }
           
        private void tab_anggota()
        {
            dgv_ak1.Columns[0].HeaderText = "NIPD";
            dgv_ak1.Columns[0].Width = 80;
            dgv_ak1.Columns[1].HeaderText = "Nama Siswa";
            dgv_ak1.Columns[1].Width = 150;
            dgv_ak1.Columns[2].HeaderText = "JK";
            dgv_ak1.Columns[2].Width = 30;
            dgv_ak1.Columns[3].HeaderText = "Jurusan";
            dgv_ak1.Columns[3].Width = 160;
            dgv_ak1.Columns[4].HeaderText = "Tahun Ajaran";
            dgv_ak1.Columns[4].Width = 100;
            dgv_ak1.Columns[5].HeaderText = "Kelas";
            dgv_ak1.Columns[5].Width = 160;
        }

    }
}
