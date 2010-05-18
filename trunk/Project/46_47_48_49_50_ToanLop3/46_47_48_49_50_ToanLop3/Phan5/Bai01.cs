using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan5.CacSoDen100_000
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void btLamXong_Click(object sender, EventArgs e)
        {
            if((tb30.Text=="30 000")||(tb30.Text=="30000"))
            {
                tb30.Text = "Đúng (30000)";
            }
            else
            {
                tb30.Text = "Sai";
            }
            if ((tb40.Text == "40 000") || (tb40.Text == "40000"))
            {
                tb40.Text = "Đúng (40000)";
            }
            else
            {
                tb40.Text = "Sai";
            }
            if ((tb50.Text == "50 000") || (tb50.Text == "50000"))
            {
                tb50.Text = "Đúng (50000)";
            }
            else
            {
                tb50.Text = "Sai";
            }
            if ((tb70.Text == "70 000") || (tb30.Text == "70000"))
            {
                tb70.Text = "Đúng (70000)";
            }
            else
            {
                tb70.Text = "Sai";
            }
            if ((tb80.Text == "80 000") || (tb80.Text == "80000"))
            {
                tb80.Text = "Đúng (80000)";
            }
            else
            {
                tb80.Text = "Sai";
            }
            if ((tb90.Text == "90 000") || (tb90.Text == "90000"))
            {
                tb90.Text = "Đúng (90000)";
            }
            else
            {
                tb90.Text = "Sai";
            }
            if ((tb100.Text == "100 000") || (tb100.Text == "100000"))
            {
                tb100.Text = "Đúng (100000)";
            }
            else
            {
                tb30.Text = "Sai";
            }
        }
    }
}
