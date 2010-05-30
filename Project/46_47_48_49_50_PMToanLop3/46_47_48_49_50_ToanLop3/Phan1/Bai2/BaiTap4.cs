﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan1.Bai2
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

        private void BaiTap4_Load(object sender, EventArgs e)
        {
            lbLoi.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chb277.Checked)
            {
                lbLoi.Text = "Bạn làm rất tốt!";
                lbLoi.ForeColor = Color.Green;
                lbLoi.Show();
            }
            else
            {
                lbLoi.Text = "Bạn làm sai rồi!";
                lbLoi.ForeColor = Color.Red;
                lbLoi.Show();
            }
        }

        private void ntKiemtra_Click(object sender, EventArgs e)
        {
            chb277.Checked = true;
            chbckb213.Checked = false;
            chb214.Checked = false;
            chb225.Checked = false;
            lbLoi.Hide();
        }

        private void btLamlai_Click(object sender, EventArgs e)
        {
            chbckb213.Checked = false;
            chb277.Checked = false;
            chb214.Checked = false;
            chb225.Checked = false;
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
    }
}
