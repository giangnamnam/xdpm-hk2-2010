using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan5.HinhHoc
{
    public partial class OnTapVeGiaToan : Form
    {
        public OnTapVeGiaToan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Số dân của xã năm ngoái là \n  5236 + 87 = 5323 (người)\nSố dân năm nay của xã là\n   5323 + 75 =  5398 (người)", "Lời giải");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Số áo thun còn lại trong cửa hàng là\n     1245 : 3 = 415 (cái)", "Lời giải");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Số cây tổ đã trồng là\n    20500 : 5 = 4100(cây)\nSố cây còn lại phải trồng là\n    20500 - 4100 = 16400(cây)", "Lời giải");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Đ";
            textBox2.Text = "S";
            textBox3.Text = "Đ";
        }
    }
}
