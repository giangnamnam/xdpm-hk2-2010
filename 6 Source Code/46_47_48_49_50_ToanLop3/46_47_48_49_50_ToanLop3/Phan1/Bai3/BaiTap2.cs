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
    public partial class BaiTap2 : UserControl
    {
        public BaiTap2()
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
                if (tbvl1.Text != "438")
                {
                    lbLoi.Text += "ô 1, ";
                }
                if (tbvl2.Text != "813")
                {
                    lbLoi.Text += "ô 2, ";
                }

                if (tbvl3.Text != "449")
                {
                    lbLoi.Text += "ô 3, ";
                }

                if (tbvl4.Text != "508")
                {
                    lbLoi.Text += "ô 4, ";
                }
                if (tbvl5.Text != "637")
                {
                    lbLoi.Text += "ô 5, ";
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

        private void tbKq5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btKiemtra_Click(object sender, EventArgs e)
        {
            tbvl1.Text = "438";
            tbvl2.Text = "813";
            tbvl3.Text = "449";
            tbvl4.Text = "508";
            tbvl5.Text = "637";

            lbLoi.Hide();
        }

        private void btLamlai_Click(object sender, EventArgs e)
        {
            tbvl1.Text = "";
            tbvl2.Text = "";
            tbvl3.Text = "";
            tbvl4.Text = "";
            tbvl5.Text = "";

            lbLoi.Hide();
        }

        private void BaiTap2_Load(object sender, EventArgs e)
        {
            lbLoi.Hide();
        }
    }
}
