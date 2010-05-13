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
    public partial class Bai01 : UserControl
    {

        UserControl[] UserCT;
        int nUserCT;
        enum ScreenState { Temp, BaiTap1, BaiTap2, BaiTap3, BaiTap4, BaiTap5 };

        ScreenState currentState;
        public Bai01()
        {
            InitializeComponent();
        }

        private void Bai01_Load(object sender, EventArgs e)
        {

            UserCT = new UserControl[5];
            nUserCT = 5;
            UserCT[0] = new Phan1.Bai1.BaiTap1();
            UserCT[1] = new Phan1.Bai1.BaiTap2();
            UserCT[2] = new Phan1.Bai1.BaiTap3();
            UserCT[3] = new Phan1.Bai1.BaiTap4();
            UserCT[4] = new Phan1.Bai1.BaiTap5();

            for (int i = 0; i < nUserCT; i++)
            {
                Controls.Add(UserCT[i]);
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
            btBaiTap1.Hide();
            btBaiTap2.Hide();
            btBaiTap3.Hide();
            btBaiTap4.Hide();
            btBaiTap5.Hide();

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
                    btBaiTap1.Hide();
                    btBaiTap2.Hide();
                    btBaiTap3.Hide();
                    btBaiTap4.Hide();
                    btBaiTap5.Hide();

                    break;
                case ScreenState.Temp:
                    btBaiTap1.Show();
                    btBaiTap2.Show();
                    btBaiTap3.Show();
                    btBaiTap4.Show();
                    btBaiTap5.Show();
                    break;

            }
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

        private void btBaiTap5_Click(object sender, EventArgs e)
        {

            currentState = ScreenState.BaiTap5;
            UpdateScreen();
        }

        private void btBaiTap_Click(object sender, EventArgs e)
        {
            currentState = ScreenState.Temp;
            UpdateScreen();
        }

    }
}
