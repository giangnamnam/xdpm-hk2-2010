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
    public partial class LuyenTapBT1 : Form
    {
        public LuyenTapBT1()
        {
            InitializeComponent();
        }

        private void llbThucHanh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        #region Bai 3
        private void btnDaLamBt3_Click(object sender, EventArgs e)
        {
            lblBt3.Visible = true;
            if (chk24.Checked)
            {
                lblBt3.Text = "Bạn Đã Chọn Đúng !!";
            }
            else
            {
                lblBt3.Text = "Bạn Đã Chọn Sai !!! Hãy Chọn Lại ";
            }
        }

        private void btnQuayLaiPhan2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLamLaiBt3_Click(object sender, EventArgs e)
        {
            lblBt3.Visible = false;
            chk18.Checked = false;
            chk23.Checked = false;
            chk24.Checked = false;
            chk34.Checked = false;
        }

        private void llbKiemTraBt3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            chk24.Checked = true;
        }
        #endregion
        #region Bai 2 
        private void btnLamXongBt2_Click(object sender, EventArgs e)
        {
            lblBt2.Text = "Lổi ở : ";
            lblBt2.Visible = true;
            if (txt21.Text != "60")
            {
                lblBt2.Text += " 6 x 9 + 6 sai ;";
            }
            if (txt22.Text != "59")
            {
                lblBt2.Text += "  6 x 5 + 29 sai ;";
            }
            if (txt23.Text != "42")
            {
                lblBt2.Text += "  6 x 6 + 6 sai ;";
            }
            else
            {
                lblBt2.Text = "Chúc Mừng !!! Bạn Làm Rất Tốt";
            }

        }
        private void btnLamLaiBt2_Click(object sender, EventArgs e)
        {
            lblBt2.Visible = false;
            txt21.Text = "";
            txt22.Text = "";
            txt23.Text = "";
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt21.Text = "60";
            txt22.Text = "59";
            txt23.Text = "42";
        }
        #endregion
        #region Bai 1 a
         private void btnDaLamXong_Click(object sender, EventArgs e)
        {
            lblBt1a.Text = "Lổi ở : ";
            lblBt1a.Visible = true;
            if (txt1.Text != "30")
            {
                lblBt1a.Text += " 6 x 5  sai ;";
            }
            if (txt2.Text != "42")
            {
                lblBt1a.Text += "  6 x 7  sai ;";
            }
            if (txt3.Text != "54")
            {
                lblBt1a.Text += "  6 x 9  sai ;";
            }
            if (txt4.Text != "60")
            {
                lblBt1a.Text += "  6 x 10  sai ;";
            }
            if (txt5.Text != "48")
            {
                lblBt1a.Text += " 6 x 8  sai ;";
            }
            if (txt6.Text != "36")
            {
                lblBt1a.Text += " 6 x 6  sai ;";
            }
            if (txt7.Text != "12")
            {
                lblBt1a.Text += " 6 x 2  sai ;";
            }
            if (txt8.Text != "18")
            {
                lblBt1a.Text += " 6 x 3  sai ;";
            }
            if (txt9.Text != "24")
            {
                lblBt1a.Text += " 6 x 4  sai ;";
            }
            else
            {
                lblBt1a.Text = "Chúc Mừng!!Bạn Làm Rất Tốt !!!";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblBt1a.Visible = true;
            txt1.Text = "30";
            txt2.Text = "42";
            txt3.Text = "54";
            txt4.Text = "60";
            txt5.Text = "48";
            txt6.Text = "36";
            txt7.Text = "12";
            txt8.Text = "18";
            txt9.Text = "24"; 
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            lblBt1a.Visible = false;
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
            txt7.Text = "";
            txt8.Text = "";
            txt9.Text = ""; 
        }
      
        #endregion
        #region Bai 1b
        private void btnDaLamb_Click(object sender, EventArgs e)
        {
            lblBt1b.Text = "Lổi ở : ";
            lblBt1b.Visible = true;
            if (txtb1.Text != "12")
            {
                lblBt1b.Text += " 6 x 2  sai ;";
            }
            if (txtb2.Text != "12")
            {
                lblBt1b.Text += "  2 x 6  sai ;";
            }
            if (txtb3.Text != "18")
            {
                lblBt1b.Text += "  3 x 6  sai ;";
            }
            if (txtb4.Text != "18")
            {
                lblBt1b.Text += "  6 x 3  sai ;";
            }
            if (txtb5.Text != "30")
            {
                lblBt1b.Text += " 5 x 6  sai ;";
            }
            if (txtb6.Text != "30")
            {
                lblBt1b.Text += " 6 x 5  sai ;";
            }
            else
            {
                lblBt1b.Text = "Chúc Mừng!!Bạn Làm Rất Tốt !!!";
            }
        }

        private void btnLamLaib_Click(object sender, EventArgs e)
        {
            lblBt1b.Visible = false;
            txtb1.Text = "";
            txtb2.Text = "";
            txtb3.Text = "";
            txtb4.Text = "";
            txtb5.Text = "";
            txtb6.Text = "";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblBt1b.Visible = false;
            txtb1.Text = "12";
            txtb2.Text = "12";
            txtb3.Text = "18";
            txtb4.Text = "18";
            txtb5.Text = "30";
            txtb6.Text = "30";
        }

        private void llbThucHanh_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LuyenTapBT1_tieptheo_ frm = new LuyenTapBT1_tieptheo_();
            frm.ShowDialog();
        }
       
       
        #endregion


    }
}
