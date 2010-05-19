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
            Phan5.CacSoDen100000 fr = new Phan5.CacSoDen100000();
            fr.Show();
        }
    }
}
