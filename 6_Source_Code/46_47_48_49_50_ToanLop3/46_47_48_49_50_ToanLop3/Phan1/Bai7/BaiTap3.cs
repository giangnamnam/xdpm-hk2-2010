using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan1.Bai7
{
    public partial class BaiTap3 : UserControl
    {
        public BaiTap3()
        {
            InitializeComponent();
        }

        private void btHoanThanh_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "6")
            {
                textBox2.Text = "Đ";
            }
            else
            {
                textBox2.Text = "S";
            }
        }

        private void tbkiemtra_Click(object sender, EventArgs e)
        {
            textBox2.Text = "6";
        }

        private void btLamlai_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
