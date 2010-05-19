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
    public partial class PHAN4 : Form
    {
        public PHAN4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btBatDau_Click(object sender, EventArgs e)
        {
            try
            {
                string pathName = listView1.SelectedItems[0].Tag.ToString();
                if (pathName == "bai1")
                {
                    Phan4.Bai1 frm = new Phan4.Bai1();
                    frm.ShowDialog();
                }
                if (pathName == "bai2")
                {
                    Phan4.Bai2 frm = new Phan4.Bai2();
                    frm.ShowDialog();
                }
                if (pathName == "bai3")
                {
                    Phan4.SoSanh frm = new Phan4.SoSanh();
                    frm.ShowDialog();
                }
                if (pathName == "bai4")
                {
                    Phan4.TinhDienTichFrm frm = new Phan4.TinhDienTichFrm();
                    frm.ShowDialog();
                }
                if (pathName == "bai5")
                {
                    Phan4.DaySoFrm frm = new Phan4.DaySoFrm();
                    frm.ShowDialog();
                }
                if (pathName=="bai6")
                {
                    Phan4.PHAN4_11 frm = new Phan4.PHAN4_11();
                    frm.ShowDialog();

                } if (pathName == "bai7")
                {
                    Phan4.PHAN4_12 frm = new Phan4.PHAN4_12();
                    frm.ShowDialog();

                } 
                if (pathName == "bai8")
                {
                    Phan4.PHAN4_13 frm = new Phan4.PHAN4_13();
                    frm.ShowDialog();

                }
                 if (pathName == "bai1lt")
                {
                    Phan4.PHAN4_5ChuSo frm = new Phan4.PHAN4_5ChuSo();
                    frm.ShowDialog();

                }
               
            }
            catch
            {
                MessageBox.Show("Bạn hãy chọn bài học cho mình!!");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PHAN4_Load(object sender, EventArgs e)
        {

        }
    }
}
