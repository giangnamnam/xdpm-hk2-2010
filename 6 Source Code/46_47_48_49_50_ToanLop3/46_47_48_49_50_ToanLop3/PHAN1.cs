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
            Bai11
        };
        ScreenState currentState;
        public PHAN1()
        {
            InitializeComponent();
        }

        private void PHAN1_Load(object sender, EventArgs e)
        {
            nUserCTs = 12;
            myUserControls = new UserControl[12];
            myUserControls[0] = new Phan1.Bai01();
            myUserControls[1] = new Phan1.Bai02();
            myUserControls[2] = new Phan1.Bai03();
            myUserControls[3] = new Phan1.Bai04();
            myUserControls[4] = new Phan1.Bai05();
            myUserControls[5] = new Phan1.Bai07();
            myUserControls[6] = new Phan1.Bai08();
            myUserControls[7] = new Phan1.Bai09();
            myUserControls[8] = new Phan1.Bai10();
            myUserControls[9] = new Phan1.Bai11();
            myUserControls[10] = new Phan1.Bai12();
            myUserControls[11] = new Phan1.MucLuc1();

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
                    myUserControls[11].Show();
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

      

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }  
    }
}
