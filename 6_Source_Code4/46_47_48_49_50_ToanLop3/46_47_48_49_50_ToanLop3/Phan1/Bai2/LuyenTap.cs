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

        private void btLamxong_Click(object sender, EventArgs e)
        {
            lbLoi.Text = "Lỗi ở: Bài";
            lbLoi.ForeColor = Color.Red;
            lbLoi.Visible = true;
            if (true)
            {
                if (tbvl1.Text != "740")
                {
                    lbLoi.Text += "1 ô 1, ";
                }
                if (tbvl2.Text != "889")
                {
                    lbLoi.Text += "1 ô 2, ";
                }

                if (tbvl3.Text != "296")
                {
                    lbLoi.Text += "1 ô 3, ";
                }

                if (tbvl4.Text != "343")
                {
                    lbLoi.Text += "1 ô 4, ";
                }
                if (tbvl5.Text != "333")
                {
                    lbLoi.Text += "1 ô 5, ";
                }
                if (tbvl6.Text != "773")
                {
                    lbLoi.Text += "1 ô 6, ";
                }
                if (tbvl7.Text != "469")
                {
                    lbLoi.Text += "2 ô 7, ";
                }
                if (tbvl8.Text != "141")
                {
                    lbLoi.Text += "2 ô 8, ";
                }
               
                if(chb214.Checked == false)
                {
                    lbLoi.Text += "3";
                }
                if (lbLoi.Text == "Lỗi ở: Bài")
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

        private void ntKiemtra_Click(object sender, EventArgs e)
        {
            tbvl1.Text = "740";
            tbvl2.Text = "889";
            tbvl3.Text = "296";
            tbvl4.Text = "343";
            tbvl5.Text = "333";
            tbvl6.Text = "773";
            tbvl7.Text = "469";
            tbvl8.Text = "141";
            chb214.Checked = true;
            chb225.Checked = false;
            chb277.Checked = false;
            chbckb213.Checked = false;
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
            chb214.Checked = false;
            chb225.Checked = false;
            chb277.Checked = false;
            chbckb213.Checked = false;
            lbLoi.Hide();
        }

        private void chb214_Click(object sender, EventArgs e)
        {
            chbckb213.Checked = false;
            chb225.Checked = false;
            chb277.Checked = false;
        }

        private void chbckb213_Click(object sender, EventArgs e)
        {
            chb277.Checked = false;
            chb225.Checked = false;
            chb214.Checked = false;
        }

        private void chb277_Click(object sender, EventArgs e)
        {
            chb214.Checked = false;
            chb225.Checked = false;
            chbckb213.Checked = false;
        }

        private void chb225_Click(object sender, EventArgs e)
        {
            chbckb213.Checked = false;
            chb277.Checked = false;
            chb214.Checked = false;
        }

        private void LuyenTap_Load(object sender, EventArgs e)
        {
            lbLoi.Hide();
        }

       
     
    }
}
