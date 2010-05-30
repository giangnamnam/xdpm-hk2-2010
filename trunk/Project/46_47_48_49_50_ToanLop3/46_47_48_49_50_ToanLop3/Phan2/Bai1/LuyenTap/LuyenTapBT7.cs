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
    public partial class LuyenTapBT7 : Form
    {
        public LuyenTapBT7()
        {
            InitializeComponent();
        }
        private void LuyenTapBT7_Load(object sender, EventArgs e)
        {

        }
        #region  bai 1
        private void btnKiemTra1_Click(object sender, EventArgs e)
        {
            lblError1.Visible = false;
            txt1.Text = "8";
            txt11.Text = "1";
            txt2.Text = "8";
            txt12.Text = "3";
            txt3.Text = "8";
            txt13.Text = "2";
            txt4.Text = "9";
            txt14.Text = "4";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            lblError1.Visible = true;
            if (txt1.Text == "8" && txt11.Text=="1")
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
            if (txt2.Text == "8"&& txt12.Text=="3")
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
            if (txt3.Text == "8" && txt13.Text == "2")
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
            if (txt4.Text == "9" && txt14.Text == "4")
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
            txt11.Text = "";
            txt2.Text = "";
            txt12.Text = "";
            txt3.Text = "";
            txt13.Text = "";
            txt4.Text = "";
            txt14.Text = "";
        }
        #endregion
        #region  bai 2
        private void btnLamLai3_Click(object sender, EventArgs e)
        {
            chk1.Checked = false;
            chk2.Checked = false;
            chk3.Checked = false;
            chk4.Checked = false;
            lblBt2.Visible = false;
        }

        private void btnDaLam_Click(object sender, EventArgs e)
        {
            lblBt2.Visible = true;
            if (chk1.Checked == false &&
            chk2.Checked == true &&
            chk3.Checked == false &&
            chk4.Checked == false)
            {
                lblBt2.Text = "Đúng";
            }
            else
            {
                lblBt2.Text = "Sai";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chk1.Checked = false;
            chk2.Checked = true;
            chk3.Checked = false;
            chk4.Checked = false;
            lblBt2.Visible = false;
        }
        #endregion
       

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        #region Bai 3
        private void btnDaLam3_Click(object sender, EventArgs e)
        {
            lblBt12.Visible = true;
            if (chk11.Checked == false &&
            chk12.Checked == true &&
            chk13.Checked == false &&
            chk14.Checked == false)
            {
                lblBt12.Text = "Đúng";
            }
            else
            {
                lblBt12.Text = "Sai";
            }
        }

        private void btKetQua3_Click(object sender, EventArgs e)
        {
            chk11.Checked = false;
            chk12.Checked = true;
            chk13.Checked = false;
            chk14.Checked = false;
            lblBt12.Visible = false;
        }

        private void btnLamLai33_Click(object sender, EventArgs e)
        {
            chk11.Checked = false;
            chk12.Checked = false;
            chk13.Checked = false;
            chk14.Checked = false;
            lblBt12.Visible = false;
        }
        #endregion

        private void btnQuayLaiPhan2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
       
    }
}
