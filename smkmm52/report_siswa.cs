using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace smkmm52
{
    public partial class report_siswa : Form
    {
        public report_siswa()
        {
            InitializeComponent();
        }

        private void report_siswa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dasetsiswa.lap_siswa' table. You can move, or remove it, as needed.
            this.lap_siswaTableAdapter.Fill(this.dasetsiswa.lap_siswa);
            // TODO: This line of code loads data into the 'dasetwali.lap_walikelas' table. You can move, or remove it, as needed.
            

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

    
    }
}
