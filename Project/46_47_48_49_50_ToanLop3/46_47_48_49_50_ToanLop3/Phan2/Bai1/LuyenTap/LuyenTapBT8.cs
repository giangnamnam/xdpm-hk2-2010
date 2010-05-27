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
    public partial class LuyenTapBT8 : Form
    {
        public LuyenTapBT8()
        {
            InitializeComponent();
        }
        #region Bai 1
        private void btnDaLamXong1_Click(object sender, EventArgs e)
        {
            lblError.Visible = true;
            lblError.Text = "Lỗi ở:";
            btnLamLai1.Visible = false;
            if (txt1.Text != " 7")
            {
                lblError.Text += " 7 x 1;";
            }
            if (txt2.Text != "14")
            {
                lblError.Text += "7 x 2 ;";
            }
            if (txt3.Text != "21")
            {
                lblError.Text += " 7 x 3 ;";
            }
            if (txt4.Text != "56")
            {
                lblError.Text += " 7 x 8 ;";
            }
            if (txt5.Text != "63")
            {
                lblError.Text += " 7 x 9 ;";
            }
            if (txt6.Text != "49")
            {
                lblError.Text += "7 x 7 ;";
            }
            if (txt7.Text != "42")
            {
                lblError.Text += " 7 x 6 ;";
            }
            if (txt8.Text != "28")
            {
                lblError.Text += " 7 x 4 ;";
            }
            if (txt9.Text != "0")
            {
                lblError.Text += " 7 x 0 ;";
            }
            if (txt10.Text != "35")
            {
                lblError.Text += " 7 x 5 ;";
            }
            if (txt11.Text != "0")
            {
                lblError.Text += " 0 x 7 ;";
            }
            if (txt12.Text != "70")
            {
                lblError.Text += " 7 x 10 ;";
            }
            else
                if (txt1.Text == "7" &&
            txt2.Text == "14" &&
            txt3.Text == "21" &&
            txt4.Text == "56" &&
            txt5.Text == "63" &&
            txt6.Text == "49" &&
            txt7.Text == "42" &&
            txt8.Text == "28" &&
            txt9.Text == "0" &&
            txt10.Text == "35" &&
            txt11.Text == "0" &&
            txt12.Text == "70")
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
            txt1.Text = "7";
            txt2.Text = "14";
            txt3.Text = "21";
            txt4.Text = "56";
            txt5.Text = "63";
            txt6.Text = "49";
            txt7.Text = "42";
            txt8.Text = "28";
            txt9.Text = "0";
            txt10.Text = "35";
            txt11.Text = "0";
            txt12.Text = "70";
        }
        #endregion

        #region bai 1b
        private void btnDaLam1b_Click(object sender, EventArgs e)
        {
            lblError1b.Visible = true;
            lblError1b.Text = "Lỗi ở:";
            btnLamLai1b.Visible = false;
            if (txt1b.Text != "14")
            {
                lblError1b.Text += " 7 x 2 ;";
            }
            if (txt2b.Text != "14")
            {
                lblError1b.Text += "2 x 7 ;";
            }
            if (txt3b.Text != "28")
            {
                lblError1b.Text += " 4 x 7 ;";
            }
            if (txt4b.Text != "28")
            {
                lblError1b.Text += " 7 x 4 ;";
            }
            if (txt5b.Text != "42")
            {
                lblError1b.Text += " 7 x 6 ;";
            }
            if (txt6b.Text != "42")
            {
                lblError1b.Text += "6 x 7 ;";
            }
            if (txt7b.Text != "21")
            {
                lblError1b.Text += " 3 x 7 ;";
            }
            if (txt8b.Text != "21")
            {
                lblError1b.Text += " 7 x 3 ;";
            }
            else
                if (
            txt1b.Text == "14" &&
            txt2b.Text == "14" &&
            txt3b.Text == "28" &&
            txt4b.Text == "28" &&
            txt5b.Text == "42" &&
            txt6b.Text == "42" &&
            txt7b.Text == "21" &&
            txt8b.Text == "21")
                {
                    lblError1b.Text = "Bạn Đã Làm Đúng !!!";
                    btnLamLai1b.Visible = true;
                }
            lblError1b.Text = lblError1b.Text.TrimEnd(';');
        }

        private void btnLamLai1b_Click(object sender, EventArgs e)
        {
            btnDaLam1b.Visible = true;
            btnLamLai1b.Visible = false;
            lblError1b.Visible = false;
            txt1b.Text = "14";
            txt2b.Text = "14";
            txt3b.Text = "28";
            txt4b.Text = "28";
            txt5b.Text = "42";
            txt6b.Text = "42";
            txt7b.Text = "21";
            txt8b.Text = "21";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnDaLam1b.Visible = false;
            btnLamLai1b.Visible = true;
            lblError1b.Visible = false;
            txt1b.Text = "14";
            txt2b.Text = "14";
            txt3b.Text = "28";
            txt4b.Text = "28";
            txt5b.Text = "42";
            txt6b.Text = "42";
            txt7b.Text = "21";
            txt8b.Text = "21";
        }
        #endregion
        

        private void button1_Click(object sender, EventArgs e)
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
        private void btnDaLambt2_Click(object sender, EventArgs e)
        {
            lblbt2.Visible = true;
            lblbt2.Text = "Lỗi ỡ: ";
            btnlamLaibt2.Visible = false;
            if (txt21.Text != "50")
            {
                lblbt2.Text += "Câu a ;";
            }
            if (txt22.Text != "80")
            {
                lblbt2.Text += "Câu a ;";
            }
            if (txt23.Text != "70")
            {
                lblbt2.Text += "Câu b ;";
            }
            if (txt24.Text != "60")
            {
                lblbt2.Text += "Câu b ;";
            }
            else
                if (
                    txt21.Text == "50" &&
                    txt22.Text == "80" &&
                    txt23.Text == "70" &&
                    txt24.Text == "60")
                {
                    lblbt2.Text = "Bạn Đã Làm Đúng !!!";
                    btnlamLaibt2.Visible = true;
                    btnDaLambt2.Visible = false;
                }
        }

        private void btnlamLaibt2_Click(object sender, EventArgs e)
        {
            btnDaLambt2.Visible = true;
            btnlamLaibt2.Visible = false;
            lblbt2.Visible = false;
            txt21.Text = "50";
            txt22.Text = "80";
            txt23.Text = "70";
            txt24.Text = "60";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnDaLambt2.Visible = false;
            btnlamLaibt2.Visible = true;
            lblbt2.Visible = false;
            txt21.Text = "50";
            txt22.Text = "80";
            txt23.Text = "70";
            txt24.Text = "60";
        }

        #endregion
      
        private void button3_Click(object sender, EventArgs e)
        {
            lblErrorbt3.Visible = true;
            btnLamLaibt3.Visible = false;
            if (chk28.Checked == false && chk24.Checked == false && chk35.Checked == true && chk42.Checked == false)
            {
                lblErrorbt3.Text = "Bạn Đã Chọn Đúng !!";
                btnLamLaibt3.Visible = true;
                btnDaLambt3.Visible = false;
            }
            else
            {
                lblErrorbt3.Text = "Bạn Đã Chọn Sai !!! Hãy Chọn Lại ";
            }
        }

        private void btnLamLaibt3_Click(object sender, EventArgs e)
        {
            btnDaLambt3.Visible = true;
            btnLamLaibt3.Visible = false;
            lblErrorbt3.Visible = false;
            chk24.Checked = false;
            chk28.Checked = false;
            chk35.Checked = false;
            chk42.Checked = false;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnDaLambt3.Visible = false;
            btnLamLaibt3.Visible = true;
            lblErrorbt3.Visible = false;
            chk35.Checked = true;
            chk24.Checked = false;
            chk28.Checked = false;
            chk42.Checked = false;
        }

        private void llbThucHanh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LuyenTapBT8_tieptheo_ frm = new LuyenTapBT8_tieptheo_();
            frm.ShowDialog();
        }
    }
}
