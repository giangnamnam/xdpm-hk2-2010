using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan5.Bai1
{
    public partial class Bai03b : Form
    {
        public Bai03b()
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
            label10.Text = label11.Text = label12.Text = label9.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "9999")
            {
                label9.Text = "Đúng";
            }
            else
            {
                label9.Text = "Sai";
            }
            if ((textBox2.Text == "9009") )
            {
                label10.Text = "Đúng";
            }
            else
            {
                label10.Text = "Sai";
            }
            if ((textBox3.Text == "7590"))
            {
                label11.Text = "Đúng";
            }
            else
            {
                label11.Text = "Sai";
            }
            if ((textBox4.Text == "9090"))
            {
                label12.Text = "Đúng";
            }
            else
            {
                label12.Text = "Sai";
            }
        }


    }
}
