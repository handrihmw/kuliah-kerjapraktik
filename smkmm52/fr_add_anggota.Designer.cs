namespace smkmm52
{
    partial class fr_add_anggota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_add_anggota));
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_cari = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_kls = new System.Windows.Forms.ComboBox();
            this.tb_thn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_ak1 = new System.Windows.Forms.DataGridView();
            this.bt_hapus = new System.Windows.Forms.Button();
            this.bt_conf = new System.Windows.Forms.Button();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ak1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox13
            // 
            this.groupBox13.BackColor = System.Drawing.Color.Transparent;
            this.groupBox13.Controls.Add(this.label6);
            this.groupBox13.Controls.Add(this.bt_cari);
            this.groupBox13.Controls.Add(this.label2);
            this.groupBox13.Controls.Add(this.cb_kls);
            this.groupBox13.Controls.Add(this.tb_thn);
            this.groupBox13.Controls.Add(this.label3);
            this.groupBox13.Location = new System.Drawing.Point(23, 28);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(469, 96);
            this.groupBox13.TabIndex = 24;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Data Anggota Kelas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 285;
            this.label6.Text = "ex : 2016 / 2017";
            // 
            // bt_cari
            // 
            this.bt_cari.BackColor = System.Drawing.Color.Transparent;
            this.bt_cari.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.bt_cari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cari.Font = new System.Drawing.Font("NewsGoth BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cari.ForeColor = System.Drawing.Color.Transparent;
            this.bt_cari.Image = ((System.Drawing.Image)(resources.GetObject("bt_cari.Image")));
            this.bt_cari.Location = new System.Drawing.Point(340, 49);
            this.bt_cari.Name = "bt_cari";
            this.bt_cari.Size = new System.Drawing.Size(49, 21);
            this.bt_cari.TabIndex = 248;
            this.bt_cari.UseVisualStyleBackColor = false;
            this.bt_cari.Click += new System.EventHandler(this.bt_cari_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NewsGoth BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tahun Ajaran";
            // 
            // cb_kls
            // 
            this.cb_kls.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cb_kls.FormattingEnabled = true;
            this.cb_kls.Location = new System.Drawing.Point(94, 49);
            this.cb_kls.Name = "cb_kls";
            this.cb_kls.Size = new System.Drawing.Size(240, 21);
            this.cb_kls.TabIndex = 19;
            this.cb_kls.Text = "-- Pilihan --";
            // 
            // tb_thn
            // 
            this.tb_thn.Location = new System.Drawing.Point(94, 21);
            this.tb_thn.Name = "tb_thn";
            this.tb_thn.Size = new System.Drawing.Size(240, 20);
            this.tb_thn.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NewsGoth BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Kelas";
            // 
            // dgv_ak1
            // 
            this.dgv_ak1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_ak1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ak1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_ak1.Location = new System.Drawing.Point(23, 130);
            this.dgv_ak1.Name = "dgv_ak1";
            this.dgv_ak1.Size = new System.Drawing.Size(608, 208);
            this.dgv_ak1.TabIndex = 25;
            // 
            // bt_hapus
            // 
            this.bt_hapus.BackColor = System.Drawing.Color.Red;
            this.bt_hapus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.bt_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_hapus.Font = new System.Drawing.Font("NewsGoth BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_hapus.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_hapus.Location = new System.Drawing.Point(23, 344);
            this.bt_hapus.Name = "bt_hapus";
            this.bt_hapus.Size = new System.Drawing.Size(76, 29);
            this.bt_hapus.TabIndex = 246;
            this.bt_hapus.Text = "Hapus";
            this.bt_hapus.UseVisualStyleBackColor = false;
            this.bt_hapus.Click += new System.EventHandler(this.bt_hapus_Click);
            // 
            // bt_conf
            // 
            this.bt_conf.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_conf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.bt_conf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_conf.Font = new System.Drawing.Font("NewsGoth BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_conf.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_conf.Location = new System.Drawing.Point(517, 54);
            this.bt_conf.Name = "bt_conf";
            this.bt_conf.Size = new System.Drawing.Size(114, 44);
            this.bt_conf.TabIndex = 247;
            this.bt_conf.Text = "Konfigurasi";
            this.bt_conf.UseVisualStyleBackColor = false;
            this.bt_conf.Click += new System.EventHandler(this.bt_conf_Click);
            // 
            // fr_add_anggota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 395);
            this.Controls.Add(this.bt_conf);
            this.Controls.Add(this.bt_hapus);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.dgv_ak1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fr_add_anggota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah Anggota Kelas";
            this.Load += new System.EventHandler(this.fr_add_anggota_Load);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ak1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_kls;
        private System.Windows.Forms.TextBox tb_thn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_ak1;
        private System.Windows.Forms.Button bt_hapus;
        private System.Windows.Forms.Button bt_cari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_conf;
    }
}