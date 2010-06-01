using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan5.LuyenTapChung_1
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private void Bai03_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "10" && txt2.Text == "18")
            {
                lbl1.Text = "Đúng";
            }
            else
            {
                lbl1.Text = "Sai";
            }
            if ((txt3.Text == "2" && txt4.Text == "50" ))
            {
                lbl2.Text = "Đúng";
            }
            else
            {
                lbl2.Text = "Sai";
            }
            if ((txt5.Text == "6" && txt6.Text == "35"))
            {
                lbl3.Text = "Đúng";
            }
            else
            {
                lbl3.Text = "Sai";
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Text = " 10";
            txt2.Text = " 18";
            txt3.Text = " 2";
            txt4.Text = " 50";
            txt5.Text = " 6";
            txt6.Text = " 35";
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
        }
    }
}
