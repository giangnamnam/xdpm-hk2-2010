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
    public partial class BaiTap1 : UserControl
    {
        public BaiTap1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btHoanThanh_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "147")
            {
                textBox4.Text = "Đ";
            }
            else 
            {
                textBox4.Text = "S";
            }
            if (textBox2.Text == "114")
            {
                textBox5.Text = "Đ";
            }
            else
            {
                textBox5.Text = "S";
            }
            if (textBox3.Text == "30")
            {
                textBox6.Text = "Đ";
            }
            else
            {
                textBox6.Text = "S";
            }
        }

        private void tbkiemtra_Click(object sender, EventArgs e)
        {
            textBox4.Text = "147";
            textBox5.Text = "114";
            textBox6.Text = "30";
        }

        private void btLamlai_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
