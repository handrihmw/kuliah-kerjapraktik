namespace smkmm52
{
    partial class fr_konfigurasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_konfigurasi));
            this.dgv_anggota = new System.Windows.Forms.DataGridView();
            this.dgv_ak = new System.Windows.Forms.DataGridView();
            this.bt_proses = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_jurusan = new System.Windows.Forms.ComboBox();
            this.tb_jml = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_thn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_dsb = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_semester = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_tambah = new System.Windows.Forms.Button();
            this.bt_hapus = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_idak = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cb_jurusans = new System.Windows.Forms.ComboBox();
            this.rb_pr = new System.Windows.Forms.RadioButton();
            this.thn_ajarans = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rb_lk = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_nmsiswa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_nipd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bt_simpananggota = new System.Windows.Forms.Button();
            this.cb_kls = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.bt_ket = new System.Windows.Forms.Button();
            this.cb_jurusan1 = new System.Windows.Forms.ComboBox();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_thn1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_anggota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ak)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsb)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_anggota
            // 
            this.dgv_anggota.BackgroundColor = System.Drawing.Color.White;
            this.dgv_anggota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_anggota.Location = new System.Drawing.Point(281, 29);
            this.dgv_anggota.Name = "dgv_anggota";
            this.dgv_anggota.Size = new System.Drawing.Size(343, 197);
            this.dgv_anggota.TabIndex = 38;
            this.dgv_anggota.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_anggota_CellClick);
            // 
            // dgv_ak
            // 
            this.dgv_ak.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ak.Location = new System.Drawing.Point(15, 29);
            this.dgv_ak.Name = "dgv_ak";
            this.dgv_ak.Size = new System.Drawing.Size(349, 170);
            this.dgv_ak.TabIndex = 29;
            this.dgv_ak.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ak_CellClick);
            // 
            // bt_proses
            // 
            this.bt_proses.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_proses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.bt_proses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_proses.Font = new System.Drawing.Font("NewsGoth BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_proses.ForeColor = System.Drawing.Color.Transparent;
            this.bt_proses.Location = new System.Drawing.Point(114, 111);
            this.bt_proses.Name = "bt_proses";
            this.bt_proses.Size = new System.Drawing.Size(86, 34);
            this.bt_proses.TabIndex = 22;
            this.bt_proses.Text = "Proses";
            this.bt_proses.UseVisualStyleBackColor = false;
            this.bt_proses.Click += new System.EventHandler(this.bt_proses_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cb_jurusan);
            this.groupBox2.Controls.Add(this.tb_jml);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tb_thn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.bt_proses);
            this.groupBox2.Location = new System.Drawing.Point(845, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 167);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pembagian Kelas";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("NewsGoth BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(155, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 28);
            this.button1.TabIndex = 52;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_jurusan
            // 
            this.cb_jurusan.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cb_jurusan.FormattingEnabled = true;
            this.cb_jurusan.Items.AddRange(new object[] {
            "Teknik Telekomunikasi",
            "Agri Bisnis Produksi Tanaman"});
            this.cb_jurusan.Location = new System.Drawing.Point(90, 22);
            this.cb_jurusan.Name = "cb_jurusan";
            this.cb_jurusan.Size = new System.Drawing.Size(148, 21);
            this.cb_jurusan.TabIndex = 47;
            this.cb_jurusan.Text = "--Pilihan--";
            // 
            // tb_jml
            // 
            this.tb_jml.Location = new System.Drawing.Point(99, 78);
            this.tb_jml.Name = "tb_jml";
            this.tb_jml.Size = new System.Drawing.Size(50, 20);
            this.tb_jml.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Jumlah";
            // 
            // tb_thn
            // 
            this.tb_thn.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_thn.Location = new System.Drawing.Point(90, 49);
            this.tb_thn.Name = "tb_thn";
            this.tb_thn.Size = new System.Drawing.Size(148, 20);
            this.tb_thn.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Tahun Ajaran";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Jurusan";
            // 
            // dgv_dsb
            // 
            this.dgv_dsb.BackgroundColor = System.Drawing.Color.White;
            this.dgv_dsb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsb.Location = new System.Drawing.Point(16, 22);
            this.dgv_dsb.Name = "dgv_dsb";
            this.dgv_dsb.Size = new System.Drawing.Size(486, 123);
            this.dgv_dsb.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_dsb);
            this.groupBox1.Location = new System.Drawing.Point(26, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 167);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daftar Siswa Baru";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_ak);
            this.groupBox3.Location = new System.Drawing.Point(27, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 285);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Jumlah Siswa  Per Kelas";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_semester);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.bt_tambah);
            this.groupBox4.Controls.Add(this.bt_hapus);
            this.groupBox4.Controls.Add(this.bt_edit);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.tb_idak);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.cb_jurusans);
            this.groupBox4.Controls.Add(this.rb_pr);
            this.groupBox4.Controls.Add(this.thn_ajarans);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.rb_lk);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.tb_nmsiswa);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.tb_nipd);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.bt_simpananggota);
            this.groupBox4.Controls.Add(this.dgv_anggota);
            this.groupBox4.Controls.Add(this.cb_kls);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(449, 219);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(649, 285);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kelas Baru";
            // 
            // tb_semester
            // 
            this.tb_semester.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_semester.Location = new System.Drawing.Point(90, 210);
            this.tb_semester.Name = "tb_semester";
            this.tb_semester.Size = new System.Drawing.Size(163, 20);
            this.tb_semester.TabIndex = 291;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 290;
            this.label3.Text = "Semester";
            // 
            // bt_tambah
            // 
            this.bt_tambah.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_tambah.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumTurquoise;
            this.bt_tambah.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.bt_tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_tambah.Font = new System.Drawing.Font("NewsGoth BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tambah.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_tambah.Location = new System.Drawing.Point(311, 235);
            this.bt_tambah.Name = "bt_tambah";
            this.bt_tambah.Size = new System.Drawing.Size(69, 27);
            this.bt_tambah.TabIndex = 289;
            this.bt_tambah.Text = "Tambah";
            this.bt_tambah.UseVisualStyleBackColor = false;
            this.bt_tambah.Click += new System.EventHandler(this.bt_tambah_Click);
            // 
            // bt_hapus
            // 
            this.bt_hapus.BackColor = System.Drawing.Color.Red;
            this.bt_hapus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.bt_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_hapus.Font = new System.Drawing.Font("NewsGoth BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_hapus.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_hapus.Location = new System.Drawing.Point(536, 235);
            this.bt_hapus.Name = "bt_hapus";
            this.bt_hapus.Size = new System.Drawing.Size(69, 27);
            this.bt_hapus.TabIndex = 287;
            this.bt_hapus.Text = "Hapus";
            this.bt_hapus.UseVisualStyleBackColor = false;
            this.bt_hapus.Click += new System.EventHandler(this.bt_hapus_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.bt_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_edit.Font = new System.Drawing.Font("NewsGoth BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_edit.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_edit.Location = new System.Drawing.Point(461, 235);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(69, 27);
            this.bt_edit.TabIndex = 286;
            this.bt_edit.Text = "Update";
            this.bt_edit.UseVisualStyleBackColor = false;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("NewsGoth BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(386, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 27);
            this.button2.TabIndex = 288;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_idak
            // 
            this.tb_idak.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_idak.Location = new System.Drawing.Point(90, 29);
            this.tb_idak.Name = "tb_idak";
            this.tb_idak.Size = new System.Drawing.Size(163, 20);
            this.tb_idak.TabIndex = 241;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 240;
            this.label15.Text = "ID Anggota";
            // 
            // cb_jurusans
            // 
            this.cb_jurusans.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cb_jurusans.FormattingEnabled = true;
            this.cb_jurusans.Items.AddRange(new object[] {
            "Teknik Telekomunikasi",
            "Agri Bisnis Produksi Tanaman"});
            this.cb_jurusans.Location = new System.Drawing.Point(90, 130);
            this.cb_jurusans.Name = "cb_jurusans";
            this.cb_jurusans.Size = new System.Drawing.Size(163, 21);
            this.cb_jurusans.TabIndex = 53;
            this.cb_jurusans.Text = "--Pilihan--";
            // 
            // rb_pr
            // 
            this.rb_pr.AutoSize = true;
            this.rb_pr.Location = new System.Drawing.Point(179, 106);
            this.rb_pr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb_pr.Name = "rb_pr";
            this.rb_pr.Size = new System.Drawing.Size(79, 17);
            this.rb_pr.TabIndex = 239;
            this.rb_pr.TabStop = true;
            this.rb_pr.Text = "Perempuan";
            this.rb_pr.UseVisualStyleBackColor = true;
            this.rb_pr.CheckedChanged += new System.EventHandler(this.rb_pr_CheckedChanged);
            // 
            // thn_ajarans
            // 
            this.thn_ajarans.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.thn_ajarans.Location = new System.Drawing.Point(90, 157);
            this.thn_ajarans.Name = "thn_ajarans";
            this.thn_ajarans.Size = new System.Drawing.Size(163, 20);
            this.thn_ajarans.TabIndex = 52;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 51;
            this.label13.Text = "Tahun Ajaran";
            // 
            // rb_lk
            // 
            this.rb_lk.AutoSize = true;
            this.rb_lk.Location = new System.Drawing.Point(94, 106);
            this.rb_lk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb_lk.Name = "rb_lk";
            this.rb_lk.Size = new System.Drawing.Size(71, 17);
            this.rb_lk.TabIndex = 238;
            this.rb_lk.TabStop = true;
            this.rb_lk.Text = "Laki -Laki";
            this.rb_lk.UseVisualStyleBackColor = true;
            this.rb_lk.CheckedChanged += new System.EventHandler(this.rb_lk_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 50;
            this.label14.Text = "Jurusan";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 108);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 237;
            this.label12.Text = "Jenis Kelamin";
            // 
            // tb_nmsiswa
            // 
            this.tb_nmsiswa.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_nmsiswa.Location = new System.Drawing.Point(90, 80);
            this.tb_nmsiswa.Name = "tb_nmsiswa";
            this.tb_nmsiswa.Size = new System.Drawing.Size(163, 20);
            this.tb_nmsiswa.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Nama Siswa";
            // 
            // tb_nipd
            // 
            this.tb_nipd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_nipd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_nipd.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_nipd.Location = new System.Drawing.Point(90, 54);
            this.tb_nipd.Name = "tb_nipd";
            this.tb_nipd.Size = new System.Drawing.Size(163, 20);
            this.tb_nipd.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "NIPD";
            // 
            // bt_simpananggota
            // 
            this.bt_simpananggota.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_simpananggota.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.bt_simpananggota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_simpananggota.Font = new System.Drawing.Font("NewsGoth BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_simpananggota.ForeColor = System.Drawing.Color.Transparent;
            this.bt_simpananggota.Location = new System.Drawing.Point(118, 236);
            this.bt_simpananggota.Name = "bt_simpananggota";
            this.bt_simpananggota.Size = new System.Drawing.Size(103, 32);
            this.bt_simpananggota.TabIndex = 49;
            this.bt_simpananggota.Text = "Simpan";
            this.bt_simpananggota.UseVisualStyleBackColor = false;
            this.bt_simpananggota.Click += new System.EventHandler(this.bt_simpananggota_Click);
            // 
            // cb_kls
            // 
            this.cb_kls.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cb_kls.FormattingEnabled = true;
            this.cb_kls.Location = new System.Drawing.Point(90, 183);
            this.cb_kls.Name = "cb_kls";
            this.cb_kls.Size = new System.Drawing.Size(163, 21);
            this.cb_kls.TabIndex = 42;
            this.cb_kls.Text = "--Pilihan--";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Pilih Kelas";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.bt_refresh);
            this.groupBox5.Controls.Add(this.bt_ket);
            this.groupBox5.Controls.Add(this.cb_jurusan1);
            this.groupBox5.Controls.Add(this.tb_total);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.tb_thn1);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(567, 29);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(253, 167);
            this.groupBox5.TabIndex = 49;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Keterangan Jumlah Siswa";
            // 
            // bt_refresh
            // 
            this.bt_refresh.BackColor = System.Drawing.Color.Transparent;
            this.bt_refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.bt_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_refresh.Font = new System.Drawing.Font("NewsGoth BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_refresh.ForeColor = System.Drawing.Color.White;
            this.bt_refresh.Image = ((System.Drawing.Image)(resources.GetObject("bt_refresh.Image")));
            this.bt_refresh.Location = new System.Drawing.Point(146, 75);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(35, 28);
            this.bt_refresh.TabIndex = 51;
            this.bt_refresh.UseVisualStyleBackColor = false;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // bt_ket
            // 
            this.bt_ket.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_ket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.bt_ket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ket.Font = new System.Drawing.Font("NewsGoth BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ket.ForeColor = System.Drawing.Color.Transparent;
            this.bt_ket.Location = new System.Drawing.Point(95, 111);
            this.bt_ket.Name = "bt_ket";
            this.bt_ket.Size = new System.Drawing.Size(86, 34);
            this.bt_ket.TabIndex = 49;
            this.bt_ket.Text = "Proses";
            this.bt_ket.UseVisualStyleBackColor = false;
            this.bt_ket.Click += new System.EventHandler(this.bt_ket_Click);
            // 
            // cb_jurusan1
            // 
            this.cb_jurusan1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cb_jurusan1.FormattingEnabled = true;
            this.cb_jurusan1.Items.AddRange(new object[] {
            "Teknik Telekomunikasi",
            "Agri Bisnis Produksi Tanaman"});
            this.cb_jurusan1.Location = new System.Drawing.Point(90, 22);
            this.cb_jurusan1.Name = "cb_jurusan1";
            this.cb_jurusan1.Size = new System.Drawing.Size(148, 21);
            this.cb_jurusan1.TabIndex = 47;
            this.cb_jurusan1.Text = "--Pilihan--";
            // 
            // tb_total
            // 
            this.tb_total.Location = new System.Drawing.Point(90, 78);
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(50, 20);
            this.tb_total.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Jumlah Total";
            // 
            // tb_thn1
            // 
            this.tb_thn1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_thn1.Location = new System.Drawing.Point(90, 49);
            this.tb_thn1.Name = "tb_thn1";
            this.tb_thn1.Size = new System.Drawing.Size(148, 20);
            this.tb_thn1.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Tahun Ajaran";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Jurusan";
            // 
            // fr_konfigurasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 526);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fr_konfigurasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Konfigurasi Pembagian Kelas";
            this.Activated += new System.EventHandler(this.fr_konfigurasi_Activated);
            this.Load += new System.EventHandler(this.fr_konfigurasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_anggota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ak)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsb)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_anggota;
        private System.Windows.Forms.DataGridView dgv_ak;
        private System.Windows.Forms.Button bt_proses;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_dsb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_kls;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_thn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_jurusan;
        private System.Windows.Forms.TextBox tb_jml;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_simpananggota;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cb_jurusan1;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_thn1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_ket;
        private System.Windows.Forms.TextBox tb_nipd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_nmsiswa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_jurusans;
        private System.Windows.Forms.RadioButton rb_pr;
        private System.Windows.Forms.TextBox thn_ajarans;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rb_lk;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_idak;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button bt_refresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_tambah;
        private System.Windows.Forms.Button bt_hapus;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_semester;
        private System.Windows.Forms.Label label3;
    }
}