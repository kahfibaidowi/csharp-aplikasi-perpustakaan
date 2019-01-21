using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace perpustakaan_app.model
{
    class peminjaman
    {
        public string count_search(string k, string q)
        {
            var result = db.get_data("select count(*) from tb_pinjam a, tb_member b, tb_pegawai c where a.id_member=b.id_member and a.id_pegawai=c.id_pegawai and (select count(*) from tb_kembali d where d.id_pinjam=a.id_pinjam)='0' and a."+k+" like '%"+q+"%'");
            return result.Rows[0][0].ToString();
        }

        public bool active_member(string id)
        {
            var result = db.get_data("select count(*) from tb_member where id_member='" + id + "' and aktif='y'");
            if (result.Rows[0][0].ToString() != "0")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable search_peminjaman(string k, string q, string posisi, string batas)
        {
            var result = db.get_data("select a.id_pinjam, b.id_member, b.nama_lengkap, c.nama_lengkap, a.tgl_pinjam from tb_pinjam a, tb_member b, tb_pegawai c where a.id_member=b.id_member and a.id_pegawai=c.id_pegawai and (select count(*) from tb_kembali d where d.id_pinjam=a.id_pinjam)='0' and a." + k + " like '%" + q + "%'");
            result.Columns.Add("tgl_kembali", typeof(string));

            foreach (DataRow dr in result.Rows)
            {
                string [] exp_tgl = lib.pisahkan(dr[4].ToString(), "/");
                DateTime dt1 = new DateTime(Convert.ToInt32(exp_tgl[2].Substring(0, 4)), Convert.ToInt32(exp_tgl[0]), Convert.ToInt32(exp_tgl[1]));
                DateTime dt = dt1.AddDays(7);
                dr[5] = dt.Month + "/" + dt.Day + "/" + dt.Year;
            }
            return result;
        }

        public bool cek_peminjaman(string id_member)
        {
            var result = db.get_data("select count(*) from tb_pinjam a where (select count(*) from tb_kembali b where b.id_pinjam=a.id_pinjam)='0' and a.id_member='"+id_member+"'");
            if (result.Rows[0][0].ToString() != "0")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void add_peminjaman(string id_member, string id_pegawai, string tgl)
        {
            db.execute("insert into tb_pinjam values('','" + id_member + "','" + id_pegawai + "','" + tgl + "')");
        }

        public DataTable get_buku_pinjam(string id)
        {
            var result = db.get_data("select a.id_buku, a.judul, a.pengarang, a.penerbit from tb_buku a, tb_detail_pinjam b where (select count(*) from tb_detail_kembali c where c.id_pinjam='"+id+"' and c.id_buku=b.id_buku)='0' and b.id_buku=a.id_buku and b.id_pinjam='" + id + "'");
            return result;
        }

        public DataTable get_cetak_buku_pinjam(string id)
        {
            var result = db.get_data("select a.id_buku, a.judul, b.tgl_pinjam, adddate(b.tgl_pinjam, interval 7 day) as tgl_kembali from tb_buku a, tb_pinjam b, tb_detail_pinjam c where c.id_pinjam=b.id_pinjam and c.id_buku=a.id_buku and c.id_pinjam='"+id+"'");
            return result;
        }

        public DataTable get_cetak_buku_kembali(string id)
        {
            var result = db.get_data("select a.id_buku, a.judul, b.tipe_denda, b.denda from tb_buku a, tb_detail_kembali b where b.id_buku=a.id_buku and b.id_pinjam='"+id+"'");
            return result;
        }

        public string total_denda(string id)
        {
            var result = db.get_data("select sum(denda) from tb_detail_kembali where id_pinjam='" + id + "'");
            return result.Rows[0][0].ToString();
        }

        public string[] get_pinjam_description(string id)
        {
            var result = db.get_data("select a.id_pinjam, b.nama_lengkap, c.nama_lengkap from tb_pinjam a, tb_member b, tb_pegawai c where a.id_member=b.id_member and a.id_pegawai=c.id_pegawai and a.id_pinjam='" + id + "'");
            string[] data = {
                        result.Rows[0][0].ToString(),
                        result.Rows[0][1].ToString(),
                        result.Rows[0][2].ToString()
            };

            return data;
        }

        public string[] get_pinjam_description2(string id)
        {
            var result = db.get_data("select a.id_pinjam, b.nama_lengkap, c.nama_lengkap from tb_pinjam a, tb_member b, tb_pegawai c where a.id_member=b.id_member and a.id_pegawai=c.id_pegawai and a.id_pinjam='" + id + "'");
            string[] data = {
                        result.Rows[0][0].ToString(),
                        result.Rows[0][1].ToString(),
                        result.Rows[0][2].ToString()
            };

            return data;
        }

        public void add_buku_pinjam(string id_pinjam, string id_buku)
        {
            db.execute("insert into tb_detail_pinjam values('" + id_pinjam + "','" + id_buku + "')");
        }

        public string count_pinjam(string id_pinjam)
        {
            var result = db.get_data("select count(*) from tb_detail_pinjam where id_pinjam='" + id_pinjam + "'");
            return result.Rows[0][0].ToString();
        }

        public void hapus_buku_pinjam(string id_pinjam, string id_buku)
        {
            db.execute("delete from tb_detail_pinjam where id_pinjam='" + id_pinjam + "' and id_buku='" + id_buku + "'");
        }

        public void delete_pinjam(string id_pinjam)
        {
            db.execute("delete from tb_detail_pinjam where id_pinjam='" + id_pinjam + "'");
            db.execute("delete from tb_pinjam where id_pinjam='" + id_pinjam + "'");
        }

        public bool is_null_pinjam(string id)
        {
            var result = db.get_data("select count(*) from tb_pinjam where id_pinjam='" + id + "'");
            if (result.Rows[0][0].ToString() == "0")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string[] get_pinjam(string id)
        {
            var result = db.get_data("select id_pinjam, id_member, tgl_pinjam from tb_pinjam where id_pinjam='" + id + "'");

            string[] tgl = lib.pisahkan(result.Rows[0][2].ToString(), "/");
            string[] data = {
                        result.Rows[0][0].ToString(),
                        result.Rows[0][1].ToString(),
                        tgl[1]+"/"+tgl[0]+"/"+tgl[2].Substring(0, 4)
            };

            return data;
        }
        public string[] get_last_pinjam(string id)
        {
            var result = db.get_data("select id_pinjam, id_member, tgl_pinjam from tb_pinjam where id_member='"+id+"' order by id_pinjam desc limit 1");

            string[] tgl = lib.pisahkan(result.Rows[0][2].ToString(), "/");
            string[] data = {
                        result.Rows[0][0].ToString(),
                        result.Rows[0][1].ToString(),
                        tgl[1]+"/"+tgl[0]+"/"+tgl[2].Substring(0, 4)
            };

            return data;
        }

        public void kembalikan_buku(string id_pinjam, string id_buku, string id_pegawai, bool check, string denda)
        {
            string tipe_denda = "";
            if (check)
            {
                tipe_denda = "Buku Hilang";
            }
            db.execute("insert into tb_detail_kembali values('"+id_pinjam+"','"+id_buku+"','"+tipe_denda+"','"+denda+"')");
            if (!isset_kembali(id_pinjam))
            {
                DateTime dt = DateTime.Today;
                string tgl = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
                db.execute("insert into tb_kembali values('" + id_pinjam + "','" + id_pegawai + "','" + tgl + "')");
            }
        }

        public bool isset_kembali(string id_pinjam)
        {
            var result = db.get_data("select count(*) from tb_kembali where id_pinjam='" + id_pinjam + "'");
            if (result.Rows[0][0].ToString() != "0")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void add_denda(string id_pinjam, string id_buku, string denda)
        {
            db.execute("insert into tb_denda values('" + id_pinjam + "','" + id_buku + "','hilang','" + denda + "')");
        }
    }
}
