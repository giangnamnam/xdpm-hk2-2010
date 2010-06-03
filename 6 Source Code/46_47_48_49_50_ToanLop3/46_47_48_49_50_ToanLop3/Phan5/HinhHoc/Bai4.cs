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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void Bai4_Load(object sender, EventArgs e)
        {
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Text = "36";
            label9.Text = "36";
            label10.Text = "36";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "36")
            {
                label8.Text = "Đúng";
            }
            else
            {
                label8.Text = "Sai";
            }

            if (textBox2.Text == "36")
            {
                label9.Text = "Đúng";
            }
            else
            {
                label9.Text = "Sai";
            }

            if (textBox3.Text == "36")
            {
                label10.Text = "Đúng";
            }
            else
            {
                label10.Text = "Sai";
            }
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
