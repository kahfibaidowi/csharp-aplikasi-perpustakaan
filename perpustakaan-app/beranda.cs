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
    public partial class beranda : Form
    {
        private model.general general = new model.general();
        public beranda()
        {
            InitializeComponent();

            update_statistik();

            update_panel();
        }

        private void update_panel()
        {
            var jml_buku = general.count_buku();
            var jml_member = general.count_member();
            var jml_pegawai = general.count_pegawai();
            var jml_pinjam = general.count_pinjam();

            txt_jml_buku.Text = jml_buku;
            txt_jml_member.Text = jml_member;
            txt_jml_pegawai.Text = jml_pegawai;
            txt_jml_pinjam.Text = jml_pinjam;
        }

        private void update_statistik()
        {
            List<string[]> data = general.get_min7day_statistic();

            chart_home.Series["statistik"].Points.Clear();
            for (int i = 0; i <data.Count; i++)
            {
                chart_home.Series["statistik"].Points.AddXY(data[i][0], data[i][1]);
                chart_home.Series["statistik"].Points[i].Label = data[i][1];
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            update_statistik();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void beranda_Load(object sender, EventArgs e)
        {

        }
    }
}
