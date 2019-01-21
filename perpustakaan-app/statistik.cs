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
    public partial class statistik : Form
    {
        private model.statistik stat = new model.statistik();
        public statistik()
        {
            InitializeComponent();

            add_checkbox();

            show_pengunjung();
        }

        private void add_checkbox(){
            var data = stat.date_found();

            for (int i = 0; i < data.Count; i++)
            {
                cmb_mulai.Items.Add(data[i]);
            }
            for (int i = 0; i < data.Count; i++)
            {
                cmb_selesai.Items.Add(data[i]);
            }
            cmb_mulai.Text = data[0];
            cmb_selesai.Text = data[data.Count-1];
        }

        private void btn_tampil_Click(object sender, EventArgs e)
        {
            show_pengunjung();
        }

        private void show_pengunjung()
        {
            var result = stat.show_pengunjung(cmb_mulai.Text, cmb_selesai.Text);
            dgv_data_pengunjung.DataSource = "";
            dgv_data_pengunjung.DataSource = result;

            atur_kolom();

            txt_count.Text = result.Rows.Count.ToString();
        }

        private void atur_kolom()
        {
            dgv_data_pengunjung.Columns[0].HeaderText = "ID Pengunjung";
            dgv_data_pengunjung.Columns[1].HeaderText = "Status Pengunjung";
            dgv_data_pengunjung.Columns[2].HeaderText = "Nama Lengkap";
            dgv_data_pengunjung.Columns[3].HeaderText = "Alamat";

            dgv_data_pengunjung.Columns[0].Width = 100;
            dgv_data_pengunjung.Columns[1].Width = 120;
            dgv_data_pengunjung.Columns[2].Width = 200;
            dgv_data_pengunjung.Columns[3].Width = 300;
        }
    }
}
