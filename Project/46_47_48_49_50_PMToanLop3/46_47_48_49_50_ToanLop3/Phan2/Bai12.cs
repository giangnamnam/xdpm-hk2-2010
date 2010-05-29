﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan2
{
    public partial class Bai12 : Form
    {
        public Bai12()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnQuayLaiPhan2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llbThucHanh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Bai1.LuyenTap.LuyenTapBT12 frm = new Bai1.LuyenTap.LuyenTapBT12();
            frm.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Bai1.BaiTap12 frm = new Bai1.BaiTap12();
            frm.ShowDialog();
        }
    }
}
