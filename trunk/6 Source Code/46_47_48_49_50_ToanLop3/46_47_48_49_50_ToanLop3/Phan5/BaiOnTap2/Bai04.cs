using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan5.BaiOnTap2
{
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
            label3.Text = "Số lớn nhất";
            label4.Text = "Số lớn thứ hai";
            label5.Text = "Số lớn thứ ba";
            label6.Text = "Số bé nhất";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "96400") || (textBox1.Text == "96 400"))
            {
                label3.Text = "Đúng";
            }
            else
                label3.Text = "Sai";
            if ((textBox2.Text == "94600") || (textBox2.Text == "94 600"))
            {
                label4.Text = "Đúng";
            }
            else
                label4.Text = "Sai";
            if ((textBox3.Text == "64900") || (textBox3.Text == "64 900"))
            {
                label5.Text = "Đúng";
            }
            else
                label5.Text = "Sai";
            if ((textBox4.Text == "46900") || (textBox4.Text == "46 900"))
            {
                label6.Text = "Đúng";
            }
            else
                label6.Text = "Sai";
        }

    }
}
