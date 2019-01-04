namespace smkmm52
{
    partial class fr_add_kelas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_add_kelas));
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_cari2 = new System.Windows.Forms.TextBox();
            this.tb_cari1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.bt_hapus = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_simpan = new System.Windows.Forms.Button();
            this.dgv_kls = new System.Windows.Forms.DataGridView();
            this.tb_kls = new System.Windows.Forms.TextBox();
            this.tb_idKelas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_tambah = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kls)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Berdasarkan Kelas :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tb_cari2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(360, 43);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kelas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_cari2
            // 
            this.tb_cari2.Location = new System.Drawing.Point(121, 11);
            this.tb_cari2.Name = "tb_cari2";
            this.tb_cari2.Size = new System.Drawing.Size(299, 20);
            this.tb_cari2.TabIndex = 3;
            this.tb_cari2.TextChanged += new System.EventHandler(this.tb_cari2_TextChanged);
            // 
            // tb_cari1
            // 
            this.tb_cari1.Location = new System.Drawing.Point(132, 13);
            this.tb_cari1.Name = "tb_cari1";
            this.tb_cari1.Size = new System.Drawing.Size(208, 20);
            this.tb_cari1.TabIndex = 1;
            this.tb_cari1.TextChanged += new System.EventHandler(this.tb_cari1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Berdasarkan ID Kelas :";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tb_cari1);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(360, 43);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ID Kelas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(27, 125);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(368, 69);
            this.tabControl1.TabIndex = 240;
            // 
            // bt_refresh
            // 
            this.bt_refresh.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bt_refresh.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumTurquoise;
            this.bt_refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.bt_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_refresh.Font = new System.Drawing.Font("NewsGoth BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_refresh.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_refresh.Location = new System.Drawing.Point(251, 82);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(69, 27);
            this.bt_refresh.TabIndex = 238;
            this.bt_refresh.Text = "Refresh";
            this.bt_refresh.UseVisualStyleBackColor = false;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // bt_hapus
            // 
            this.bt_hapus.BackColor = System.Drawing.Color.Red;
            this.bt_hapus.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumTurquoise;
            this.bt_hapus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.bt_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_hapus.Font = new System.Drawing.Font("NewsGoth BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_hapus.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_hapus.Location = new System.Drawing.Point(326, 82);
            this.bt_hapus.Name = "bt_hapus";
            this.bt_hapus.Size = new System.Drawing.Size(69, 27);
            this.bt_hapus.TabIndex = 237;
            this.bt_hapus.Text = "Hapus";
            this.bt_hapus.UseVisualStyleBackColor = false;
            this.bt_hapus.Click += new System.EventHandler(this.bt_hapus_Click);
            // 
            // bt_update
            // 
            this.bt_update.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bt_update.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumTurquoise;
            this.bt_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.bt_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_update.Font = new System.Drawing.Font("NewsGoth BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_update.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_update.Location = new System.Drawing.Point(176, 82);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(69, 27);
            this.bt_update.TabIndex = 236;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = false;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_simpan
            // 
            this.bt_simpan.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bt_simpan.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumTurquoise;
            this.bt_simpan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.bt_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_simpan.Font = new System.Drawing.Font("NewsGoth BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_simpan.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_simpan.Location = new System.Drawing.Point(101, 82);
            this.bt_simpan.Name = "bt_simpan";
            this.bt_simpan.Size = new System.Drawing.Size(69, 27);
            this.bt_simpan.TabIndex = 235;
            this.bt_simpan.Text = "Simpan";
            this.bt_simpan.UseVisualStyleBackColor = false;
            this.bt_simpan.Click += new System.EventHandler(this.bt_simpan_Click);
            // 
            // dgv_kls
            // 
            this.dgv_kls.BackgroundColor = System.Drawing.Color.White;
            this.dgv_kls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kls.Location = new System.Drawing.Point(27, 211);
            this.dgv_kls.Name = "dgv_kls";
            this.dgv_kls.Size = new System.Drawing.Size(364, 169);
            this.dgv_kls.TabIndex = 234;
            this.dgv_kls.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_kls_CellClick);
            // 
            // tb_kls
            // 
            this.tb_kls.Location = new System.Drawing.Point(85, 47);
            this.tb_kls.Name = "tb_kls";
            this.tb_kls.Size = new System.Drawing.Size(310, 20);
            this.tb_kls.TabIndex = 233;
            // 
            // tb_idKelas
            // 
            this.tb_idKelas.Location = new System.Drawing.Point(86, 21);
            this.tb_idKelas.Name = "tb_idKelas";
            this.tb_idKelas.Size = new System.Drawing.Size(309, 20);
            this.tb_idKelas.TabIndex = 232;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 231;
            this.label2.Text = "Kelas      ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 230;
            this.label1.Text = "ID Kelas ";
            // 
            // bt_tambah
            // 
            this.bt_tambah.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bt_tambah.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumTurquoise;
            this.bt_tambah.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.bt_tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_tambah.Font = new System.Drawing.Font("NewsGoth BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tambah.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_tambah.Location = new System.Drawing.Point(26, 82);
            this.bt_tambah.Name = "bt_tambah";
            this.bt_tambah.Size = new System.Drawing.Size(69, 27);
            this.bt_tambah.TabIndex = 241;
            this.bt_tambah.Text = "Tambah";
            this.bt_tambah.UseVisualStyleBackColor = false;
            this.bt_tambah.Click += new System.EventHandler(this.bt_tambah_Click);
            // 
            // fr_add_kelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 404);
            this.Controls.Add(this.bt_tambah);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bt_refresh);
            this.Controls.Add(this.bt_hapus);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_simpan);
            this.Controls.Add(this.dgv_kls);
            this.Controls.Add(this.tb_kls);
            this.Controls.Add(this.tb_idKelas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fr_add_kelas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Kelas";
            this.Activated += new System.EventHandler(this.fr_add_kelas_Activated);
            this.Load += new System.EventHandler(this.fr_add_kelas_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_cari2;
        private System.Windows.Forms.TextBox tb_cari1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button bt_refresh;
        private System.Windows.Forms.Button bt_hapus;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_simpan;
        private System.Windows.Forms.DataGridView dgv_kls;
        private System.Windows.Forms.TextBox tb_kls;
        private System.Windows.Forms.TextBox tb_idKelas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_tambah;
    }
}