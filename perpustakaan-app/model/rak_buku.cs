using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace perpustakaan_app.model
{
    class rak_buku
    {
        public string count_rak_buku()
        {
            var result = db.get_data("select count(*) from tb_rak_buku");
            return result.Rows[0][0].ToString();
        }
        public DataTable get_all_rak(string posisi, string batas){
            var result = db.get_data("select * from tb_rak_buku order by nama_rak_buku limit "+posisi+","+batas);
            result.Columns.Add("total_data", typeof(string));

            foreach (DataRow dr in result.Rows)
            {
                var data_buku = db.get_data("select * from tb_buku where id_rak='" + dr[0].ToString() + "'");
                dr[2] = data_buku.Rows.Count.ToString()+" buku";
            }

            return result;
        }

        public void add_rak(string id, string kategori)
        {
            db.execute("insert into tb_rak_buku values('" + id + "','" + kategori + "')");
        }

        public void update_rak(string id, string kategori)
        {
            db.execute("update tb_rak_buku set nama_rak_buku='" + kategori + "' where id_rak='" + id + "'");
        }

        public string[] get_rak(string id)
        {
            var result = db.get_data("select * from tb_rak_buku where id_rak='" + id + "'");

            string[] data = {
                     result.Rows[0][0].ToString(),
                     result.Rows[0][1].ToString()
            };

            return data;
        }

        public void delete_rak(string id)
        {
            db.execute("delete from tb_rak_buku where id_rak='" + id + "'");
        }
    }
}
