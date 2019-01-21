using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace perpustakaan_app.model
{
    class member
    {
        public string count_search(string k, string q)
        {
            var result = db.get_data("select count(*) from tb_member where " + k + " like '%" + q + "%'");
            return result.Rows[0][0].ToString();
        }
        public DataTable search(string k, string q, string posisi, string batas)
        {
            var result = db.get_data("select * from tb_member where " + k + " like '%" + q + "%' order by nama_lengkap limit "+posisi+","+batas);
            result.Columns[5].MaxLength = 20;

            foreach (DataRow dr in result.Rows)
            {
                dr[5] = lib.set_status(dr[5].ToString());
            }

            return result;
        }

        public void add_member(string id, string nama, string alamat, string telp, bool check)
        {
            var date = DateTime.Today;

            var day = date.Day.ToString();
            var month = date.Month.ToString();
            var year = date.Year.ToString();

            if (check)
            {
                db.execute("insert into tb_member values('" + id + "','" + nama + "','" + alamat + "','" + telp + "','" + year + "-" + month + "-" + day + "','y')");
            }
            else
            {
                db.execute("insert into tb_member values('" + id + "','" + nama + "','" + alamat + "','" + telp + "','0000-00-00','n')");
            }
        }

        public string[] get_member(string id)
        {
            var result = db.get_data("select id_member, nama_lengkap, alamat, no_telp, aktif from tb_member where id_member='" + id + "'");

            string[] data = {
                        result.Rows[0][0].ToString(),
                        result.Rows[0][1].ToString(),
                        result.Rows[0][2].ToString(),
                        result.Rows[0][3].ToString(),
                        result.Rows[0][4].ToString()
            };

            return data;
        }

        public void delete_member(string id)
        {
            var result = db.execute("delete from tb_member where id_member='" + id + "'");
        }

        public void update_member(string id, string nama, string alamat, string telp, bool check, bool check_perpanjang)
        {
            if (check)
            {
                var date = DateTime.Today;

                var day = date.Day.ToString();
                var month = date.Month.ToString();
                var year = date.Year.ToString();

                if (check_perpanjang)
                {
                    db.execute("update tb_member set nama_lengkap='" + nama + "', alamat='" + alamat + "', no_telp='" + telp + "', tgl_registrasi='" + year + "-" + month + "-" + day + "', aktif='y' where id_member='" + id + "'");
                }
                else
                {
                    db.execute("update tb_member set nama_lengkap='" + nama + "', alamat='" + alamat + "', no_telp='" + telp + "', aktif='y' where id_member='" + id + "'");
                }
            }
            else
            {
                db.execute("update tb_member set nama_lengkap='" + nama + "', alamat='" + alamat + "', no_telp='" + telp + "', aktif='n' where id_member='" + id + "'");
            }
        }
    }
}
