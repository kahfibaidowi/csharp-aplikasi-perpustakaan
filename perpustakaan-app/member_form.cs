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
    public partial class member_form : Form
    {
        private model.member anggota = new model.member();

        public member data;

        public member_form(member layout)
        {
            data = layout;
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            anggota.update_member(txt_id.Text, txt_nama.Text, txt_alamat.Text, txt_telp.Text, check_aktif.Checked, check_panjang.Checked);
            MessageBox.Show("Berhasil Mengubah Member.!", "Message");
            data.show_all_member();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            anggota.add_member(txt_id.Text, txt_nama.Text, txt_alamat.Text, txt_telp.Text, check_aktif.Checked);
            MessageBox.Show("Berhasil Menambahkan Member.!", "Message");
            data.show_all_member();
            reset();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            if (label_header.Text == "Edit Member")
            {
                var data = anggota.get_member(txt_id.Text);

                if (data[4] == "y")
                {
                    check_aktif.Checked = true;
                }
                else
                {
                    check_aktif.Checked = false;
                }
                check_panjang.Checked = false;
                txt_nama.Text = data[1];
                txt_alamat.Text = data[2];
                txt_telp.Text = data[3];
            }
            else
            {
                txt_id.Text = "";
                txt_nama.Text = "";
                txt_alamat.Text = "";
                txt_telp.Text = "";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.check_panjang.Checked)
            {
                check_aktif.Checked = true;
            }
        }

    }
}
