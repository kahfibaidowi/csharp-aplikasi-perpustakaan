using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace perpustakaan_app.model
{
    class pengembalian
    {
        public string count_search(string k, string q)
        {
            var result = db.get_data("select count(*) from tb_kembali a, tb_member b, tb_pegawai c, tb_pinjam d where d.id_member=b.id_member and d.id_pinjam=a.id_pinjam and a.id_pegawai=c.id_pegawai and a." + k + " like '%" + q + "%'");
            return result.Rows[0][0].ToString();
        }

        public DataTable search_pengembalian(string k, string q, string posisi, string batas)
        {
            var result = db.get_data("select a.id_pinjam, b.id_member, b.nama_lengkap, c.nama_lengkap, a.tgl_kembali from tb_kembali a, tb_member b, tb_pegawai c, tb_pinjam d where d.id_member=b.id_member and d.id_pinjam=a.id_pinjam and a.id_pegawai=c.id_pegawai and a." + k + " like '%" + q + "%' order by a.id_pinjam desc limit " + posisi + "," + batas);
            return result;
        }

        public bool cek_peminjaman(string id_member)
        {
            var result = db.get_data("select count(*) from tb_pinjam a, tb_detail_pinjam b where a.id_pinjam=b.id_pinjam and a.id_member='" + id_member + "' and b.kembali='n'");
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
            db.execute("insert into tb_pinjam values('','" + id_member + "','" + id_pegawai + "','','" + tgl + "')");
        }

        public DataTable get_buku_pinjam(string id)
        {
            var result = db.get_data("select a.id_buku, a.judul, a.pengarang, a.penerbit from tb_buku a, tb_detail_pinjam b where b.id_buku=a.id_buku and b.id_pinjam='" + id + "' and b.kembali='n'");
            return result;
        }

        public DataTable get_cetak_buku_pinjam(string id)
        {
            var result = db.get_data("select a.id_buku, a.judul, b.tgl_pinjam, adddate(b.tgl_pinjam, interval 7 day) as tgl_kembali from tb_buku a, tb_pinjam b, tb_detail_pinjam c where c.id_pinjam=b.id_pinjam and c.id_buku=a.id_buku and c.id_pinjam='"+id+"' and c.kembali='n'");
            return result;
        }

        public DataTable get_cetak_buku_kembali(string id)
        {
            var result = db.get_data("select a.id_buku, a.judul, (select denda from tb_denda b where b.id_buku=a.id_buku and b.id_pinjam=c.id_pinjam) as denda, (select tipe_denda from tb_denda b where b.id_buku=a.id_buku and b.id_pinjam=c.id_pinjam) as tipe_denda from tb_buku a, tb_detail_pinjam c where c.id_buku=a.id_buku and c.id_pinjam='"+id+"' and c.kembali='y'");
            return result;
        }

        public string total_denda(string id)
        {
            var result = db.get_data("select sum(denda) from tb_denda where id_pinjam='" + id + "'");
            return result.Rows[0][0].ToString();
        }

        public string[] get_pinjam_description(string id)
        {
            var result = db.get_data("select a.id_pinjam, b.nama_lengkap, c.nama_lengkap from tb_pinjam a, tb_member b, tb_pegawai c where a.id_member=b.id_member and a.id_pegawai_pinjam=c.id_pegawai and a.id_pinjam='" + id + "'");
            string[] data = {
                        result.Rows[0][0].ToString(),
                        result.Rows[0][1].ToString(),
                        result.Rows[0][2].ToString()
            };

            return data;
        }

        public string[] get_pinjam_description2(string id)
        {
            var result = db.get_data("select a.id_pinjam, b.nama_lengkap, c.nama_lengkap from tb_pinjam a, tb_member b, tb_pegawai c where a.id_member=b.id_member and a.id_pegawai_kembali=c.id_pegawai and a.id_pinjam='" + id + "'");
            string[] data = {
                        result.Rows[0][0].ToString(),
                        result.Rows[0][1].ToString(),
                        result.Rows[0][2].ToString()
            };

            return data;
        }

        public void add_buku_pinjam(string id_pinjam, string id_buku, string kembali)
        {
            db.execute("insert into tb_detail_pinjam values('" + id_pinjam + "','" + id_buku + "','" + kembali + "')");
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

        public void kembalikan_buku(string id_pinjam, string id_buku, string id_pegawai)
        {
            db.execute("update tb_detail_pinjam set kembali='y' where id_pinjam='" + id_pinjam + "' and id_buku='" + id_buku + "'");
            db.execute("update tb_pinjam set id_pegawai_kembali='" + id_pegawai + "' where id_pinjam='" + id_pinjam + "'");
        }

        public void add_denda(string id_pinjam, string id_buku, string denda)
        {
            db.execute("insert into tb_denda values('" + id_pinjam + "','" + id_buku + "','hilang','" + denda + "')");
        }
    }
}
