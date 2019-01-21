namespace perpustakaan_client
{
    partial class halaman_utama
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cari = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.dgv_hasil_cari = new System.Windows.Forms.DataGridView();
            this.cmb_kategori = new System.Windows.Forms.ComboBox();
            this.txt_cari = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txt_id_member = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_cari_member = new System.Windows.Forms.Button();
            this.txt_alamat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rd_n = new System.Windows.Forms.RadioButton();
            this.rd_y = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hasil_cari)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1349, 126);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(481, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "PERPUSTAKAAN BAHAGIA";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.btn_cari);
            this.panel2.Controls.Add(this.lbl_info);
            this.panel2.Controls.Add(this.dgv_hasil_cari);
            this.panel2.Controls.Add(this.cmb_kategori);
            this.panel2.Controls.Add(this.txt_cari);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(82, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(515, 490);
            this.panel2.TabIndex = 1;
            // 
            // btn_cari
            // 
            this.btn_cari.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_cari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cari.FlatAppearance.BorderSize = 0;
            this.btn_cari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cari.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cari.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cari.Image = global::perpustakaan_client.Properties.Resources.refresh;
            this.btn_cari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cari.Location = new System.Drawing.Point(417, 94);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Padding = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.btn_cari.Size = new System.Drawing.Size(73, 32);
            this.btn_cari.TabIndex = 27;
            this.btn_cari.Text = "CARI";
            this.btn_cari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cari.UseVisualStyleBackColor = false;
            this.btn_cari.Click += new System.EventHandler(this.btn_cari_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(23, 446);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 16);
            this.lbl_info.TabIndex = 18;
            // 
            // dgv_hasil_cari
            // 
            this.dgv_hasil_cari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_hasil_cari.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv_hasil_cari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_hasil_cari.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgv_hasil_cari.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_hasil_cari.Location = new System.Drawing.Point(26, 150);
            this.dgv_hasil_cari.MultiSelect = false;
            this.dgv_hasil_cari.Name = "dgv_hasil_cari";
            this.dgv_hasil_cari.ReadOnly = true;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_hasil_cari.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgv_hasil_cari.RowHeadersWidth = 40;
            this.dgv_hasil_cari.RowTemplate.Height = 28;
            this.dgv_hasil_cari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hasil_cari.Size = new System.Drawing.Size(464, 267);
            this.dgv_hasil_cari.TabIndex = 17;
            // 
            // cmb_kategori
            // 
            this.cmb_kategori.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_kategori.FormattingEnabled = true;
            this.cmb_kategori.Items.AddRange(new object[] {
            "judul",
            "pengarang",
            "penerbit"});
            this.cmb_kategori.Location = new System.Drawing.Point(233, 94);
            this.cmb_kategori.Name = "cmb_kategori";
            this.cmb_kategori.Size = new System.Drawing.Size(158, 32);
            this.cmb_kategori.TabIndex = 2;
            this.cmb_kategori.Text = "judul";
            // 
            // txt_cari
            // 
            this.txt_cari.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cari.Location = new System.Drawing.Point(26, 94);
            this.txt_cari.Name = "txt_cari";
            this.txt_cari.Size = new System.Drawing.Size(201, 32);
            this.txt_cari.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(515, 58);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(21, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pencarian Buku";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.btn_submit);
            this.panel3.Controls.Add(this.txt_id_member);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btn_cari_member);
            this.panel3.Controls.Add(this.txt_alamat);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txt_nama);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.rd_n);
            this.panel3.Controls.Add(this.rd_y);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(749, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(517, 490);
            this.panel3.TabIndex = 2;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Gray;
            this.btn_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_submit.FlatAppearance.BorderSize = 0;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_submit.Image = global::perpustakaan_client.Properties.Resources.add;
            this.btn_submit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_submit.Location = new System.Drawing.Point(162, 433);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Padding = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.btn_submit.Size = new System.Drawing.Size(94, 29);
            this.btn_submit.TabIndex = 36;
            this.btn_submit.Text = "SUBMIT";
            this.btn_submit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // txt_id_member
            // 
            this.txt_id_member.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_member.Location = new System.Drawing.Point(162, 188);
            this.txt_id_member.Name = "txt_id_member";
            this.txt_id_member.ReadOnly = true;
            this.txt_id_member.Size = new System.Drawing.Size(221, 29);
            this.txt_id_member.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "ID Member";
            // 
            // btn_cari_member
            // 
            this.btn_cari_member.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_cari_member.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cari_member.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cari_member.Enabled = false;
            this.btn_cari_member.FlatAppearance.BorderSize = 0;
            this.btn_cari_member.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cari_member.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cari_member.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cari_member.Image = global::perpustakaan_client.Properties.Resources.refresh;
            this.btn_cari_member.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cari_member.Location = new System.Drawing.Point(403, 188);
            this.btn_cari_member.Name = "btn_cari_member";
            this.btn_cari_member.Padding = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.btn_cari_member.Size = new System.Drawing.Size(75, 29);
            this.btn_cari_member.TabIndex = 33;
            this.btn_cari_member.Text = "CARI";
            this.btn_cari_member.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cari_member.UseVisualStyleBackColor = false;
            this.btn_cari_member.Click += new System.EventHandler(this.btn_cari_member_Click);
            // 
            // txt_alamat
            // 
            this.txt_alamat.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_alamat.Location = new System.Drawing.Point(162, 285);
            this.txt_alamat.Multiline = true;
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.Size = new System.Drawing.Size(316, 130);
            this.txt_alamat.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Alamat";
            // 
            // txt_nama
            // 
            this.txt_nama.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nama.Location = new System.Drawing.Point(162, 236);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(316, 29);
            this.txt_nama.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Nama Lengkap";
            // 
            // rd_n
            // 
            this.rd_n.AutoSize = true;
            this.rd_n.Checked = true;
            this.rd_n.Location = new System.Drawing.Point(72, 138);
            this.rd_n.Name = "rd_n";
            this.rd_n.Size = new System.Drawing.Size(57, 17);
            this.rd_n.TabIndex = 4;
            this.rd_n.TabStop = true;
            this.rd_n.Text = "TIDAK";
            this.rd_n.UseVisualStyleBackColor = true;
            this.rd_n.CheckedChanged += new System.EventHandler(this.rd_n_CheckedChanged);
            // 
            // rd_y
            // 
            this.rd_y.AutoSize = true;
            this.rd_y.Location = new System.Drawing.Point(27, 138);
            this.rd_y.Name = "rd_y";
            this.rd_y.Size = new System.Drawing.Size(39, 17);
            this.rd_y.TabIndex = 3;
            this.rd_y.Text = "YA";
            this.rd_y.UseVisualStyleBackColor = true;
            this.rd_y.CheckedChanged += new System.EventHandler(this.rd_y_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Member Perpustakaan";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(0, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(515, 58);
            this.panel5.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(21, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Buku Tamu";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel6.Location = new System.Drawing.Point(26, 167);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(452, 1);
            this.panel6.TabIndex = 37;
            // 
            // halaman_utama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "halaman_utama";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hasil_cari)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmb_kategori;
        private System.Windows.Forms.TextBox txt_cari;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_hasil_cari;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Button btn_cari;
        private System.Windows.Forms.RadioButton rd_n;
        private System.Windows.Forms.RadioButton rd_y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id_member;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_cari_member;
        private System.Windows.Forms.TextBox txt_alamat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Panel panel6;
    }
}

