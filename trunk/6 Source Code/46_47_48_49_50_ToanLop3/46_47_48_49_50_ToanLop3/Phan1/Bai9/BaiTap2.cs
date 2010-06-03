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
    public partial class BaiTap2 : UserControl
    {
        public BaiTap2()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btLamLai_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void btXemKetQua_Click(object sender, EventArgs e)
        {
            textBox4.Text = "40";
        }

        private void tbHoanThanh_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "40")
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
