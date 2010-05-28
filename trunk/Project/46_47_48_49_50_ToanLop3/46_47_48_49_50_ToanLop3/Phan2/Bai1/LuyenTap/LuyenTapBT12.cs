using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan2.Bai1.LuyenTap
{
    public partial class LuyenTapBT12 : Form
    {
        public LuyenTapBT12()
        {
            InitializeComponent();
        }
        #region Bai 1
        private void btnDung1_Click(object sender, EventArgs e)
        {
            lblError2c.Visible = true;
            if (txt2c.Text != "35")
            {
                lblError2c.Text = "Sai";
            }
            else
            {
                lblError2c.Text = "Đúng";
            }
        }

        private void btnDung1b_Click(object sender, EventArgs e)
        {
            lblError2d.Visible = true;
            if (txt2d.Text != "18")
            {
                lblError2d.Text = "Sai";
            }
            else
            {
                lblError2d.Text = "Đúng";
            }
        }

        private void btnLamLai1_Click(object sender, EventArgs e)
        {
            lblError2c.Visible = false;
            lblError2d.Visible = false;
            dapan3.Visible = false;
            dapan4.Visible = false;
            txt2c.Text = "";
            txt2d.Text = "";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblError2c.Visible = false;
            lblError2d.Visible = false;
            dapan3.Visible = true;
            dapan4.Visible = true;
            txt2c.Text = "35";
            txt2d.Text = "18";
        }
        #endregion

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        #region Bai 2
        private void btnDaLam2_Click(object sender, EventArgs e)
        {
            lblError.Visible = true;
            if (txt21.Text == "70" &&
                txt22.Text == "104" &&
                txt23.Text == "33" &&
                txt24.Text == "20")
            {
                lblError.Text = "Chúc Mừng!!Bạn Thật Khá!!!";
            }
            else
            {
                lblError.Text = "Sai!!!Hãy Bấm Kết Quả Để So Sánh";
            }
        }

        private void btnKetQua2_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            lblError.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            lblError.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblBt3.Visible = true;
            if (chk1.Checked == false &&
                chk2.Checked == true &&
                chk3.Checked == false &&
                chk4.Checked == false)
            {
                lblBt3.Text = "Bạn Rất Khá!!!";
            }
            else
            {
                lblBt3.Text = "Sai Rồi Bấm Kết Quả Đi Bạn!!!";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnLamLai3.Visible = true;
            chk1.Checked = false;
            chk2.Checked = true;
            chk3.Checked = false;
            chk4.Checked = false;
            lblBt3.Visible = false;
        }

        private void btnLamLai3_Click(object sender, EventArgs e)
        {
            btnLamLai3.Visible = false;
            chk1.Checked = false;
            chk2.Checked = false;
            chk3.Checked = false;
            chk4.Checked = false;
            lblBt3.Visible = false;
        }

      
        
        
    }
}
