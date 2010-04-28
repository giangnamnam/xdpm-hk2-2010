﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_50_ToanLop3
{
    public partial class MucLuc : Form
    {
        public MucLuc()
        {
            InitializeComponent();
        }

        private void MucLuc_Load(object sender, EventArgs e)
        {
            ListView1.GridLines = true;
        }
        private void bntBatDau_Click(object sender, EventArgs e)
        {
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        #region Chọn Menu Khi double Click

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            string pathName = ListView1.SelectedItems[0].Tag.ToString();
            if (pathName == "chuong1")
            {
                Chuong1 frm = new Chuong1();
                frm.ShowDialog();
            }
            if (pathName == "chuong2")
            {
                Chuong2 frm = new Chuong2();
                frm.ShowDialog();
            }
            if (pathName == "chuong3")
            {
                Chuong3 frm = new Chuong3();
                frm.ShowDialog();
            }
            if (pathName == "chuong4")
            {
                Chuong4 frm = new Chuong4();
                frm.Show();
            }
            if (pathName == "chuong5")
            {
                Chuong5 frm = new Chuong5();
                frm.Show();
            }
            if (pathName == "chuong6")
            {
                Chuong6 frm = new Chuong6();
                frm.Show();
            }
            if (pathName == "chuong7")
            {
                Chuong7 frm = new Chuong7();
                frm.Show();
            }
            if (pathName == "chuong8")
            {
                Chuong8 frm = new Chuong8();
                frm.Show();
            }
            if (pathName == "chuong9")
            {
                Chuong9 frm = new Chuong9();
                frm.Show();
            }
            if (pathName == "baiTapThem")
            {
                BaiTapThem frm = new BaiTapThem();
                frm.Show();
            }
        }
        #endregion

        #region Chay menu khi chon BatDau
        private void bntBatDau_Click_1(object sender, EventArgs e)
        {
            string pathName = ListView1.SelectedItems[0].Tag.ToString();
                if (pathName == "chuong1")
                {
                    Chuong1 frm = new Chuong1();
                    frm.ShowDialog();
                }
                if (pathName == "chuong2")
                {
                    Chuong2 frm = new Chuong2();
                    frm.ShowDialog();
                }
                if (pathName == "chuong3")
                {
                    Chuong3 frm = new Chuong3();
                    frm.ShowDialog();
                }
                if (pathName == "chuong4")
                {
                    Chuong4 frm = new Chuong4();
                    frm.Show();
                }
                if (pathName == "chuong5")
                {
                    Chuong5 frm = new Chuong5();
                    frm.Show();
                }
                if (pathName == "chuong6")
                {
                    Chuong6 frm = new Chuong6();
                    frm.Show();
                }
                if (pathName == "chuong7")
                {
                    Chuong7 frm = new Chuong7();
                    frm.Show();
                }
                if (pathName == "chuong8")
                {
                    Chuong8 frm = new Chuong8();
                    frm.Show();
                }
                if (pathName == "chuong9")
                {
                    Chuong9 frm = new Chuong9();
                    frm.Show();
                }
                if (pathName == "baiTapThem")
                {
                    BaiTapThem frm = new BaiTapThem();
                    frm.Show();
                }
        }
        #endregion
        #region CHon Bang menu ngang
              private void chươngIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chuong1 frm = new Chuong1();
            frm.ShowDialog();
        }

        private void chươngIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chuong2 frm = new Chuong2();
            frm.ShowDialog();
        }

        private void chươngIIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chuong3 frm = new Chuong3();
            frm.ShowDialog();
        }

        private void chươngIVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chuong4 frm = new Chuong4();
            frm.ShowDialog();
        }

        private void chươngVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chuong5 frm = new Chuong5();
            frm.ShowDialog();
        }

        private void chươngVIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chuong6 frm = new Chuong6();
            frm.ShowDialog();
        }

        private void chươngVIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chuong7 frm = new Chuong7();
            frm.ShowDialog();
        }

        private void chươngVIIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chuong8 frm = new Chuong8();
            frm.ShowDialog();
        }

        private void chươngIVToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Chuong9 frm = new Chuong9();
            frm.ShowDialog();
        }

        private void BaitapThem_Click(object sender, EventArgs e)
        {
            BaiTapThem frm = new BaiTapThem();
            frm.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }    
        #endregion

    }
}
