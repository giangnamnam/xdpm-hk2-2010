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

        private void BaiTap5_Load(object sender, EventArgs e)
        {
            lbLoi.Hide();
        }

        private void tbVl3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLamxong_Click(object sender, EventArgs e)
        {
            lbLoi.Text = "Lỗi ở:";
            lbLoi.ForeColor = Color.Red;
            lbLoi.Visible = true;
            if (true)
            {
                if (tbvl1.Text != "300")
                {
                    lbLoi.Text += "ô 1, ";
                }
                if (tbvl2.Text != "100")
                {
                    lbLoi.Text += "ô 2, ";
                }

                if (tbvl3.Text != "0")
                {
                    lbLoi.Text += "ô 3, ";
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
            tbvl1.Text = "300";
            tbvl2.Text = "100";
            tbvl3.Text = "0";
           
            lbLoi.Hide();
        }

        private void btLamlai_Click(object sender, EventArgs e)
        {
            tbvl1.Text = "";
            tbvl2.Text = "";
            tbvl3.Text = "";

            lbLoi.Hide();
        }
    }
}
