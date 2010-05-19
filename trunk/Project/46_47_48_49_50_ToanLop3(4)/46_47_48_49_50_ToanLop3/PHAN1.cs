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
    public partial class PHAN1 : Form
    {
        UserControl[] myUserControls;
        int nUserCTs;
        enum ScreenState
        {
            MucLuc1,
            Bai1,
            Bai2,
            Bai3,
            Bai4,
            Bai5,
            Bai6,
            Bai7,
            Bai8,
            Bai9,
            Bai10,
            Bai11,
            Bai12,
            Bai13,
            Bai14,
            Bai15,
            Bai16,
        };
        ScreenState currentState;
        public PHAN1()
        {
            InitializeComponent();
        }

        private void PHAN1_Load(object sender, EventArgs e)
        {
            nUserCTs = 17;
            myUserControls = new UserControl[17];
            myUserControls[0] = new Phan1.Bai01();
            myUserControls[1] = new Phan1.Bai02();
            myUserControls[2] = new Phan1.Bai03();
            myUserControls[3] = new Phan1.Bai04();
            myUserControls[4] = new Phan1.Bai05();
            myUserControls[5] = new Phan1.Bai06();
            myUserControls[6] = new Phan1.Bai07();
            myUserControls[7] = new Phan1.Bai08();
            myUserControls[8] = new Phan1.Bai09();
            myUserControls[9] = new Phan1.Bai10();
            myUserControls[10] = new Phan1.Bai11();
            myUserControls[11] = new Phan1.Bai12();
            myUserControls[12] = new Phan1.Bai13();
            myUserControls[13] = new Phan1.Bai14();
            myUserControls[14] = new Phan1.Bai15();
            myUserControls[15] = new Phan1.Bai16();
            myUserControls[16] = new Phan1.MucLuc1();

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
                    myUserControls[16].Show();
                    break;
                case ScreenState.Bai1:
                    myUserControls[0].Show();
                    break;
                case ScreenState.Bai2:
                    myUserControls[1].Show();
                    break;
                case ScreenState.Bai3:
                    myUserControls[2].Show();
                    break;

                case ScreenState.Bai16:
                    myUserControls[15].Show();
                    break;
                case ScreenState.Bai4:
                    myUserControls[3].Show();
                    break;
                case ScreenState.Bai5:
                    myUserControls[4].Show();
                    break;
                case ScreenState.Bai6:
                    myUserControls[5].Show();
                    break;
                case ScreenState.Bai7:
                    myUserControls[6].Show();
                    break;
                case ScreenState.Bai8:
                    myUserControls[7].Show();
                    break;
                case ScreenState.Bai9:
                    myUserControls[8].Show();
                    break;
                case ScreenState.Bai10:
                    myUserControls[9].Show();
                    break;
                case ScreenState.Bai11:
                    myUserControls[10].Show();
                    break;
                case ScreenState.Bai12:
                    myUserControls[11].Show();
                    break;
                case ScreenState.Bai13:
                    myUserControls[12].Show();
                    break;
                case ScreenState.Bai14:
                    myUserControls[13].Show();
                    break;
                case ScreenState.Bai15:
                    myUserControls[14].Show();
                    break;

            }

        }

        private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentState = ScreenState.Bai1;
            UpdateSreen();
        }

        private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentState = ScreenState.Bai2;
            UpdateSreen();
        }

        private void bai3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentState = ScreenState.Bai3;
            UpdateSreen();
        }

        private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentState = ScreenState.Bai4;
            UpdateSreen();
        }

        private void bài5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentState = ScreenState.Bai5;
            UpdateSreen();
        }

        private void bài6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentState = ScreenState.Bai6;
            UpdateSreen();
        }

        private void bài7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentState = ScreenState.Bai7;
            UpdateSreen();
        }

        private void bai8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentState = ScreenState.Bai8;
            UpdateSreen();
        }

        private void bài9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentState = ScreenState.Bai9;
            UpdateSreen();
        }

        private void bài10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentState = ScreenState.Bai10;
            UpdateSreen();
        }

        private void bai11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentState = ScreenState.Bai11;
            UpdateSreen();
        }

        private void bài12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentState = ScreenState.Bai12;
            UpdateSreen();
        }

        private void bài13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentState = ScreenState.Bai13;
            UpdateSreen();
        }

        private void bài14ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentState = ScreenState.Bai14;
            UpdateSreen();
        }

        private void bài15ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentState = ScreenState.Bai15;
            UpdateSreen();
        }

        private void bài16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentState = ScreenState.Bai16;
            UpdateSreen();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
    }
}
