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

        private void tbLamxong_Click(object sender, EventArgs e)
        {
            lbLoi.Text = "Lỗi ở:";
            lbLoi.ForeColor = Color.Red;
            lbLoi.Visible = true;
            if (true)
            {
                if (tbvl1.Text != "652")
                {
                    lbLoi.Text += "ô 1, ";
                }
                if (tbvl2.Text != "326")
                {
                    lbLoi.Text += "ô 2, ";
                }

                if (tbvl3.Text != "380")
                {
                    lbLoi.Text += "ô 3, ";
                }

                if (tbvl4.Text != "420")
                {
                    lbLoi.Text += "ô 4, ";
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

            tbvl1.Text = "652";
            tbvl2.Text = "326";
            tbvl3.Text = "380";
            tbvl4.Text = "420";
           
            lbLoi.Hide();
        }

        private void btLamlai_Click(object sender, EventArgs e)
        {

            tbvl1.Text = "";
            tbvl2.Text = "";
            tbvl3.Text = "";
            tbvl4.Text = "";
          
            lbLoi.Hide();
        }

        private void BaiTap3_Load(object sender, EventArgs e)
        {
            lbLoi.Hide();
        }

       
    }
}
