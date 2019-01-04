using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smkmm52
{
    public partial class print : Form
    {
        public print()
        {
            InitializeComponent();
        }

        private void bt_conf_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(dgv_print.Text, new Font("Tahoma", 15), Brushes.Black, 10, 12);
        }

        private void bt_preview_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void bt_print_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void print_Load(object sender, EventArgs e)
        {

        }
    }
}
