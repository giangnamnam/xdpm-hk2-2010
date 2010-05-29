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
    public partial class BaiTap11 : Form
    {
        public BaiTap11()
        {
            InitializeComponent();
        }

        private void BaiTap11_Load(object sender, EventArgs e)
        {

        }
        private void btnDalam_Click(object sender, EventArgs e)
        {
            lbl2.Visible = true;
            lbl2.Text = " Lỗi ở :";
            if (txt1.Text != "12")
            {
                lbl2.Text += "Ô 1 ;";
            }
            if (txt2.Text != "9")
            {
                lbl2.Text += "Ô 2 ;";
            }
            if (txt3.Text != "6")
            {
                lbl2.Text += "Ô 3 ;";
            }
            if (txt4.Text != "8")
            {
                lbl2.Text += "Ô 4 ;";
            }
            if (txt5.Text != "6")
            {
                lbl2.Text += "Ô 5 ;";
            }
            if (txt6.Text != "4")
            {
                lbl2.Text += "Ô 6 ;";
            }
            else
                if (txt1.Text == "12" &&
                    txt2.Text == "9" &&
                    txt3.Text == "6" &&
                    txt4.Text == "8" &&
                    txt5.Text == "6" &&
                    txt6.Text == "4")
                {
                    lbl2.Text = "Bạn Đã Làm Đúng !!!";
                }
            lbl2.Text = lbl2.Text.TrimEnd(';');
        }

        private void btnKiemtra_Click(object sender, EventArgs e)
        {
            btnLamLai.Visible = true;
            lbl2.Visible = false;
            txt1.Text = "12";
            txt2.Text = "9";
            txt3.Text = "6";
            txt4.Text = "8";
            txt5.Text = "6";
            txt6.Text = "4";
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            btnLamLai.Visible = false;
            lbl2.Visible = false;
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblErr2b.Visible = true;
            if (txt2b.Text == "6")
            {
                lblErr2b.Text = "Đúng";
            }
            else
            {
                lblErr2b.Text = "Sai";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            richTextBox1.Visible = false;
            lblErr2b.Visible = true;
            txt2b.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            richTextBox1.Visible = true;
            lblErr2b.Visible = true;
            txt2b.Text = "6";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnQuayLaiPhan2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void llbThucHanh_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LuyenTap.LuyenTapBT11 frm = new LuyenTap.LuyenTapBT11();
            frm.ShowDialog();
        }

        private void llbThucHanh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LuyenTap.LuyenTapBT11 frm = new LuyenTap.LuyenTapBT11();
            frm.ShowDialog();
        }
    }
}
