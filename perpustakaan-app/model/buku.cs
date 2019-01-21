using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace perpustakaan_app.model
{
    public class buku
    {
        public string count_search(string k, string q)
        {
            var result = db.get_data("select count(*) from tb_buku where " + k + " like '%" + q + "%'");
            return result.Rows[0][0].ToString();
        }

        public DataTable search(string k, string q, string posisi, string batas)
        {
            var result = db.get_data("select a.id_buku, a.judul, a.pengarang, a.penerbit, a.tahun, b.nama_rak_buku, a.stok from tb_buku a, tb_rak_buku b where a.id_rak=b.id_rak and a."+k+" like '%"+q+"%' order by a.judul asc limit "+posisi+", "+batas);
            return result;
        }

        public DataTable get_kategori()
        {
            var result = db.get_data("select id_rak, nama_rak_buku from tb_rak_buku");
            return result;
        }

        public string[] get_buku(string id)
        {
            var result = db.get_data("select a.id_buku, a.judul, a.pengarang, a.penerbit, a.tahun, a.stok, a.id_rak, b.nama_rak_buku from tb_buku a, tb_rak_buku b where a.id_rak=b.id_rak and a.id_buku='" + id + "'");

            string[] data = {
                     result.Rows[0][0].ToString(),
                     result.Rows[0][1].ToString(),
                     result.Rows[0][2].ToString(),
                     result.Rows[0][3].ToString(),
                     result.Rows[0][4].ToString(),
                     result.Rows[0][5].ToString(),
                     result.Rows[0][6].ToString()+"   "+result.Rows[0][7].ToString(),
            };

            return data;
        }

        public void add_buku(string id, string judul, string penerbit, string pengarang, string stok, string tahun, string kategori)
        {
            var category = lib.pisahkan(kategori, "   ");
            db.execute("insert into tb_buku values('" + id + "','" + category[0] + "','" + judul + "','" + pengarang + "','" + penerbit + "','" + tahun + "','" + stok + "')");
        }

        public void update_buku(string id, string judul, string penerbit, string pengarang, string stok, string tahun, string kategori)
        {
            var category = lib.pisahkan(kategori, "   ");
            db.execute("update tb_buku set judul='" + judul + "', penerbit='" + penerbit + "', pengarang='" + pengarang + "', tahun='" + tahun + "', id_rak='" + category[0] + "',stok='" + stok + "' where id_buku='" + id + "'");
        }

        public void delete_buku(string id)
        {
            db.execute("delete from tb_buku where id_buku='" + id + "'");
        }
    }
}
