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
    public partial class buku_form : Form
    {
        model.buku book = new model.buku();

        private buku data;

        public buku_form(buku design)
        {
            InitializeComponent();

            data = design;
           
            combobox_fill();
        }

        private void combobox_fill()
        {
            var result = book.get_kategori();

            foreach(DataRow row in result.Rows){
                cmb_kategori.Items.Add(row[0].ToString() + "   " + row[1].ToString());
            }
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "" || txt_judul.Text == "" || txt_penerbit.Text == "" || txt_pengarang.Text == "" || txt_stok.Text == "" || txt_tahun.Text == "" || cmb_kategori.Text == "")
            {
                MessageBox.Show("Lengkapi data terlebih dahulu.!", "Message");
            }
            else
            {
                book.add_buku(txt_id.Text, txt_judul.Text, txt_penerbit.Text, txt_pengarang.Text, txt_stok.Text, txt_tahun.Text, cmb_kategori.Text);
                MessageBox.Show("Berhasil Menambahkan Data.!", "Message");
                data.tampil_buku();
                reset();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            book.update_buku(txt_id.Text, txt_judul.Text, txt_penerbit.Text, txt_pengarang.Text, txt_stok.Text, txt_tahun.Text, cmb_kategori.Text);
            MessageBox.Show("Berhasil Mengubah Data.!", "Message");
            data.tampil_buku();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            if (label_header.Text == "Edit Buku")
            {
                string[] data = book.get_buku(txt_id.Text);

                txt_judul.Text = data[1];
                txt_pengarang.Text = data[2];
                txt_penerbit.Text = data[3];
                txt_stok.Text = data[5];
                txt_tahun.Text = data[4];
                cmb_kategori.Text = data[6];
            }
            else
            {
                txt_id.Text = "";
                txt_judul.Text = "";
                txt_pengarang.Text = "";
                txt_penerbit.Text = "";
                txt_stok.Text = "";
                txt_tahun.Text = "";
                cmb_kategori.Text = "";
            }
        }
    }
}
