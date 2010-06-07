using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan1.Bai8
{
    public partial class BaiTap4 : UserControl
    {
        public BaiTap4()
        {
            InitializeComponent();
        }

        private void btHoanThanh_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "2")
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
            textBox2.Text = "2";
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
