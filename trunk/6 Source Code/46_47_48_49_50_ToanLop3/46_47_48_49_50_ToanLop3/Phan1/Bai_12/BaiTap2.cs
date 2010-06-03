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
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void btXemKetQua_Click(object sender, EventArgs e)
        {
            textBox1.Text = "C";
            textBox2.Text = "A";
            textBox3.Text = "B";
        }

        private void tbHoanThanh_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "C")
            {
                textBox1.Text = "Đ";
            }
            else
            {
                textBox1.Text = "S";
            }
            if (textBox5.Text == "A")
            {
                textBox2.Text = "Đ";
            }
            else
            {
                textBox2.Text = "S";
            }
            if (textBox6.Text == "B")
            {
                textBox3.Text = "Đ";
            }
            else
            {
                textBox3.Text = "S";
            }
        }
    }
}
