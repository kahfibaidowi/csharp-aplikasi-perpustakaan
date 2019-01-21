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
    public partial class pegawai_form : Form
    {
        private model.pegawai peg = new model.pegawai();

        public pegawai data;

        public pegawai_form(pegawai layout)
        {
            data = layout;
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            peg.update_pegawai(txt_id.Text, txt_nama.Text, txt_alamat.Text, txt_telp.Text, txt_password.Text, cmb_level.Text, check_aktif.Checked);
            MessageBox.Show("Berhasil Mengubah Pegawai.!", "Message");
            data.show_all_pegawai();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            peg.add_pegawai(txt_id.Text, txt_nama.Text, txt_alamat.Text, txt_telp.Text, txt_password.Text, cmb_level.Text, check_aktif.Checked);
            MessageBox.Show("Berhasil Menambah Pegawai.!", "Message");
            data.show_all_pegawai();
            reset();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            if (label_header.Text == "Edit Pegawai")
            {
                var data = peg.get_pegawai(txt_id.Text);

                if (data[5] == "y")
                {
                    check_aktif.Checked = true;
                }
                else
                {
                    check_aktif.Checked = false;
                }
                txt_nama.Text = data[1];
                txt_alamat.Text = data[2];
                txt_telp.Text = data[3];
                cmb_level.Text = data[4];
                txt_password.Text = "";
            }
            else
            {
                txt_id.Text = "";
                txt_nama.Text = "";
                txt_alamat.Text = "";
                txt_telp.Text = "";
                cmb_level.Text = "pelayanan";
                txt_password.Text = "";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

    }
}
