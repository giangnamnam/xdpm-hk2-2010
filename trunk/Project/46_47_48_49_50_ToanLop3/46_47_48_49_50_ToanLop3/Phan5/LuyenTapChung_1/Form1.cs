using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan5.LuyenTapChung1
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "76245")
            {
                lbl1.Text = "Đúng";
            }
            else
            {
                lbl1.Text = "Sai";
            }
            if ((textBox2.Text == "51807"))
            {
                lbl2.Text = "Đúng";
            }
            else
            {
                lbl2.Text = "Sai";
            }
            if ((textBox3.Text == "90900"))
            {
                lbl3.Text = "Đúng";
            }
            else
            {
                lbl3.Text = "Sai";
            }
            if ((textBox4.Text == "22002"))
            {
                lbl4.Text = "Đúng";
            }
            else
            {
                lbl4.Text = "Sai";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
            lbl1.Text = lbl2.Text = lbl3.Text = lbl4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbl1.Text = "76245";
            lbl2.Text = "51807";
            lbl3.Text = "90900";
            lbl4.Text = "22002";
        }

        private void Bai01_Load(object sender, EventArgs e)
        {

        }

        
    }
}
