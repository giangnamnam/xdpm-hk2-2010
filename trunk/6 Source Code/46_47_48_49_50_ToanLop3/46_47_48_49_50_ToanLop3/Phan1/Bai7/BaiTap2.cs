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
    public partial class BaiTap2 : UserControl
    {
        public BaiTap2()
        {
            InitializeComponent();
        }

        private void btHoanThanh_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "200")
            {
                textBox7.Text = "Đ";
            }
            else
            {
                textBox7.Text = "S";
            }
            if (textBox2.Text == "200")
            {
                textBox8.Text = "Đ";
            }
            else
            {
                textBox8.Text = "S";
            }
            if (textBox3.Text == "100")
            {
                textBox9.Text = "Đ";
            }
            else
            {
                textBox9.Text = "S";
            }
            if (textBox4.Text == "400")
            {
                textBox10.Text = "Đ";
            }
            else
            {
                textBox10.Text = "S";
            }
            if (textBox5.Text == "100")
            {
                textBox11.Text = "Đ";
            }
            else
            {
                textBox11.Text = "S";
            }
            if (textBox6.Text == "200")
            {
                textBox12.Text = "Đ";
            }
            else
            {
                textBox12.Text = "S";
            }
        }

        private void tbkiemtra_Click(object sender, EventArgs e)
        {
            textBox7.Text = "200";
            textBox8.Text = "200";
            textBox9.Text = "100";
            textBox10.Text = "400";
            textBox11.Text = "100";
            textBox12.Text = "200";
        }

        private void btLamlai_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
