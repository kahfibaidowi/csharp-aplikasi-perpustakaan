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
    public partial class pegawai : Form
    {
        private model.pegawai peg = new model.pegawai();
        private paging pg = new paging();

        public pegawai()
        {
            InitializeComponent();

            pg.set_btnprev(btn_prev_page);
            pg.set_btnnext(btn_next_page);
            pg.set_toolpage(txt_page);
            pg.set_labelpage(label_page);
            pg.set_datalength(cmb_length.Text);

            show_all_pegawai();
        }

        public void show_all_pegawai()
        {
            pg.all_data(peg.count_search(cmb_kategori_cari.Text, txt_cari.Text));

            var posisi = Convert.ToInt32(pg.num_filter)*(Convert.ToInt32(txt_page.Text)-1);
            var result = peg.search_pegawai(cmb_kategori_cari.Text, txt_cari.Text, Convert.ToString(posisi), pg.num_filter.ToString());
            data_update(result);

            pg.btn_reset();
        }

        private void data_update(DataTable result)
        {
            dgv_data_pegawai.DataSource = "";
            dgv_data_pegawai.DataSource = result;

            atur_kolom();
        }

        private void atur_kolom()
        {
            dgv_data_pegawai.Columns[0].HeaderText = "ID Pegawai";
            dgv_data_pegawai.Columns[1].HeaderText = "Nama Lengkap";
            dgv_data_pegawai.Columns[2].HeaderText = "Jabatan";
            dgv_data_pegawai.Columns[3].HeaderText = "No. Telepon";
            dgv_data_pegawai.Columns[4].HeaderText = "Alamat";
            dgv_data_pegawai.Columns[5].HeaderText = "Status";

            dgv_data_pegawai.Columns[0].Width = 100;
            dgv_data_pegawai.Columns[1].Width = 250;
            dgv_data_pegawai.Columns[2].Width = 100;
            dgv_data_pegawai.Columns[3].Width = 120;
            dgv_data_pegawai.Columns[4].Width = 300;
            dgv_data_pegawai.Columns[5].Width = 80;
            
        }

        private void txt_cari_TextChanged(object sender, EventArgs e)
        {
            show_all_pegawai();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            pegawai_form frmact = new pegawai_form(this);
            frmact.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var baris = dgv_data_pegawai.CurrentRow.Index;

            var data = peg.get_pegawai(dgv_data_pegawai.Rows[baris].Cells[0].Value.ToString());

            pegawai_form anggota_form = new pegawai_form(this);
            anggota_form.label_header.Text = "Edit Pegawai";
            anggota_form.txt_id.ReadOnly = true;
            anggota_form.txt_id.Text = data[0];
            anggota_form.txt_nama.Text = data[1];
            anggota_form.txt_alamat.Text = data[2];
            anggota_form.txt_telp.Text = data[3];
            anggota_form.cmb_level.Text = data[4];
            if (data[5] == "y")
            {
                anggota_form.check_aktif.Checked = true;
            }
            else
            {
                anggota_form.check_aktif.Checked = false;
            }
            anggota_form.label_pass_info.Visible = true;
            anggota_form.btn_tambah.Visible = false;
            anggota_form.btn_update.Visible = true;
            anggota_form.ShowDialog();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            var baris = dgv_data_pegawai.CurrentRow.Index;
            string[] data = peg.get_pegawai(dgv_data_pegawai.Rows[baris].Cells[0].Value.ToString());

            DialogResult dr = MessageBox.Show("Apakah anda yakin ingin menghapus pegawai ini.?\n" + data[1], "Konfirmasi", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                peg.delete_pegawai(dgv_data_pegawai.Rows[baris].Cells[0].Value.ToString());
                show_all_pegawai();
            }
        }

        private void cmb_length_SelectedIndexChanged(object sender, EventArgs e)
        {
            pg.set_datalength(cmb_length.Text);
            show_all_pegawai();
        }

        private void btn_prev_page_Click(object sender, EventArgs e)
        {
            pg.prev();
            show_all_pegawai();
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
                show_all_pegawai();
            }
        }

        private void btn_next_page_Click(object sender, EventArgs e)
        {
            pg.next();
            show_all_pegawai();
        }
    }
}
