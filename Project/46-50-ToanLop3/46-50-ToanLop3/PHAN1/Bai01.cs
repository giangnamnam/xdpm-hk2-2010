using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_50_ToanLop3.PHAN1
{
    public partial class Bai01 : UserControl
    {
        UserControl[] UserCT;
        int nUserCT;
        enum ScreenState { Temp,BaiTap1, BaiTap2 };
        ScreenState currentState;
        public Bai01()
        {
            InitializeComponent();
        }

        private void btBT1_Click(object sender, EventArgs e)
        {
            currentState = ScreenState.BaiTap1;
            UpdateScreen();
        }

        private void Bai01_Load(object sender, EventArgs e)
        {
            UserCT = new UserControl[2];
            nUserCT = 2;
            UserCT[0] = new PHAN1.Bai1.BaiTap1();
            UserCT[1] = new PHAN1.Bai1.BaiTap2();
            for (int i = 0; i < nUserCT; i++)
            {
               pnBaiTap.Controls.Add(UserCT[i]);
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
            }
        }

        private void btBT2_Click(object sender, EventArgs e)
        {
            currentState = ScreenState.BaiTap2;
            UpdateScreen();
        }
    }
}
