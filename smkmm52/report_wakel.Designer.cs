namespace smkmm52
{
    partial class report_wakel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(report_wakel));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dasetwali = new smkmm52.dasetwali();
            this.lap_walikelasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lap_walikelasTableAdapter = new smkmm52.dasetwaliTableAdapters.lap_walikelasTableAdapter();
            this.cb_kelas = new System.Windows.Forms.ComboBox();
            this.bt_cari = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_thn = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dasetwali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lap_walikelasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Data_Wali_Kelas";
            reportDataSource1.Value = this.lap_walikelasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "smkmm52.rewali.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 78);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(873, 379);
            this.reportViewer1.TabIndex = 0;
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
            // cb_kelas
            // 
            this.cb_kelas.FormattingEnabled = true;
            this.cb_kelas.Location = new System.Drawing.Point(89, 37);
            this.cb_kelas.Name = "cb_kelas";
            this.cb_kelas.Size = new System.Drawing.Size(206, 21);
            this.cb_kelas.TabIndex = 255;
            // 
            // bt_cari
            // 
            this.bt_cari.BackColor = System.Drawing.Color.Transparent;
            this.bt_cari.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
            this.bt_cari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cari.Font = new System.Drawing.Font("NewsGoth BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cari.ForeColor = System.Drawing.Color.Transparent;
            this.bt_cari.Image = ((System.Drawing.Image)(resources.GetObject("bt_cari.Image")));
            this.bt_cari.Location = new System.Drawing.Point(301, 37);
            this.bt_cari.Name = "bt_cari";
            this.bt_cari.Size = new System.Drawing.Size(49, 21);
            this.bt_cari.TabIndex = 254;
            this.bt_cari.UseVisualStyleBackColor = false;
            this.bt_cari.Click += new System.EventHandler(this.bt_cari_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 253;
            this.label3.Text = "Kelas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 252;
            this.label1.Text = "Tahun Ajaran";
            // 
            // tb_thn
            // 
            this.tb_thn.Location = new System.Drawing.Point(89, 12);
            this.tb_thn.Name = "tb_thn";
            this.tb_thn.Size = new System.Drawing.Size(206, 20);
            this.tb_thn.TabIndex = 251;
            this.tb_thn.Text = "2016 / 2017";
            // 
            // report_wakel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 457);
            this.Controls.Add(this.cb_kelas);
            this.Controls.Add(this.bt_cari);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_thn);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "report_wakel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan Walikelas";
            this.Load += new System.EventHandler(this.report_wakel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dasetwali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lap_walikelasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource lap_walikelasBindingSource;
        private dasetwali dasetwali;
        private dasetwaliTableAdapters.lap_walikelasTableAdapter lap_walikelasTableAdapter;
        private System.Windows.Forms.ComboBox cb_kelas;
        private System.Windows.Forms.Button bt_cari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_thn;


    }
}