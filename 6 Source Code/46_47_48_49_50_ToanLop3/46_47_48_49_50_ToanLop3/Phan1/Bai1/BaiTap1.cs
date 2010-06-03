using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan1.Bai1
{
    public partial class BaiTap1 : UserControl
    {
        public BaiTap1()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            lbLoi.Text = "Lỗi ở:";
            lbLoi.ForeColor = Color.Red;
            lbLoi.Visible = true;
            if (true)
            {
                if (tbkq1.Text != "161")
                {
                    lbLoi.Text += "Dòng 2, ";
                }
                if (tbkq2.Text != "Ba trăm năm mươi bốn")
                {
                    lbLoi.Text += "Dòng 3, ";
                }
                
                if(tbkq3.Text != "Ba trăm linh bảy")
                {
                    lbLoi.Text += "Dòng 4, ";
                }

                if (tbkq4.Text != "555")
                {
                    lbLoi.Text += "Dòng 5, ";
                }
                if (tbkq5.Text != "601")
                {
                    lbLoi.Text += "Dòng 6, ";
                }

                if (lbLoi.Text == "Lỗi ở:")
                {
                    lbLoi.Text = "Bạn làm rất tốt!";
                    lbLoi.ForeColor = Color.Green;
                }
                lbLoi.Show();
            }
            else
            {
                lbLoi.Text = "Bạn làm rất tốt!";
                lbLoi.ForeColor = Color.Green;
                lbLoi.Show();
            }
        }

        private void BaiTap1_Load(object sender, EventArgs e)
        {
            lbLoi.Hide();
        }
        private void btKientra_Click(object sender, EventArgs e)
        {
            tbkq1.Text = "161";
            tbkq2.Text = "Ba trăm năm mươi bốn";
            tbkq3.Text = "Ba trăm linh bảy";
            tbkq4.Text = "555";
            tbkq5.Text = "601";
            lbLoi.Hide();
        }

        private void btLamlai_Click(object sender, EventArgs e)
        {
            tbkq1.Text = "";
            tbkq2.Text = "";
            tbkq3.Text = "";
            tbkq4.Text = "";
            tbkq5.Text = "";
            lbLoi.Hide();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
