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
    public partial class BaiTap1 : UserControl
    {
        public BaiTap1()
        {
            InitializeComponent();
        }

        private void btHoanThanh_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "12")
            {
                textBox13.Text = "Đ";
            }
            else
            {
                textBox13.Text = "S";
            }
            if (textBox2.Text == "10")
            {
                textBox14.Text = "Đ";
            }
            else
            {
                textBox14.Text = "S";
            }
            if (textBox3.Text == "15")
            {
                textBox15.Text = "Đ";
            }
            else 
            {
                textBox15.Text = "S";
            }
            if (textBox4.Text == "8")
            {
                textBox16.Text = "Đ";
            }
            else
            {
                textBox16.Text = "S";
            }
            if (textBox5.Text == "4")
            {
                textBox17.Text = "Đ";
            }
            else
            {
                textBox17.Text = "S";
            }
            if (textBox6.Text == "5")
            {
                textBox18.Text = "Đ";
            }
            else
            {
                textBox18.Text = "S";
            }
            if (textBox7.Text == "5")
            {
                textBox19.Text = "Đ";
            }
            else 
            {
                textBox19.Text = "S"; 
            }
            if (textBox8.Text == "4")
            {
                textBox20.Text = "Đ";
            }
            else
            {
                textBox20.Text = "S";
            }
            if (textBox9.Text == "3")
            {
                textBox21.Text = "Đ";
            }
            else
            {
                textBox21.Text = "S";
            }
            if (textBox10.Text == "2")
            {
                textBox22.Text = "Đ";
            }
            else
            {
                textBox22.Text = "S";
            }
            if (textBox11.Text == "3")
            {
                textBox23.Text = "Đ";
            }
            else
            {
                textBox23.Text = "S";
            }
            if (textBox12.Text == "2")
            {
                textBox24.Text = "Đ";
            }
            else
            {
                textBox24.Text = "S";
            }
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
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            textBox23.Text = "";
            textBox24.Text = "";
        }

        private void tbkiemtra_Click(object sender, EventArgs e)
        {
            textBox13.Text = "12";
            textBox14.Text = "10";
            textBox15.Text = "15";
            textBox16.Text = "8";
            textBox17.Text = "4";
            textBox18.Text = "5";
            textBox19.Text = "5";
            textBox20.Text = "4";
            textBox21.Text = "3";
            textBox22.Text = "2";
            textBox23.Text = "3";
            textBox24.Text = "2";
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
    }
}
