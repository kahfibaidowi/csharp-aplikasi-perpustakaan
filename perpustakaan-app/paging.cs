using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace perpustakaan_app
{
    class paging
    {
        private int jml_data;
        public int jml_halaman;
        public int num_filter;

        private Button btn_prev;
        private Button btn_next;
        private TextBox txt_page;
        private Label label_page;

        public void set_datalength(string str_value)
        {
            reset_page();
            num_filter = Convert.ToInt32(str_value);
        }

        public void set_toolpage(TextBox value)
        {
            txt_page = value;
        }

        public void set_btnprev(Button value)
        {
            btn_prev = value;
        }

        public void set_btnnext(Button value)
        {
            btn_next = value;
        }

        public void set_labelpage(Label value)
        {
            label_page = value;
        }

        public bool isset_hal()
        {
            if (txt_page.Text == "" || Convert.ToInt32(txt_page.Text) > jml_halaman || txt_page.Text == "0")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void all_data(string jml)
        {
            jml_data = Convert.ToInt32(jml);
            jml_halaman = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(jml_data) / Convert.ToDouble(num_filter)));

            if_hal_single();

            label_page.Text = "/ " + jml_halaman.ToString();
        }

        public void if_hal_single()
        {
            if (jml_halaman <= 1)
            {
                jml_halaman = 1;
                btn_prev.Enabled = false;
                btn_next.Enabled = false;
            }
        }

        public void prev()
        {
            btn_next.Enabled = true;
            txt_page.Text = (Convert.ToInt32(txt_page.Text) - 1).ToString();

            if (Convert.ToInt32(txt_page.Text) == 1)
            {
                btn_prev.Enabled = false;
                btn_next.Focus();
            }
            else
            {
                btn_prev.Enabled = true;
            }
        }

        public void next()
        {
            btn_prev.Enabled = true;
            txt_page.Text = (Convert.ToInt32(txt_page.Text) + 1).ToString();

            if (Convert.ToInt32(txt_page.Text) == jml_halaman)
            {
                btn_next.Enabled = false;
                btn_prev.Focus();
            }
            else
            {
                btn_next.Enabled = true;
            }
        }

        public void btn_reset()
        {
            btn_prev.Enabled = true;
            btn_next.Enabled = true;
            if (txt_page.Text == "1")
            {
                btn_prev.Enabled = false;
            }
            if (txt_page.Text == jml_halaman.ToString())
            {
                btn_next.Enabled = false;
            }
        }

        public void reset_page()
        {
            txt_page.Text = "1";
        }
    }
}
