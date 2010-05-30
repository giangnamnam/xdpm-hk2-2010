using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan5.BaiOnTap4
{
    public partial class Bai01 : Form
    {
        public Bai01()
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
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox9.Text = textBox10.Text  = "";
            label2.Text = label3.Text = l4.Text = l5.Text = l6.Text = l7.Text = "";

        }

        private void Bai01_Load(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox9.Text = textBox10.Text = "";
            label2.Text = label3.Text = l4.Text = l5.Text = l6.Text = l7.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "20000") || (textBox1.Text == "20 000"))
            {
                label2.Text = "Đúng";
            } 
            else
            {
                label2.Text = "Sai";
            }
            if ((textBox2.Text == "30000") || (textBox2.Text == "30 000"))
            {
                label3.Text = "Đúng";
            }
            else
            {
                label3.Text = "Sai";
            }
            if ((textBox9.Text == "30000") || (textBox9.Text == "30 000"))
            {
                l4.Text = "Đúng";
            }
            else
            {
                l4.Text = "Sai";
            }
            if ((textBox3.Text == "2000") )
            {
                l5.Text = "Đúng";
            }
            else
            {
                l5.Text = "Sai";
            }
            if ((textBox4.Text == "2400") )
            {
                l6.Text = "Đúng";
            }
            else
            {
                l6.Text = "Sai";
            }
            if ((textBox10.Text == "400") )
            {
                l7.Text = "Đúng";
            }
            else
            {
                l7.Text = "Sai";
            }
        }


    }
}
