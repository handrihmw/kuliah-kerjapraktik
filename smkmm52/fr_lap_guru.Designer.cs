namespace smkmm52
{
    partial class fr_lap_guru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_lap_guru));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_sg = new System.Windows.Forms.RadioButton();
            this.rb_g = new System.Windows.Forms.RadioButton();
            this.tb_cari1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tb_cari = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.dgv_lapg = new System.Windows.Forms.DataGridView();
            this.tc_g = new System.Windows.Forms.TabControl();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lapg)).BeginInit();
            this.tc_g.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.rb_sg);
            this.panel1.Controls.Add(this.rb_g);
            this.panel1.Location = new System.Drawing.Point(29, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 43);
            this.panel1.TabIndex = 34;
            // 
            // rb_sg
            // 
            this.rb_sg.AutoSize = true;
            this.rb_sg.Font = new System.Drawing.Font("NewsGoth BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_sg.Location = new System.Drawing.Point(299, 11);
            this.rb_sg.Name = "rb_sg";
            this.rb_sg.Size = new System.Drawing.Size(163, 22);
            this.rb_sg.TabIndex = 1;
            this.rb_sg.TabStop = true;
            this.rb_sg.Text = "Laporan Semua Guru";
            this.rb_sg.UseVisualStyleBackColor = true;
            this.rb_sg.CheckedChanged += new System.EventHandler(this.rb_sg_CheckedChanged);
            this.rb_sg.Click += new System.EventHandler(this.rb_sg_Click);
            // 
            // rb_g
            // 
            this.rb_g.AutoSize = true;
            this.rb_g.Font = new System.Drawing.Font("NewsGoth BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_g.Location = new System.Drawing.Point(16, 11);
            this.rb_g.Name = "rb_g";
            this.rb_g.Size = new System.Drawing.Size(141, 22);
            this.rb_g.TabIndex = 0;
            this.rb_g.TabStop = true;
            this.rb_g.Text = "Laporan Per Guru";
            this.rb_g.UseVisualStyleBackColor = true;
            this.rb_g.CheckedChanged += new System.EventHandler(this.rb_g_CheckedChanged);
            this.rb_g.Click += new System.EventHandler(this.rb_g_Click);
            // 
            // tb_cari1
            // 
            this.tb_cari1.Location = new System.Drawing.Point(89, 14);
            this.tb_cari1.Name = "tb_cari1";
            this.tb_cari1.Size = new System.Drawing.Size(196, 20);
            this.tb_cari1.TabIndex = 4;
            this.tb_cari1.TextChanged += new System.EventHandler(this.tb_cari1_TextChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 17);
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
            this.tabPage9.Text = "Nama Guru";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tb_cari
            // 
            this.tb_cari.Location = new System.Drawing.Point(53, 13);
            this.tb_cari.Name = "tb_cari";
            this.tb_cari.Size = new System.Drawing.Size(233, 20);
            this.tb_cari.TabIndex = 1;
            this.tb_cari.TextChanged += new System.EventHandler(this.tb_cari_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "NIP :";
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
            this.tabPage8.Text = "NIP";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // dgv_lapg
            // 
            this.dgv_lapg.BackgroundColor = System.Drawing.Color.White;
            this.dgv_lapg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lapg.Location = new System.Drawing.Point(25, 164);
            this.dgv_lapg.Name = "dgv_lapg";
            this.dgv_lapg.Size = new System.Drawing.Size(569, 209);
            this.dgv_lapg.TabIndex = 33;
            // 
            // tc_g
            // 
            this.tc_g.Controls.Add(this.tabPage8);
            this.tc_g.Controls.Add(this.tabPage9);
            this.tc_g.Location = new System.Drawing.Point(25, 77);
            this.tc_g.Name = "tc_g";
            this.tc_g.SelectedIndex = 0;
            this.tc_g.Size = new System.Drawing.Size(311, 71);
            this.tc_g.TabIndex = 32;
            // 
            // fr_lap_guru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(621, 395);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_lapg);
            this.Controls.Add(this.tc_g);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fr_lap_guru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan Data Guru";
            this.Load += new System.EventHandler(this.fr_lap_guru_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lapg)).EndInit();
            this.tc_g.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rb_sg;
        private System.Windows.Forms.RadioButton rb_g;
        private System.Windows.Forms.TextBox tb_cari1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TextBox tb_cari;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.DataGridView dgv_lapg;
        private System.Windows.Forms.TabControl tc_g;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}