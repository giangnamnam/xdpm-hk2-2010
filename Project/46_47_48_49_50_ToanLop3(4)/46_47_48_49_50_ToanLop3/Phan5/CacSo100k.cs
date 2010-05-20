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
    public partial class CacSo100k : Form
    {
        public CacSo100k()
        {
            InitializeComponent();
        }
      

        private void btBai1_Click(object sender, EventArgs e)
        {
           
           
        }

        private void btBai2_Click(object sender, EventArgs e)
        {
           
        }

        private void btBai3_Click(object sender, EventArgs e)
        {
           
        }

        private void btBai4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btBai1_Click_1(object sender, EventArgs e)
        {
            Phan5.Bai1.Bai01a fr = new Phan5.Bai1.Bai01a();
            fr.Show();
        }

        private void btBai2_Click_1(object sender, EventArgs e)
        {
            Phan5.Bai1.Bai01b fr = new Phan5.Bai1.Bai01b();
            fr.Show();
        }

        private void btBai3_Click_1(object sender, EventArgs e)
        {
            Phan5.Bai1.Bài_2 fr = new Phan5.Bai1.Bài_2();
            fr.Show();
        }

        private void btBai4_Click_1(object sender, EventArgs e)
        {

            Phan5.Bai1.Bai03a fr = new Phan5.Bai1.Bai03a();
            fr.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Phan5.Bai1.Bai03b fr = new Phan5.Bai1.Bai03b();
            fr.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Phan5.Bai1.Bai04 fr = new Phan5.Bai1.Bai04();
            fr.Show();
        }
    }
}
