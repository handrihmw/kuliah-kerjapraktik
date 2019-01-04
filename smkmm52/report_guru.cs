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
    public partial class report_guru : Form
    {
        public report_guru()
        {
            InitializeComponent();
        }

        private void report_guru_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dasetguru.lap_guru' table. You can move, or remove it, as needed.
            this.lap_guruTableAdapter.Fill(this.dasetguru.lap_guru);

            this.reportViewer1.RefreshReport();
        }

    }
}
