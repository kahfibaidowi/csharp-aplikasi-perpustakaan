using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace perpustakaan_app.model
{
    class pegawai
    {

        public string count_search(string k, string q)
        {
            var result = db.get_data("select count(*) from tb_pegawai");
            return result.Rows[0][0].ToString();
        }

        public DataTable search_pegawai(string k, string q, string posisi, string batas)
        {
            var result = db.get_data("select id_pegawai, nama_lengkap, jabatan, no_telp, alamat, aktif from tb_pegawai where " + k + " like '%" + q + "%' order by nama_lengkap asc limit "+posisi+","+batas);
            result.Columns[5].MaxLength = 20;

            foreach (DataRow dr in result.Rows)
            {
                dr[5] = lib.set_status(dr[5].ToString());
            }

            return result;
        }

        public string[] get_pegawai(string id)
        {
            var result = db.get_data("select id_pegawai, nama_lengkap, alamat, no_telp, jabatan, aktif from tb_pegawai where id_pegawai='"+id+"'");

            string[] data = {
                     result.Rows[0][0].ToString(),
                     result.Rows[0][1].ToString(),
                     result.Rows[0][2].ToString(),
                     result.Rows[0][3].ToString(),
                     result.Rows[0][4].ToString(),
                     result.Rows[0][5].ToString(),
            };

            return data;
        }

        public void add_pegawai(string id, string nama, string alamat, string telp, string password, string level, bool check)
        {
            if (check)
            {
                db.execute("insert into tb_pegawai values('" + id + "','" + nama + "','" + alamat + "','" + telp + "','','" + level + "','y')");
            }
            else
            {
                db.execute("insert into tb_pegawai values('" + id + "','" + nama + "','" + alamat + "','" + telp + "','','" + level + "','n')");
            }

            if (password != "")
            {
                db.execute("update tb_pegawai set passwd='" + lib.md5_hash(password) + "' where id_pegawai='"+id+"'");
            }
        }

        public void update_pegawai(string id, string nama, string alamat, string telp, string password, string level, bool check)
        {
            if (check)
            {
                db.execute("update tb_pegawai set nama_lengkap='" + nama + "', alamat='" + alamat + "', no_telp='" + telp + "', jabatan='" + level + "', aktif='y' where id_pegawai='" + id + "'");
            }
            else
            {
                db.execute("update tb_pegawai set nama_lengkap='" + nama + "', alamat='" + alamat + "', no_telp='" + telp + "', jabatan='" + level + "', aktif='n' where id_pegawai='" + id + "'");
            }

            if (password != "")
            {
                db.execute("update tb_pegawai set passwd='" + lib.md5_hash(password) + "' where id_pegawai='"+id+"'");
            }
        }

        public void delete_pegawai(string id)
        {
            db.execute("delete from tb_pegawai where id_pegawai='" + id + "'");
        }
    }
}
