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
    public partial class LuyenTapBT2 : Form
    {
        public LuyenTapBT2()
        {
            InitializeComponent();
        }
        #region  Bai 3
        private void btnDaLamBt3_Click(object sender, EventArgs e)
        {
            lblBt3.Visible = true;
            if (chk5.Checked == false && chk8.Checked == true && chk7.Checked == false && chk9.Checked == false)
            {
                lblBt3.Text = "Bạn Đã Chọn Đúng !!";
            }
            else
            {
                lblBt3.Text = "Bạn Đã Chọn Sai !!! Hãy Chọn Lại ";
            }
        }

        private void llbKiemTraBt3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblBt3.Visible = false;
            chk8.Checked = true;
        }

        private void btnLamLaiBt3_Click(object sender, EventArgs e)
        {
            lblBt3.Visible = false;
            chk8.Checked = false; chk5.Checked = false;
            chk7.Checked = false; chk9.Checked = false;
        }
        #endregion
        #region  Bai 4
        private void btnLamXong4_Click(object sender, EventArgs e)
        {
            lblError4.Visible = true;
            if (chk48.Checked == true && chk49.Checked == false && chk10.Checked == false && chk11.Checked == false)
            {
                lblError4.Text = "Bạn Đã Chọn Đúng !!";
            }
            else
            {
                lblError4.Text = "Bạn Đã Chọn Sai !!! Hãy Chọn Lại ";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblError4.Visible = false;
            chk48.Checked = true;
        }

        private void btnLamLai4_Click(object sender, EventArgs e)
        {
            lblError4.Visible = false;
            chk48.Checked = false; chk10.Checked = false;
            chk11.Checked = false; chk49.Checked = false;
        }
       
        #endregion

        private void btnQuayLaiPhan2_Click(object sender, EventArgs e)
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
      
    }
}
