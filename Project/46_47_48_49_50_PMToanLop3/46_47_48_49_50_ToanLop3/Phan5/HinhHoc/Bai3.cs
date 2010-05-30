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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Green;
            label3.ForeColor = Color.Green;
            label4.ForeColor = Color.Green;

            label2.Text = "6";
            label3.Text = "M";
            label4.Text = "N";
        }

        private void Bai3_Load(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "6")
            {
                label2.ForeColor = Color.Red;
                label2.Text = "Sai";
            }
            else
            {
                label2.ForeColor = Color.Green;
                label2.Text = "Đúng";
            }

            if (textBox2.Text != "M")
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Sai";
            }
            else
            {
                label3.ForeColor = Color.Green;
                label3.Text = "Đúng";
            }

            if (textBox3.Text != "N")
            {
                label4.ForeColor = Color.Red;
                label4.Text = "Sai";
            }
            else
            {
                label4.ForeColor = Color.Green;
                label4.Text = "Đúng";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
