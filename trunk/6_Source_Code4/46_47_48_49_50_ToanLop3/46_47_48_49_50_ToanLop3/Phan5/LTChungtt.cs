using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan5
{
    public partial class LTChungtt : Form
    {
        public LTChungtt()
        {
            InitializeComponent();
        }

        private void btnQLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnBai01_Click(object sender, EventArgs e)
        {
            Phan5.LuyenTapChungtt.Bai01 fr = new Phan5.LuyenTapChungtt.Bai01();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Phan5.LuyenTapChungtt.Bai02 fr = new Phan5.LuyenTapChungtt.Bai02();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Phan5.LuyenTapChungtt.Bai03 fr = new Phan5.LuyenTapChungtt.Bai03();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Phan5.LuyenTapChungtt.Bai04 fr = new Phan5.LuyenTapChungtt.Bai04();
            fr.Show();
        }
    }
}
