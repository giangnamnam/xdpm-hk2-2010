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
            label4.Text =  label5.Text= "Kết Quả X =";
            textBox1.Text = textBox2.Text = "";
            label4.BackColor = label5.BackColor = Color.FromArgb(192, 255, 255);
        }

        private void Bai03_Load(object sender, EventArgs e)
        {
            label4.Text = label5.Text = "Kết Quả X =";
            textBox1.Text = textBox2.Text = "";
            label4.BackColor = label5.BackColor=Color.FromArgb(192, 255, 255);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="6")
            {
                label4.Text = "Đúng";
                label4.BackColor = Color.FromArgb(0, 255, 0);
            } 
            else
            {
                label4.Text = "Sai";
                label4.BackColor = Color.FromArgb(0, 255, 0);
            }
            if ((textBox2.Text == "1999") || (textBox2.Text == "1 999"))
            {
                label5.Text = "Đúng";
                label5.BackColor = Color.FromArgb(0, 255, 0);
            }
            else
            {
                label5.Text = "Sai";
                label5.BackColor = Color.FromArgb(0, 255, 0);
            }
        }

    }
}
