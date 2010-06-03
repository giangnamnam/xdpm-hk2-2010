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
    public partial class BaiTap2 : Form
    {
        public BaiTap2()
        {
            InitializeComponent();
        }

        private void BaiTap2_Load(object sender, EventArgs e)
        {

        }
        #region bai 2 
        private void btnDaLamXong_Click(object sender, EventArgs e)
        {
            lblError.Text = "Lổi ở : ";
            lblError.Visible = true; btnLamLai.Visible = false;
            if (txt1.Text != "96")
            {
                lblError.Text += " Dòng 1 câu a  ;";
            }
            if (txt2.Text != "66")
            {
                lblError.Text += " Dòng 2 câu a ;";
            }
            if (txt3.Text != "84")
            {
                lblError.Text += "  Dòng 1 câu b ;";
            }
            if (txt4.Text != "39")
            {
                lblError.Text += "  Dòng 2 câu b ;";
            }
            else if ( txt1.Text == "96"&&
            txt2.Text == "66"&&
            txt3.Text == "84"&&
            txt4.Text == "39")  
            {
                btnLamLai.Visible = true;
                lblError.Text = "Chúc Mừng Bạn!!Bạn Đã Làm Đúng";
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            btnDaLamXong.Visible = true;
            btnLamLai.Visible = false;
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblError.Visible = false;
            btnDaLamXong.Visible = false;
            btnLamLai.Visible=true;
            txt1.Text = "96";
            txt2.Text = "66";
            txt3.Text = "84";
            txt4.Text = "39";
        }
        #endregion

        private void btnDaLamBt3_Click(object sender, EventArgs e)
        {
            lblBt3.Visible = true;
            btnLamLaiBt3.Visible = false;
            if (chk48.Checked==true && chk18.Checked == false && chk34.Checked ==false && chk54.Checked == false)
            {
                lblBt3.Text = "Bạn Đã Chọn Đúng !!";
                btnLamLaiBt3.Visible = true;
            }
            else
            {
                lblBt3.Text = "Bạn Đã Chọn Sai !!! Hãy Chọn Lại ";
            }
        }

        private void btnLamLaiBt3_Click(object sender, EventArgs e)
        {
            btnDaLamBt3.Visible = true;
            btnLamLaiBt3.Visible = false;
            lblBt3.Visible = false;
            chk18.Checked = false;
            chk34.Checked = false;
            chk48.Checked = false;
            chk54.Checked = false;
        }

        private void llbKiemTraBt3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnDaLamBt3.Visible = false;
            btnLamLaiBt3.Visible=true;
            lblBt3.Visible = false;
            chk48.Checked = true;
            chk18.Checked = false;
            chk34.Checked = false;
            chk54.Checked = false;
        }

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
        
    }
}
