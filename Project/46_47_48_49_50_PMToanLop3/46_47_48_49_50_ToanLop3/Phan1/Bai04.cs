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
    public partial class Bai04 : UserControl
    {
        UserControl[] UserCT;
        int nUserCT;
        enum ScreenState { Temp, BaiTap12, BaiTap34, Lythuyet, LuyenTap };

        ScreenState currentState;

        public Bai04()
        {
            InitializeComponent();
        }

        private void btLyThuyet_Click(object sender, EventArgs e)
        {
            currentState = ScreenState.Lythuyet;
            UpdateScreen();
        }

        private void Bai04_Load(object sender, EventArgs e)
        {

            UserCT = new UserControl[4];
            nUserCT = 4;
            UserCT[0] = new Phan1.Bai4.BaiTap12();
            UserCT[1] = new Phan1.Bai4.BaiTap34();
            UserCT[2] = new Phan1.Bai4.LuyenTap();
            UserCT[3] = new Phan1.Bai4.LyThuyet();
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
                case ScreenState.BaiTap12:
                    UserCT[0].Show();

                    break;

                case ScreenState.BaiTap34:
                    UserCT[1].Show();

                    break;

                case ScreenState.LuyenTap:
                    UserCT[2].Show();

                    break;

                case ScreenState.Lythuyet:
                    UserCT[3].Show();

                    break;
                case ScreenState.Temp:
                    break;

            }

        }

        private void btBaiTap12_Click(object sender, EventArgs e)
        {
            currentState = ScreenState.BaiTap12;
            UpdateScreen();
        }

        private void btBaiTap34_Click(object sender, EventArgs e)
        {
            currentState = ScreenState.BaiTap34;
            UpdateScreen();
        }

        private void btLuyenTap_Click(object sender, EventArgs e)
        {
            currentState = ScreenState.LuyenTap;
            UpdateScreen();
        }
    }
}
