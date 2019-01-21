using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace perpustakaan_app
{
    public partial class peminjaman_form : Form
    {
        private model.peminjaman pinjam = new model.peminjaman();
        private model.member anggota = new model.member();

        public peminjaman data;

        public peminjaman_form(peminjaman layout)
        {
            data = layout;
            InitializeComponent();
        }

        private void btn_simpan_pinjam_Click(object sender, EventArgs e)
        {
            if (txt_idm.Text == "")
            {
                MessageBox.Show("Lengkapi Semua Field Pada Form");
            }
            else
            {
                if (pinjam.cek_peminjaman(txt_idm.Text))
                {
                    MessageBox.Show("Member Masih Melakukan peminjaman buku yang belum dikembalikan.");
                }
                else if(!pinjam.active_member(txt_idm.Text))
                {
                    MessageBox.Show("Masa Berlaku Member Sudah Kadaluwarsa, Silahkan Registrasi ulang.?");
                }
                else
                {
                    DateTime dt = DateTime.Today;
                    string date = dt.Year.ToString()+"-"+dt.Month.ToString()+"-"+dt.Day.ToString();

                    pinjam.add_peminjaman(txt_idm.Text, txt_idp.Text, date);
                    data.show_all_pinjam();

                    string[] data2 = pinjam.get_last_pinjam(txt_idm.Text);
                    txt_id.Text = data2[0];
                    txt_idm.ReadOnly = true;

                    panel_pinjam.Visible = true;
                    string[] data1 = anggota.get_member(txt_idm.Text);
                    lbl_idm.Text = data1[0];
                    lbl_nama.Text = data1[1];
                    lbl_telp.Text = data1[3];
                    txt_alamat.Text = data1[2];

                    show_buku_pinjam();
                }
            }
        }

        public void show_buku_pinjam()
        {
            var result = pinjam.get_buku_pinjam(txt_id.Text);
            data_update(result);
        }

        public void data_update(DataTable result)
        {
            dgv_buku_pinjam.DataSource = "";
            dgv_buku_pinjam.DataSource = result;

            atur_kolom();
        }

        public void atur_kolom()
        {
            dgv_buku_pinjam.Columns[0].HeaderText = "ID Buku";
            dgv_buku_pinjam.Columns[1].HeaderText = "Judul";
            dgv_buku_pinjam.Columns[2].HeaderText = "Pengarang";
            dgv_buku_pinjam.Columns[3].HeaderText = "Penerbit";

            dgv_buku_pinjam.Columns[0].Width = 100;
            dgv_buku_pinjam.Columns[1].Width = 300;
            dgv_buku_pinjam.Columns[2].Width = 150;
            dgv_buku_pinjam.Columns[3].Width = 150;
        }

        private void btn_simpan_buku_pinjam_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(pinjam.count_pinjam(txt_id.Text)) < 3)
            {
                pinjam.add_buku_pinjam(txt_id.Text, txt_id_buku.Text);
                show_buku_pinjam();
            }
            else
            {
                MessageBox.Show("Peminjaman Melebihi Batas Maksimum Peminjaman 3 Buku.!");
            }
        }

        private void btn_batal_buku_pinjam_Click(object sender, EventArgs e)
        {
            var baris = dgv_buku_pinjam.CurrentRow.Index;
            pinjam.hapus_buku_pinjam(txt_id.Text, dgv_buku_pinjam.Rows[baris].Cells[0].Value.ToString());
            show_buku_pinjam();
        }

        private void btn_batal_pinjam_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah anda yakin ingin membatalkan Peminjaman ini.?\nSemua data yang telah anda inputkan akan terhapus.!", "Konfirmasi", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                pinjam.delete_pinjam(txt_id.Text);
                txt_id.Text = "auto";
                txt_id_buku.Text = "";
                txt_idm.Text = "";
                txt_idm.ReadOnly = false;
                panel_pinjam.Visible = false;
                data.show_all_pinjam();
            }
        }

        private void btn_cetak_pinjam_Click(object sender, EventArgs e)
        {
            var result = pinjam.get_cetak_buku_pinjam(txt_id.Text);
            var data = pinjam.get_pinjam_description(txt_id.Text);

            ReportDocument rd = new ReportDocument();
            rd.Load("../../report/peminjaman.rpt");
            TextObject txt, txt1, txt2, txt3, txt4;
            txt = (TextObject)rd.ReportDefinition.ReportObjects["ttd_pegawai"];
            txt.Text = "("+data[2]+")";
            txt1 = (TextObject)rd.ReportDefinition.ReportObjects["ttd_peminjam"];
            txt1.Text = "("+data[1]+")";
            txt2 = (TextObject)rd.ReportDefinition.ReportObjects["peminjam"];
            txt2.Text = ":  "+data[1];
            txt3 = (TextObject)rd.ReportDefinition.ReportObjects["pegawai"];
            txt3.Text = ":  "+data[2];
            txt4 = (TextObject)rd.ReportDefinition.ReportObjects["id"];
            txt4.Text = ":  "+data[0];
            rd.Database.Tables[0].SetDataSource(result);

            //cetak laporan
            print laporan = new print();
            laporan.crv_report.ReportSource = rd;
            laporan.ShowDialog();  
        }

    }
}
