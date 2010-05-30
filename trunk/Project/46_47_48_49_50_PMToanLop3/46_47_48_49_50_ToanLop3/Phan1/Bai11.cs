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
    public partial class Bai11 : UserControl
    {
        UserControl[] myUsercontrol;
        int nUsct;

        enum ScreenState { ChonBT, BaiTap1, BaiTap2, BaiTap3, BaiTap4 };
        ScreenState currentScreen;
        public Bai11()
        {
            InitializeComponent();
        }

        private void Bai11_Load(object sender, EventArgs e)
        {
            nUsct = 4;
            myUsercontrol = new UserControl[5];

            myUsercontrol[0] = new Phan1.Bai_11.BaiTap1();
            myUsercontrol[1] = new Phan1.Bai_11.BaiTap2();
            myUsercontrol[2] = new Phan1.Bai_11.BaiTap3();
            myUsercontrol[3] = new Phan1.Bai_11.BaiTap4();


            for (int i = 0; i < nUsct; i++)
            {
                pnbai11.Controls.Add(myUsercontrol[i]);
                myUsercontrol[i].Dock = DockStyle.Fill;
            }
            currentScreen = ScreenState.ChonBT;
            UpdateScreen();
        }
        void UpdateScreen()
        {
            for (int i = 0; i < nUsct; i++)
            {
                myUsercontrol[i].Hide();
            }
            switch (currentScreen)
            {
                case ScreenState.BaiTap1:
                    myUsercontrol[0].Show();
                    break;
                case ScreenState.BaiTap2:
                    myUsercontrol[1].Show();
                    break;
                case ScreenState.BaiTap3:
                    myUsercontrol[2].Show();
                    break;
                case ScreenState.BaiTap4:
                    myUsercontrol[3].Show();
                    break;
                case ScreenState.ChonBT:
                    for (int i = 0; i < nUsct; i++)
                    {
                        myUsercontrol[i].Hide();
                    }
                    break;
            }
        }

        private void btBaiTap4_Click(object sender, EventArgs e)
        {
            currentScreen = ScreenState.BaiTap4;
            UpdateScreen();
        }

        private void btBaiTap3_Click(object sender, EventArgs e)
        {
            currentScreen = ScreenState.BaiTap3;
            UpdateScreen();
        }

        private void btBaiTap2_Click(object sender, EventArgs e)
        {
            currentScreen = ScreenState.BaiTap2;
            UpdateScreen();
        }

        private void btBaiTap1_Click(object sender, EventArgs e)
        {
            currentScreen = ScreenState.BaiTap1;
            UpdateScreen();
        }

        private void btChonBT_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
