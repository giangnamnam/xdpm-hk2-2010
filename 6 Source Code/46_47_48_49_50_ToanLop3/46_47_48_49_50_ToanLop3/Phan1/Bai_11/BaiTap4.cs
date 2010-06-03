using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan1.Bai_11
{
    public partial class BaiTap4 : UserControl
    {
        public BaiTap4()
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
            tb9.Text = "";
            tb10.Text = "";
            tb11.Text = "";
            tb12.Text = "";
        }

        private void btXemKetQua_Click(object sender, EventArgs e)
        {
            
            tb2.Text = "Năm giờ hai mươi phút";            
            tb4.Text = "Chín giờ mười lăm phút";           
            tb6.Text = "Mười hai giờ ba mưoi lăm phút";           
            tb8.Text = "Mười bốn giờ lẻ năm phút";
            tb10.Text = "Mười bảy giờ ba mươi phút";
            tb12.Text = "Hai mươi mốt giờ năm lăm phút";
        }

        private void tbHoanThanh_Click(object sender, EventArgs e)
        {
            if (tb1.Text == "Năm giờ hai mươi phút")
            {
                tb2.Text = "Đ";
            }
            else
            {
                tb2.Text = "S";
            }
            if (tb3.Text == "Chín giờ mười lăm phút")
            {
                tb4.Text = "Đ";
            }
            else
            {
                tb4.Text = "S";
            }
            if (tb5.Text == "Mười hai giờ ba mưoi lăm phút")
            {
                tb6.Text = "Đ";
            }
            else
            {
                tb6.Text = "S";
            }
            if (tb7.Text == "Mười bốn giờ lẻ năm phút")
            {
                tb8.Text = "Đ";
            }
            else
            {
                tb8.Text = "S";
            }
            if (tb9.Text == "Mười bảy giờ ba mươi phút")
            {
                tb10.Text = "Đ";
            }
            else
            {
                tb10.Text = "S";
            }
            if (tb11.Text == "Hai mươi mốt giờ năm lăm phút")
            {
                tb12.Text = "Đ";
            }
            else
            {
                tb12.Text = "S";
            }
        }
    }
}
