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
    public partial class MucLuc : Form
    {
        public MucLuc()
        {
            InitializeComponent();
        }

        private void bntBatDau_Click(object sender, EventArgs e)
        {
            try
            {
                string pathName = ListView1.SelectedItems[0].Tag.ToString();
                if (pathName == "phan1")
                {
                    PHAN1 frm = new PHAN1();
                    frm.ShowDialog();
                }
                if (pathName == "phan2")
                {
                    PHAN2 frm = new PHAN2();
                    frm.ShowDialog();
                }
                if (pathName == "phan3")
                {
                    PHAN3 frm = new PHAN3();
                    frm.ShowDialog();
                }
                if (pathName == "phan4")
                {
                    PHAN4 frm = new PHAN4();
                    frm.Show();
                }
                if (pathName == "phan5")
                {
                    PHAN5 frm = new PHAN5();
                    frm.Show();
                }

                if (pathName == "baiTapThem")
                {
                    BAITAPTHEM frm = new BAITAPTHEM();
                    frm.Show();
                }
            }
            catch 
            {
                MessageBox.Show("Bạn hãy chọn phần để học!!!");
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string pathName = ListView1.SelectedItems[0].Tag.ToString();
                if (pathName == "phan1")
                {
                    PHAN1 frm = new PHAN1();
                    frm.ShowDialog();
                }
                if (pathName == "phan2")
                {
                    PHAN2 frm = new PHAN2();
                    frm.ShowDialog();
                }
                if (pathName == "phan3")
                {
                    PHAN3 frm = new PHAN3();
                    frm.ShowDialog();
                }
                if (pathName == "phan4")
                {
                    PHAN4 frm = new PHAN4();
                    frm.Show();
                }
                if (pathName == "phan5")
                {
                    PHAN5 frm = new PHAN5();
                    frm.Show();
                }

                if (pathName == "baiTapThem")
                {
                    BAITAPTHEM frm = new BAITAPTHEM();
                    frm.Show();
                }
            }
            catch
            {
                MessageBox.Show("Bạn hãy chọn phần để học!!!");
            }
        }

        private void MucLuc_Load(object sender, EventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
