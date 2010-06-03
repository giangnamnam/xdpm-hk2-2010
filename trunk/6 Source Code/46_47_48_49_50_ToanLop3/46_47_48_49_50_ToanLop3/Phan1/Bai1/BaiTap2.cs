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

        private void btHoanThanh_Click(object sender, EventArgs e)
        {
            lbLoi.Text = "Lỗi ở:";
            lbLoi.ForeColor = Color.Red;
            lbLoi.Visible = true;
            if (true)
            {
                if (tbvl1.Text != "312")
                {
                    lbLoi.Text += "ô 1, ";
                }
                if (tbvl2.Text != "313")
                {
                    lbLoi.Text += "ô 2, ";
                }

                if (tbvl3.Text != "314")
                {
                    lbLoi.Text += "ô 3, ";
                }

                if (tbvl4.Text != "316")
                {
                    lbLoi.Text += "ô 4, ";
                }
                if (tbvl5.Text != "317")
                {
                    lbLoi.Text += "ô 5, ";
                }
                if (tbvl6.Text != "318")
                {
                    lbLoi.Text += "ô 6, ";
                }
                if (tbvl7.Text != "398")
                {
                    lbLoi.Text += "ô 7, ";
                }
                if (tbvl8.Text != "397")
                {
                    lbLoi.Text += "ô 8, ";
                }
                if (tbvl9.Text != "396")
                {
                    lbLoi.Text += "ô 9, ";
                }
                if (tbvl10.Text != "394")
                {
                    lbLoi.Text += "ô 10, ";
                }
                if (tbvl11.Text != "393")
                {
                    lbLoi.Text += "ô 11, ";
                }
                if (tbvl12.Text != "392")
                {
                    lbLoi.Text += "ô 12, ";
                }
                if (tbvl13.Text != "391")
                {
                    lbLoi.Text += "ô 13, ";
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

        private void tbkiemtra_Click(object sender, EventArgs e)
        {
            tbvl1.Text = "312";
            tbvl2.Text = "313";
            tbvl3.Text = "314";
            tbvl4.Text = "316";
            tbvl5.Text = "317";
            tbvl6.Text = "318";
            tbvl7.Text = "398";
            tbvl8.Text = "397";
            tbvl9.Text = "396";
            tbvl10.Text = "394";
            tbvl11.Text = "393";
            tbvl12.Text = "392";
            tbvl13.Text = "391";
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
            lbLoi.Hide();
        }

        private void BaiTap2_Load(object sender, EventArgs e)
        {
            lbLoi.Hide();
        }
    }
}
