using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan1.Bai_10
{
    public partial class BaiTap1 : UserControl
    {
        public BaiTap1()
        {
            InitializeComponent();
        }

        private void tbHoanThanh_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "320")
            {
                textBox2.Text = "Đ";
            }
            else
            {
                textBox2.Text = "S";
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "320";
        }

        private void BaiTap1_Load(object sender, EventArgs e)
        {

        }
    }
}
