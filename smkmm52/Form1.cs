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
    public partial class fr_utama : Form
    {
        public fr_utama()
        {
            InitializeComponent();
        }

        private void fr_utama_Load(object sender, EventArgs e)
        {
            logoutToolStripMenuItem.Visible = false;
            administrasiDataToolStripMenuItem.Visible = false;
            masterDataToolStripMenuItem.Visible = false;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_login log = new fr_login();
            log.Owner = this;
            loginToolStripMenuItem.Visible = true;
            logoutToolStripMenuItem.Visible = false;
            administrasiDataToolStripMenuItem.Visible = false;
            masterDataToolStripMenuItem.Visible = false;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_login log = new fr_login();
            log.Owner = this;
            log.ShowDialog();
        }

        private void masterDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_login log = new fr_login();
            log.Owner = this;
        }

        public void administrasiDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_login log = new fr_login();
            log.Owner = this;
        }

        public void laporanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_login log = new fr_login();
            log.Owner = this;
        }

        private void dataSiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_add_siswa adds = new fr_add_siswa();
            adds.ShowDialog();
        }

        private void dataGuruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_add_guru addg = new fr_add_guru();
            addg.ShowDialog();
        }

        private void dataPelajaranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_add_pelajaran addp = new fr_add_pelajaran();
            addp.ShowDialog();
        }

        private void dataWaliKelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_add_kelas addk = new fr_add_kelas();
            addk.ShowDialog();
        }

        private void dataWilayahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_add_wilayah addw = new fr_add_wilayah();
            addw.ShowDialog();
        }

        private void dataWalikelasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fr_add_walikelas addwk = new fr_add_walikelas();
            addwk.ShowDialog();
        }

        private void dataMengajarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_add_mengajar addm = new fr_add_mengajar();
            addm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void laporanSiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_lap_siswa ls = new fr_lap_siswa();
            ls.ShowDialog();
        }

        private void laporanGuruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_lap_guru lg = new fr_lap_guru();
            lg.ShowDialog();
        }

        private void laporanWalikelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_lap_walikelas wk = new fr_lap_walikelas();
            wk.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_add_anggota addang = new fr_add_anggota();
            addang.ShowDialog();
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profil ps = new profil();
            ps.ShowDialog();
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contact ct = new contact();
            ct.ShowDialog();
        }

        private void tESTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report_perguru lp = new report_perguru();
            lp.Show();
        }

        private void ubahUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_user us = new fr_user();
            us.ShowDialog();
        }

        private void bbbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report_guru rg = new report_guru();
            rg.ShowDialog();
        }
    }
}
