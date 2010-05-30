using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan2.Bai1.LuyenTap
{
    public partial class LuyenTapBT11 : Form
    {
        public LuyenTapBT11()
        {
            InitializeComponent();
        }

        private void LuyenTapBT11_Load(object sender, EventArgs e)
        {

        }
        private void btnXong1_Click(object sender, EventArgs e)
        {
            lbl1.Visible = true;
            if (txt1.Text == "5")
            {
                lbl1.Text = "Bạn Làm Đúng";
            }
            else
            {
                lbl1.Text = "Bạn Làm Sai!!!!!";
            }
        }

        private void btnXong2_Click(object sender, EventArgs e)
        {
            lbl1.Visible = true;
            if (txt2.Text == "4" && txt1a.Text=="24")
            {
                lbl1.Text = "Bạn Làm Đúng";
            }
            else
            {
                lbl1.Text = "Bạn Làm Sai!!!!!";
            }
        }

        private void btnKT_Click(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            txt11.Visible = true;
            txt22.Visible = true;
            txt1b.Visible = true;
 
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            txt11.Visible = false;
            txt22.Visible = false;
            txt1b.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblErr2b.Visible = true;
            if (txt2b.Text == "20")
            {
                lblErr2b.Text = "Đúng";
            }
            else
            {
                lblErr2b.Text = "Sai";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblErr2b.Visible = false;
            richTextBox2.Visible = true;
            txt2b.Text = "20";
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblErr2b.Visible = false;
            txt2b.Text = "";
            richTextBox2.Visible = false;
            button1.Visible = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnQuayLaiPhan2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
