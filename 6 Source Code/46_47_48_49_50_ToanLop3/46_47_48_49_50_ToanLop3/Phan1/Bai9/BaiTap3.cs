using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan1.Bai9
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
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void btXemKetQua_Click(object sender, EventArgs e)
        {
            textBox2.Text = "6";
            textBox4.Text = "5";
        }

        private void tbHoanThanh_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "6")
            {
                textBox2.Text = "Đ";
            }
            else
            {
                textBox2.Text = "S";
            }
            if (textBox3.Text == "5")
            {
                textBox4.Text = "Đ";
            }
            else
            {
                textBox4.Text = "S";
            }
        }
    }
}
