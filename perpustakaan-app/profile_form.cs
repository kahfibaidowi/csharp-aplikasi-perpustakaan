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
    public partial class profile_form : Form
    {
        private model.pegawai pg = new model.pegawai();
        private administrator pr;

        public profile_form(administrator parent)
        {
            InitializeComponent();
            pr = parent;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            pg.update_pegawai(txt_id.Text, txt_nama.Text, txt_alamat.Text, txt_telp.Text, txt_pass.Text, lbl_jabatan.Text, true);
            pr.show_pegawai(); 
            MessageBox.Show("Berhasil Mengubah Data Akun.!");
            
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            var data = pg.get_pegawai(txt_id.Text);

            txt_nama.Text = data[1];
            txt_alamat.Text = data[2];
            txt_telp.Text = data[3];
            txt_pass.Text = "";
        }
    }
}
