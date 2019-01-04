namespace smkmm52
{
    partial class report_perguru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(report_perguru));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dasetperguru = new smkmm52.dasetperguru();
            this.lap_guruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lap_guruTableAdapter = new smkmm52.dasetperguruTableAdapters.lap_guruTableAdapter();
            this.bt_cari = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dasetperguru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lap_guruBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Data_Perguru";
            reportDataSource1.Value = this.lap_guruBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "smkmm52.reperguru.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 53);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(950, 478);
            this.reportViewer1.TabIndex = 0;
            // 
            // dasetperguru
            // 
            this.dasetperguru.DataSetName = "dasetperguru";
            this.dasetperguru.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lap_guruBindingSource
            // 
            this.lap_guruBindingSource.DataMember = "lap_guru";
            this.lap_guruBindingSource.DataSource = this.dasetperguru;
            // 
            // lap_guruTableAdapter
            // 
            this.lap_guruTableAdapter.ClearBeforeFill = true;
            // 
            // bt_cari
            // 
            this.bt_cari.BackColor = System.Drawing.Color.Transparent;
            this.bt_cari.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
            this.bt_cari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cari.Font = new System.Drawing.Font("NewsGoth BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cari.ForeColor = System.Drawing.Color.Transparent;
            this.bt_cari.Image = ((System.Drawing.Image)(resources.GetObject("bt_cari.Image")));
            this.bt_cari.Location = new System.Drawing.Point(301, 15);
            this.bt_cari.Name = "bt_cari";
            this.bt_cari.Size = new System.Drawing.Size(49, 21);
            this.bt_cari.TabIndex = 255;
            this.bt_cari.UseVisualStyleBackColor = false;
            this.bt_cari.Click += new System.EventHandler(this.bt_cari_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 254;
            this.label2.Text = "Nama Guru";
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(89, 15);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(206, 20);
            this.tb_nama.TabIndex = 253;
            // 
            // report_perguru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 532);
            this.Controls.Add(this.bt_cari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nama);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "report_perguru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan Guru";
            this.Load += new System.EventHandler(this.report_perguru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dasetperguru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lap_guruBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource lap_guruBindingSource;
        private dasetperguru dasetperguru;
        private dasetperguruTableAdapters.lap_guruTableAdapter lap_guruTableAdapter;
        private System.Windows.Forms.Button bt_cari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nama;
    }
}