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
    public partial class Bai01b : Form
    {
        public Bai01b()
        {
            InitializeComponent();
        }

        private void btLamXong_Click(object sender, EventArgs e)
        {

        }

        private void btLamXong_Click_1(object sender, EventArgs e)
        {
            if((tb90.Text=="90 000")||(tb90.Text=="90000"))
            {
                label3.Text = "Đúng (90 000)";
            }
            else
            {
                label3.Text = "Sai";
            }
            if ((tb95.Text == "95 000") || (tb95.Text == "95000"))
            {
                label7.Text = "Đúng (95 000)";
            }
            else
            {
                label7.Text = "Sai";
            }
            if ((tb100.Text == "100 000") || (tb100.Text == "100000"))
            {
                label8.Text = "Đúng (100 000)";
            }
            else
            {
                label8.Text = "Sai";
            }
        }

        private void btLamLai_Click(object sender, EventArgs e)
        {
            tb90.Text = tb95.Text = tb100.Text = "";
            label3.Text = label7.Text = label8.Text = "Điền vào";
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }

        }
    }
}
