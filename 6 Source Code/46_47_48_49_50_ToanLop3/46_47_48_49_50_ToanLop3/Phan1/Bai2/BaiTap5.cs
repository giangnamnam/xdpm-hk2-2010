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
    public partial class BaiTap5 : UserControl
    {
        public BaiTap5()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btLamxong_Click(object sender, EventArgs e)
        {
            lbLoi.Text = "Bạn làm sai phép tính thứ:";
            lbLoi.ForeColor = Color.Red;
            lbLoi.Visible = true;
            int Dem = 0;
            if (true)
            {
                if (tbvl3.Text == "355" && ((tbvl1.Text == "40" && tbvl2.Text == "315") || (tbvl1.Text == "315" && tbvl2.Text == "40")))
                {
                    Dem++;
                }
                else
                {
                    lbLoi.Text += "1, ";
                }
                if (tbvl6.Text == "355" && ((tbvl4.Text == "40" && tbvl5.Text == "315") || (tbvl4.Text == "315" && tbvl5.Text == "40")))
                {
                    Dem++;
                }
                else
                {
                    lbLoi.Text += "2, ";
                }
                if (tbvl7.Text == "355" && ((tbvl8.Text == "40" && tbvl9.Text == "315") || (tbvl8.Text == "315" && tbvl9.Text == "40")))
                {
                    Dem++;
                }
                else
                {
                    lbLoi.Text += "3, ";
                }
                if (tbvl10.Text == "355" && ((tbvl11.Text == "40" && tbvl12.Text == "315") || (tbvl11.Text == "315" && tbvl12.Text == "40")))
                {
                    Dem++;
                }
                else
                {
                    lbLoi.Text += "4";
                }

                if (Dem == 4)
                {
                    lbLoi.Text = "Bạn làm rất tốt!";
                    lbLoi.ForeColor = Color.Green;
                    lbLoi.Show();
                }
                else
                {
                    lbLoi.Show();
                }
                
            }
            
        }

        private void BaiTap5_Load(object sender, EventArgs e)
        {
            lbLoi.Hide();
        }

        private void btKiemtra_Click(object sender, EventArgs e)
        {
            tbvl1.Text = "40";
            tbvl2.Text = "315";
            tbvl3.Text = "355";
            tbvl4.Text = "315";
            tbvl5.Text = "40";
            tbvl6.Text = "355";
            tbvl7.Text = "355";
            tbvl8.Text = "40";
            tbvl9.Text = "315";
            tbvl10.Text = "355";
            tbvl11.Text = "315";
            tbvl12.Text = "40";

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
            tbvl11.Text = "";
            tbvl12.Text = "";
            lbLoi.Hide();
        }

        
    }
}
