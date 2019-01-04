namespace smkmm52
{
    partial class fr_add_pelajaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_add_pelajaran));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tb_cari1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_cari2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tb_cari3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_tambah = new System.Windows.Forms.Button();
            this.bt_hapus = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_simpan = new System.Windows.Forms.Button();
            this.dgv_plj = new System.Windows.Forms.DataGridView();
            this.tb_pel = new System.Windows.Forms.TextBox();
            this.tb_idpel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.cb_tipe = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_plj)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(21, 140);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(369, 69);
            this.tabControl1.TabIndex = 251;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tb_cari1);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(361, 43);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ID Pelajaran";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tb_cari1
            // 
            this.tb_cari1.Location = new System.Drawing.Point(95, 12);
            this.tb_cari1.Name = "tb_cari1";
            this.tb_cari1.Size = new System.Drawing.Size(248, 20);
            this.tb_cari1.TabIndex = 1;
            this.tb_cari1.TextChanged += new System.EventHandler(this.tb_cari1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "ID Pelajaran :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tb_cari2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(361, 43);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pelajaran";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_cari2
            // 
            this.tb_cari2.Location = new System.Drawing.Point(84, 11);
            this.tb_cari2.Name = "tb_cari2";
            this.tb_cari2.Size = new System.Drawing.Size(281, 20);
            this.tb_cari2.TabIndex = 3;
            this.tb_cari2.TextChanged += new System.EventHandler(this.tb_cari2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pelajaran :";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tb_cari3);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(361, 43);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tipe";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tb_cari3
            // 
            this.tb_cari3.Location = new System.Drawing.Point(91, 11);
            this.tb_cari3.Name = "tb_cari3";
            this.tb_cari3.Size = new System.Drawing.Size(270, 20);
            this.tb_cari3.TabIndex = 3;
            this.tb_cari3.TextChanged += new System.EventHandler(this.tb_cari3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipe :";
            // 
            // bt_tambah
            // 
            this.bt_tambah.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bt_tambah.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.bt_tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_tambah.Font = new System.Drawing.Font("NewsGoth BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tambah.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_tambah.Location = new System.Drawing.Point(21, 103);
            this.bt_tambah.Name = "bt_tambah";
            this.bt_tambah.Size = new System.Drawing.Size(69, 27);
            this.bt_tambah.TabIndex = 249;
            this.bt_tambah.Text = "Tambah";
            this.bt_tambah.UseVisualStyleBackColor = false;
            this.bt_tambah.Click += new System.EventHandler(this.bt_tambah_Click);
            // 
            // bt_hapus
            // 
            this.bt_hapus.BackColor = System.Drawing.Color.Red;
            this.bt_hapus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.bt_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_hapus.Font = new System.Drawing.Font("NewsGoth BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_hapus.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_hapus.Location = new System.Drawing.Point(321, 103);
            this.bt_hapus.Name = "bt_hapus";
            this.bt_hapus.Size = new System.Drawing.Size(69, 27);
            this.bt_hapus.TabIndex = 248;
            this.bt_hapus.Text = "Hapus";
            this.bt_hapus.UseVisualStyleBackColor = false;
            this.bt_hapus.Click += new System.EventHandler(this.bt_hapus_Click);
            // 
            // bt_update
            // 
            this.bt_update.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bt_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.bt_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_update.Font = new System.Drawing.Font("NewsGoth BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_update.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_update.Location = new System.Drawing.Point(171, 101);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(69, 27);
            this.bt_update.TabIndex = 247;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = false;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_simpan
            // 
            this.bt_simpan.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bt_simpan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.bt_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_simpan.Font = new System.Drawing.Font("NewsGoth BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_simpan.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_simpan.Location = new System.Drawing.Point(96, 103);
            this.bt_simpan.Name = "bt_simpan";
            this.bt_simpan.Size = new System.Drawing.Size(69, 27);
            this.bt_simpan.TabIndex = 246;
            this.bt_simpan.Text = "Simpan";
            this.bt_simpan.UseVisualStyleBackColor = false;
            this.bt_simpan.Click += new System.EventHandler(this.bt_simpan_Click);
            // 
            // dgv_plj
            // 
            this.dgv_plj.BackgroundColor = System.Drawing.Color.White;
            this.dgv_plj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_plj.Location = new System.Drawing.Point(21, 213);
            this.dgv_plj.Name = "dgv_plj";
            this.dgv_plj.Size = new System.Drawing.Size(365, 180);
            this.dgv_plj.TabIndex = 245;
            this.dgv_plj.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_plj_CellClick);
            // 
            // tb_pel
            // 
            this.tb_pel.Location = new System.Drawing.Point(94, 48);
            this.tb_pel.Name = "tb_pel";
            this.tb_pel.Size = new System.Drawing.Size(296, 20);
            this.tb_pel.TabIndex = 244;
            // 
            // tb_idpel
            // 
            this.tb_idpel.Location = new System.Drawing.Point(95, 22);
            this.tb_idpel.Name = "tb_idpel";
            this.tb_idpel.Size = new System.Drawing.Size(142, 20);
            this.tb_idpel.TabIndex = 243;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 242;
            this.label2.Text = "Pelajaran      ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 241;
            this.label1.Text = "ID Pelajaran ";
            // 
            // bt_refresh
            // 
            this.bt_refresh.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bt_refresh.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumTurquoise;
            this.bt_refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.bt_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_refresh.Font = new System.Drawing.Font("NewsGoth BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_refresh.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_refresh.Location = new System.Drawing.Point(246, 101);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(69, 27);
            this.bt_refresh.TabIndex = 263;
            this.bt_refresh.Text = "Refresh";
            this.bt_refresh.UseVisualStyleBackColor = false;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // cb_tipe
            // 
            this.cb_tipe.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cb_tipe.FormattingEnabled = true;
            this.cb_tipe.Items.AddRange(new object[] {
            "Produktif",
            "Normatif",
            "Adaptif",
            "Muatan Lokal"});
            this.cb_tipe.Location = new System.Drawing.Point(94, 74);
            this.cb_tipe.Name = "cb_tipe";
            this.cb_tipe.Size = new System.Drawing.Size(296, 21);
            this.cb_tipe.TabIndex = 265;
            this.cb_tipe.Text = "-- Pilihan --";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 264;
            this.label9.Text = "Tipe             ";
            // 
            // fr_add_pelajaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 415);
            this.Controls.Add(this.cb_tipe);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bt_refresh);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bt_tambah);
            this.Controls.Add(this.bt_hapus);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_simpan);
            this.Controls.Add(this.dgv_plj);
            this.Controls.Add(this.tb_pel);
            this.Controls.Add(this.tb_idpel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fr_add_pelajaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Pelajaran";
            this.Activated += new System.EventHandler(this.fr_add_pelajaran_Activated);
            this.Load += new System.EventHandler(this.fr_add_pelajaran_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_plj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tb_cari1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_cari2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_tambah;
        private System.Windows.Forms.Button bt_hapus;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_simpan;
        private System.Windows.Forms.DataGridView dgv_plj;
        private System.Windows.Forms.TextBox tb_pel;
        private System.Windows.Forms.TextBox tb_idpel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_refresh;
        private System.Windows.Forms.ComboBox cb_tipe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tb_cari3;
        private System.Windows.Forms.Label label4;
    }
}