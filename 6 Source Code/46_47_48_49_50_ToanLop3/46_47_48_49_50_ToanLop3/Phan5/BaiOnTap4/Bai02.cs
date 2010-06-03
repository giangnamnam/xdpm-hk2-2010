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
    public partial class Bai02 : Form
    {
        public Bai02()
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
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = "";
            label2.Text = label3.Text = label8.Text = label9.Text = label12.Text = label13.Text = label16.Text = label17.Text = "";

        }

        private void Bai02_Load(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = "";
            label2.Text = label3.Text = label8.Text = label9.Text = label12.Text = label13.Text = label16.Text = label17.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "7352") || (textBox1.Text == "7 352"))
            {
                label2.Text = "Đúng";
                label2.BackColor = Color.FromArgb(0, 0, 255);
            }
            else
            {
                label2.Text = "Sai";
                label2.BackColor = Color.FromArgb(0, 0, 255);
            }
            if ((textBox2.Text == "6294") || (textBox2.Text == "6 294"))
            {
                label3.Text = "Đúng";
                label3.BackColor = Color.FromArgb(0, 0, 255);
            }
            else
            {
                label3.Text = "Sai";
                label3.BackColor = Color.FromArgb(0, 0, 255);
            }
            if ((textBox3.Text == "39011") || (textBox3.Text == "39 011"))
            {
                label9.Text = "Đúng";
                label9.BackColor = Color.FromArgb(0, 0, 255);
            }
            else
            {
                label9.Text = "Sai";
                label9.BackColor = Color.FromArgb(0, 0, 255);
            }
            if ((textBox4.Text == "26097") || (textBox4.Text == "26 097"))
            {
                label8.Text = "Đúng";
                label8.BackColor = Color.FromArgb(0, 0, 255);
            }
            else
            {
                label8.Text = "Sai";
                label8.BackColor = Color.FromArgb(0, 0, 255);
            }
            if ((textBox5.Text == "14432") || (textBox5.Text == "14 432"))
            {
                label13.Text = "Đúng";
                label13.BackColor = Color.FromArgb(0, 0, 255);
            }
            else
            {
                label13.Text = "Sai";
                label13.BackColor = Color.FromArgb(0, 0, 255);
            }
            if ((textBox6.Text == "30235") || (textBox6.Text == "30 235"))
            {
                label12.Text = "Đúng";
                label12.BackColor = Color.FromArgb(0, 0, 255);
            }
            else
            {
                label12.Text = "Sai";
                label12.BackColor = Color.FromArgb(0, 0, 255);
            }
            if ((textBox7.Text == "5724") || (textBox7.Text == "5 724"))
            {
                label17.Text = "Đúng";
                label17.BackColor = Color.FromArgb(0, 0, 255);
            }
            else
            {
                label17.Text = "Sai";
                label17.BackColor = Color.FromArgb(0, 0, 255);
            }
            if ((textBox8.Text == "1201") || (textBox1.Text == "1 201"))
            {
                label16.Text = "Đúng";
                label16.BackColor = Color.FromArgb(0, 0, 255);
            }
            else
            {
                label16.Text = "Sai";
                label16.BackColor = Color.FromArgb(0, 0, 255);
            }
        }

    }
}
