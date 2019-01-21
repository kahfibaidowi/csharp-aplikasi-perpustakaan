namespace perpustakaan_app
{
    partial class rak_buku_form
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_kategori = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_header = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.btn_reset);
            this.panel2.Controls.Add(this.btn_tambah);
            this.panel2.Location = new System.Drawing.Point(-1, 411);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 67);
            this.panel2.TabIndex = 31;
            // 
            // txt_kategori
            // 
            this.txt_kategori.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kategori.Location = new System.Drawing.Point(89, 157);
            this.txt_kategori.Name = "txt_kategori";
            this.txt_kategori.Size = new System.Drawing.Size(304, 25);
            this.txt_kategori.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Kategori";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(89, 114);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(116, 25);
            this.txt_id.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.label_header);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 63);
            this.panel1.TabIndex = 17;
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_header.Location = new System.Drawing.Point(12, 19);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(166, 25);
            this.label_header.TabIndex = 0;
            this.label_header.Text = "Tambah Rak Buku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID Rak";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_update.Image = global::perpustakaan_app.Properties.Resources.update;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(18, 20);
            this.btn_update.Name = "btn_update";
            this.btn_update.Padding = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.btn_update.Size = new System.Drawing.Size(87, 32);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "UPDATE";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_reset.Image = global::perpustakaan_app.Properties.Resources.hapus;
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(114, 20);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Padding = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.btn_reset.Size = new System.Drawing.Size(80, 32);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "RESET";
            this.btn_reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_tambah
            // 
            this.btn_tambah.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_tambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_tambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tambah.FlatAppearance.BorderSize = 0;
            this.btn_tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tambah.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tambah.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_tambah.Image = global::perpustakaan_app.Properties.Resources.simpan;
            this.btn_tambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tambah.Location = new System.Drawing.Point(18, 20);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Padding = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.btn_tambah.Size = new System.Drawing.Size(87, 32);
            this.btn_tambah.TabIndex = 9;
            this.btn_tambah.Text = "SIMPAN";
            this.btn_tambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_tambah.UseVisualStyleBackColor = false;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // rak_buku_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(413, 476);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_kategori);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "rak_buku_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_reset;
        public System.Windows.Forms.Button btn_tambah;
        public System.Windows.Forms.TextBox txt_kategori;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label_header;
        private System.Windows.Forms.Label label2;
    }
}