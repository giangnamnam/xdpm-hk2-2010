using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan5.Bai1
{
    public partial class Bai01a : Form
    {
        public Bai01a()
        {
            InitializeComponent();
        }

        private void btLamXong_Click(object sender, EventArgs e)
        {
           
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btLamLai_Click(object sender, EventArgs e)
        {
           

        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLamXong_Click_1(object sender, EventArgs e)
        {
            if ((tb3.Text == "30 000") || (tb3.Text == "30000"))
            {
                label7.Text = "Đúng(30 000)";
            }
            else
            {
                label7.Text = "Sai";
            }
            if ((tb4.Text == "40 000") || (tb4.Text == "40000"))
            {
                label8.Text = "Đúng(40 000)";
            }
            else
            {
                label8.Text = "Sai";
            }
            if ((tb5.Text == "50 000") || (tb5.Text == "50000"))
            {
                label9.Text = "Đúng(50 000)";
            }
            else
            {
                label9.Text = "Sai";
            }
            if ((tb7.Text == "70 000") || (tb7.Text == "70000"))
            {
                label10.Text = "Đúng(70 000)";
            }
            else
            {
                label10.Text = "Sai";
            }
            if ((tb8.Text == "80 000") || (tb8.Text == "80000"))
            {
                label11.Text = "Đúng(80 000)";
            }
            else
            {
                label11.Text = "Sai";
            }
            if ((tb9.Text == "90 000") || (tb9.Text == "90000"))
            {
                label12.Text = "Đúng(90 000)";
            }
            else
            {
                label12.Text = "Sai";
            }
            if ((tb10.Text == "100 000") || (tb10.Text == "100000"))
            {
                label13.Text = "Đúng(100 000)";
            }
            else
            {
                label13.Text = "Sai";
            }
        }

        private void btLamLai_Click_1(object sender, EventArgs e)
        {
            tb3.Text = tb4.Text = tb5.Text = tb7.Text = tb8.Text = tb9.Text = tb10.Text = "";
            label7.Text = label8.Text = label9.Text = label10.Text = label11.Text = label12.Text = label13.Text = "Điền vào";
        }

        private void btQuayLai_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
