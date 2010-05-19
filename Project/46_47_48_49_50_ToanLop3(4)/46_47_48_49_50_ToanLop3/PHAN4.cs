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
    }
}
