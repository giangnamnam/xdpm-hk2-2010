using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan5.HinhHoc
{
    public partial class HinhHoc : Form
    {
        public HinhHoc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Phan5.HinhHoc.Bai1 fr = new Phan5.HinhHoc.Bai1();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Phan5.HinhHoc.Bai2 fr = new Phan5.HinhHoc.Bai2();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Phan5.HinhHoc.Bai3 fr = new Phan5.HinhHoc.Bai3();
            fr.Show();
        }
    }
}
