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

        private void Bai01_Load(object sender, EventArgs e)
        {
            label3.Text = label4.Text = label5.Text = label12.Text = label13.Text = label14.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "<")
            {
                label3.Text = "Đúng";

            }
            else
            {
                label3.Text = "Sai";
            }
            if (textBox2.Text == ">")
            {
                label4.Text = "Đúng";

            }
            else
            {
                label4.Text = "Sai";
            }
            if (textBox3.Text == "=")
            {
                label5.Text = "Đúng";

            }
            else
            {
                label5.Text = "Sai";
            }
            if (textBox4.Text == ">")
            {
                label12.Text = "Đúng";

            }
            else
            {
                label12.Text = "Sai";
            }
            if (textBox5.Text == "<")
            {
                label13.Text = "Đúng";

            }
            else
            {
                label13.Text = "Sai";
            }
            if (textBox6.Text == "=")
            {
                label14.Text = "Đúng";

            }
            else
            {
                label14.Text = "Sai";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = label4.Text = label5.Text = label12.Text = label13.Text = label14.Text = "";
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
