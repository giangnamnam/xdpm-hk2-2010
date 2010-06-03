using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan1.Bai_12
{
    public partial class BaiTap3 : UserControl
    {
        public BaiTap3()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btLamLai_Click(object sender, EventArgs e)
        {
            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
            tb4.Text = "";
            tb5.Text = "";
            tb6.Text = "";
            tb7.Text = "";
            tb8.Text = "";
        }

        private void btXemKetQua_Click(object sender, EventArgs e)
        {
            tb1.Text = "D";
            tb2.Text = "C";
            tb3.Text = "B";
            tb4.Text = "A";
        }

        private void tbHoanThanh_Click(object sender, EventArgs e)
        {
            if (tb5.Text == "D")
            {
                tb1.Text = "Đ";
            }
            else
            {
                tb1.Text = "S";
            }
            if (tb6.Text == "C")
            {
                tb2.Text = "Đ";
            }
            else
            {
                tb2.Text = "S";
            }
            if (tb7.Text == "B")
            {
                tb3.Text = "Đ";
            }
            else
            {
                tb3.Text = "S";
            }
            if (tb8.Text == "A")
            {
                tb4.Text = "Đ";
            }
            else
            {
                tb4.Text = "S";
            }
        }
    }
}
