using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace perpustakaan_app
{
    class lib
    {

        public static string ubah_tgl(string tgl)
        {
            if (tgl == "")
            {
                return "1 Januari 2000";
            }
            else
            {
                var data = pisahkan(tgl, "/");

                return data[0] + " " + ubah_bulan(data[1]) + " " + data[2];
            }
        }

        public static string ubah_bulan(string bulan)
        {
            string[] bln = { "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Nopember", "Desember" };
            return bln[Convert.ToInt32(bulan)];
        }

        public static string set_status(string aktif)
        {
            if (aktif == "y")
            {
                return "Aktif";
            }
            else
            {
                return "Tidak Aktif";
            }
        }

        public static string[] pisahkan(string str, string delimiter)
        {
            string[] tokens = str.Split(new[]
            {
                delimiter
            },
            StringSplitOptions.None);

            return tokens;
        }

        public static string md5_hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
    }
}
