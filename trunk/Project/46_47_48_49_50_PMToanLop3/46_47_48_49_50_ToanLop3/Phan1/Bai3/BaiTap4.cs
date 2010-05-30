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
    public partial class BaiTap4 : UserControl
    {
        public BaiTap4()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tbLamxong_Click(object sender, EventArgs e)
        {
            if (tbvl1.Text == "263")
            {
                lbLoi.Text = "Bạn làm rất tôt";
                lbLoi.ForeColor = Color.Green;
            }
            else
            {
                lbLoi.Text = "Bạn làm sai rồi!";
                lbLoi.ForeColor = Color.Red;
            }
            lbLoi.Show();
        }

        private void BaiTap4_Load(object sender, EventArgs e)
        {
            lbLoi.Hide();
        }

        private void btKiemtra_Click(object sender, EventArgs e)
        {
            tbvl1.Text = "263";
            lbLoi.Hide();
        }

        private void btLamlai_Click(object sender, EventArgs e)
        {
            tbvl1.Text = "";
            lbLoi.Hide();
        }
    }
}
