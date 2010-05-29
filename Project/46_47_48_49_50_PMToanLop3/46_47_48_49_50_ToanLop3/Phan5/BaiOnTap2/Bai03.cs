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
    public partial class Bai03 : Form
    {
        public Bai03()
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
            label3.Text = "Số bé nhất";
            label4.Text = "Số bé thứ hai";
            label5.Text = "Số bé thứ ba";
            label6.Text = "Số lớn nhất";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "59825") || (textBox1.Text == "59 825"))
            {
                label3.Text = "Đúng";
            }
            else
                label3.Text = "Sai";
            if ((textBox2.Text == "67925") || (textBox2.Text == "67 925"))
            {
                label4.Text = "Đúng";
            }
            else
                label4.Text = "Sai";
            if ((textBox3.Text == "69725") || (textBox3.Text == "69 725"))
            {
                label5.Text = "Đúng";
            }
            else
                label5.Text = "Sai";
            if ((textBox4.Text == "70100") || (textBox4.Text == "70 100"))
            {
                label6.Text = "Đúng";
            }
            else
                label6.Text = "Sai";
        }
        
        
    }
}
