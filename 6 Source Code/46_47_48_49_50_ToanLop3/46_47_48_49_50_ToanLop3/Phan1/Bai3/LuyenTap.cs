using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan1.Bai3
{
    public partial class LuyenTap : UserControl
    {
        public LuyenTap()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LuyenTap_Load(object sender, EventArgs e)
        {
            lbLoi.Hide();
        }

        private void tbvl9_TextChanged(object sender, EventArgs e)
        {

        }

        private void btLamxong_Click(object sender, EventArgs e)
        {
            lbLoi.Text = "Lỗi ở:";
            lbLoi.ForeColor = Color.Red;
            lbLoi.Visible = true;
            if (true)
            {
                if (tbvl1.Text != "487")
                {
                    lbLoi.Text += "ô 1, ";
                }
                if (tbvl2.Text != "789")
                {
                    lbLoi.Text += "ô 2, ";
                }

                if (tbvl3.Text != "157")
                {
                    lbLoi.Text += "ô 3, ";
                }

                if (tbvl4.Text != "183")
                {
                    lbLoi.Text += "ô 4, ";
                }
                if (tbvl5.Text != "492")
                {
                    lbLoi.Text += "ô 5, ";
                }
                if (tbvl6.Text != "151")
                {
                    lbLoi.Text += "ô 6, ";
                }
                if (tbvl7.Text != "671")
                {
                    lbLoi.Text += "ô 7, ";
                }
                if (tbvl8.Text != "617")
                {
                    lbLoi.Text += "ô 8, ";
                }
                if (tbvl9.Text != "260")
                {
                    lbLoi.Text += "ô 9, ";
                }
                if (tbvl10.Text != "350")
                {
                    lbLoi.Text += "ô 10, ";
                }
                if (tbvl11.Text != "400")
                {
                    lbLoi.Text += "ô 11, ";
                }
                if (tbvl12.Text != "300")
                {
                    lbLoi.Text += "ô 12, ";
                }
                if (tbvl13.Text != "450")
                {
                    lbLoi.Text += "ô 13, ";
                }

                if (tbvl14.Text != "350")
                {
                    lbLoi.Text += "ô 14, ";
                }
                if (tbvl15.Text != "500")
                {
                    lbLoi.Text += "ô 15, ";
                }
                if (tbvl16.Text != "50")
                {
                    lbLoi.Text += "ô 16, ";
                }
                if (tbvl17.Text != "900")
                {
                    lbLoi.Text += "ô 17, ";
                }

                if (tbvl18.Text != "100")
                {
                    lbLoi.Text += "ô 18, ";
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
            tbvl1.Text = "487";
            tbvl2.Text = "789";
            tbvl3.Text = "157";
            tbvl4.Text = "183";
            tbvl5.Text = "492";
            tbvl6.Text = "151";
            tbvl7.Text = "671";
            tbvl8.Text = "617";
            tbvl9.Text = "260";
            tbvl10.Text = "350";
            tbvl11.Text = "400";
            tbvl12.Text = "300";
            tbvl13.Text = "450";
            tbvl14.Text = "350";
            tbvl15.Text = "500";
            tbvl16.Text = "50";
            tbvl17.Text = "900";
            tbvl18.Text = "100";
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
            tbvl13.Text = "";
            tbvl14.Text = "";
            tbvl15.Text = "";
            tbvl16.Text = "";
            tbvl17.Text = "";
            tbvl18.Text = "";
            lbLoi.Hide();
        }
    }
}
