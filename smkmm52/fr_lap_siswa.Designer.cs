namespace smkmm52
{
    partial class fr_lap_siswa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_lap_siswa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_ss = new System.Windows.Forms.RadioButton();
            this.rb_k = new System.Windows.Forms.RadioButton();
            this.rb_s = new System.Windows.Forms.RadioButton();
            this.tb_cari1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tb_cari = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.dgv_laps = new System.Windows.Forms.DataGridView();
            this.tc_s = new System.Windows.Forms.TabControl();
            this.cb_kls = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_thn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_cari = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_laps)).BeginInit();
            this.tc_s.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.rb_ss);
            this.panel1.Controls.Add(this.rb_k);
            this.panel1.Controls.Add(this.rb_s);
            this.panel1.Location = new System.Drawing.Point(28, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 43);
            this.panel1.TabIndex = 22;
            // 
            // rb_ss
            // 
            this.rb_ss.AutoSize = true;
            this.rb_ss.Font = new System.Drawing.Font("NewsGoth BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_ss.Location = new System.Drawing.Point(588, 10);
            this.rb_ss.Name = "rb_ss";
            this.rb_ss.Size = new System.Drawing.Size(170, 22);
            this.rb_ss.TabIndex = 1;
            this.rb_ss.TabStop = true;
            this.rb_ss.Text = "Laporan Semua Siswa";
            this.rb_ss.UseVisualStyleBackColor = true;
            this.rb_ss.CheckedChanged += new System.EventHandler(this.rb_ss_CheckedChanged);
            this.rb_ss.Click += new System.EventHandler(this.rb_ss_Click);
            // 
            // rb_k
            // 
            this.rb_k.AutoSize = true;
            this.rb_k.Font = new System.Drawing.Font("NewsGoth BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_k.Location = new System.Drawing.Point(341, 10);
            this.rb_k.Name = "rb_k";
            this.rb_k.Size = new System.Drawing.Size(145, 22);
            this.rb_k.TabIndex = 2;
            this.rb_k.TabStop = true;
            this.rb_k.Text = "Laporan Per Kelas";
            this.rb_k.UseVisualStyleBackColor = true;
            this.rb_k.CheckedChanged += new System.EventHandler(this.rb_k_CheckedChanged);
            this.rb_k.Click += new System.EventHandler(this.rb_k_Click);
            // 
            // rb_s
            // 
            this.rb_s.AutoSize = true;
            this.rb_s.Font = new System.Drawing.Font("NewsGoth BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_s.Location = new System.Drawing.Point(33, 10);
            this.rb_s.Name = "rb_s";
            this.rb_s.Size = new System.Drawing.Size(148, 22);
            this.rb_s.TabIndex = 0;
            this.rb_s.TabStop = true;
            this.rb_s.Text = "Laporan Per Siswa";
            this.rb_s.UseVisualStyleBackColor = true;
            this.rb_s.CheckedChanged += new System.EventHandler(this.rb_s_CheckedChanged);
            this.rb_s.Click += new System.EventHandler(this.rb_s_Click);
            // 
            // tb_cari1
            // 
            this.tb_cari1.Location = new System.Drawing.Point(90, 12);
            this.tb_cari1.Name = "tb_cari1";
            this.tb_cari1.Size = new System.Drawing.Size(196, 20);
            this.tb_cari1.TabIndex = 4;
            this.tb_cari1.TextChanged += new System.EventHandler(this.tb_cari1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nama Siswa :";
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.tb_cari1);
            this.tabPage9.Controls.Add(this.label9);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(303, 45);
            this.tabPage9.TabIndex = 1;
            this.tabPage9.Text = "Nama Siswa";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tb_cari
            // 
            this.tb_cari.Location = new System.Drawing.Point(57, 12);
            this.tb_cari.Name = "tb_cari";
            this.tb_cari.Size = new System.Drawing.Size(233, 20);
            this.tb_cari.TabIndex = 1;
            this.tb_cari.TextChanged += new System.EventHandler(this.tb_cari_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "NIPD :";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.tb_cari);
            this.tabPage8.Controls.Add(this.label4);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(303, 45);
            this.tabPage8.TabIndex = 0;
            this.tabPage8.Text = "NIPD";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // dgv_laps
            // 
            this.dgv_laps.BackgroundColor = System.Drawing.Color.White;
            this.dgv_laps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_laps.Location = new System.Drawing.Point(24, 169);
            this.dgv_laps.Name = "dgv_laps";
            this.dgv_laps.Size = new System.Drawing.Size(781, 214);
            this.dgv_laps.TabIndex = 21;
            // 
            // tc_s
            // 
            this.tc_s.Controls.Add(this.tabPage8);
            this.tc_s.Controls.Add(this.tabPage9);
            this.tc_s.Location = new System.Drawing.Point(24, 82);
            this.tc_s.Name = "tc_s";
            this.tc_s.SelectedIndex = 0;
            this.tc_s.Size = new System.Drawing.Size(311, 71);
            this.tc_s.TabIndex = 20;
            // 
            // cb_kls
            // 
            this.cb_kls.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cb_kls.FormattingEnabled = true;
            this.cb_kls.Location = new System.Drawing.Point(443, 132);
            this.cb_kls.Name = "cb_kls";
            this.cb_kls.Size = new System.Drawing.Size(141, 21);
            this.cb_kls.TabIndex = 17;
            this.cb_kls.Text = "-- Pilhan --";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NewsGoth BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Kelas";
            // 
            // tb_thn
            // 
            this.tb_thn.Location = new System.Drawing.Point(443, 104);
            this.tb_thn.Name = "tb_thn";
            this.tb_thn.Size = new System.Drawing.Size(141, 20);
            this.tb_thn.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NewsGoth BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tahun Ajaran";
            // 
            // bt_cari
            // 
            this.bt_cari.BackColor = System.Drawing.Color.Transparent;
            this.bt_cari.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.bt_cari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cari.Font = new System.Drawing.Font("NewsGoth BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cari.ForeColor = System.Drawing.Color.Transparent;
            this.bt_cari.Image = ((System.Drawing.Image)(resources.GetObject("bt_cari.Image")));
            this.bt_cari.Location = new System.Drawing.Point(590, 132);
            this.bt_cari.Name = "bt_cari";
            this.bt_cari.Size = new System.Drawing.Size(49, 21);
            this.bt_cari.TabIndex = 40;
            this.bt_cari.UseVisualStyleBackColor = false;
            this.bt_cari.Click += new System.EventHandler(this.bt_cari_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(590, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 285;
            this.label6.Text = "ex : 2016 / 2017";
            // 
            // fr_lap_siswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(828, 415);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt_cari);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_laps);
            this.Controls.Add(this.tc_s);
            this.Controls.Add(this.cb_kls);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_thn);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fr_lap_siswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan Data Siswa";
            this.Load += new System.EventHandler(this.fr_lap_siswa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_laps)).EndInit();
            this.tc_s.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rb_ss;
        private System.Windows.Forms.RadioButton rb_k;
        private System.Windows.Forms.RadioButton rb_s;
        private System.Windows.Forms.TextBox tb_cari1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TextBox tb_cari;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.DataGridView dgv_laps;
        private System.Windows.Forms.TabControl tc_s;
        private System.Windows.Forms.ComboBox cb_kls;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_thn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_cari;
        private System.Windows.Forms.Label label6;
    }
}