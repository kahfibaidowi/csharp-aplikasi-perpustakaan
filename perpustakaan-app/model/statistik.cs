using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace perpustakaan_app.model
{
    public class statistik
    {
        public List<string> date_found()
        {
            var result = db.get_data("select distinct tgl_berkunjung from tb_pengunjung order by tgl_berkunjung asc");

            List<string> data = new List<string>(); 
            for (int i = 0; i < result.Rows.Count; i++)
            {
                string[] tgl = lib.pisahkan(result.Rows[i][0].ToString(), "/");
                data.Add(tgl[2].Substring(0, 4) + "-" + tgl[0] + "-" + tgl[1]);
            }

            return data;
        }

        public DataTable show_pengunjung(string mulai, string selesai)
        {
            var result = db.get_data("select a.id_pengunjung, 'member', b.nama_lengkap, b.alamat from tb_pengunjung a, tb_member b where a.id_member=b.id_member and a.member='y' and a.tgl_berkunjung between '"+mulai+"' and '"+selesai+"' union select id_pengunjung, 'bukan member', nama_lengkap, alamat from tb_pengunjung where member='n' and tgl_berkunjung between '"+mulai+"' and '"+selesai+"'");
            return result;
        }
    }
}
