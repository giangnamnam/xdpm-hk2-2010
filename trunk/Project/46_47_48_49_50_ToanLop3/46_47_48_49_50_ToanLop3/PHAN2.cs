﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3
{
    public partial class PHAN2 : Form
    {

        public PHAN2()
        {
            InitializeComponent();
        }

        private void PHAN2_Load(object sender, EventArgs e)
        {
        }
       
        private void bài01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phan2.Bai01 frm = new Phan2.Bai01();
            frm.ShowDialog();
        }

        private void bài02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phan2.Bai02 frm = new Phan2.Bai02();
            frm.ShowDialog();

        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            string pathName = ListView1.SelectedItems[0].Tag.ToString();
            if (pathName == "bai1")
            {
                Phan2.Bai01 frm = new Phan2.Bai01();
                frm.ShowDialog();
            }
            if (pathName == "bai2")
            {
                Phan2.Bai02 frm = new Phan2.Bai02();
                frm.ShowDialog();
            }
            if (pathName == "bai3")
            {
                Phan2.Bai03 frm = new Phan2.Bai03();
                frm.ShowDialog();
            }
            if (pathName == "bai4")
            {
                Phan2.Bai04 frm = new Phan2.Bai04();
                frm.ShowDialog();
            }
            if (pathName == "bai5")
            {
                Phan2.Bai05 frm = new Phan2.Bai05();
                frm.ShowDialog();
            }
        }

        private void bntBatDau_Click(object sender, EventArgs e)
        {
            try
            {
                string pathName = ListView1.SelectedItems[0].Tag.ToString();
                if (pathName == "bai1")
                {
                    Phan2.Bai01 frm = new Phan2.Bai01();
                    frm.ShowDialog();
                }
                if (pathName == "bai2")
                {
                    Phan2.Bai02 frm = new Phan2.Bai02();
                    frm.ShowDialog();
                }
                if (pathName =="bai3")
                {
                    Phan2.Bai03 frm = new Phan2.Bai03();
                    frm.ShowDialog();
                }
                if (pathName == "bai4")
                {
                    Phan2.Bai04 frm = new Phan2.Bai04();
                    frm.ShowDialog();
                }
                if (pathName == "bai5")
                {
                    Phan2.Bai05 frm = new Phan2.Bai05();
                    frm.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Bạn hãy chọn bài học cho mình!!");
            }
      
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
