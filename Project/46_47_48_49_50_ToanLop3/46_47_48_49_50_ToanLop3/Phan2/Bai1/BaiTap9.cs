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
    public partial class BaiTap9 : Form
    {
        public BaiTap9()
        {
            InitializeComponent();
        }

        private void btnKiemTra2_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            txt1.Text = "35";
            lblError2.Visible = false;
            button1.Visible = true;
        }

        private void btnDaLam2_Click(object sender, EventArgs e)
        {
            lblError2.Visible = true;
            if (txt1.Text == "35")
            {
                lblError2.Text = "Đúng";
            }
            else
            {
                lblError2.Text = "Sai->Hãy Bấm Kiểm Tra";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            txt1.Text = "";
            lblError2.Visible = false;
            button1.Visible = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void BaiTap9_Load(object sender, EventArgs e)
        {

        }

        private void btnDalam_Click(object sender, EventArgs e)
        {
            lbl2.Visible = true;
            if (rtb1.Text!="11")
            {
                lbl2.Text += "Ô 1 sai ;";
            }
            if (rtb2.Text != "9")
            {
                lbl2.Text += "Ô 2 sai ;";
            }
            if (rtb3.Text != "12")
            {
                lbl2.Text += "Ô 3 sai ;";
            }
            if (rtb4.Text != "10")
            {
                lbl2.Text += "Ô 4 sai ;";
            }

            if (rtb5.Text != "5")
            {
                lbl2.Text += "Ô 5 sai ;";
            }
            if (rtb6.Text != "30")
            {
                lbl2.Text = "Ô 6 sai ;";
            }
            if (rtb7.Text != "20")
            {
                lbl2.Text += "Ô 7 sai ;";
            }
            if (rtb8.Text != "35")
            {
                lbl2.Text += "Ô 8 sai ;";
            }
            if (rtb9.Text != "25")
            {
                lbl2.Text += "Ô 9 sai ;";
            }
            if (rtb10.Text != "0")
            {
                lbl2.Text += "Ô 10 sai ;";
            }
            else
                if(rtb1.Text=="11"&&
                    rtb2.Text=="9"&&
                    rtb3.Text=="12"&&
                    rtb4.Text=="10"&&
                    rtb5.Text=="5"&&
                    rtb6.Text=="30"&&
                    rtb7.Text=="20"&&
                    rtb8.Text=="35"&&
                    rtb9.Text=="25"&&
                    rtb10.Text=="0")
            {
                lbl2.Text = "Bạn Đã làm đúng";
            }
            lbl2.Text = lbl2.Text.TrimEnd(';');
        }

        private void btnKiemtra_Click(object sender, EventArgs e)
        {
            lbl2.Visible = false;
            button2.Visible = true;
            rtb1.Text="11";
            rtb2.Text = "9";
            rtb3.Text = "12";
            rtb4.Text = "10";
            rtb5.Text = "5";
            rtb6.Text = "30"; 
            rtb7.Text = "20";
            rtb8.Text = "35";
            rtb9.Text = "25";
            rtb10.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl2.Visible = false;
            button2.Visible = false;
            rtb1.Text = "";
            rtb2.Text = "";
            rtb3.Text = "";
            rtb4.Text = "";
            rtb5.Text = "";
            rtb6.Text = "";
            rtb7.Text = "";
            rtb8.Text = "";
            rtb9.Text = "";
            rtb10.Text = "";
        }

        private void llbThucHanh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LuyenTap.LuyenTapBT9 frm = new LuyenTap.LuyenTapBT9();
            frm.ShowDialog();
        }

        private void btnQuayLaiPhan2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
