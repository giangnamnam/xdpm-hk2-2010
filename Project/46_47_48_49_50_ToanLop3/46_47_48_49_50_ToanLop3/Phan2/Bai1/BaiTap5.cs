using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan2.Bai1
{
    public partial class BaiTap5 : Form
    {
        public BaiTap5()
        {
            InitializeComponent();
        }

        private void BaiTap4_Load(object sender, EventArgs e)
        {

        }
        #region Bai1
        private void btnDaLamBt1_Click(object sender, EventArgs e)
        {
            lblBt1.Text = "Lổi ở : ";
            lblBt1.Visible = true; btnLamLaiBt1.Visible = false;
            if (txt1.Text != "4")
            {
                lblBt1.Text += " câu a  ;";
            }
            if (txt2.Text != "6")
            {
                lblBt1.Text += " câu b ;";
            }
            if (txt3.Text != "7")
            {
                lblBt1.Text += " câu c ;";
            }
            if (txt4.Text != "9")
            {
                lblBt1.Text += " câu d ;";
            }
            else if (txt1.Text == "4" &&
            txt2.Text == "6" &&
            txt3.Text == "7" &&
            txt4.Text == "9")
            {
                btnLamLaiBt1.Visible = true;
                lblBt1.Visible = true;
                lblBt1.Text = "Chúc Mừng Bạn!!Bạn Đã Làm Đúng";
            }
            lblBt1.Text += lblBt1.Text.TrimEnd(';');
        }

        private void llbKiemTraBt3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblBt1.Visible = false;
            btnDaLamBt1.Visible = false;
            btnLamLaiBt1.Visible = true;
            txt1.Text = "4";
            txt2.Text = "6";
            txt3.Text = "7";
            txt4.Text = "9";
        }

        private void btnLamLaiBt1_Click(object sender, EventArgs e)
        {
            lblBt1.Visible = false;
            btnDaLamBt1.Visible = true;
            btnLamLaiBt1.Visible = false;
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
        }

        #endregion
        
        private void btnQuayLaiPhan2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        #region Bai 2
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            richTextBox2.Visible = true;
            btnLamLaibt2.Visible = true;
            btnDaLamBt2.Visible = false;
        }

        private void btnLamLaibt2_Click(object sender, EventArgs e)
        {
            richTextBox2.Visible = false;
            btnDaLamBt2.Visible = true;
            btnLamLaibt2.Visible = false;
        }

        private void btnDaLamBt2_Click(object sender, EventArgs e)
        {

            lblError2.Text = "";
            lblError2.Visible = true; btnLamLaibt2.Visible = false;
            if (txtbt2.Text != "8")
            {
                lblError2.Text += "Sai";
            }
            else
            {
                lblError2.Text += "Đúng";
                btnLamLaibt2.Visible = true;
            }
        }
        #endregion

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Bai1.LuyenTap.LuyenTapBT5 frm = new Bai1.LuyenTap.LuyenTapBT5();
            frm.ShowDialog();
        }
       
    }
}
