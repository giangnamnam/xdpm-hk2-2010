using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan1.Bai2
{
    public partial class BaiTap1 : UserControl
    {
        public BaiTap1()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btLamxong_Click(object sender, EventArgs e)
        {
            lbLoi.Text = "Lỗi ở:";
            lbLoi.ForeColor = Color.Red;
            lbLoi.Visible = true;
            if (true)
            {
                if (tbvl1.Text != "700")
                {
                    lbLoi.Text += "ô 1, ";
                }
                if (tbvl2.Text != "400")
                {
                    lbLoi.Text += "ô 2, ";
                }

                if (tbvl3.Text != "300")
                {
                    lbLoi.Text += "ô 3, ";
                }

                if (tbvl4.Text != "540")
                {
                    lbLoi.Text += "ô 4, ";
                }
                if (tbvl5.Text != "500")
                {
                    lbLoi.Text += "ô 5, ";
                }
                if (tbvl6.Text != "40")
                {
                    lbLoi.Text += "ô 6, ";
                }
                if (tbvl7.Text != "124")
                {
                    lbLoi.Text += "ô 7, ";
                }
                if (tbvl8.Text != "367")
                {
                    lbLoi.Text += "ô 8, ";
                }
                if (tbvl9.Text != "815")
                {
                    lbLoi.Text += "ô 9, ";
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

        private void btKiemtra_Click(object sender, EventArgs e)
        {
            tbvl1.Text = "700";
            tbvl2.Text = "400";
            tbvl3.Text = "300";
            tbvl4.Text = "540";
            tbvl5.Text = "500";
            tbvl6.Text = "40";
            tbvl7.Text = "124";
            tbvl8.Text = "367";
            tbvl9.Text = "815";
            
            lbLoi.Hide();
        }

        private void btLamlai_Click(object sender, EventArgs e)
        {
            tbvl1.Text = "";
            tbvl2.Text = "";
            tbvl3.Text = "";
            tbvl4.Text = "";
            tbvl5.Text = "";
            tbvl6.Text = "";
            tbvl7.Text = "";
            tbvl8.Text = "";
            tbvl9.Text = "";

            lbLoi.Hide();
        }

        
    }
}
