using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan1.Bai4
{
    public partial class BaiTap12 : UserControl
    {
        public BaiTap12()
        {
            InitializeComponent();
        }

        private void BaiTap12_Load(object sender, EventArgs e)
        {
            lbLoi.Hide();
        }

        private void btLamxong_Click(object sender, EventArgs e)
        {
            lbLoi.Text = "Lỗi ở:";
            lbLoi.ForeColor = Color.Red;
            lbLoi.Visible = true;
            if (true)
            {
                if (tbvl1.Text != "414")
                {
                    lbLoi.Text += "ô 1, ";
                }
                if (tbvl2.Text != "308")
                {
                    lbLoi.Text += "ô 2, ";
                }

                if (tbvl3.Text != "349")
                {
                    lbLoi.Text += "ô 3, ";
                }

                if (tbvl4.Text != "427")
                {
                    lbLoi.Text += "ô 4, ";
                }
                if (tbvl5.Text != "457")
                {
                    lbLoi.Text += "ô 5, ";
                }
                if (tbvl6.Text != "184")
                {
                    lbLoi.Text += "ô 6, ";
                }
                if (tbvl7.Text != "495")
                {
                    lbLoi.Text += "ô 7, ";
                }
                if (tbvl8.Text != "174")
                {
                    lbLoi.Text += "ô 8, ";
                }
                if (tbvl9.Text != "684")
                {
                    lbLoi.Text += "ô 9, ";
                }
                if (tbvl10.Text != "395")
                {
                    lbLoi.Text += "ô 10, ";
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

        private void btKiemtra_Click(object sender, EventArgs e)
        {
            tbvl1.Text = "414";
            tbvl2.Text = "308";
            tbvl3.Text = "349";
            tbvl4.Text = "427";
            tbvl5.Text = "457";
            tbvl6.Text = "184";
            tbvl7.Text = "495";
            tbvl8.Text = "174";
            tbvl9.Text = "684";
            tbvl10.Text = "395";
           
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
            tbvl10.Text = "";
            
            lbLoi.Hide();
        }

        
    }
}
