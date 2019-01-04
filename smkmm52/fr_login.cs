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
    public partial class fr_login : Form
    {
        public fr_login()
        {
            InitializeComponent();
        }
         private void proses()
        {
            /*SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select * from tb_login where username ='" + tb_user.Text +
                "'and password='" + tb_pass.Text+ "'";
            coman.ExecuteNonQuery();
            SqlDataReader dr = coman.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Login Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Username atau Password salah !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_user.Focus();
                tb_pass.Text = "";
            }
            con.Close();*/

            //SqlConnection con = new SqlConnection(@"Data Source=hand;Initial Catalog=db_smkmm52; Integrated Security=true");
            //SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from tb_login where username='" + tb_user.Text + "' and password='" + tb_pass.Text + "'", con);

            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from tb_login where username='" + tb_user.Text + "' and password='" + tb_pass.Text + "'", con);
             DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                fr_login lg = new fr_login();
                this.Close();
                tb_user.Focus();

                (this.Owner as fr_utama).logoutToolStripMenuItem.Visible = true;
                (this.Owner as fr_utama).loginToolStripMenuItem.Visible = false;
                (this.Owner as fr_utama).masterDataToolStripMenuItem.Visible = true;
                (this.Owner as fr_utama).administrasiDataToolStripMenuItem.Visible = true;

            }

            else
            {
                if (tb_user.Text == "")
                    MessageBox.Show("Username Salah !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                else if (tb_pass.Text == "")
                    MessageBox.Show("Password Salah !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_user.Focus();
            }
        }
       
        
        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            /*try
            {
                //proses();
                (this.Owner as fr_utama).logoutToolStripMenuItem.Visible = true;
                (this.Owner as fr_utama).loginToolStripMenuItem.Visible = false;
                (this.Owner as fr_utama).masterDataToolStripMenuItem.Visible = true;
                (this.Owner as fr_utama).administrasiDataToolStripMenuItem.Visible = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Gagal Koneksi " + err);
            }*/
            proses();
        }
    }
}
