namespace perpustakaan_app
{
    partial class statistik
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_data_pengunjung = new System.Windows.Forms.DataGridView();
            this.cmb_mulai = new System.Windows.Forms.ComboBox();
            this.cmb_selesai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_tampil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_count = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_pengunjung)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(13, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 1);
            this.panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Statistik Pengunjung";
            // 
            // dgv_data_pengunjung
            // 
            this.dgv_data_pengunjung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data_pengunjung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_data_pengunjung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data_pengunjung.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_data_pengunjung.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_data_pengunjung.Location = new System.Drawing.Point(16, 153);
            this.dgv_data_pengunjung.MultiSelect = false;
            this.dgv_data_pengunjung.Name = "dgv_data_pengunjung";
            this.dgv_data_pengunjung.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data_pengunjung.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_data_pengunjung.RowHeadersWidth = 40;
            this.dgv_data_pengunjung.RowTemplate.Height = 28;
            this.dgv_data_pengunjung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_data_pengunjung.Size = new System.Drawing.Size(575, 312);
            this.dgv_data_pengunjung.TabIndex = 26;
            // 
            // cmb_mulai
            // 
            this.cmb_mulai.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_mulai.FormattingEnabled = true;
            this.cmb_mulai.Location = new System.Drawing.Point(16, 101);
            this.cmb_mulai.Name = "cmb_mulai";
            this.cmb_mulai.Size = new System.Drawing.Size(153, 28);
            this.cmb_mulai.TabIndex = 27;
            // 
            // cmb_selesai
            // 
            this.cmb_selesai.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_selesai.FormattingEnabled = true;
            this.cmb_selesai.Location = new System.Drawing.Point(210, 101);
            this.cmb_selesai.Name = "cmb_selesai";
            this.cmb_selesai.Size = new System.Drawing.Size(153, 28);
            this.cmb_selesai.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "-";
            // 
            // btn_tampil
            // 
            this.btn_tampil.BackColor = System.Drawing.Color.Gray;
            this.btn_tampil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_tampil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tampil.FlatAppearance.BorderSize = 0;
            this.btn_tampil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tampil.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tampil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_tampil.Image = global::perpustakaan_app.Properties.Resources.update;
            this.btn_tampil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tampil.Location = new System.Drawing.Point(476, 99);
            this.btn_tampil.Name = "btn_tampil";
            this.btn_tampil.Padding = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.btn_tampil.Size = new System.Drawing.Size(115, 32);
            this.btn_tampil.TabIndex = 30;
            this.btn_tampil.Text = "TAMPILKAN";
            this.btn_tampil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_tampil.UseVisualStyleBackColor = false;
            this.btn_tampil.Click += new System.EventHandler(this.btn_tampil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(645, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 42);
            this.label3.TabIndex = 31;
            this.label3.Text = "TOTAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(615, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 42);
            this.label4.TabIndex = 32;
            this.label4.Text = "Pengunjung";
            // 
            // txt_count
            // 
            this.txt_count.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_count.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_count.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_count.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_count.Location = new System.Drawing.Point(652, 261);
            this.txt_count.Name = "txt_count";
            this.txt_count.ReadOnly = true;
            this.txt_count.Size = new System.Drawing.Size(100, 46);
            this.txt_count.TabIndex = 33;
            this.txt_count.Text = "25";
            this.txt_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(821, 545);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_tampil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_selesai);
            this.Controls.Add(this.cmb_mulai);
            this.Controls.Add(this.dgv_data_pengunjung);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "statistik";
            this.Text = "buku_add";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_pengunjung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_data_pengunjung;
        private System.Windows.Forms.ComboBox cmb_mulai;
        private System.Windows.Forms.ComboBox cmb_selesai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_tampil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_count;



    }
}