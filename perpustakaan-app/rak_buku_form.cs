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
    public partial class rak_buku_form : Form
    {
        private model.rak_buku rak = new model.rak_buku();
        private rak_buku data;

        public rak_buku_form(rak_buku design)
        {
            InitializeComponent();

            data = design;
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            rak.add_rak(txt_id.Text, txt_kategori.Text);
            MessageBox.Show("Berhasil Menambahkan Rak Buku.!", "Message");
            data.semua_rak_buku();
            reset();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            rak.update_rak(txt_id.Text, txt_kategori.Text);
            MessageBox.Show("Berhasil Mengubah Rak Buku.!", "Message");
            data.semua_rak_buku();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            if (label_header.Text == "Edit Rak Buku")
            {
                string[] data = rak.get_rak(txt_id.Text);

                txt_kategori.Text = data[1];
            }
            else
            {
                txt_id.Text = "";
                txt_kategori.Text = "";
            }
        }
    }
}
