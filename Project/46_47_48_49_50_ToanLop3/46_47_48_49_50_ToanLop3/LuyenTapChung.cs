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
    public partial class LuyenTapChung : Form
    {
        public LuyenTapChung()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Phan5.LuyenTapChung1.Bai01 fr = new Phan5.LuyenTapChung1.Bai01();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Phan5.LuyenTapChung_1.Bai2 fr = new Phan5.LuyenTapChung_1.Bai2();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Phan5.LuyenTapChung_1.Bai03 fr = new Phan5.LuyenTapChung_1.Bai03();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Phan5.LuyenTapChung_1.Bai04 fr = new Phan5.LuyenTapChung_1.Bai04();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Phan5.LuyenTapChung_1.Bai05 fr = new Phan5.LuyenTapChung_1.Bai05();
            fr.Show();
        }
    }
} 
