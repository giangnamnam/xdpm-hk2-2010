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
    public partial class CacDaiLuong : Form
    {
        public CacDaiLuong()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai1Dapan.Text = "B";
            bai2dapana.Text = "300";
            bai2dapanb.Text = "700";
            bai2dapanc.Text = "400";
            bai3dapan.Text = "25";
            bai4dapan.Text = "1300";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radio_Bai1B.Checked)
            {
                Bai1Dapan.Text = "Đúng";
            }
            else
            {
                Bai1Dapan.Text = "Sai";
            }

            if (bai2a.Text == "300")
            {
                bai2dapana.Text = "Đ";
            }
            else
            {
                bai2dapana.Text = "S";
            }

            if (bai2b.Text == "700")
            {
                bai2dapanb.Text = "Đ";
            }
            else
            {
                bai2dapanb.Text = "S";
            }

            if (bai2c.Text == "400")
            {
                bai2dapanc.Text = "Đ";
            }
            else
            {
                bai2dapanc.Text = "S";
            }

            if (bai3dapan.Text == "25")
            {
                bai3dapan.Text = "Đúng";
            }
            else
            {
                bai3dapan.Text = "Sai";
            }

            if(bai4dapan.Text == "1300")
            {
                bai4dapan.Text = "Đúng";
            }
            else
            {
                bai4dapan.Text = "Sai";
            }

        }

        private void CacDaiLuong_Load(object sender, EventArgs e)
        {
            Bai1Dapan.Text = "";
            bai2dapana.Text = "";
            bai2dapanb.Text = "";
            bai2dapanc.Text = "";
            bai3dapan.Text = "";
            bai4dapan.Text = "";
        }
    }
}
