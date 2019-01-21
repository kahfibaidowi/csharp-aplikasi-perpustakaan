namespace perpustakaan_app
{
    partial class administrator
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
            this.status_bar = new System.Windows.Forms.StatusStrip();
            this.status_id = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_nama = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_level = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel_account = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_pengunjung = new System.Windows.Forms.Button();
            this.btn_petugas = new System.Windows.Forms.Button();
            this.btn_member = new System.Windows.Forms.Button();
            this.btn_kembali = new System.Windows.Forms.Button();
            this.btn_pinjam = new System.Windows.Forms.Button();
            this.btn_rak = new System.Windows.Forms.Button();
            this.btn_buku = new System.Windows.Forms.Button();
            this.btn_beranda = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_content = new System.Windows.Forms.Panel();
            this.menu_bar = new System.Windows.Forms.MenuStrip();
            this.tentangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_profile = new System.Windows.Forms.Button();
            this.lbl_level = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_alamat = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_telp = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.status_bar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menu_bar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // status_bar
            // 
            this.status_bar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_id,
            this.status_nama,
            this.status_level});
            this.status_bar.Location = new System.Drawing.Point(0, 698);
            this.status_bar.Name = "status_bar";
            this.status_bar.Size = new System.Drawing.Size(1350, 31);
            this.status_bar.TabIndex = 5;
            this.status_bar.Text = "status_bar";
            // 
            // status_id
            // 
            this.status_id.Name = "status_id";
            this.status_id.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.status_id.Size = new System.Drawing.Size(50, 26);
            this.status_id.Text = "987654";
            // 
            // status_nama
            // 
            this.status_nama.Name = "status_nama";
            this.status_nama.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.status_nama.Size = new System.Drawing.Size(83, 26);
            this.status_nama.Text = "status_nama";
            // 
            // status_level
            // 
            this.status_level.Name = "status_level";
            this.status_level.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.status_level.Size = new System.Drawing.Size(76, 26);
            this.status_level.Text = "status_level";
            // 
            // panel_account
            // 
            this.panel_account.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_account.Location = new System.Drawing.Point(0, 30);
            this.panel_account.Name = "panel_account";
            this.panel_account.Size = new System.Drawing.Size(1350, 77);
            this.panel_account.TabIndex = 6;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(12, 328);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(224, 39);
            this.button6.TabIndex = 5;
            this.button6.Text = "Member/Anggota";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.btn_pengunjung);
            this.panel1.Controls.Add(this.btn_petugas);
            this.panel1.Controls.Add(this.btn_member);
            this.panel1.Controls.Add(this.btn_kembali);
            this.panel1.Controls.Add(this.btn_pinjam);
            this.panel1.Controls.Add(this.btn_rak);
            this.panel1.Controls.Add(this.btn_buku);
            this.panel1.Controls.Add(this.btn_beranda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 591);
            this.panel1.TabIndex = 8;
            // 
            // btn_pengunjung
            // 
            this.btn_pengunjung.BackColor = System.Drawing.Color.LightGray;
            this.btn_pengunjung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pengunjung.FlatAppearance.BorderSize = 0;
            this.btn_pengunjung.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_pengunjung.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_pengunjung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pengunjung.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pengunjung.Location = new System.Drawing.Point(16, 376);
            this.btn_pengunjung.Name = "btn_pengunjung";
            this.btn_pengunjung.Size = new System.Drawing.Size(219, 37);
            this.btn_pengunjung.TabIndex = 14;
            this.btn_pengunjung.Text = "Statistik Pengunjung";
            this.btn_pengunjung.UseVisualStyleBackColor = false;
            this.btn_pengunjung.Click += new System.EventHandler(this.btn_pengunjung_Click);
            // 
            // btn_petugas
            // 
            this.btn_petugas.BackColor = System.Drawing.Color.LightGray;
            this.btn_petugas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_petugas.FlatAppearance.BorderSize = 0;
            this.btn_petugas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_petugas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_petugas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_petugas.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_petugas.Location = new System.Drawing.Point(16, 325);
            this.btn_petugas.Name = "btn_petugas";
            this.btn_petugas.Size = new System.Drawing.Size(219, 37);
            this.btn_petugas.TabIndex = 13;
            this.btn_petugas.Text = "Petugas/Pegawai";
            this.btn_petugas.UseVisualStyleBackColor = false;
            this.btn_petugas.Click += new System.EventHandler(this.btn_petugas_Click);
            // 
            // btn_member
            // 
            this.btn_member.BackColor = System.Drawing.Color.LightGray;
            this.btn_member.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_member.FlatAppearance.BorderSize = 0;
            this.btn_member.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_member.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_member.Location = new System.Drawing.Point(16, 274);
            this.btn_member.Name = "btn_member";
            this.btn_member.Size = new System.Drawing.Size(219, 37);
            this.btn_member.TabIndex = 12;
            this.btn_member.Text = "Member/Anggota";
            this.btn_member.UseVisualStyleBackColor = false;
            this.btn_member.Click += new System.EventHandler(this.btn_member_Click);
            // 
            // btn_kembali
            // 
            this.btn_kembali.BackColor = System.Drawing.Color.LightGray;
            this.btn_kembali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kembali.FlatAppearance.BorderSize = 0;
            this.btn_kembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kembali.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kembali.Location = new System.Drawing.Point(16, 223);
            this.btn_kembali.Name = "btn_kembali";
            this.btn_kembali.Size = new System.Drawing.Size(219, 37);
            this.btn_kembali.TabIndex = 11;
            this.btn_kembali.Text = "Buku Kembali";
            this.btn_kembali.UseVisualStyleBackColor = false;
            this.btn_kembali.Click += new System.EventHandler(this.btn_kembali_Click);
            // 
            // btn_pinjam
            // 
            this.btn_pinjam.BackColor = System.Drawing.Color.LightGray;
            this.btn_pinjam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pinjam.FlatAppearance.BorderSize = 0;
            this.btn_pinjam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pinjam.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pinjam.Location = new System.Drawing.Point(16, 172);
            this.btn_pinjam.Name = "btn_pinjam";
            this.btn_pinjam.Size = new System.Drawing.Size(219, 37);
            this.btn_pinjam.TabIndex = 10;
            this.btn_pinjam.Text = "Peminjaman";
            this.btn_pinjam.UseVisualStyleBackColor = false;
            this.btn_pinjam.Click += new System.EventHandler(this.btn_pinjam_Click);
            // 
            // btn_rak
            // 
            this.btn_rak.BackColor = System.Drawing.Color.LightGray;
            this.btn_rak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rak.FlatAppearance.BorderSize = 0;
            this.btn_rak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rak.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rak.Location = new System.Drawing.Point(16, 121);
            this.btn_rak.Name = "btn_rak";
            this.btn_rak.Size = new System.Drawing.Size(219, 37);
            this.btn_rak.TabIndex = 9;
            this.btn_rak.Text = "Kategori/Rak Buku";
            this.btn_rak.UseVisualStyleBackColor = false;
            this.btn_rak.Click += new System.EventHandler(this.btn_rak_Click);
            // 
            // btn_buku
            // 
            this.btn_buku.BackColor = System.Drawing.Color.LightGray;
            this.btn_buku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buku.FlatAppearance.BorderSize = 0;
            this.btn_buku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buku.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buku.Location = new System.Drawing.Point(16, 70);
            this.btn_buku.Name = "btn_buku";
            this.btn_buku.Size = new System.Drawing.Size(219, 37);
            this.btn_buku.TabIndex = 8;
            this.btn_buku.Text = "Data Buku";
            this.btn_buku.UseVisualStyleBackColor = false;
            this.btn_buku.Click += new System.EventHandler(this.btn_buku_Click);
            // 
            // btn_beranda
            // 
            this.btn_beranda.BackColor = System.Drawing.Color.LightGray;
            this.btn_beranda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_beranda.FlatAppearance.BorderSize = 0;
            this.btn_beranda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_beranda.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_beranda.Location = new System.Drawing.Point(16, 19);
            this.btn_beranda.Name = "btn_beranda";
            this.btn_beranda.Size = new System.Drawing.Size(219, 37);
            this.btn_beranda.TabIndex = 7;
            this.btn_beranda.Text = "Beranda";
            this.btn_beranda.UseVisualStyleBackColor = false;
            this.btn_beranda.Click += new System.EventHandler(this.btn_beranda_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel_content);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(254, 107);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.panel2.Size = new System.Drawing.Size(840, 591);
            this.panel2.TabIndex = 9;
            // 
            // panel_content
            // 
            this.panel_content.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_content.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_content.Location = new System.Drawing.Point(20, 0);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(820, 571);
            this.panel_content.TabIndex = 0;
            // 
            // menu_bar
            // 
            this.menu_bar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menu_bar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tentangToolStripMenuItem,
            this.keluarToolStripMenuItem});
            this.menu_bar.Location = new System.Drawing.Point(0, 0);
            this.menu_bar.Name = "menu_bar";
            this.menu_bar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu_bar.Size = new System.Drawing.Size(1350, 30);
            this.menu_bar.Stretch = false;
            this.menu_bar.TabIndex = 1;
            this.menu_bar.Text = "menu_bar";
            // 
            // tentangToolStripMenuItem
            // 
            this.tentangToolStripMenuItem.Name = "tentangToolStripMenuItem";
            this.tentangToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tentangToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.tentangToolStripMenuItem.Text = "&Tentang";
            this.tentangToolStripMenuItem.Click += new System.EventHandler(this.tentangToolStripMenuItem_Click);
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(57, 26);
            this.keluarToolStripMenuItem.Text = "&Keluar";
            this.keluarToolStripMenuItem.Click += new System.EventHandler(this.keluarToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(1094, 107);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.panel3.Size = new System.Drawing.Size(256, 591);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.btn_logout);
            this.panel4.Controls.Add(this.btn_profile);
            this.panel4.Controls.Add(this.lbl_level);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txt_alamat);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.lbl_telp);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.lbl_nama);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.lbl_id);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(6, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 571);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(1, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(249, 43);
            this.panel5.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(14, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "User Account";
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(125, 318);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 19;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_profile
            // 
            this.btn_profile.Location = new System.Drawing.Point(44, 318);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(75, 23);
            this.btn_profile.TabIndex = 18;
            this.btn_profile.Text = "Ubah Profile";
            this.btn_profile.UseVisualStyleBackColor = true;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // lbl_level
            // 
            this.lbl_level.AutoSize = true;
            this.lbl_level.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_level.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_level.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_level.Location = new System.Drawing.Point(87, 173);
            this.lbl_level.Name = "lbl_level";
            this.lbl_level.Size = new System.Drawing.Size(81, 20);
            this.lbl_level.TabIndex = 17;
            this.lbl_level.Text = "Administrator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(17, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Jabatan :";
            // 
            // txt_alamat
            // 
            this.txt_alamat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_alamat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_alamat.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_alamat.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_alamat.Location = new System.Drawing.Point(16, 230);
            this.txt_alamat.Multiline = true;
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.ReadOnly = true;
            this.txt_alamat.Size = new System.Drawing.Size(214, 82);
            this.txt_alamat.TabIndex = 15;
            this.txt_alamat.Text = "Dk Gebangarum Ds Plumpungrejo KecWonoasri Madiun, kode pos 63157";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(17, 206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Alamat :";
            // 
            // lbl_telp
            // 
            this.lbl_telp.AutoSize = true;
            this.lbl_telp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_telp.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_telp.Location = new System.Drawing.Point(112, 142);
            this.lbl_telp.Name = "lbl_telp";
            this.lbl_telp.Size = new System.Drawing.Size(93, 20);
            this.lbl_telp.TabIndex = 13;
            this.lbl_telp.Text = "089789654367";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(17, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "No. Telepon :";
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_nama.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nama.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_nama.Location = new System.Drawing.Point(73, 109);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(84, 20);
            this.lbl_nama.TabIndex = 11;
            this.lbl_nama.Text = "Kahfi Baidowi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(17, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nama :";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_id.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_id.Location = new System.Drawing.Point(100, 78);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(51, 20);
            this.lbl_id.TabIndex = 9;
            this.lbl_id.Text = "000001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(17, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID Pegawai :";
            // 
            // administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_account);
            this.Controls.Add(this.status_bar);
            this.Controls.Add(this.menu_bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.administrator_Load);
            this.status_bar.ResumeLayout(false);
            this.status_bar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.menu_bar.ResumeLayout(false);
            this.menu_bar.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.StatusStrip status_bar;
        private System.Windows.Forms.Panel panel_account;
        private System.Windows.Forms.Button button6;
        public System.Windows.Forms.ToolStripStatusLabel status_id;
        public System.Windows.Forms.ToolStripStatusLabel status_nama;
        public System.Windows.Forms.ToolStripStatusLabel status_level;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_petugas;
        private System.Windows.Forms.Button btn_member;
        private System.Windows.Forms.Button btn_kembali;
        private System.Windows.Forms.Button btn_pinjam;
        private System.Windows.Forms.Button btn_rak;
        private System.Windows.Forms.Button btn_buku;
        private System.Windows.Forms.Button btn_beranda;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_content;
        private System.Windows.Forms.MenuStrip menu_bar;
        private System.Windows.Forms.ToolStripMenuItem tentangToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_alamat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_telp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_level;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Button btn_pengunjung;
    }
}