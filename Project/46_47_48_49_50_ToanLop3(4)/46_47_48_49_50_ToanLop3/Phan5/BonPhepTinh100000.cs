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
    public partial class BonPhepTinh100000 : Form
    {
        public BonPhepTinh100000()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Phan5.BaiOnTap3.Bai01 fr = new Phan5.BaiOnTap3.Bai01();
            fr.Show();
        }
    }
}
