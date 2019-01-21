using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace perpustakaan_app
{
    class db
    {
        private static string koneksi_str = "server=localhost;user=root;database=db_perpus;password=;Convert Zero Datetime=True;";
        public readonly static MySqlConnection koneksi = new MySqlConnection(koneksi_str);

        public static MySqlDataReader execute(string command)
        {
            try
            {
                koneksi.Open();
                MySqlCommand cmd = new MySqlCommand(command, koneksi);
                return cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return null;
            }
            finally
            {
                koneksi.Close();
            }
        }

        public static DataTable get_data(string command)
        {
            try
            {
                koneksi.Open();
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand(command, koneksi);
                MySqlDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);

                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return null;
            }
            finally
            {
                koneksi.Close();
            }
        }
    }
}
