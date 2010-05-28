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
    public partial class Bài_2 : Form
    {
        public Bài_2()
        {
            InitializeComponent();
        }

        private void Bài_2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void btLamXong_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Text == "năm mươi bốn nghìn một trăm bảy mươi lăm")
            {
                label9.Text = "Đúng";
            }
            else
            {
                label9.Text = "Sai";
            }
            if (textBox3.Text == "Chín mươi nghìn sáu trăm ba mươi mốt")
            {
                label10.Text = "Đúng";
            }
            else
            {
                label10.Text = "Sai";
            }
            if (textBox4.Text == "mười bốn nghìn không trăm ba mươi bốn")
            {
                label11.Text = "Đúng";
            }
            else
            {
                label11.Text = "Sai";
            }
            if (textBox5.Text == "tám nghìn không trăm sáu mươi sáu")
            {
                label12.Text = "Đúng";
            }
            else
            {
                label12.Text = "Sai";
            }
        }

        private void btLamLai_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";
            label10.Text = label11.Text = label12.Text = label9.Text = "     ";
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
