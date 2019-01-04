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
using Excel = Microsoft.Office.Interop.Excel;
using ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;
using System.Text.RegularExpressions;


namespace smkmm52
{
    public partial class fr_lap_guru : Form
    {
        public fr_lap_guru()
        {
            InitializeComponent();
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
            dgv_lapg.DataSource = ds;
            dgv_lapg.DataMember = "guru";
        }
        private void tb_cari1_TextChanged(object sender, EventArgs e)
        {
            string cari1 = tb_cari.Text;
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
                dgv_lapg.DataSource = ds;
                dgv_lapg.DataMember = "nip";

            }
            catch (Exception err)
            {
                MessageBox.Show("Data Tidak ada\n" + err.Message);
            }
        }

        private void tb_cari2_TextChanged(object sender, EventArgs e)
        {
            string cari2 = tb_cari1.Text;
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
                dgv_lapg.DataSource = ds;
                dgv_lapg.DataMember = "nm_guru";

            }
            catch (Exception err)
            {
                MessageBox.Show("Data Tidak ada\n" + err.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void rb_sg_CheckedChanged(object sender, EventArgs e)
        {
            tampil_guru();
            tc_g.Enabled = false;
        }

        private void rb_g_CheckedChanged(object sender, EventArgs e)
        {
            tampil_guru();
            tc_g.Enabled = true;
        }

        private void tb_cari_TextChanged(object sender, EventArgs e)
        {
            string cari1 = tb_cari.Text;
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
                dgv_lapg.DataSource = ds;
                dgv_lapg.DataMember = "nip";

            }
            catch (Exception err)
            {
                MessageBox.Show("Data Tidak ada\n" + err.Message);
            }
        }

        private void tb_cari1_TextChanged_1(object sender, EventArgs e)
        {
            string cari = tb_cari1.Text;
            try
            {
                SqlConnection con;
                con = koneksi.conn;
                SqlCommand coman = new SqlCommand();
                coman.Connection = con;
                coman.CommandType = CommandType.Text;
                coman.CommandText = "select * from tb_guru where nm_guru like '" + cari + "%'";
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(coman);
                sda.Fill(ds, "nm_guru");
                dgv_lapg.DataSource = ds;
                dgv_lapg.DataMember = "nm_guru";

            }
            catch (Exception err)
            {
                MessageBox.Show("Data Tidak ada\n" + err.Message);
            }
        }

        private void tabel()
        {
            dgv_lapg.Columns[0].HeaderText = "NIP";
            dgv_lapg.Columns[0].Width = 110;
            dgv_lapg.Columns[1].HeaderText = "Nama Guru";
            dgv_lapg.Columns[1].Width = 130;
            dgv_lapg.Columns[2].HeaderText = "JK";
            dgv_lapg.Columns[2].Width = 30;
            dgv_lapg.Columns[3].HeaderText = "Agama";
            dgv_lapg.Columns[3].Width = 90;
            dgv_lapg.Columns[4].HeaderText = "Tempat Lahir";
            dgv_lapg.Columns[4].Width = 110;
            dgv_lapg.Columns[5].HeaderText = "Tanggal Lahir";
            dgv_lapg.Columns[5].Width = 120;
            dgv_lapg.Columns[6].HeaderText = "Alamat";
            dgv_lapg.Columns[6].Width = 110;
            dgv_lapg.Columns[7].HeaderText = "Kelurahan";
            dgv_lapg.Columns[7].Width = 110;
            dgv_lapg.Columns[8].HeaderText = "Kecamatan";
            dgv_lapg.Columns[8].Width = 110;
            dgv_lapg.Columns[9].HeaderText = "Kabupaten";
            dgv_lapg.Columns[9].Width = 110;
            dgv_lapg.Columns[10].HeaderText = "Provinsi";
            dgv_lapg.Columns[10].Width = 110;
            dgv_lapg.Columns[11].HeaderText = "Status Menikah";
            dgv_lapg.Columns[11].Width = 110;
            dgv_lapg.Columns[12].HeaderText = "Status Kepegawaian";
            dgv_lapg.Columns[12].Width = 130;
            dgv_lapg.Columns[13].HeaderText = "Jabatan";
            dgv_lapg.Columns[13].Width = 110;
            dgv_lapg.Columns[14].HeaderText = "No. Handphone";
            dgv_lapg.Columns[14].Width = 110;
            dgv_lapg.Columns[15].HeaderText = "Email";
            dgv_lapg.Columns[15].Width = 130;
        }
        private void rb_g_Click(object sender, EventArgs e)
        {
            report_perguru rpg = new report_perguru();
            rpg.ShowDialog();
            tabel();
        }

        private void rb_sg_Click(object sender, EventArgs e)
        {
            report_guru rg = new report_guru();
            rg.ShowDialog();
            tabel();
        }

        private void bt_ctk_Click(object sender, EventArgs e)
        {
            //print printer = new print();
            //printer.ShowDialog();
            //laporan_guru lap = new laporan_guru();
            //lap.ShowDialog();
            //string query = "select * from tb_guru";
            // laporan.laporan_guru(query, "tb_guru");
            report_guru rg = new report_guru();
            rg.ShowDialog();

        }


        private void bt_print_Click(object sender, EventArgs e)
        {
            string query = "select * from tb_guru";
            laporan.laporan_guru(query, "tb_guru");
            //laporanku lap = new laporanku();
            //lap.ShowDialog();

        }


        private void bt_load_Click(object sender, EventArgs e)
        {/*
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            Int16 i, j;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            for (i = 0; i <= dgv_lapg.RowCount - 2; i++)
            {
                for (j = 0; j <= dgv_lapg.ColumnCount - 1; j++)
                {
                    xlWorkSheet.Cells[i + 1, j + 1] = dgv_lapg[j, i].Value.ToString();
                }
            }

            xlWorkBook.SaveAs(@"D:\contohnya.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }*/
        }

        private void fr_lap_guru_Load(object sender, EventArgs e)
        {
            // Mengatur property Filename dan filter pada savefiledialog
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel 2003 (*.xls) | *.xls|Excel 2007 (*.xlsx) | *.xlsx";
            tb_cari.Focus();
        }

        private void bt_export_Click(object sender, EventArgs e)
        {
            /*saveFileDialog1.InitialDirectory = "D:";
            saveFileDialog1.Title = " Save as Excel File";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel Files(2003)|*.xls|Excel Files(2007)|*.xlsx";
            
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                /*Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                ExcelApp.Application.Workbooks.Add(Type.Missing);
                ExcelApp.Columns.ColumnWidth = "20";

                for (int i = 1; i < dgv_lapg.Columns.Count + 1; i++)
                {
                    ExcelApp.Cells[1, i] = dgv_lapg.Columns[1 - i].HeaderText;
                }

                for (int i = 0; i < dgv_lapg.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv_lapg.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = dgv_lapg.Rows[i].Cells[j].Value.ToString();
                    }
                }
                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();
            }

            //Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Excel.Application excelapp;
            Excel.Workbook excelworkbook;
            Excel.Worksheet excelworksheet;
            object msvalue = System.Reflection.Missing.Value;

            excelapp = new Excel.Application();
            excelworkbook = excelapp.Workbooks.Add(msvalue);
            excelworksheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkbook.Sheets["sheet1"];

            // Perulangan untuk mengexport data dari datagridview ke sheet ms Excel
            for (int i = 0; i <= dgv_lapg.Rows.Count - 2; i++)
            {
                for (int j = 0; j <= dgv_lapg.Columns.Count - 1; j++)
                {
                    if (i == 0)
                    {
                        excelworksheet.Cells[i + 3, j + 2] = dgv_lapg.Columns[j].HeaderText.ToString();
                    }
                    else
                    {
                        excelworksheet.Cells[i + 3, j + 2] = dgv_lapg[j, i].Value.ToString();
                    }
                }
            
            }
            
            // Mengatur ukuran baris dan column
            excelworksheet.UsedRange.EntireRow.AutoFit();
            excelworksheet.UsedRange.EntireColumn.AutoFit();

            // Mengatur border table
            excelworksheet.UsedRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            excelworksheet.UsedRange.Borders.Color = Color.Black;
            excelworksheet.UsedRange.Borders.Weight = Excel.XlBorderWeight.xlThin;

            // Membuat judul
            //excelworksheet.Cells[1, 2] = tb_judul.Text;
            // Menyimpan file excel
            excelworksheet.SaveAs(tb_browse.Text);
            excelworkbook.Close();
            excelapp.Quit();

            MessageBox.Show("Data berhasil di Export", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
      
        }

        private void bt_browse_Click_1(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                tb_browse.Text = saveFileDialog1.FileName;
            }
        }
            */
        }

        private void bt_print_Click_1(object sender, EventArgs e)
        {
          
        }
    }
}
