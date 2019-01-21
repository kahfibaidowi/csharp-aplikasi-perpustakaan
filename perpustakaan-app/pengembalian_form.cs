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
    public partial class pengembalian_form : Form
    {
        private model.peminjaman pinjam = new model.peminjaman();
        private model.member anggota = new model.member();

        private peminjaman data = new peminjaman(new administrator());
        private pengembalian data2 = new pengembalian(new administrator());

        public pengembalian_form(peminjaman layout)
        {
            data = layout;
            InitializeComponent();
        }

        public pengembalian_form(pengembalian layout)
        {
            data2 = layout;
            InitializeComponent();
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

        private void txt_denda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)8) e.Handled = false;
        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            var baris = dgv_buku_pinjam.CurrentRow.Index;
            var id_buku = dgv_buku_pinjam.Rows[baris].Cells[0].Value.ToString();
            pinjam.kembalikan_buku(txt_id.Text, id_buku, txt_idp.Text,check_denda.Checked, txt_denda.Text);

            check_denda.Checked = false;
            show_buku_pinjam();
            data.show_all_pinjam();
            data2.show_all_kembali();
        }

        private void btn_cetak_kembali_Click(object sender, EventArgs e)
        {
            var result = pinjam.get_cetak_buku_kembali(txt_id.Text);
            var data = pinjam.get_pinjam_description2(txt_id.Text);
            var total_denda = pinjam.total_denda(txt_id.Text);

            ReportDocument rd = new ReportDocument();
            rd.Load("../../report/pengembalian.rpt");
            TextObject txt, txt1, txt2, txt3, txt4;
            txt = (TextObject)rd.ReportDefinition.ReportObjects["ttd_pegawai"];
            txt.Text = "(" + data[2] + ")";
            txt1 = (TextObject)rd.ReportDefinition.ReportObjects["total_denda"];
            txt1.Text = total_denda;
            txt2 = (TextObject)rd.ReportDefinition.ReportObjects["peminjam"];
            txt2.Text = ":  " + data[1];
            txt3 = (TextObject)rd.ReportDefinition.ReportObjects["pegawai"];
            txt3.Text = ":  " + data[2];
            txt4 = (TextObject)rd.ReportDefinition.ReportObjects["id"];
            txt4.Text = ":  " + data[0];
            rd.Database.Tables[0].SetDataSource(result);

            //cetak laporan
            print laporan = new print();
            laporan.crv_report.ReportSource = rd;
            laporan.ShowDialog();  
        }

        private void btn_cari_Click(object sender, EventArgs e)
        {
            if (!pinjam.is_null_pinjam(txt_id.Text))
            {
                string[] data_pinjam = pinjam.get_pinjam(txt_id.Text);

                txt_idm.Text = data_pinjam[1];
                txt_tgl.Text = data_pinjam[2];

                panel_pinjam.Visible = true;
                string[] data_member = anggota.get_member(txt_idm.Text);
                lbl_idm.Text = data_member[0];
                lbl_nama.Text = data_member[1];
                lbl_telp.Text = data_member[3];
                txt_alamat.Text = data_member[2];
                show_buku_pinjam();
            }
            else
            {
                MessageBox.Show("ID Peminjaman Tidak Ditemukan");
                txt_id.Text = "";
                txt_idm.Text = "";
                txt_tgl.Text = "";
                panel_pinjam.Visible = false;
            }
        }

        private void check_denda_CheckedChanged(object sender, EventArgs e)
        {
            if (check_denda.Checked)
            {
                txt_denda.ReadOnly = false;
            }
            else
            {
                txt_denda.ReadOnly = true;
                txt_denda.Text = "";
            }
        }

    }
}
