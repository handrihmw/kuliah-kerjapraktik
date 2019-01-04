namespace smkmm52
{
    partial class report_siswa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(report_siswa));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lap_siswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dasetsiswa = new smkmm52.dasetsiswa();
            this.lap_siswaTableAdapter = new smkmm52.dasetsiswaTableAdapters.lap_siswaTableAdapter();
            this.dasetwali = new smkmm52.dasetwali();
            this.lap_walikelasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lap_walikelasTableAdapter = new smkmm52.dasetwaliTableAdapters.lap_walikelasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lap_siswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dasetsiswa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dasetwali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lap_walikelasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Data_Siswa";
            reportDataSource1.Value = this.lap_siswaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "smkmm52.resiswa.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(817, 367);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // lap_siswaBindingSource
            // 
            this.lap_siswaBindingSource.DataMember = "lap_siswa";
            this.lap_siswaBindingSource.DataSource = this.dasetsiswa;
            // 
            // dasetsiswa
            // 
            this.dasetsiswa.DataSetName = "dasetsiswa";
            this.dasetsiswa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lap_siswaTableAdapter
            // 
            this.lap_siswaTableAdapter.ClearBeforeFill = true;
            // 
            // dasetwali
            // 
            this.dasetwali.DataSetName = "dasetwali";
            this.dasetwali.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lap_walikelasBindingSource
            // 
            this.lap_walikelasBindingSource.DataMember = "lap_walikelas";
            this.lap_walikelasBindingSource.DataSource = this.dasetwali;
            // 
            // lap_walikelasTableAdapter
            // 
            this.lap_walikelasTableAdapter.ClearBeforeFill = true;
            // 
            // report_siswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 367);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "report_siswa";
            this.Text = "Laporan Data Siswa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.report_siswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lap_siswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dasetsiswa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dasetwali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lap_walikelasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource lap_siswaBindingSource;
        private dasetsiswa dasetsiswa;
        private dasetsiswaTableAdapters.lap_siswaTableAdapter lap_siswaTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource lap_walikelasBindingSource;
        private dasetwali dasetwali;
        private dasetwaliTableAdapters.lap_walikelasTableAdapter lap_walikelasTableAdapter;
    }
}