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
    public partial class buku : Form
    {
        model.buku book = new model.buku();
        paging pg = new paging();

        public buku()
        {
            InitializeComponent();

            pg.set_btnprev(btn_prev_page);
            pg.set_btnnext(btn_next_page);
            pg.set_toolpage(txt_page);
            pg.set_labelpage(label_page);
            pg.set_datalength(cmb_length.Text);

            tampil_buku();
        }

        public void tampil_buku()
        {
            pg.all_data(book.count_search(cmb_kategori_cari.Text, txt_cari.Text));
            
            var posisi = Convert.ToInt32(pg.num_filter)*(Convert.ToInt32(txt_page.Text)-1);
            var result = book.search(cmb_kategori_cari.Text, txt_cari.Text, Convert.ToString(posisi), pg.num_filter.ToString());
            data_update(result);

            pg.btn_reset();
        }

        private void data_update(DataTable result)
        {
            dgv_data_buku.DataSource = "";
            dgv_data_buku.DataSource = result;
            atur_kolom();
        }

        private void txt_cari_KeyUp(object sender, KeyEventArgs e)
        {
            pg.reset_page();
            tampil_buku();
        }

        private void atur_kolom()
        {
            dgv_data_buku.Columns[0].HeaderText = "ID Buku";
            dgv_data_buku.Columns[1].HeaderText = "Judul";
            dgv_data_buku.Columns[2].HeaderText = "Pengarang";
            dgv_data_buku.Columns[3].HeaderText = "Penerbit";
            dgv_data_buku.Columns[4].HeaderText = "Tahun";
            dgv_data_buku.Columns[5].HeaderText = "Lokasi Rak";
            dgv_data_buku.Columns[6].HeaderText = "Stok";

            dgv_data_buku.Columns[0].Width = 90;
            dgv_data_buku.Columns[1].Width = 300;
            dgv_data_buku.Columns[2].Width = 130;
            dgv_data_buku.Columns[3].Width = 130;
            dgv_data_buku.Columns[4].Width = 80;
            dgv_data_buku.Columns[5].Width = 150;
            dgv_data_buku.Columns[6].Width = 70;
        }

        private void cmb_kategori_cari_SelectedIndexChanged(object sender, EventArgs e)
        {
            tampil_buku();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            buku_form book_form = new buku_form(this);
            book_form.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var baris = dgv_data_buku.CurrentRow.Index;

            string[] data = book.get_buku(dgv_data_buku.Rows[baris].Cells[0].Value.ToString());

            buku_form book_form = new buku_form(this);
            book_form.label_header.Text = "Edit Buku";
            book_form.btn_update.Visible = true;
            book_form.btn_tambah.Visible = false;
            book_form.txt_id.ReadOnly = true;
            book_form.txt_id.Text = data[0];
            book_form.txt_judul.Text = data[1];
            book_form.txt_pengarang.Text = data[2];
            book_form.txt_penerbit.Text = data[3];
            book_form.txt_tahun.Text = data[4];
            book_form.cmb_kategori.Text = data[6];
            book_form.txt_stok.Text = data[5];
            book_form.ShowDialog();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            var baris = dgv_data_buku.CurrentRow.Index;
            string[] data = book.get_buku(dgv_data_buku.Rows[baris].Cells[0].Value.ToString());

            DialogResult dr = MessageBox.Show("Apakah anda yakin ingin menghapus buku ini.?\n" + data[1], "Konfirmasi", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                book.delete_buku(dgv_data_buku.Rows[baris].Cells[0].Value.ToString());
                tampil_buku();
            }
        }

        private void btn_next_page_Click(object sender, EventArgs e)
        {
            pg.next();
            tampil_buku();
        }

        private void btn_prev_page_Click(object sender, EventArgs e)
        {
            pg.prev();
            tampil_buku();
        }

        private void cmb_length_SelectedIndexChanged(object sender, EventArgs e)
        {
            pg.set_datalength(cmb_length.Text);
            tampil_buku();
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
                tampil_buku();
            }
        }
    }
}
