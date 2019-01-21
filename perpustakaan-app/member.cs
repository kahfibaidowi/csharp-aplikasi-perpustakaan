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
    public partial class member : Form
    {
        private model.member anggota = new model.member();
        paging pg = new paging();

        public member()
        {
            InitializeComponent();

            pg.set_btnprev(btn_prev_page);
            pg.set_btnnext(btn_next_page);
            pg.set_toolpage(txt_page);
            pg.set_labelpage(label_page);
            pg.set_datalength(cmb_length.Text);

            show_all_member();
        }
        
        public void show_all_member()
        {
            pg.all_data(anggota.count_search(cmb_kategori_cari.Text, txt_cari.Text));

            var posisi = Convert.ToInt32(pg.num_filter) * (Convert.ToInt32(txt_page.Text) - 1);
            var result = anggota.search(cmb_kategori_cari.Text, txt_cari.Text, Convert.ToString(posisi), pg.num_filter.ToString());
            data_update(result);

            pg.btn_reset();
        }

        private void data_update(DataTable result)
        {
            dgv_data_member.DataSource = "";
            dgv_data_member.DataSource = result;

            atur_kolom();
        }

        private void atur_kolom()
        {
            dgv_data_member.Columns[0].HeaderText = "ID Member";
            dgv_data_member.Columns[1].HeaderText = "Nama Lengkap";
            dgv_data_member.Columns[2].HeaderText = "Alamat";
            dgv_data_member.Columns[3].HeaderText = "No. Telepon";
            dgv_data_member.Columns[4].HeaderText = "Tanggal Registrasi";
            dgv_data_member.Columns[5].HeaderText = "Status";

            dgv_data_member.Columns[0].Width = 100;
            dgv_data_member.Columns[1].Width = 170;
            dgv_data_member.Columns[2].Width = 300;
            dgv_data_member.Columns[3].Width = 110;
            dgv_data_member.Columns[4].Width = 150;
            dgv_data_member.Columns[5].Width = 80;
            
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            member_form anggota_form = new member_form(this);
            anggota_form.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var baris = dgv_data_member.CurrentRow.Index;

            var data = anggota.get_member(dgv_data_member.Rows[baris].Cells[0].Value.ToString());

            member_form anggota_form = new member_form(this);
            anggota_form.label_header.Text = "Edit Member";
            anggota_form.txt_id.ReadOnly = true;
            anggota_form.txt_id.Text = data[0];
            anggota_form.txt_nama.Text = data[1];
            anggota_form.txt_alamat.Text = data[2];
            anggota_form.txt_telp.Text = data[3];
            if (data[4] == "y")
            {
                anggota_form.check_aktif.Checked = true;
            }
            else
            {
                anggota_form.check_aktif.Checked = false;
            }
            anggota_form.check_panjang.Visible = true;
            anggota_form.btn_tambah.Visible = false;
            anggota_form.btn_update.Visible = true;
            anggota_form.ShowDialog();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            var baris = dgv_data_member.CurrentRow.Index;
            string[] data = anggota.get_member(dgv_data_member.Rows[baris].Cells[0].Value.ToString());

            DialogResult dr = MessageBox.Show("Apakah anda yakin ingin menghapus member ini.?\n" + data[1], "Konfirmasi", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                anggota.delete_member(dgv_data_member.Rows[baris].Cells[0].Value.ToString());
                show_all_member();
            }
        }

        private void cmb_length_SelectedIndexChanged(object sender, EventArgs e)
        {
            pg.set_datalength(cmb_length.Text);
            show_all_member();
        }

        private void btn_prev_page_Click(object sender, EventArgs e)
        {
            pg.prev();
            show_all_member();
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

                show_all_member();
            }
        }

        private void btn_next_page_Click(object sender, EventArgs e)
        {
            pg.next();
            show_all_member();
        }

        private void txt_cari_KeyUp(object sender, KeyEventArgs e)
        {
            pg.reset_page();
            show_all_member();
        }
    }
}
