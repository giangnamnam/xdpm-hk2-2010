using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan2.Bai1
{
    public partial class BaiTap7 : Form
    {
        public BaiTap7()
        {
            InitializeComponent();
        }

        private void BaiTap7_Load(object sender, EventArgs e)
        {

        }

        #region Bai 2
        private void button1_Click(object sender, EventArgs e)
        {
            lbl2a.Visible = true;
            lbl2a.Text = "Đúng";
            button2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            lbl2b.Visible = true;
            lbl2b.Text = "Sai";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void llbThucHanh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LuyenTap.LuyenTapBT7 frm = new LuyenTap.LuyenTapBT7();
            frm.ShowDialog();
        }

        private void btnQuayLaiPhan2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
      
        #region  Bai 1
        private void btnKiemTra1_Click(object sender, EventArgs e)
        {
            lblError1.Visible = false;
            txt1.Text = "5";
            txt2.Text = "6";
            txt3.Text = "6";
            txt13.Text = "1";
            txt4.Text = "4";
            txt14.Text = "4";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            lblError1.Visible = true;
            if (txt1.Text == "5")
            {
                lblError1.Text = "Đúng";
            }
            else
            {
                lblError1.Text = "Sai";
            }
        }

        private void btnDaLam1_Click(object sender, EventArgs e)
        {
            lblError1.Visible = true;
            if (txt2.Text == "6")
            {
                lblError1.Text = "Đúng";
            }
            else
            {
                lblError1.Text = "Sai";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblError1.Visible = true;
            if (txt3.Text == "6" && txt13.Text == "1")
            {
                lblError1.Text = "Đúng";
            }
            else
            {
                lblError1.Text = "Sai";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblError1.Visible = true;
            if (txt4.Text == "4" && txt14.Text == "4")
            {
                lblError1.Text = "Đúng";
            }
            else
            {
                lblError1.Text = "Sai";
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            lblError1.Visible = false;
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt13.Text = "";
            txt4.Text = "";
            txt14.Text = "";
        }
        #endregion
       
    }
}
