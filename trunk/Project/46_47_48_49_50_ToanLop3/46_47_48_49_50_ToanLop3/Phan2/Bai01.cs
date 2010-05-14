using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan2
{
    public partial class Bai01 : UserControl
    {
        UserControl[] UserCT;
        int nUserCT;
        enum ScreenState { Temp, BaiTap1, BaiTap2, BaiTap3, BaiTap4, BaiTap5 };
        ScreenState currenState;
        public Bai01()
        {
            InitializeComponent();
        }

        private void Bai01_Load(object sender, EventArgs e)
        {
            UserCT = new UserControl[5];
            nUserCT = 5;
            UserCT[0] = new Phan2.Bai1.BaiTap1();
            UserCT[1] = new Phan2.Bai1.BaiTap2();
            UserCT[2] = new Phan2.Bai1.BaiTap3();
            UserCT[3] = new Phan2.Bai1.BaiTap4();
            UserCT[4] = new Phan2.Bai1.BaiTap5();

        }

    }
}
