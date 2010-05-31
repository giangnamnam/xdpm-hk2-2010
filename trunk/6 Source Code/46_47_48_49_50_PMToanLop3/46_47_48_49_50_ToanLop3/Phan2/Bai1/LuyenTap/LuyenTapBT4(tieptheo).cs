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
    public partial class LuyenTapBT4_tieptheo_ : Form
    {
        public LuyenTapBT4_tieptheo_()
        {
            InitializeComponent();
        }
        #region  bai1
        private void btnDaLamXong1_Click(object sender, EventArgs e)
        {
            lbl1.Text = ""; lbl4.Text = ""; lbl7.Text = "";
            lbl10.Text = ""; lbl2.Text = ""; lbl5.Text = "";
            lbl11.Text = ""; lbl8.Text = "";
            btnLamLai2.Visible = false;
            if (true)
            {
                if (txt1.Text != "36")
                {
                    lbl1.Visible = true;
                    lbl1.Text += "Sai";
                }
                if (txt2.Text != "6")
                {
                    lbl2.Visible = true;
                    lbl2.Text += "Sai";
                }
                if (txt4.Text != "54")
                {
                    lbl4.Visible = true;
                    lbl4.Text += "Sai";
                }
                if (txt5.Text != "9")
                {
                    lbl5.Visible = true;
                    lbl5.Text += "Sai";
                }
                if (txt7.Text != "42")
                {
                    lbl7.Visible = true;
                    lbl7.Text += "Sai";
                }
                if (txt8.Text != "7")
                {
                    lbl8.Visible = true;
                    lbl8.Text += "Sai";
                }
                if (txt10.Text != "48")
                {
                    lbl10.Visible = true;
                    lbl10.Text += "Sai";
                }
                if (txt11.Text != "8")
                {
                    lbl11.Visible = true;
                    lbl11.Text = "Sai";
                }
            }
            else
                if(txt1.Text == "36"&& txt2.Text == "6"&&
            txt4.Text == "54"&& txt11.Text == "8"&&
            txt5.Text == "9"&& txt10.Text == "48"&&
            txt7.Text == "42" && txt8.Text == "7")
            {
                lblError.Visible = true;
                lblError.Text = "Bạn Đã Làm Đúng !!";
                btnLamLai2.Visible = true;
            }
            lblError.Text = lblError.Text.TrimEnd(';');
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnDaLamXong1.Visible = false; btnLamLai2.Visible = true;
            lbl1.Visible = false; lbl4.Visible = false;
            lbl10.Visible = false; lbl2.Visible = false;
            lbl11.Visible = false; lbl5.Visible = false;
            lbl7.Visible = false; lbl8.Visible = false;
            txt1.Text = "36"; txt2.Text = "6";
            txt4.Text = "54"; txt11.Text = "8";
            txt5.Text = "9"; txt10.Text = "48";
            txt7.Text = "42"; txt8.Text = "7";


        }

        private void btnLamLai2_Click(object sender, EventArgs e)
        {
            btnDaLamXong1.Visible = true;
            lbl1.Visible = false; lbl4.Visible = false;
            lbl10.Visible = false; lbl2.Visible = false;
            lbl11.Visible = false; lbl5.Visible = false;
            lbl7.Visible = false; lbl8.Visible = false;
            txt1.Text = ""; txt2.Text = "";
            txt4.Text = ""; txt11.Text = "";
            txt5.Text = ""; txt10.Text = "";
            txt7.Text = ""; txt8.Text = "";
        }
        #endregion

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnLamLai2.Visible = false; lblError2.Visible = false;
            txt21.Text = "4"; txt22.Text = "8"; txt23.Text = "2";
            txt24.Text = "6"; txt25.Text = "3"; txt26.Text = "3";
            txt27.Text = "4"; txt28.Text = "6"; txt29.Text = "7";
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

        private void btnLamXong2_Click(object sender, EventArgs e)
        {
            lblError2.Text = "Lổi ở : ";
            lblError2.Visible = true;
            if (txt21.Text != "4")
            {
                lblError2.Text += " 16 : 4  sai ;";
            }
            if (txt22.Text != "8")
            {
                lblError2.Text += " 16 : 2  sai ;";
            }
            if (txt23.Text != "2")
            {
                lblError2.Text += " 12 : 6  sai ;";
            }
            if (txt24.Text != "6")
            {
                lblError2.Text += " 16 : 3  sai ;";
            }
            if (txt25.Text != "3")
            {
                lblError2.Text += " 16 : 6 sai ;";
            }
            if (txt26.Text != "3")
            {
                lblError2.Text += " 15 : 5 sai ;";
            }
            if (txt27.Text != "4")
            {
                lblError2.Text += " 26 : 4  sai ;";
            }
            if (txt28.Text != "6")
            {
                lblError2.Text += " 24 : 6  sai ;";
            }
            if (txt29.Text != "7")
            {
                lblError2.Text += " 35 : 5  sai ;";
            }

            else 
                if(txt21.Text == "4"&& txt22.Text == "8"&& txt23.Text == "2"&&
            txt24.Text== "6"&& txt25.Text == "3"&& txt26.Text == "3"&&
            txt27.Text == "4"&& txt28.Text == "6"&& txt29.Text == "7")
            {
                btnLamLai2.Visible = true;
                lblError2.Text = "Chúc Mừng!!Bạn Làm Rất Tốt !!!";
            }
        }

        private void btnLamLaibt2_Click(object sender, EventArgs e)
        {
            btnLamLai2.Visible = false; lblError2.Visible = false;
            txt21.Text = ""; txt22.Text = ""; txt23.Text = "";
            txt24.Text = ""; txt25.Text = ""; txt26.Text = "";
            txt27.Text = ""; txt28.Text = ""; txt29.Text = "";
        }

        private void llbThucHanh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LuyenTapBT4_tieptheo1_ frm = new LuyenTapBT4_tieptheo1_();
            frm.ShowDialog();
        }
    }
}
