using System;
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
        UserControl[] myUserControls;
        int nUserCTs;
        enum ScreenState
        {
            MucLuc1,
            Bai1,
            Bai2,
        };
        ScreenState currentState;
        public PHAN2()
        {
            InitializeComponent();
        }

        private void PHAN2_Load(object sender, EventArgs e)
        {
            nUserCTs = 2;
            myUserControls = new UserControl[2];
            myUserControls[0] = new Phan2.Bai01();
            myUserControls[1] = new Phan2.Bai02();
            for (int i = 0; i < nUserCTs; i++)
            {
                Controls.Add(myUserControls[i]);
                myUserControls[i].Dock = DockStyle.Fill;
            }
            currentState = ScreenState.MucLuc1;
            UpdateSreen();
        }
        void UpdateSreen()
        {
            for (int i = 0; i < nUserCTs; i++)
            {
                myUserControls[i].Hide();
            }
            switch (currentState)
            {
                case ScreenState.MucLuc1:
                    myUserControls[1].Show();
                    break;
                case ScreenState.Bai1:
                    myUserControls[0].Show();
                    break;
                case ScreenState.Bai2:
                    myUserControls[1].Show();
                    break;
                //case ScreenState.Bai3:
                //    myUserControls[2].Show();
                //    break;

                //case ScreenState.Bai16:
                //    myUserControls[15].Show();
                //    break;
            }

        }
    }
}
