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
    public partial class PHAN5 : Form
    {
         //UserControl[] myUserControls;
        //int nUserCTs;
        enum ScreenState
        {
            MucLuc1,
            Bai1,
            
        };
        //ScreenState currentState;
         private void PHAN5_Load(object sender, EventArgs e)
        {
          
        }
        public PHAN5()
        {
            InitializeComponent();
        }
        void UpdateSreen()
        {
            
        }
        private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
//             currentState = ScreenState.Bai01;
//             UpdateSreen();
        }

        private void chọnBàiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bài1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void bài1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void bài2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void btCacSo100000_Click(object sender, EventArgs e)
        {
            Phan5.CacSo fr = new Phan5.CacSo();
            fr.Show();
        }

        private void btDaiLuong_Click(object sender, EventArgs e)
        {
            Phan5.HinhHoc.Bai01 fr = new Phan5.HinhHoc.Bai01();
            fr.Show();
        }

        private void btCacSoDen100000tt_Click(object sender, EventArgs e)
        {
            Phan5.CacSoTT fr = new Phan5.CacSoTT();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Phan5.BonPhepTinh fr = new Phan5.BonPhepTinh();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Phan5.BonPhepTinhTTT fr = new Phan5.BonPhepTinhTTT();
            fr.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
