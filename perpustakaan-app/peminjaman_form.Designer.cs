namespace perpustakaan_app
{
    partial class peminjaman_form
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
            this.txt_idp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_idm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_header = new System.Windows.Forms.Label();
            this.txt_tgl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_pinjam = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_buku_pinjam = new System.Windows.Forms.DataGridView();
            this.btn_batal_buku_pinjam = new System.Windows.Forms.Button();
            this.btn_simpan_buku_pinjam = new System.Windows.Forms.Button();
            this.txt_id_buku = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_cetak_pinjam = new System.Windows.Forms.Button();
            this.txt_alamat = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_telp = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_idm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_batal_pinjam = new System.Windows.Forms.Button();
            this.btn_simpan_pinjam = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_pinjam.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buku_pinjam)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_idp
            // 
            this.txt_idp.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idp.Location = new System.Drawing.Point(378, 85);
            this.txt_idp.Name = "txt_idp";
            this.txt_idp.Size = new System.Drawing.Size(161, 25);
            this.txt_idp.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(286, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "ID Pegawai";
            // 
            // txt_idm
            // 
            this.txt_idm.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idm.Location = new System.Drawing.Point(106, 129);
            this.txt_idm.Name = "txt_idm";
            this.txt_idm.Size = new System.Drawing.Size(168, 25);
            this.txt_idm.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "ID Member";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(106, 86);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(168, 25);
            this.txt_id.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID Pinjam";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.label_header);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 63);
            this.panel1.TabIndex = 17;
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_header.Location = new System.Drawing.Point(12, 19);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(164, 25);
            this.label_header.TabIndex = 0;
            this.label_header.Text = "Form Peminjaman";
            // 
            // txt_tgl
            // 
            this.txt_tgl.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tgl.Location = new System.Drawing.Point(378, 126);
            this.txt_tgl.Name = "txt_tgl";
            this.txt_tgl.Size = new System.Drawing.Size(161, 25);
            this.txt_tgl.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Tanggal Pinjam";
            // 
            // panel_pinjam
            // 
            this.panel_pinjam.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel_pinjam.Controls.Add(this.panel4);
            this.panel_pinjam.Controls.Add(this.panel3);
            this.panel_pinjam.Location = new System.Drawing.Point(0, 174);
            this.panel_pinjam.Name = "panel_pinjam";
            this.panel_pinjam.Size = new System.Drawing.Size(757, 372);
            this.panel_pinjam.TabIndex = 42;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.dgv_buku_pinjam);
            this.panel4.Controls.Add(this.btn_batal_buku_pinjam);
            this.panel4.Controls.Add(this.btn_simpan_buku_pinjam);
            this.panel4.Controls.Add(this.txt_id_buku);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(287, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(451, 328);
            this.panel4.TabIndex = 1;
            // 
            // dgv_buku_pinjam
            // 
            this.dgv_buku_pinjam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_buku_pinjam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_buku_pinjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_buku_pinjam.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_buku_pinjam.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_buku_pinjam.Location = new System.Drawing.Point(15, 17);
            this.dgv_buku_pinjam.MultiSelect = false;
            this.dgv_buku_pinjam.Name = "dgv_buku_pinjam";
            this.dgv_buku_pinjam.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_buku_pinjam.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_buku_pinjam.RowHeadersWidth = 40;
            this.dgv_buku_pinjam.RowTemplate.Height = 28;
            this.dgv_buku_pinjam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_buku_pinjam.Size = new System.Drawing.Size(418, 235);
            this.dgv_buku_pinjam.TabIndex = 44;
            // 
            // btn_batal_buku_pinjam
            // 
            this.btn_batal_buku_pinjam.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_batal_buku_pinjam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_batal_buku_pinjam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_batal_buku_pinjam.FlatAppearance.BorderSize = 0;
            this.btn_batal_buku_pinjam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_batal_buku_pinjam.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_batal_buku_pinjam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_batal_buku_pinjam.Image = global::perpustakaan_app.Properties.Resources.hapus;
            this.btn_batal_buku_pinjam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_batal_buku_pinjam.Location = new System.Drawing.Point(353, 277);
            this.btn_batal_buku_pinjam.Name = "btn_batal_buku_pinjam";
            this.btn_batal_buku_pinjam.Padding = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.btn_batal_buku_pinjam.Size = new System.Drawing.Size(80, 33);
            this.btn_batal_buku_pinjam.TabIndex = 43;
            this.btn_batal_buku_pinjam.Text = "BATAL";
            this.btn_batal_buku_pinjam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_batal_buku_pinjam.UseVisualStyleBackColor = false;
            this.btn_batal_buku_pinjam.Click += new System.EventHandler(this.btn_batal_buku_pinjam_Click);
            // 
            // btn_simpan_buku_pinjam
            // 
            this.btn_simpan_buku_pinjam.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_simpan_buku_pinjam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_simpan_buku_pinjam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_simpan_buku_pinjam.FlatAppearance.BorderSize = 0;
            this.btn_simpan_buku_pinjam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_simpan_buku_pinjam.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpan_buku_pinjam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_simpan_buku_pinjam.Image = global::perpustakaan_app.Properties.Resources.simpan;
            this.btn_simpan_buku_pinjam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_simpan_buku_pinjam.Location = new System.Drawing.Point(257, 277);
            this.btn_simpan_buku_pinjam.Name = "btn_simpan_buku_pinjam";
            this.btn_simpan_buku_pinjam.Padding = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.btn_simpan_buku_pinjam.Size = new System.Drawing.Size(85, 33);
            this.btn_simpan_buku_pinjam.TabIndex = 42;
            this.btn_simpan_buku_pinjam.Text = "SIMPAN";
            this.btn_simpan_buku_pinjam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_simpan_buku_pinjam.UseVisualStyleBackColor = false;
            this.btn_simpan_buku_pinjam.Click += new System.EventHandler(this.btn_simpan_buku_pinjam_Click);
            // 
            // txt_id_buku
            // 
            this.txt_id_buku.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_buku.Location = new System.Drawing.Point(70, 281);
            this.txt_id_buku.Name = "txt_id_buku";
            this.txt_id_buku.Size = new System.Drawing.Size(123, 25);
            this.txt_id_buku.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "ID Buku";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.btn_cetak_pinjam);
            this.panel3.Controls.Add(this.txt_alamat);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.lbl_telp);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.lbl_nama);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lbl_idm);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(15, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 328);
            this.panel3.TabIndex = 0;
            // 
            // btn_cetak_pinjam
            // 
            this.btn_cetak_pinjam.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cetak_pinjam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cetak_pinjam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cetak_pinjam.FlatAppearance.BorderSize = 0;
            this.btn_cetak_pinjam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cetak_pinjam.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cetak_pinjam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cetak_pinjam.Image = global::perpustakaan_app.Properties.Resources.cetak;
            this.btn_cetak_pinjam.Location = new System.Drawing.Point(16, 235);
            this.btn_cetak_pinjam.Name = "btn_cetak_pinjam";
            this.btn_cetak_pinjam.Padding = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.btn_cetak_pinjam.Size = new System.Drawing.Size(222, 42);
            this.btn_cetak_pinjam.TabIndex = 41;
            this.btn_cetak_pinjam.Text = "  CETAK";
            this.btn_cetak_pinjam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cetak_pinjam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cetak_pinjam.UseVisualStyleBackColor = false;
            this.btn_cetak_pinjam.Click += new System.EventHandler(this.btn_cetak_pinjam_Click);
            // 
            // txt_alamat
            // 
            this.txt_alamat.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_alamat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_alamat.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_alamat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_alamat.Location = new System.Drawing.Point(16, 147);
            this.txt_alamat.Multiline = true;
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.ReadOnly = true;
            this.txt_alamat.Size = new System.Drawing.Size(214, 82);
            this.txt_alamat.TabIndex = 7;
            this.txt_alamat.Text = "Dk Gebangarum Ds Plumpungrejo KecWonoasri Madiun, kode pos 63157";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(12, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "Alamat :";
            // 
            // lbl_telp
            // 
            this.lbl_telp.AutoSize = true;
            this.lbl_telp.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_telp.Location = new System.Drawing.Point(107, 86);
            this.lbl_telp.Name = "lbl_telp";
            this.lbl_telp.Size = new System.Drawing.Size(93, 20);
            this.lbl_telp.TabIndex = 5;
            this.lbl_telp.Text = "089789654367";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(12, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "No. Telepon :";
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nama.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_nama.Location = new System.Drawing.Point(68, 53);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(84, 20);
            this.lbl_nama.TabIndex = 3;
            this.lbl_nama.Text = "Kahfi Baidowi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(12, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nama :";
            // 
            // lbl_idm
            // 
            this.lbl_idm.AutoSize = true;
            this.lbl_idm.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_idm.Location = new System.Drawing.Point(95, 22);
            this.lbl_idm.Name = "lbl_idm";
            this.lbl_idm.Size = new System.Drawing.Size(51, 20);
            this.lbl_idm.TabIndex = 1;
            this.lbl_idm.Text = "000001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Member :";
            // 
            // btn_batal_pinjam
            // 
            this.btn_batal_pinjam.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_batal_pinjam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_batal_pinjam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_batal_pinjam.FlatAppearance.BorderSize = 0;
            this.btn_batal_pinjam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_batal_pinjam.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_batal_pinjam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_batal_pinjam.Image = global::perpustakaan_app.Properties.Resources.hapus;
            this.btn_batal_pinjam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_batal_pinjam.Location = new System.Drawing.Point(656, 85);
            this.btn_batal_pinjam.Name = "btn_batal_pinjam";
            this.btn_batal_pinjam.Padding = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.btn_batal_pinjam.Size = new System.Drawing.Size(80, 66);
            this.btn_batal_pinjam.TabIndex = 41;
            this.btn_batal_pinjam.Text = "BATAL";
            this.btn_batal_pinjam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_batal_pinjam.UseVisualStyleBackColor = false;
            this.btn_batal_pinjam.Click += new System.EventHandler(this.btn_batal_pinjam_Click);
            // 
            // btn_simpan_pinjam
            // 
            this.btn_simpan_pinjam.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_simpan_pinjam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_simpan_pinjam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_simpan_pinjam.FlatAppearance.BorderSize = 0;
            this.btn_simpan_pinjam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_simpan_pinjam.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpan_pinjam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_simpan_pinjam.Image = global::perpustakaan_app.Properties.Resources.simpan;
            this.btn_simpan_pinjam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_simpan_pinjam.Location = new System.Drawing.Point(556, 85);
            this.btn_simpan_pinjam.Name = "btn_simpan_pinjam";
            this.btn_simpan_pinjam.Padding = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.btn_simpan_pinjam.Size = new System.Drawing.Size(85, 66);
            this.btn_simpan_pinjam.TabIndex = 40;
            this.btn_simpan_pinjam.Text = "SIMPAN";
            this.btn_simpan_pinjam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_simpan_pinjam.UseVisualStyleBackColor = false;
            this.btn_simpan_pinjam.Click += new System.EventHandler(this.btn_simpan_pinjam_Click);
            // 
            // peminjaman_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(752, 541);
            this.Controls.Add(this.panel_pinjam);
            this.Controls.Add(this.btn_batal_pinjam);
            this.Controls.Add(this.btn_simpan_pinjam);
            this.Controls.Add(this.txt_tgl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_idp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_idm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "peminjaman_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_pinjam.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buku_pinjam)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_idp;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_idm;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label_header;
        public System.Windows.Forms.TextBox txt_tgl;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btn_simpan_pinjam;
        private System.Windows.Forms.Button btn_batal_pinjam;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_telp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_idm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_alamat;
        public System.Windows.Forms.Button btn_cetak_pinjam;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_batal_buku_pinjam;
        public System.Windows.Forms.Button btn_simpan_buku_pinjam;
        public System.Windows.Forms.TextBox txt_id_buku;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Panel panel_pinjam;
        public System.Windows.Forms.DataGridView dgv_buku_pinjam;
    }
}