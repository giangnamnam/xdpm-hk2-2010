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
    public partial class LuyenTapBT5 : Form
    {
        public LuyenTapBT5()
        {
            InitializeComponent();
        }
        #region Bai 1
        private void btnDaLamBt1_Click(object sender, EventArgs e)
        {
            lblBt1.Text = "Lổi ở : ";
            lblBt1.Visible = true; btnLamLaiBt1.Visible = false;
            if (txt1.Text != "6")
            {
                lblBt1.Text += " câu a thứ nhất  ;";
            }
            if (txt2.Text != "9")
            {
                lblBt1.Text += " câu a thứ 2 ;";
            }
            if (txt3.Text != "5")
            {
                lblBt1.Text += " câu c thứ 3;";
            }
            if (txt4.Text != "4")
            {
                lblBt1.Text += " câu b thứ nhất ;";
            }
            if (txt5.Text != "5")
            {
                lblBt1.Text += " câu b thứ 2 ;";
            }
            if (txt6.Text != "9")
            {
                lblBt1.Text += " câu b thứ 3 ;";
            }
            else if (txt1.Text == "6" &&
            txt2.Text == "9" &&
            txt3.Text == "5" &&
            txt4.Text == "4" &&
            txt5.Text == "5" &&
            txt6.Text == "9")
            {
                btnLamLaiBt1.Visible = true;
                lblBt1.Visible = true;
                lblBt1.Text = "Chúc Mừng Bạn!!Bạn Đã Làm Đúng";
            }
            lblBt1.Text = lblBt1.Text.TrimEnd(';');
        }

        private void llbKiemTraBt3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblBt1.Visible = false;
            btnDaLamBt1.Visible = false;
            btnLamLaiBt1.Visible = true;
            txt1.Text = "6";
            txt2.Text = "9";
            txt3.Text = "5";
            txt4.Text = "4";
            txt5.Text = "5";
            txt6.Text = "9";
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
            txt5.Text = "";
            txt6.Text = "";
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

        private void btnDaLamBt2_Click(object sender, EventArgs e)
        {

            lblError2.Text = "";
            lblError2.Visible = true; btnLamLaibt2.Visible = false;
            if (txtbt2.Text != "5")
            {
                lblError2.Text += "Sai";
            }
            else
            {
                lblError2.Text += "Đúng";
                btnLamLaibt2.Visible = true;
            }
        }

        private void btnLamLaibt2_Click(object sender, EventArgs e)
        {
            richTextBox2.Visible = false;
            btnDaLamBt2.Visible = true;
            btnLamLaibt2.Visible = false;
            txtbt2.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            richTextBox2.Visible = true;
            btnLamLaibt2.Visible = true;
            btnDaLamBt2.Visible = false;
            txtbt2.Text = "5";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LuyenTapBT5_tieptheo_ frm = new LuyenTapBT5_tieptheo_();
            frm.ShowDialog();
        }
    }
}
