namespace perpustakaan_app
{
    partial class buku_form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_header = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_judul = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pengarang = new System.Windows.Forms.TextBox();
            this.txt_penerbit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tahun = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_stok = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmb_kategori = new System.Windows.Forms.ComboBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.label_header);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 63);
            this.panel1.TabIndex = 0;
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_header.Location = new System.Drawing.Point(12, 19);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(129, 25);
            this.label_header.TabIndex = 0;
            this.label_header.Text = "Tambah Buku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Buku";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(89, 95);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(120, 25);
            this.txt_id.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Judul";
            // 
            // txt_judul
            // 
            this.txt_judul.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_judul.Location = new System.Drawing.Point(89, 138);
            this.txt_judul.Name = "txt_judul";
            this.txt_judul.Size = new System.Drawing.Size(304, 25);
            this.txt_judul.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pengarang";
            // 
            // txt_pengarang
            // 
            this.txt_pengarang.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pengarang.Location = new System.Drawing.Point(89, 182);
            this.txt_pengarang.Name = "txt_pengarang";
            this.txt_pengarang.Size = new System.Drawing.Size(189, 25);
            this.txt_pengarang.TabIndex = 6;
            // 
            // txt_penerbit
            // 
            this.txt_penerbit.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_penerbit.Location = new System.Drawing.Point(89, 227);
            this.txt_penerbit.Name = "txt_penerbit";
            this.txt_penerbit.Size = new System.Drawing.Size(169, 25);
            this.txt_penerbit.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Penerbit";
            // 
            // txt_tahun
            // 
            this.txt_tahun.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tahun.Location = new System.Drawing.Point(89, 270);
            this.txt_tahun.Name = "txt_tahun";
            this.txt_tahun.Size = new System.Drawing.Size(77, 25);
            this.txt_tahun.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tahun";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Kategori";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Stok";
            // 
            // txt_stok
            // 
            this.txt_stok.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stok.Location = new System.Drawing.Point(89, 358);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(77, 25);
            this.txt_stok.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.btn_reset);
            this.panel2.Controls.Add(this.btn_tambah);
            this.panel2.Location = new System.Drawing.Point(-1, 412);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 67);
            this.panel2.TabIndex = 15;
            // 
            // cmb_kategori
            // 
            this.cmb_kategori.DropDownHeight = 200;
            this.cmb_kategori.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_kategori.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmb_kategori.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.cmb_kategori.IntegralHeight = false;
            this.cmb_kategori.ItemHeight = 16;
            this.cmb_kategori.Location = new System.Drawing.Point(88, 315);
            this.cmb_kategori.Name = "cmb_kategori";
            this.cmb_kategori.Size = new System.Drawing.Size(170, 24);
            this.cmb_kategori.TabIndex = 16;
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
            // buku_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(413, 476);
            this.Controls.Add(this.cmb_kategori);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_stok);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_tahun);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_penerbit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_pengarang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_judul);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "buku_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_reset;
        public System.Windows.Forms.TextBox txt_id;
        public System.Windows.Forms.Label label_header;
        public System.Windows.Forms.TextBox txt_judul;
        public System.Windows.Forms.TextBox txt_pengarang;
        public System.Windows.Forms.TextBox txt_penerbit;
        public System.Windows.Forms.TextBox txt_tahun;
        public System.Windows.Forms.TextBox txt_stok;
        public System.Windows.Forms.ComboBox cmb_kategori;
        public System.Windows.Forms.Button btn_update;
        public System.Windows.Forms.Button btn_tambah;
    }
}