using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan2
{
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnDaLamXong.Visible = false; lbl1.Visible = false;lbl2.Visible = false;
            lbl3.Visible = false; lbl4.Visible = false; lbl5.Visible = false; lbl6.Visible = false;
            txt1.Text = "5"; txt2.Text = "6"; 
            txt3.Text = "7"; txt4.Text = "8";
            txt5.Text = "9"; txt6.Text = "10";
            btnLamLai.Visible = true;
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            btnDaLamXong.Visible = true; lbl1.Visible = false; lbl2.Visible = false;
            lbl3.Visible = false; lbl4.Visible = false; lbl5.Visible = false; lbl6.Visible = false;
            txt1.Text = ""; txt2.Text = "";
            txt3.Text = ""; txt4.Text = "";
            txt5.Text = ""; txt6.Text = "";
            btnLamLai.Visible = false;
        }

        private void btnDaLamXong_Click(object sender, EventArgs e)
        {
            lbl1.Visible = false; lbl2.Visible = false;
            lbl3.Visible = false; lbl4.Visible = false; 
            lbl5.Visible = false; lbl6.Visible = false;
            lblError.Visible = false;
                if (txt1.Text != "5")
                {
                    lbl1.Visible = true;
                }
                if (txt2.Text != "6")
                {
                    lbl2.Visible = true;
                }
                if (txt3.Text != "7")
                {
                    lbl3.Visible = true;
                }
                if (txt4.Text != "8")
                {
                    lbl4.Visible = true;
                }
                if (txt5.Text != "9")
                {
                    lbl5.Visible = true;
                }
                if (txt6.Text != "10")
                {
                    lbl6.Visible = true;
                }
                else
                {
                    lblError.Visible = true;
                    btnLamLai.Visible = true;
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llbThucHanh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Phan2.Bai1.BaiTap4 frm = new Phan2.Bai1.BaiTap4();
            frm.ShowDialog();
        }

        private void Bai02_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Phan2.Bai1.LuyenTap.LuyenTapBT4_tieptheo_ frm = new Phan2.Bai1.LuyenTap.LuyenTapBT4_tieptheo_();
            frm.ShowDialog();
        }
    }
}
