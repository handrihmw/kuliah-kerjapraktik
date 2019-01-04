namespace smkmm52
{
    partial class fr_lap_walikelas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_lap_walikelas));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_lapwk = new System.Windows.Forms.DataGridView();
            this.cb_kls = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_thn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_cari = new System.Windows.Forms.Button();
            this.tb_idwk = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lapwk)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NewsGoth BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "ex : 2016/2017";
            // 
            // dgv_lapwk
            // 
            this.dgv_lapwk.BackgroundColor = System.Drawing.Color.White;
            this.dgv_lapwk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lapwk.Location = new System.Drawing.Point(45, 97);
            this.dgv_lapwk.Name = "dgv_lapwk";
            this.dgv_lapwk.Size = new System.Drawing.Size(533, 213);
            this.dgv_lapwk.TabIndex = 37;
            // 
            // cb_kls
            // 
            this.cb_kls.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cb_kls.FormattingEnabled = true;
            this.cb_kls.Location = new System.Drawing.Point(130, 58);
            this.cb_kls.Name = "cb_kls";
            this.cb_kls.Size = new System.Drawing.Size(255, 21);
            this.cb_kls.TabIndex = 34;
            this.cb_kls.Text = "--Pilihan--";
            this.cb_kls.TextChanged += new System.EventHandler(this.cb_kls_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NewsGoth BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Kelas";
            // 
            // tb_thn
            // 
            this.tb_thn.Location = new System.Drawing.Point(130, 30);
            this.tb_thn.Name = "tb_thn";
            this.tb_thn.Size = new System.Drawing.Size(113, 20);
            this.tb_thn.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NewsGoth BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 31;
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
            this.bt_cari.Location = new System.Drawing.Point(391, 57);
            this.bt_cari.Name = "bt_cari";
            this.bt_cari.Size = new System.Drawing.Size(49, 21);
            this.bt_cari.TabIndex = 39;
            this.bt_cari.UseVisualStyleBackColor = false;
            this.bt_cari.Click += new System.EventHandler(this.bt_cari_Click);
            // 
            // tb_idwk
            // 
            this.tb_idwk.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_idwk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_idwk.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tb_idwk.Location = new System.Drawing.Point(432, 12);
            this.tb_idwk.Name = "tb_idwk";
            this.tb_idwk.Size = new System.Drawing.Size(37, 13);
            this.tb_idwk.TabIndex = 40;
            this.tb_idwk.TextChanged += new System.EventHandler(this.tb_idwk_TextChanged);
            // 
            // fr_lap_walikelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(620, 346);
            this.Controls.Add(this.tb_idwk);
            this.Controls.Add(this.bt_cari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_lapwk);
            this.Controls.Add(this.cb_kls);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_thn);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fr_lap_walikelas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan Data Wali Kelas";
            this.Load += new System.EventHandler(this.fr_lap_walikelas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lapwk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_lapwk;
        private System.Windows.Forms.ComboBox cb_kls;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_thn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_cari;
        private System.Windows.Forms.TextBox tb_idwk;
    }
}