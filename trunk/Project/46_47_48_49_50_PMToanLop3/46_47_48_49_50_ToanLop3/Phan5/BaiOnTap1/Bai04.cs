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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((textBox1.Text=="2020")||(textBox1.Text=="2 020"))
            {
                label3.Text="Đúng";
            }
            else
            
           {
               label3.Text = "Sai";
            }
            if ((textBox2.Text == "2025") || (textBox2.Text == "2 025"))
            {
                label4.Text = "Đúng";
            }
            else
            {
                label4.Text = "Sai";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = "";
            label3.Text = label4.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((textBox3.Text == "14600") || (textBox3.Text == "14 600"))
            {
                label5.Text = "Đúng";
            }
            else
            {
                label5.Text = "Sai";
            }
            if ((textBox4.Text == "14 700") || (textBox4.Text == "14700"))
            {
                label6.Text = "Đúng";
            }
            else
            {
                label6.Text = "Sai";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox4.Text = "";
            label5.Text = label6.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if ((textBox5.Text == "68030") || (textBox5.Text == "68 030"))
            {
                label8.Text = "Đúng";
            }
            else
            {
                label8.Text = "Sai";
            }
            if ((textBox6.Text == "68040") || (textBox6.Text == "68 040"))
            {
                label9.Text = "Đúng";
            }
            else
            {
                label9.Text = "Sai";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox5.Text = textBox6.Text = "";
            label9.Text = label8.Text = "";
        }
    }
}
