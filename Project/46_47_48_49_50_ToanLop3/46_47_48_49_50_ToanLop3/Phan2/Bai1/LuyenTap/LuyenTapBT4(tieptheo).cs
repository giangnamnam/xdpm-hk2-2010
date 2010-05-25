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

        private void btnDaLamXong1_Click(object sender, EventArgs e)
        {
            lbl1.Text = ""; lbl4.Text = ""; lbl7.Text = "";
            lbl10.Text = ""; lbl2.Text = ""; lbl5.Text = "";
            lbl11.Text = ""; lbl8.Text = ""; lblError.Text = "";
            lblError.Text = "";
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
            {
                lblError.Visible = true;
                lblError.Text += "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //btnDaLamXong1.Visible = true;
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

        }
    }
}
