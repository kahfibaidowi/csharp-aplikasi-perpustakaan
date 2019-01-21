using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace perpustakaan_app.model
{
    class general
    {
        public DataTable login(string username, string password)
        {
            var result = db.get_data("select id_pegawai, nama_lengkap, jabatan from tb_pegawai where id_pegawai='" + username + "' and passwd='" + lib.md5_hash(password) + "' and aktif='y'");
            return result;
        }

        public List<string[]> get_min7day_statistic()
        {
            List<string[]> data = new List<string[]>();

            for (int i = 6; i >= 0; i--)
            {
                var result = db.get_data("select adddate(curdate(), interval -"+i+" day), count(tgl_berkunjung) from tb_pengunjung where tgl_berkunjung=adddate(curdate(), interval-"+i.ToString()+" day)");
                string[] tgl = lib.pisahkan(result.Rows[0][0].ToString(), "/");
                string[] arr = {
                     tgl[2].Substring(0, 4)+"-"+tgl[1]+"-"+tgl[0],
                     result.Rows[0][1].ToString()
                };
                data.Add(arr);
            }

            return data;
        }

        public string count_buku()
        {
            var result = db.get_data("select count(*) from tb_buku");
            return result.Rows[0][0].ToString();
        }
        public string count_member()
        {
            var result = db.get_data("select count(*) from tb_member");
            return result.Rows[0][0].ToString();
        }
        public string count_pegawai()
        {
            var result = db.get_data("select count(*) from tb_pegawai");
            return result.Rows[0][0].ToString();
        }
        public string count_pinjam()
        {
            var result = db.get_data("select count(*) from tb_pinjam");
            return result.Rows[0][0].ToString();
        }
    }
}
