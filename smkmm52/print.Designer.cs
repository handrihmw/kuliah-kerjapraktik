namespace smkmm52
{
    partial class print
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(print));
            this.bt_setup = new System.Windows.Forms.Button();
            this.bt_preview = new System.Windows.Forms.Button();
            this.bt_print = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.dgv_print = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_print)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_setup
            // 
            this.bt_setup.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_setup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.bt_setup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_setup.Font = new System.Drawing.Font("NewsGoth BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_setup.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_setup.Location = new System.Drawing.Point(119, 259);
            this.bt_setup.Name = "bt_setup";
            this.bt_setup.Size = new System.Drawing.Size(96, 34);
            this.bt_setup.TabIndex = 248;
            this.bt_setup.Text = "Page Setup";
            this.bt_setup.UseVisualStyleBackColor = false;
            this.bt_setup.Click += new System.EventHandler(this.bt_conf_Click);
            // 
            // bt_preview
            // 
            this.bt_preview.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_preview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.bt_preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_preview.Font = new System.Drawing.Font("NewsGoth BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_preview.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_preview.Location = new System.Drawing.Point(232, 259);
            this.bt_preview.Name = "bt_preview";
            this.bt_preview.Size = new System.Drawing.Size(96, 34);
            this.bt_preview.TabIndex = 249;
            this.bt_preview.Text = "Preview";
            this.bt_preview.UseVisualStyleBackColor = false;
            this.bt_preview.Click += new System.EventHandler(this.bt_preview_Click);
            // 
            // bt_print
            // 
            this.bt_print.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_print.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.bt_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_print.Font = new System.Drawing.Font("NewsGoth BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_print.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_print.Location = new System.Drawing.Point(346, 259);
            this.bt_print.Name = "bt_print";
            this.bt_print.Size = new System.Drawing.Size(96, 34);
            this.bt_print.TabIndex = 250;
            this.bt_print.Text = "Print";
            this.bt_print.UseVisualStyleBackColor = false;
            this.bt_print.Click += new System.EventHandler(this.bt_print_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // dgv_print
            // 
            this.dgv_print.BackgroundColor = System.Drawing.Color.White;
            this.dgv_print.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_print.Location = new System.Drawing.Point(12, 12);
            this.dgv_print.Name = "dgv_print";
            this.dgv_print.Size = new System.Drawing.Size(527, 232);
            this.dgv_print.TabIndex = 251;
            // 
            // print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(551, 321);
            this.Controls.Add(this.dgv_print);
            this.Controls.Add(this.bt_print);
            this.Controls.Add(this.bt_preview);
            this.Controls.Add(this.bt_setup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "print";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Setting";
            this.Load += new System.EventHandler(this.print_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_print)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_setup;
        private System.Windows.Forms.Button bt_preview;
        private System.Windows.Forms.Button bt_print;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridView dgv_print;
    }
}