namespace smkmm52
{
    partial class report_persiswa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(report_persiswa));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bt_cari = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.lap_siswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dasetpersiswa = new smkmm52.dasetpersiswa();
            this.lap_siswaTableAdapter = new smkmm52.dasetpersiswaTableAdapters.lap_siswaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lap_siswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dasetpersiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Data_Persiswa";
            reportDataSource1.Value = this.lap_siswaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "smkmm52.repersiswa.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 52);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(936, 458);
            this.reportViewer1.TabIndex = 0;
            // 
            // bt_cari
            // 
            this.bt_cari.BackColor = System.Drawing.Color.Transparent;
            this.bt_cari.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
            this.bt_cari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cari.Font = new System.Drawing.Font("NewsGoth BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cari.ForeColor = System.Drawing.Color.Transparent;
            this.bt_cari.Image = ((System.Drawing.Image)(resources.GetObject("bt_cari.Image")));
            this.bt_cari.Location = new System.Drawing.Point(304, 12);
            this.bt_cari.Name = "bt_cari";
            this.bt_cari.Size = new System.Drawing.Size(49, 21);
            this.bt_cari.TabIndex = 252;
            this.bt_cari.UseVisualStyleBackColor = false;
            this.bt_cari.Click += new System.EventHandler(this.bt_cari_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 251;
            this.label2.Text = "Nama Siswa";
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(92, 12);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(206, 20);
            this.tb_nama.TabIndex = 250;
            // 
            // lap_siswaBindingSource
            // 
            this.lap_siswaBindingSource.DataMember = "lap_siswa";
            this.lap_siswaBindingSource.DataSource = this.dasetpersiswa;
            // 
            // dasetpersiswa
            // 
            this.dasetpersiswa.DataSetName = "dasetpersiswa";
            this.dasetpersiswa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lap_siswaTableAdapter
            // 
            this.lap_siswaTableAdapter.ClearBeforeFill = true;
            // 
            // report_persiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 510);
            this.Controls.Add(this.bt_cari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nama);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "report_persiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan Siswa";
            this.Load += new System.EventHandler(this.report_persiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lap_siswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dasetpersiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource lap_siswaBindingSource;
        private dasetpersiswa dasetpersiswa;
        private dasetpersiswaTableAdapters.lap_siswaTableAdapter lap_siswaTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button bt_cari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nama;

    }
}