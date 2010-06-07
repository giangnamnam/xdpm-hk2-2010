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
    public partial class BaiTap3 : UserControl
    {
        public BaiTap3()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tbHoanThanh_Click(object sender, EventArgs e)
        {
            lbLoi.Text = "Lỗi ở:";
            lbLoi.ForeColor = Color.Red;
            lbLoi.Visible = true;
            if (true)
            {
                if (tbvl1.Text != "<")
                {
                    lbLoi.Text += "ô 1, ";
                }
                if (tbvl2.Text != ">")
                {
                    lbLoi.Text += "ô 2, ";
                }

                if (tbvl3.Text != "<")
                {
                    lbLoi.Text += "ô 3, ";
                }

                if (tbvl4.Text != "<")
                {
                    lbLoi.Text += "ô 4, ";
                }
                if (tbvl5.Text != "<")
                {
                    lbLoi.Text += "ô 5, ";
                }
                if (tbvl6.Text != "=")
                {
                    lbLoi.Text += "ô 6, ";
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

        private void BaiTap3_Load(object sender, EventArgs e)
        {
            lbLoi.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbvl1.Text = "<";
            tbvl2.Text = ">";
            tbvl3.Text = "<";
            tbvl4.Text = "<";
            tbvl5.Text = "<";
            tbvl6.Text = "=";
            lbLoi.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbvl1.Text = "";
            tbvl2.Text = "";
            tbvl3.Text = "";
            tbvl4.Text = "";
            tbvl5.Text = "";
            tbvl6.Text = "";
            lbLoi.Hide();
        }
    }
}
