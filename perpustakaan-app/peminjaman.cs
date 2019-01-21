using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace perpustakaan_app
{
    public partial class peminjaman : Form
    {
        private model.peminjaman pinjam = new model.peminjaman();
        private paging pg = new paging();

        private administrator parent_data;

        public peminjaman(administrator parent)
        {
            InitializeComponent();

            parent_data = parent;

            pg.set_btnprev(btn_prev_page);
            pg.set_btnnext(btn_next_page);
            pg.set_toolpage(txt_page);
            pg.set_labelpage(label_page);
            pg.set_datalength(cmb_length.Text);

            show_all_pinjam();
        }

        public void show_all_pinjam()
        {
            pg.all_data(pinjam.count_search(cmb_kategori_cari.Text, txt_cari.Text));

            var posisi = Convert.ToInt32(pg.num_filter)*(Convert.ToInt32(txt_page.Text)-1);
            var result = pinjam.search_peminjaman(cmb_kategori_cari.Text, txt_cari.Text, Convert.ToString(posisi), pg.num_filter.ToString());
            data_update(result);

            pg.btn_reset();
        }

        private void data_update(DataTable result)
        {
            dgv_data_pinjam.DataSource = "";
            dgv_data_pinjam.DataSource = result;

            atur_kolom();
        }

        private void atur_kolom()
        {
            dgv_data_pinjam.Columns[0].HeaderText = "ID Pinjam";
            dgv_data_pinjam.Columns[1].HeaderText = "ID Member";
            dgv_data_pinjam.Columns[2].HeaderText = "Peminjam";
            dgv_data_pinjam.Columns[3].HeaderText = "Pegawai";
            dgv_data_pinjam.Columns[4].HeaderText = "Tanggal Pinjam";
            dgv_data_pinjam.Columns[5].HeaderText = "Tanggal Kembali";

            dgv_data_pinjam.Columns[0].Width = 100;
            dgv_data_pinjam.Columns[1].Width = 100;
            dgv_data_pinjam.Columns[2].Width = 200;
            dgv_data_pinjam.Columns[3].Width = 200;
            dgv_data_pinjam.Columns[4].Width = 130;
            dgv_data_pinjam.Columns[5].Width = 130;
        }

        private void txt_cari_TextChanged(object sender, EventArgs e)
        {
            show_all_pinjam();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            peminjaman_form frmact = new peminjaman_form(this);

            DateTime dt = DateTime.Today;

            frmact.txt_id.Text = "auto";
            frmact.txt_id.ReadOnly = true;
            frmact.txt_idp.Text = parent_data.status_id.Text;
            frmact.txt_idp.ReadOnly = true;
            frmact.txt_tgl.Text = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
            frmact.txt_tgl.ReadOnly = true;
            frmact.panel_pinjam.Visible = false;
            frmact.ShowDialog();
        }

        private void cmb_length_SelectedIndexChanged(object sender, EventArgs e)
        {
            pg.set_datalength(cmb_length.Text);
            show_all_pinjam();
        }

        private void btn_prev_page_Click(object sender, EventArgs e)
        {
            pg.prev();
            show_all_pinjam();
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
                show_all_pinjam();
            }
        }

        private void btn_next_page_Click(object sender, EventArgs e)
        {
            pg.next();
            show_all_pinjam();
        }

        private void txt_cari_KeyUp(object sender, KeyEventArgs e)
        {
            pg.reset_page();
            show_all_pinjam();
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
    }
}
