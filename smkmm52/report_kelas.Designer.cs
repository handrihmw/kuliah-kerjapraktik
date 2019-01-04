namespace smkmm52
{
    partial class report_kelas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(report_kelas));
            this.lap_kelasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dasetperkelas = new smkmm52.dasetperkelas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tb_smt = new System.Windows.Forms.TextBox();
            this.tb_thn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_cari = new System.Windows.Forms.Button();
            this.lap_kelasTableAdapter = new smkmm52.dasetperkelasTableAdapters.lap_kelasTableAdapter();
            this.cb_kelas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.lap_kelasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dasetperkelas)).BeginInit();
            this.SuspendLayout();
            // 
            // lap_kelasBindingSource
            // 
            this.lap_kelasBindingSource.DataMember = "lap_kelas";
            this.lap_kelasBindingSource.DataSource = this.dasetperkelas;
            // 
            // dasetperkelas
            // 
            this.dasetperkelas.DataSetName = "dasetperkelas";
            this.dasetperkelas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "Data_Kelas";
            reportDataSource2.Value = this.lap_kelasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "smkmm52.rekelas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 102);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(929, 427);
            this.reportViewer1.TabIndex = 0;
            // 
            // tb_smt
            // 
            this.tb_smt.Location = new System.Drawing.Point(89, 64);
            this.tb_smt.Name = "tb_smt";
            this.tb_smt.Size = new System.Drawing.Size(206, 20);
            this.tb_smt.TabIndex = 40;
            // 
            // tb_thn
            // 
            this.tb_thn.Location = new System.Drawing.Point(89, 12);
            this.tb_thn.Name = "tb_thn";
            this.tb_thn.Size = new System.Drawing.Size(206, 20);
            this.tb_thn.TabIndex = 42;
            this.tb_thn.Text = "2016 / 2017";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Tahun Ajaran";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Semester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Kelas";
            // 
            // bt_cari
            // 
            this.bt_cari.BackColor = System.Drawing.Color.Transparent;
            this.bt_cari.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
            this.bt_cari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cari.Font = new System.Drawing.Font("NewsGoth BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cari.ForeColor = System.Drawing.Color.Transparent;
            this.bt_cari.Image = ((System.Drawing.Image)(resources.GetObject("bt_cari.Image")));
            this.bt_cari.Location = new System.Drawing.Point(301, 64);
            this.bt_cari.Name = "bt_cari";
            this.bt_cari.Size = new System.Drawing.Size(49, 21);
            this.bt_cari.TabIndex = 249;
            this.bt_cari.UseVisualStyleBackColor = false;
            this.bt_cari.Click += new System.EventHandler(this.bt_cari_Click);
            // 
            // lap_kelasTableAdapter
            // 
            this.lap_kelasTableAdapter.ClearBeforeFill = true;
            // 
            // cb_kelas
            // 
            this.cb_kelas.FormattingEnabled = true;
            this.cb_kelas.Location = new System.Drawing.Point(89, 37);
            this.cb_kelas.Name = "cb_kelas";
            this.cb_kelas.Size = new System.Drawing.Size(206, 21);
            this.cb_kelas.TabIndex = 250;
            // 
            // report_kelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 524);
            this.Controls.Add(this.cb_kelas);
            this.Controls.Add(this.bt_cari);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_thn);
            this.Controls.Add(this.tb_smt);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "report_kelas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan Per Kelas";
            this.Load += new System.EventHandler(this.report_kelas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lap_kelasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dasetperkelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource lap_kelasBindingSource;
        private dasetperkelas dasetperkelas;
        private dasetperkelasTableAdapters.lap_kelasTableAdapter lap_kelasTableAdapter;
        private System.Windows.Forms.TextBox tb_smt;
        private System.Windows.Forms.TextBox tb_thn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_cari;
        private System.Windows.Forms.ComboBox cb_kelas;
    }
}