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
        #region bai 1
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnDaLamXong1.Visible = false;
            lbl1.Visible = false; lbl12.Visible = false; lbl4.Visible = false;
            lbl10.Visible = false; lbl2.Visible = false; lbl5.Visible = false;
            lbl11.Visible = false; lbl3.Visible = false; lbl6.Visible = false;
            lbl7.Visible = false; lbl8.Visible = false; lbl9.Visible = false;
            txt1.Text = "7"; txt2.Text = "9";
            txt3.Text = "2"; txt4.Text = "4";
            txt5.Text = "6"; txt6.Text = "1";
            txt7.Text = "8"; txt8.Text = "3";
            txt9.Text = "10"; txt10.Text = "5";
            txt11.Text = "6"; txt12.Text = "10";

        }

        private void btnLamLai2_Click(object sender, EventArgs e)
        {
            btnDaLamXong1.Visible = true;
            lbl1.Visible = false; lbl12.Visible = false; lbl4.Visible = false;
            lbl10.Visible = false; lbl2.Visible = false; lbl5.Visible = false;
            lbl11.Visible = false; lbl3.Visible = false; lbl6.Visible = false;
            lbl7.Visible = false; lbl8.Visible = false; lbl9.Visible = false;
            txt1.Text = ""; txt2.Text = "";
            txt3.Text = ""; txt4.Text = "";
            txt5.Text = ""; txt6.Text = "";
            txt7.Text = ""; txt8.Text = "";
            txt9.Text = ""; txt10.Text = "";
            txt11.Text = ""; txt12.Text = "";
        }

        private void btnDaLamXong1_Click(object sender, EventArgs e)
        {
            lbl1.Text = ""; lbl12.Text = ""; lbl4.Text = ""; lbl6.Text = ""; lbl9.Text = "";
            lbl10.Text = ""; lbl2.Text = ""; lbl5.Text = ""; lbl7.Text = ""; lbl8.Text = "";
            lbl11.Text = ""; lbl3.Text = "";
            if (true)
            {
                if (txt1.Text != "7")
                {
                    lbl1.Visible = true;
                    lbl1.Text += "Sai";
                }
                if (txt2.Text != "9")
                {
                    lbl2.Visible = true;
                    lbl2.Text += "Sai";
                }
                if (txt3.Text != "2")
                {
                    lbl3.Visible = true;
                    lbl3.Text += "Sai";
                }
                if (txt4.Text != "4")
                {
                    lbl4.Visible = true;
                    lbl4.Text += "Sai";
                }
                if (txt5.Text != "6")
                {
                    lbl5.Visible = true;
                    lbl5.Text += "Sai";
                }
                if (txt6.Text != "1")
                {
                    lbl6.Visible = true;
                    lbl6.Text += "Sai";
                }
                if (txt7.Text != "8")
                {
                    lbl7.Visible = true;
                    lbl7.Text += "Sai";
                }
                if (txt8.Text != "3")
                {
                    lbl8.Visible = true;
                    lbl8.Text += "Sai";
                }
                if (txt9.Text != "10")
                {
                    lbl9.Visible = true;
                    lbl9.Text += "Sai";
                }
                if (txt10.Text != "5")
                {
                    lbl10.Visible = true;
                    lbl10.Text += "Sai";
                }
                if (txt11.Text != "6")
                {
                    lbl11.Visible = true;
                    lbl11.Text = "Sai";
                }
                if (txt12.Text != "10")
                {
                    lbl12.Visible = true;
                    lbl12.Text += "Sai";
                }
            }
            else
            {
                lblError.Visible = true;
            }
        }
        #endregion

        #region bai2
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnLamXong2.Visible = false;
            lbl21.Visible = false; lbl212.Visible = false; lbl24.Visible = false;
            lbl210.Visible = false; lbl22.Visible = false; lbl25.Visible = false;
            lbl211.Visible = false; lbl23.Visible = false; lbl26.Visible = false;
            lbl7.Visible = false; lbl8.Visible = false; lbl9.Visible = false;
            txt21.Text = "24"; txt22.Text = "4";
            txt23.Text = "6"; txt24.Text = "12";
            txt25.Text = "2"; txt26.Text = "6";
            txt27.Text = "30"; txt28.Text = "5";
            txt29.Text = "6"; txt210.Text = "6";
            txt211.Text = "1"; txt212.Text = "6";
        }

        private void btnLamXong2_Click(object sender, EventArgs e)
        {
            lbl21.Text = ""; lbl212.Text = ""; lbl24.Text = ""; lbl26.Text = ""; lbl29.Text = "";
            lbl210.Text = ""; lbl22.Text = ""; lbl25.Text = ""; lbl27.Text = ""; lbl28.Text = "";
            lbl211.Text = ""; lbl23.Text = "";
            if (true)
            {
                if (txt21.Text != "24")
                {
                    lbl21.Visible = true;
                    lbl21.Text += "Sai";
                }
                if (txt22.Text != "4")
                {
                    lbl22.Visible = true;
                    lbl22.Text += "Sai";
                }
                if (txt23.Text != "6")
                {
                    lbl23.Visible = true;
                    lbl23.Text += "Sai";
                }
                if (txt24.Text != "12")
                {
                    lbl24.Visible = true;
                    lbl24.Text += "Sai";
                }
                if (txt25.Text != "2")
                {
                    lbl25.Visible = true;
                    lbl25.Text += "Sai";
                }
                if (txt26.Text != "6")
                {
                    lbl26.Visible = true;
                    lbl26.Text += "Sai";
                }
                if (txt27.Text != "30")
                {
                    lbl27.Visible = true;
                    lbl27.Text += "Sai";
                }
                if (txt28.Text != "5")
                {
                    lbl28.Visible = true;
                    lbl28.Text += "Sai";
                }
                if (txt29.Text != "6")
                {
                    lbl29.Visible = true;
                    lbl29.Text += "Sai";
                }
                if (txt210.Text != "6")
                {
                    lbl210.Visible = true;
                    lbl210.Text += "Sai";
                }
                if (txt211.Text != "1")
                {
                    lbl211.Visible = true;
                    lbl211.Text = "Sai";
                }
                if (txt212.Text != "6")
                {
                    lbl212.Visible = true;
                    lbl212.Text += "Sai";
                }
            }
            else
            {
                lblError2.Visible = true;
            }
        }

        private void btnLamLaibt2_Click(object sender, EventArgs e)
        {
            btnLamXong2.Visible = true;
            lbl21.Visible = false; lbl212.Visible = false; lbl24.Visible = false;
            lbl210.Visible = false; lbl22.Visible = false; lbl25.Visible = false;
            lbl211.Visible = false; lbl23.Visible = false; lbl26.Visible = false;
            lbl27.Visible = false; lbl28.Visible = false; lbl29.Visible = false;
            txt21.Text = ""; txt22.Text = "";
            txt23.Text = ""; txt24.Text = "";
            txt25.Text = ""; txt26.Text = "";
            txt27.Text = ""; txt28.Text = "";
            txt29.Text = ""; txt210.Text = "";
            txt211.Text = ""; txt212.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void llbThucHanh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Bai1.LuyenTap.LuyenTapBT2 frm = new Bai1.LuyenTap.LuyenTapBT2();
            frm.ShowDialog();
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
