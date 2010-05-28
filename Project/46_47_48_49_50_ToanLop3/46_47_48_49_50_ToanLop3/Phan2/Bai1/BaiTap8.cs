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
    public partial class BaiTap8 : Form
    {
        public BaiTap8()
        {
            InitializeComponent();
        }
        #region Cau 1
        private void btnDaLamXong1_Click(object sender, EventArgs e)
        {
            lblError.Visible = true;
            lblError.Text = "Lỗi ở:";
            btnLamLai1.Visible = false;
            if (txt1.Text != " 21")
            {
                lblError.Text += " 7 x 3 ;";
            }
            if (txt2.Text != "35")
            {
                lblError.Text += "7 x 5 ;";
            }
            if (txt3.Text != "49")
            {
                lblError.Text += " 7 x 7 ;";
            }
            if (txt4.Text != "56")
            {
                lblError.Text += " 7 x 8 ;";
            }
            if (txt5.Text != "42")
            {
                lblError.Text += " 7 x 6 ;";
            }
            if (txt6.Text != "28")
            {
                lblError.Text += "7 x 4 ;";
            }
            if (txt7.Text != "14")
            {
                lblError.Text += " 7 x 2 ;";
            }
            if (txt8.Text != "70")
            {
                lblError.Text += " 7 x 10 ;";
            }
            if (txt9.Text != "63")
            {
                lblError.Text += " 7 x 9 ;";
            }
            if (txt10.Text != "7")
            {
                lblError.Text += " 7 x 1 ;";
            }
            if (txt11.Text != "0")
            {
                lblError.Text += " 0 x 7 ;";
            }
            if (txt12.Text != "0")
            {
                lblError.Text += " 7 x 0 ;";
            }
            else
                if (txt1.Text == "21" &&
            txt2.Text == "35" &&
            txt3.Text == "49" &&
            txt4.Text == "56" &&
            txt5.Text == "42" &&
            txt6.Text == "28" &&
            txt7.Text == "14" &&
            txt8.Text == "70" &&
            txt9.Text == "63" &&
            txt10.Text == "7" &&
            txt11.Text == "0" &&
            txt12.Text == "0")
                {
                    lblError.Text = "Bạn Đã Làm Đúng !!!";
                    btnLamLai1.Visible = true;
                }
            lblError.Text = lblError.Text.TrimEnd(';');
        }

        private void btnLamLai1_Click(object sender, EventArgs e)
        {
            btnDaLamXong1.Visible = true;
            btnLamLai1.Visible = false;
            lblError.Visible = false;
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
            txt7.Text = "";
            txt8.Text = "";
            txt9.Text = "";
            txt10.Text = "";
            txt11.Text = "";
            txt12.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnDaLamXong1.Visible = false;
            btnLamLai1.Visible = true;
            lblError.Visible = false;
            txt1.Text = "21";
            txt2.Text = "35";
            txt3.Text = "49";
            txt4.Text = "56";
            txt5.Text = "42";
            txt6.Text = "28";
            txt7.Text = "14";
            txt8.Text = "70";
            txt9.Text = "63";
            txt10.Text = "7";
            txt11.Text = "0";
            txt12.Text = "0";
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region  Bai 2
        private void btnDaLamBt2_Click(object sender, EventArgs e)
        {
            lblBt2.Visible = true;
            btnLamLai1.Visible = false;
            if (chk28.Checked == true && chk24.Checked == false && chk35.Checked == false && chk42.Checked == false)
            {
                lblBt2.Text = "Bạn Đã Chọn Đúng !!";
                btnLamLaiBt2.Visible = true;
            }
            else
            {
                lblBt2.Text = "Bạn Đã Chọn Sai !!! Hãy Chọn Lại ";
            }
        }

        private void btnLamLaiBt2_Click(object sender, EventArgs e)
        {
            btnDaLamBt2.Visible = true;
            btnLamLaiBt2.Visible = false;
            lblBt2.Visible = false;
            chk24.Checked = false;
            chk28.Checked = false;
            chk35.Checked = false;
            chk42.Checked = false;
        }

        private void llbKiemTraBt3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnDaLamBt2.Visible = false;
            btnLamLaiBt2.Visible = true;
            lblBt2.Visible = false;
            chk28.Checked = true;
            chk24.Checked = false;
            chk35.Checked = false;
            chk42.Checked = false;
        }
       
        #endregion
        #region Bai 3
        private void btnDalambt3_Click(object sender, EventArgs e)
        {
            lblbt3.Visible = true;
            btnLamLaibt3.Visible = false;
            lblbt3.Text = "Lỗi ở : ";
            if (txt28.Text != "28")
            {
                lblbt3.Text += "Ô thứ 4 ;";
            }
            if (txt35.Text != "35")
            {
                lblbt3.Text += "Ô thứ 5 ;";
            }
            if (txt48.Text != "48")
            {
                lblbt3.Text += "Ô thứ 7 ;";
            }
            if (txt56.Text != "56")
            {
                lblbt3.Text += "Ô thứ 8 ;";
            }
            if (txt70.Text != "70")
            {
                lblbt3.Text += "Ô thứ 10;";
            }
            else
                if (txt28.Text == "28" &&
                    txt35.Text == "35" &&
                    txt48.Text == "48" &&
                    txt56.Text == "56" &&
                    txt70.Text == "70")
                {
                    btnLamLaibt3.Visible = true;
                    lblbt3.Text = "Chúc Mừng !! Bạn Đã Làm Đúng !!";
                }
            lblbt3.Text = lblbt3.Text.TrimEnd(';');
        }

        private void btnLamLaibt3_Click(object sender, EventArgs e)
        {
            btnDalambt3.Visible = true;
            btnLamLaibt3.Visible = false;
            lblbt3.Visible = false;
            txt28.Text = "";
            txt35.Text = "";
            txt48.Text = "";
            txt56.Text = "";
            txt70.Text = "";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnDalambt3.Visible = false;
            btnLamLaibt3.Visible = true;
            lblbt3.Visible = false;
            txt28.Text = "28";
            txt35.Text = "35";
            txt48.Text = "48";
            txt56.Text = "56";
            txt70.Text = "70";
        }
        #endregion

        private void llbThucHanh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LuyenTap.LuyenTapBT8 frm = new LuyenTap.LuyenTapBT8();
            frm.ShowDialog();
        }
       
       
    }
}
