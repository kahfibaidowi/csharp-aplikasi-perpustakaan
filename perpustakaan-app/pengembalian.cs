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
    public partial class pengembalian : Form
    {
        private model.peminjaman pinjam = new model.peminjaman();
        private model.pengembalian kembali = new model.pengembalian();
        private paging pg = new paging();

        private administrator parent_data;

        public pengembalian(administrator parent)
        {
            InitializeComponent();

            parent_data = parent;

            pg.set_btnprev(btn_prev_page);
            pg.set_btnnext(btn_next_page);
            pg.set_toolpage(txt_page);
            pg.set_labelpage(label_page);
            pg.set_datalength(cmb_length.Text);

            show_all_kembali();
        }

        public void show_all_kembali()
        {
            pg.all_data(kembali.count_search(cmb_kategori_cari.Text, txt_cari.Text));

            var posisi = Convert.ToInt32(pg.num_filter)*(Convert.ToInt32(txt_page.Text)-1);
            var result = kembali.search_pengembalian(cmb_kategori_cari.Text, txt_cari.Text, Convert.ToString(posisi), pg.num_filter.ToString());
            data_update(result);

            pg.btn_reset();
        }

        private void data_update(DataTable result)
        {
            dgv_data_kembali.DataSource = "";
            dgv_data_kembali.DataSource = result;

            atur_kolom();
        }

        private void atur_kolom()
        {
            dgv_data_kembali.Columns[0].HeaderText = "ID Pinjam";
            dgv_data_kembali.Columns[1].HeaderText = "ID Member";
            dgv_data_kembali.Columns[2].HeaderText = "Peminjam";
            dgv_data_kembali.Columns[3].HeaderText = "Pegawai";
            dgv_data_kembali.Columns[4].HeaderText = "Tanggal Kembali";

            dgv_data_kembali.Columns[0].Width = 100;
            dgv_data_kembali.Columns[1].Width = 100;
            dgv_data_kembali.Columns[2].Width = 200;
            dgv_data_kembali.Columns[3].Width = 200;
            dgv_data_kembali.Columns[4].Width = 130;
        }

        private void txt_cari_TextChanged(object sender, EventArgs e)
        {
            show_all_kembali();
        }

        private void cmb_length_SelectedIndexChanged(object sender, EventArgs e)
        {
            pg.set_datalength(cmb_length.Text);
            show_all_kembali();
        }

        private void btn_prev_page_Click(object sender, EventArgs e)
        {
            pg.prev();
            show_all_kembali();
        }

        private void txt_page_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)8) e.Handled = false;
            if (e.KeyChar == (char)13)
            {
                if (!pg.isset_hal())
                {
                    pg.reset_page();
                }
                show_all_kembali();
            }
        }

        private void btn_next_page_Click(object sender, EventArgs e)
        {
            pg.next();
            show_all_kembali();
        }

        private void txt_cari_KeyUp(object sender, KeyEventArgs e)
        {
            pg.reset_page();
            show_all_kembali();
        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            pengembalian_form frmact = new pengembalian_form(this);

            frmact.txt_idm.ReadOnly = true;
            frmact.txt_idp.Text = parent_data.status_id.Text;
            frmact.txt_idp.ReadOnly = true;
            frmact.txt_tgl.ReadOnly = true;
            frmact.panel_pinjam.Visible = false;
            frmact.ShowDialog();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            var baris = dgv_data_kembali.CurrentRow.Index;
            var id = dgv_data_kembali.Rows[baris].Cells[0].Value.ToString();
            var result = pinjam.get_cetak_buku_kembali(id);
            var data = pinjam.get_pinjam_description2(id);
            var total_denda = pinjam.total_denda(id);

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
    }
}
