using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace smkmm52
{
    public partial class fr_user : Form
    {
        public fr_user()
        {
            InitializeComponent();
        }

        private void ubah_user()
        {
            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "update tb_login set password='" + tb_pass.Text +
                "' where username ='" + tb_user.Text + "'";
            coman.ExecuteNonQuery();
            coman.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("User Berhasil Terupdate");
           
        }
        private void fr_user_Load(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            ubah_user();
        }

        private void bt_batal_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
