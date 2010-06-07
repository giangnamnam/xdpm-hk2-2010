using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace _46_47_48_49_50_ToanLop3.Phan2
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void Bai01_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt1.Visible = true; txt3.Visible = true; txt5.Visible = true; txt7.Visible = true; txt9.Visible = true;
            txt2.Visible = true; txt4.Visible = true; txt6.Visible = true; txt8.Visible = true; txt10.Visible = true;
            txt1.Text = "6";
            txt2.Text = "12";
            txt3.Text = "18";
            txt4.Text = "24";
            txt5.Text = "30";
            txt6.Text = "36";
            txt7.Text = "42";
            txt8.Text = "48";
            txt9.Text = "54";
            txt10.Text = "60";
        }

        private void btnDaLamXong_Click(object sender, EventArgs e)
        {
            lblError.Text = "Lổi ở : ";
            lblError.Visible = true;
                if (txt61.Text != "6")
                {
                    lblError.Text += " Dòng 1  Sai ;";
                }
                if (txt62.Text != "12")
                {
                    lblError.Text += " Dòng 2  Sai ;\n";
                }
                if (txt63.Text != "18")
                {
                    lblError.Text += " Dòng 3  Sai ;";
                }
                if (txt64.Text != "24")
                {
                    lblError.Text += " Dòng 4  Sai ;\n";
                }
                if (txt65.Text != "30")
                {
                    lblError.Text += " Dòng 5  Sai ;";
                }
                if (txt66.Text != "36")
                {
                    lblError.Text += " Dòng 6  Sai ;";
                }
                if (txt67.Text != "42")
                {
                    lblError.Text += " Dòng 7  Sai ;\n";
                }
                if (txt68.Text != "48")
                {
                    lblError.Text += " Dòng 8  Sai ;";
                }
                if (txt69.Text != "54")
                {
                    lblError.Text += " Dòng 9  Sai ;\n";
                }
                if (txt610.Text != "60")
                {
                    lblError.Text += " Dòng 10  Sai";
                }
                else
                {
                    lblError.Text = "Bạn Làm Rất Tốt !!!";
                }


        }

        private void llbThucHanh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Phan2.Bai1.BaiTap1 frm = new Phan2.Bai1.BaiTap1();
            frm.ShowDialog();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            txt1.Visible = false; txt3.Visible = false; txt5.Visible = false; txt7.Visible = false; txt9.Visible = false;
            txt2.Visible = false; txt4.Visible = false; txt6.Visible = false; txt8.Visible = false; txt10.Visible = false;
            lblError.Text = " ";
            txt61.Text = " " ;
            txt62.Text = " ";
            txt63.Text = " ";
            txt64.Text = " ";
            txt65.Text = " ";
            txt66.Text = " ";
            txt67.Text = " ";
            txt68.Text = " ";
            txt69.Text = " ";
            txt610.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Bai1.LuyenTap.LuyenTapBT1 frm = new Bai1.LuyenTap.LuyenTapBT1();
            frm.ShowDialog();
        }

       
    }
}
