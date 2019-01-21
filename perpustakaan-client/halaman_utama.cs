using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace perpustakaan_client
{
    public partial class halaman_utama : Form
    {
        public halaman_utama()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.MinimumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

        }

        private void atur_kolom()
        {
            dgv_hasil_cari.Columns[0].HeaderText = "ID Buku";
            dgv_hasil_cari.Columns[1].HeaderText = "Judul";
            dgv_hasil_cari.Columns[2].HeaderText = "Pengarang";
            dgv_hasil_cari.Columns[3].HeaderText = "Penerbit";
            dgv_hasil_cari.Columns[4].HeaderText = "Stok Tersedia";

            dgv_hasil_cari.Columns[0].Width = 90;
            dgv_hasil_cari.Columns[1].Width = 300;
            dgv_hasil_cari.Columns[2].Width = 130;
            dgv_hasil_cari.Columns[3].Width = 150;
            dgv_hasil_cari.Columns[4].Width = 130;
        }

        private void btn_cari_Click(object sender, EventArgs e)
        {
            var result = db.get_data("select id_buku, judul, pengarang, penerbit, stok from tb_buku where " + cmb_kategori.Text + " like '%" + txt_cari.Text + "%' order by judul asc");
            result.Columns.Add("Stok Tersedia", typeof(string));

            foreach (DataRow dr in result.Rows)
            {
                var result1 = db.get_data("select count(*) from tb_detail_pinjam where id_buku='" + dr[0].ToString() + "'");
                var result2 = db.get_data("select count(*) from tb_detail_kembali where id_buku='" + dr[0].ToString() + "'");

                dr[5] = (Convert.ToInt32(dr[4].ToString())-(Convert.ToInt32(result1.Rows[0][0].ToString()) - Convert.ToInt32(result2.Rows[0][0].ToString()))).ToString();
            }
            result.Columns.Remove("stok");

            dgv_hasil_cari.DataSource = "";
            dgv_hasil_cari.DataSource = result;

            lbl_info.Text = "Menampilkan "+result.Rows.Count.ToString()+" buku dengan kata kunci '"+cmb_kategori.Text+">"+txt_cari.Text+"'";
            atur_kolom();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (txt_nama.Text == "" || txt_alamat.Text == "")
            {
                MessageBox.Show("Lengkapi data pada form.!");
            }
            else
            {
                if (rd_y.Checked)
                {
                    db.execute("insert into tb_pengunjung values('','y','" + txt_id_member.Text + "','','','" + DateTime.Today.Year.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Day.ToString() + "')");
                }
                else
                {
                    db.execute("insert into tb_pengunjung values('','n','','"+txt_nama.Text+"','"+txt_alamat.Text+"','" + DateTime.Today.Year.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Day.ToString() + "')");
                }
                MessageBox.Show("berhasil.!");
            }
        }

        private void btn_cari_member_Click(object sender, EventArgs e)
        {
            var result = db.get_data("select * from tb_member where id_member='" + txt_id_member.Text + "'");
            if (result.Rows.Count.ToString() == "0")
            {
                MessageBox.Show("Member Tidak Ditemukan.!");
            }
            else
            {
                var result1 = db.get_data("select nama_lengkap, alamat from tb_member where id_member='" + txt_id_member.Text + "'");
                var nama = result1.Rows[0][0].ToString();
                var alamat = result1.Rows[0][1].ToString();

                txt_nama.Text = nama;
                txt_alamat.Text = alamat;
            }
        }

        private void rd_n_CheckedChanged(object sender, EventArgs e)
        {
            txt_id_member.ReadOnly = true;
            btn_cari_member.Enabled = false;

            txt_nama.Text = "";
            txt_alamat.Text = "";
            txt_nama.ReadOnly = false;
            txt_alamat.ReadOnly = false;
        }

        private void rd_y_CheckedChanged(object sender, EventArgs e)
        {
            txt_id_member.ReadOnly = false;
            btn_cari_member.Enabled = true;

            txt_nama.Text = "";
            txt_alamat.Text = "";
            txt_nama.ReadOnly = true;
            txt_alamat.ReadOnly = true;
        }
    }
}
