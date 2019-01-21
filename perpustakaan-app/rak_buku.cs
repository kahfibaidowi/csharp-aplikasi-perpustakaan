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
    public partial class rak_buku : Form
    {
        private model.rak_buku rak = new model.rak_buku();
        paging pg = new paging();

        public rak_buku()
        {
            InitializeComponent();

            pg.set_btnprev(btn_prev_page);
            pg.set_btnnext(btn_next_page);
            pg.set_toolpage(txt_page);
            pg.set_labelpage(label_page);
            pg.set_datalength(cmb_length.Text);

            semua_rak_buku();
        }

        public void semua_rak_buku()
        {
            pg.all_data(rak.count_rak_buku());

            var posisi = Convert.ToInt32(pg.num_filter) * (Convert.ToInt32(txt_page.Text) - 1);
            var result = rak.get_all_rak(Convert.ToString(posisi), pg.num_filter.ToString());
            data_update(result);

            pg.btn_reset();
        }

        private void data_update(DataTable result)
        {
            dgv_data_rak.DataSource = "";
            dgv_data_rak.DataSource = result;
            atur_kolom();
        }

        private void atur_kolom()
        {
            dgv_data_rak.Columns[0].HeaderText = "ID Rak Buku";
            dgv_data_rak.Columns[1].HeaderText = "Kategori / Rak Buku";
            dgv_data_rak.Columns[2].HeaderText = "Jumlah Koleksi";

            dgv_data_rak.Columns[0].Width = 110;
            dgv_data_rak.Columns[1].Width = 300;
            dgv_data_rak.Columns[2].Width = 160;
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            rak_buku_form rb_form = new rak_buku_form(this);
            rb_form.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var baris = dgv_data_rak.CurrentRow.Index;

            string[] data = rak.get_rak(dgv_data_rak.Rows[baris].Cells[0].Value.ToString());

            rak_buku_form rb_form = new rak_buku_form(this);
            rb_form.label_header.Text = "Edit Rak Buku";
            rb_form.btn_tambah.Visible = false;
            rb_form.btn_update.Visible = true;
            rb_form.txt_id.ReadOnly = true;
            rb_form.txt_id.Text = data[0];
            rb_form.txt_kategori.Text = data[1];
            rb_form.ShowDialog();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            var baris = dgv_data_rak.CurrentRow.Index;
            string[] data = rak.get_rak(dgv_data_rak.Rows[baris].Cells[0].Value.ToString());

            DialogResult dr = MessageBox.Show("Apakah anda yakin ingin menghapus rak ini.?\n" + data[1], "Konfirmasi", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                rak.delete_rak(dgv_data_rak.Rows[baris].Cells[0].Value.ToString());
                semua_rak_buku();
            }
        }

        private void btn_prev_page_Click(object sender, EventArgs e)
        {
            pg.prev();
            semua_rak_buku();
        }

        private void btn_next_page_Click(object sender, EventArgs e)
        {
            pg.next();
            semua_rak_buku();
        }

        private void cmb_length_SelectedIndexChanged(object sender, EventArgs e)
        {
            pg.set_datalength(cmb_length.Text);
            semua_rak_buku();
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
                semua_rak_buku();
            }
        }
    }
}
