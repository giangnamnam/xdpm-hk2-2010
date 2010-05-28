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
    public partial class LuyenTapBT5_tieptheo_ : Form
    {
        public LuyenTapBT5_tieptheo_()
        {
            InitializeComponent();
        }
        private void btnDaLamBt2_Click(object sender, EventArgs e)
        {

            lblError2.Text = "";
            lblError2.Visible = true; btnLamLaibt2.Visible = false;
            if (txtbt2.Text != "7")
            {
                lblError2.Text += "Sai";
            }
            else
            {
                lblError2.Text += "Đúng";
                btnLamLaibt2.Visible = true;
            }
        }

        private void btnLamLaibt2_Click(object sender, EventArgs e)
        {
            richTextBox2.Visible = false;
            btnDaLamBt2.Visible = true;
            btnLamLaibt2.Visible = false;
            txtbt2.Text = "";
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LuyenTapBT5_tieptheo_ frm = new LuyenTapBT5_tieptheo_();
            frm.ShowDialog();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            richTextBox2.Visible = true;
            btnLamLaibt2.Visible = true;
            btnDaLamBt2.Visible = false;
            txtbt2.Text = "7";
        }

        private void btnQuayLaiPhan2_Click_1(object sender, EventArgs e)
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
        #region Bai 4
        private void btn1_Click(object sender, EventArgs e)
        {
            lbl1.Visible = true;
            lbl1.Text = "Sai";
            btn2.Visible = false; btn3.Visible = false; btn4.Visible = false;
            button1.Visible = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lbl3.Visible = true;
            lbl3.Text = "Sai";
            btn2.Visible = false; btn1.Visible = false; btn4.Visible = false;
            button1.Visible = true;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lbl4.Visible = true;
            lbl4.Text = "Sai";
            btn2.Visible = false; btn1.Visible = false; btn3.Visible = false;
            button1.Visible = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lbl2.Visible = true;
            lbl2.Text = "Đúng";
            btn4.Visible = false; btn1.Visible = false; btn3.Visible = false;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl1.Text = ""; lbl2.Text = ""; lbl3.Text = ""; lbl4.Text = "";
            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
            button1.Visible = false;
        }
        #endregion
      
    }
}
