﻿using System;
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
    public partial class report_persiswa : Form
    {
        //cr_siswa cry = new cr_siswa();
        public report_persiswa()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            /*cry.Load(@"F:\A\smkmm52\smkmm52\CrystalReport1.rpt");

            SqlConnection con;
            con = koneksi.conn;
            con.Open();
            SqlCommand coman = new SqlCommand();
            coman.Connection = con;
            coman.CommandType = CommandType.Text;
            coman.CommandText = "select * from lap_siswa";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(coman);
            //sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            //sda.SelectCommand.Parameters.Add("@nm_guru", System.Data.SqlDbType.VarChar, 100).Value = tb_cari.Text;
            sda.Fill(ds, "lap_siswa");
            cry.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cry;*/
        }


        private void report_persiswa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dasetpersiswa.lap_siswa' table. You can move, or remove it, as needed.
            //this.lap_siswaTableAdapter.Fill(this.dasetpersiswa.lap_siswa);

            //this.reportViewer1.RefreshReport();
        }

        private void bt_cari_Click(object sender, EventArgs e)
        {
            this.lap_siswaTableAdapter.Fill(this.dasetpersiswa.lap_siswa, tb_nama.Text);

            this.reportViewer1.RefreshReport();
        }

    }
}
