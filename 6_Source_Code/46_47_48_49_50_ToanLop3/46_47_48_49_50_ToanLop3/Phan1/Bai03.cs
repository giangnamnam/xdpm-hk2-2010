using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan1
{
    public partial class Bai03 : UserControl
    {
        UserControl[] UserCT;
        int nUserCT;
        enum ScreenState { Temp, BaiTap1, BaiTap2, BaiTap3, BaiTap4, BaiTap5, Lythuyet, LuyenTap };

        ScreenState currentState;

        public Bai03()
        {
            InitializeComponent();
        }

        private void Bai03_Load(object sender, EventArgs e)
        {
            UserCT = new UserControl[7];
            nUserCT = 7;
            UserCT[0] = new Phan1.Bai3.BaiTap1();
            UserCT[1] = new Phan1.Bai3.BaiTap2();
            UserCT[2] = new Phan1.Bai3.BaiTap3();
            UserCT[3] = new Phan1.Bai3.BaiTap4();
            UserCT[4] = new Phan1.Bai3.BaiTap5();
            UserCT[5] = new Phan1.Bai3.LuyenTap();
            UserCT[6] = new Phan1.Bai3.LyThuyet();
            for (int i = 0; i < nUserCT; i++)
            {
                pnBai1.Controls.Add(UserCT[i]);
                UserCT[i].Dock = DockStyle.Fill;
            }
            currentState = ScreenState.Temp;
            UpdateScreen();
        }
        void UpdateScreen()
        {
            for (int i = 0; i < nUserCT; i++)
            {
                UserCT[i].Hide();
            }


            switch (currentState)
            {
                case ScreenState.BaiTap1:
                    UserCT[0].Show();

                    break;

                case ScreenState.BaiTap2:
                    UserCT[1].Show();

                    break;

                case ScreenState.BaiTap3:
                    UserCT[2].Show();

                    break;

                case ScreenState.BaiTap4:
                    UserCT[3].Show();

                    break;
                case ScreenState.BaiTap5:
                    UserCT[4].Show();

                    break;
                case ScreenState.LuyenTap:
                    UserCT[5].Show();
                    break;
               
                case ScreenState.Lythuyet:
                    UserCT[6].Show();
                    break;
                case ScreenState.Temp:

                    break;

            }

        }

        private void btLyThuyet_Click(object sender, EventArgs e)
        {
            currentState = ScreenState.Lythuyet;
            UpdateScreen();
        }

        private void btBaiTap1_Click(object sender, EventArgs e)
        {
            currentState = ScreenState.BaiTap1;
            UpdateScreen();
        }

        private void btBaiTap2_Click(object sender, EventArgs e)
        {
            currentState = ScreenState.BaiTap2;
            UpdateScreen();
        }

        private void btBaiTap3_Click(object sender, EventArgs e)
        {
            currentState = ScreenState.BaiTap3;
            UpdateScreen();
        }

        private void btBaiTap4_Click(object sender, EventArgs e)
        {
            currentState = ScreenState.BaiTap4;
            UpdateScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentState = ScreenState.LuyenTap;
            UpdateScreen();
        }

        private void btBaiTap5_Click(object sender, EventArgs e)
        {
            currentState = ScreenState.BaiTap5;
            UpdateScreen();
        }

    }
}
