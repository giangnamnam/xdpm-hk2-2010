﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan5
{
    public partial class CacSoDen100ktt : Form
    {
        public CacSoDen100ktt()
        {
            InitializeComponent();
        }

        private void Bai1_Click(object sender, EventArgs e)
        {
            Phan5.BaiOnTap2.Bai01 fr = new Phan5.BaiOnTap2.Bai01();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Phan5.BaiOnTap2.Bai02 fr = new Phan5.BaiOnTap2.Bai02();
            

                fr.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Phan5.BaiOnTap2.Bai03 fr = new Phan5.BaiOnTap2.Bai03();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Phan5.BaiOnTap2.Bai04 fr = new Phan5.BaiOnTap2.Bai04();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Phan5.BaiOnTap2.Bai05 fr = new Phan5.BaiOnTap2.Bai05();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
