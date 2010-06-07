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
    public partial class BaiTap34 : UserControl
    {
        public BaiTap34()
        {
            InitializeComponent();
        }

        private void btLamxong_Click(object sender, EventArgs e)
        {
            lbLoi.Text = "Lỗi ở bài:";
            lbLoi.ForeColor = Color.Red;
            lbLoi.Visible = true;
            if (true)
            {
                if (tbkq1.Text != "216")
                {
                    lbLoi.Text += "3, ";
                }
                if (chbckb213.Checked == false)
                {
                    lbLoi.Text += "4";
                }
                if (lbLoi.Text == "Lỗi ở bài:")
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


        private void BaiTap34_Load(object sender, EventArgs e)
        {
            lbLoi.Hide();
        }

        private void btKiemtra_Click(object sender, EventArgs e)
        {
            tbkq1.Text = "216";
            chbckb213.Checked = true;
            chb214.Checked = false;
            chb225.Checked = false;
            chb277.Checked = false;
            lbLoi.Hide();

        }

        private void btLamlai_Click(object sender, EventArgs e)
        {
            tbkq1.Text = "";
            chbckb213.Checked = false;
            chb214.Checked = false;
            chb225.Checked = false;
            chb277.Checked = false;
            lbLoi.Hide();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void chb214_Click(object sender, EventArgs e)
        {
            chbckb213.Checked = false;
            chb214.Checked = true;
            chb225.Checked = false;
            chb277.Checked = false;
        }

        private void chbckb213_Click(object sender, EventArgs e)
        {
            chbckb213.Checked = true;
            chb214.Checked = false;
            chb225.Checked = false;
            chb277.Checked = false;
        }

        private void chb277_Click(object sender, EventArgs e)
        {
            chbckb213.Checked = false;
            chb214.Checked = false;
            chb225.Checked = false;
            chb277.Checked = true;
        }

        private void chb225_Click(object sender, EventArgs e)
        {
            chbckb213.Checked = false;
            chb214.Checked = false;
            chb225.Checked = true;
            chb277.Checked = true;
        }
    }
}
