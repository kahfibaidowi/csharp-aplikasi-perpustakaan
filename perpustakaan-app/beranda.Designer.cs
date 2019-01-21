namespace perpustakaan_app
{
    partial class beranda
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.chart_home = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_jml_buku = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_jml_member = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_jml_pegawai = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_jml_pinjam = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart_home)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Beranda";
            // 
            // chart_home
            // 
            this.chart_home.BackColor = System.Drawing.SystemColors.Control;
            chartArea4.Name = "ChartArea1";
            this.chart_home.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_home.Legends.Add(legend4);
            this.chart_home.Location = new System.Drawing.Point(21, 200);
            this.chart_home.Name = "chart_home";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.LegendText = "Statistik Pengunjung";
            series4.Name = "statistik";
            this.chart_home.Series.Add(series4);
            this.chart_home.Size = new System.Drawing.Size(772, 322);
            this.chart_home.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(654, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 34;
            // 
            // txt_jml_buku
            // 
            this.txt_jml_buku.BackColor = System.Drawing.Color.DeepPink;
            this.txt_jml_buku.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_jml_buku.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_jml_buku.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_jml_buku.Location = new System.Drawing.Point(73, 34);
            this.txt_jml_buku.Name = "txt_jml_buku";
            this.txt_jml_buku.ReadOnly = true;
            this.txt_jml_buku.Size = new System.Drawing.Size(93, 31);
            this.txt_jml_buku.TabIndex = 37;
            this.txt_jml_buku.Text = "27";
            this.txt_jml_buku.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DeepPink;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(81, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 38;
            this.label3.Text = "Total Buku";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Gray;
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_update.Image = global::perpustakaan_app.Properties.Resources.update;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(627, 451);
            this.btn_update.Name = "btn_update";
            this.btn_update.Padding = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.btn_update.Size = new System.Drawing.Size(137, 29);
            this.btn_update.TabIndex = 35;
            this.btn_update.Text = "UPDATE/REFRESH";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepPink;
            this.panel1.BackgroundImage = global::perpustakaan_app.Properties.Resources.big_book;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_jml_buku);
            this.panel1.Location = new System.Drawing.Point(22, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 116);
            this.panel1.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BlueViolet;
            this.panel2.BackgroundImage = global::perpustakaan_app.Properties.Resources.big_user;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_jml_member);
            this.panel2.Location = new System.Drawing.Point(221, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 116);
            this.panel2.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.BlueViolet;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(58, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 38;
            this.label4.Text = "Member Aktif";
            // 
            // txt_jml_member
            // 
            this.txt_jml_member.BackColor = System.Drawing.Color.BlueViolet;
            this.txt_jml_member.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_jml_member.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_jml_member.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_jml_member.Location = new System.Drawing.Point(72, 34);
            this.txt_jml_member.Name = "txt_jml_member";
            this.txt_jml_member.ReadOnly = true;
            this.txt_jml_member.Size = new System.Drawing.Size(93, 31);
            this.txt_jml_member.TabIndex = 37;
            this.txt_jml_member.Text = "27";
            this.txt_jml_member.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel3.BackgroundImage = global::perpustakaan_app.Properties.Resources.big_support;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txt_jml_pegawai);
            this.panel3.Location = new System.Drawing.Point(419, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 116);
            this.panel3.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(56, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 23);
            this.label5.TabIndex = 38;
            this.label5.Text = "Total Pegawai";
            // 
            // txt_jml_pegawai
            // 
            this.txt_jml_pegawai.BackColor = System.Drawing.Color.DarkTurquoise;
            this.txt_jml_pegawai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_jml_pegawai.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_jml_pegawai.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_jml_pegawai.Location = new System.Drawing.Point(73, 34);
            this.txt_jml_pegawai.Name = "txt_jml_pegawai";
            this.txt_jml_pegawai.ReadOnly = true;
            this.txt_jml_pegawai.Size = new System.Drawing.Size(93, 31);
            this.txt_jml_pegawai.TabIndex = 37;
            this.txt_jml_pegawai.Text = "27";
            this.txt_jml_pegawai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Indigo;
            this.panel4.BackgroundImage = global::perpustakaan_app.Properties.Resources.big_cart;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txt_jml_pinjam);
            this.panel4.Location = new System.Drawing.Point(615, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(178, 116);
            this.panel4.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Indigo;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(69, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 23);
            this.label6.TabIndex = 38;
            this.label6.Text = "Peminjaman";
            // 
            // txt_jml_pinjam
            // 
            this.txt_jml_pinjam.BackColor = System.Drawing.Color.Indigo;
            this.txt_jml_pinjam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_jml_pinjam.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_jml_pinjam.ForeColor = System.Drawing.SystemColors.Info;
            this.txt_jml_pinjam.Location = new System.Drawing.Point(73, 34);
            this.txt_jml_pinjam.Name = "txt_jml_pinjam";
            this.txt_jml_pinjam.ReadOnly = true;
            this.txt_jml_pinjam.Size = new System.Drawing.Size(93, 31);
            this.txt_jml_pinjam.TabIndex = 37;
            this.txt_jml_pinjam.Text = "27";
            this.txt_jml_pinjam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.Location = new System.Drawing.Point(20, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(772, 1);
            this.panel5.TabIndex = 41;
            // 
            // beranda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(821, 545);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart_home);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "beranda";
            this.Text = "member";
            this.Load += new System.EventHandler(this.beranda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_home)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_home;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_jml_buku;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_jml_member;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_jml_pegawai;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_jml_pinjam;
        private System.Windows.Forms.Panel panel5;
    }
}