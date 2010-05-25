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
    public partial class Bai02 : Form
    {
        public Bai02()
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
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            btnDaLamXong.Visible = true; lbl1.Visible = false; lbl2.Visible = false;
            lbl3.Visible = false; lbl4.Visible = false; lbl5.Visible = false; lbl6.Visible = false;
            txt1.Text = ""; txt2.Text = "";
            txt3.Text = ""; txt4.Text = "";
            txt5.Text = ""; txt6.Text = "";
        }

        private void btnDaLamXong_Click(object sender, EventArgs e)
        {
            if (true)
            {
                if (txt1.Text != "5")
                {
                    lbl1.Visible = true;
                    lbl1.Text = "Sai";
                }
                if (txt2.Text != "6")
                {
                    lbl2.Visible = true;
                    lbl2.Text = "Sai";
                }
                if (txt3.Text != "7")
                {
                    lbl3.Visible = true;
                    lbl3.Text = "Sai";
                }
                if (txt4.Text != "8")
                {
                    lbl4.Visible = true;
                    lbl4.Text = "Sai";
                }
                if (txt5.Text != "9")
                {
                    lbl5.Visible = true;
                    lbl5.Text = "Sai";
                }
                if (txt6.Text != "10")
                {
                    lbl6.Visible = true;
                    lbl6.Text = "Sai";
                }
            }
            
            else
            {
                lblError.Visible = true;
                lblError.Text = "Bạn Đã Làm Đúng!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llbThucHanh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Phan2.Bai1.BaiTap2 frm = new Phan2.Bai1.BaiTap2();
            frm.ShowDialog();
        }

        private void Bai02_Load(object sender, EventArgs e)
        {

        }
    }
}
