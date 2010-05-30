using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace _46_47_48_49_50_ToanLop3
{
    public partial class PHAN2 : Form
    {

        public PHAN2()
        {
            InitializeComponent();
        }

        private void PHAN2_Load(object sender, EventArgs e)
        {
        }
       
        private void bài01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phan2.Bai01 frm = new Phan2.Bai01();
            frm.ShowDialog();
        }

        private void bài02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phan2.Bai02 frm = new Phan2.Bai02();
            frm.ShowDialog();

        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string pathName = ListView1.SelectedItems[0].Tag.ToString();
                if (pathName == "bai1")
                {
                    Phan2.Bai01 frm = new Phan2.Bai01();
                    frm.ShowDialog();
                }
                if (pathName == "bai2")
                {
                    Phan2.Bai02 frm = new Phan2.Bai02();
                    frm.ShowDialog();
                }
                if (pathName == "bai3")
                {
                    Phan2.Bai03 frm = new Phan2.Bai03();
                    frm.ShowDialog();
                }
                if (pathName == "bai4")
                {
                    Phan2.Bai04 frm = new Phan2.Bai04();
                    frm.ShowDialog();
                }
                if (pathName == "bai5")
                {
                    Phan2.Bai05 frm = new Phan2.Bai05();
                    frm.ShowDialog();
                }
                if (pathName == "bai6")
                {
                    Phan2.Bai06 frm = new Phan2.Bai06();
                    frm.ShowDialog();
                }
                if (pathName == "bai7")
                {
                    Phan2.Bai07 frm = new Phan2.Bai07();
                    frm.ShowDialog();
                }
                if (pathName == "bai8")
                {
                    Phan2.Bai08 frm = new Phan2.Bai08();
                    frm.ShowDialog();
                }
                if (pathName == "bai9")
                {
                    Phan2.Bai09 frm = new Phan2.Bai09();
                    frm.ShowDialog();
                }
                if (pathName == "bai10")
                {
                    Phan2.Bai10 frm = new Phan2.Bai10();
                    frm.ShowDialog();
                }
                if (pathName == "bai11")
                {
                    Phan2.Bai11 frm = new Phan2.Bai11();
                    frm.ShowDialog();
                }
                if (pathName == "bai12")
                {
                    Phan2.Bai12 frm = new Phan2.Bai12();
                    frm.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Bạn hãy chọn bài học cho mình!!");
            }
      
        }

        private void bntBatDau_Click(object sender, EventArgs e)
        {
            try
            {
                string pathName = ListView1.SelectedItems[0].Tag.ToString();
                if (pathName == "bai1")
                {
                    Phan2.Bai01 frm = new Phan2.Bai01();
                    frm.ShowDialog();
                }
                if (pathName == "bai2")
                {
                    Phan2.Bai02 frm = new Phan2.Bai02();
                    frm.ShowDialog();
                }
                if (pathName =="bai3")
                {
                    Phan2.Bai03 frm = new Phan2.Bai03();
                    frm.ShowDialog();
                }
                if (pathName == "bai4")
                {
                    Phan2.Bai04 frm = new Phan2.Bai04();
                    frm.ShowDialog();
                }
                if (pathName=="bai5")
                {
                    Phan2.Bai05 frm = new Phan2.Bai05();
                    frm.ShowDialog();
                }
                if (pathName=="bai6")
                {
                    Phan2.Bai06 frm = new Phan2.Bai06();
                    frm.ShowDialog();
                }
                if (pathName == "bai7")
                {
                    Phan2.Bai07 frm = new Phan2.Bai07();
                    frm.ShowDialog();
                }
                if (pathName=="bai8")
                {
                    Phan2.Bai08 frm=new Phan2.Bai08();
                    frm.ShowDialog();
                }
                if (pathName == "bai9")
                {
                    Phan2.Bai09 frm = new Phan2.Bai09();
                    frm.ShowDialog();
                } 
                if (pathName == "bai10")
                {
                    Phan2.Bai10 frm = new Phan2.Bai10();
                    frm.ShowDialog();
                }
                if (pathName == "bai11")
                {
                    Phan2.Bai11 frm = new Phan2.Bai11();
                    frm.ShowDialog();
                }
                if (pathName == "bai12")
                {
                    Phan2.Bai12 frm = new Phan2.Bai12();
                    frm.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Bạn hãy chọn bài học cho mình!!");
            }
      
        }

        private void btnThoat_Click(object sender, EventArgs e)
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

        private void btnGiaiTri_Click(object sender, EventArgs e)
        {
            Phan2.GiaiTri frm = new Phan2.GiaiTri();
            frm.ShowDialog();
        }
    }
}
