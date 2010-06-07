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
    public partial class LuyenTapBT6 : Form
    {
        public LuyenTapBT6()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void LuyenTapBT6_Load(object sender, EventArgs e)
        {

        }
        #region bai 2
        private void button3_Click(object sender, EventArgs e)
        {
            lblErrorbt3.Visible = true;
            btnLamLaibt3.Visible = false;
            if (chk28.Checked == false && chk24.Checked == false && chk35.Checked == true && chk42.Checked == false)
            {
                lblErrorbt3.Text = "Bạn Đã Chọn Đúng !!";
                btnLamLaibt3.Visible = true;
                btnDaLambt3.Visible = false;
            }
            else
            {
                lblErrorbt3.Text = "Bạn Đã Chọn Sai !!! Hãy Chọn Lại ";
            }
        }

        private void btnLamLaibt3_Click(object sender, EventArgs e)
        {
            btnDaLambt3.Visible = true;
            btnLamLaibt3.Visible = false;
            lblErrorbt3.Visible = false;
            chk24.Checked = false;
            chk28.Checked = false;
            chk35.Checked = false;
            chk42.Checked = false;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnDaLambt3.Visible = false;
            btnLamLaibt3.Visible = true;
            lblErrorbt3.Visible = false;
            chk35.Checked = true;
            chk24.Checked = false;
            chk28.Checked = false;
            chk42.Checked = false;
        }

        #endregion
        #region Bai 1
        private void btnDaLam1_Click(object sender, EventArgs e)
        {
            txt21.Visible = false;
            txt22.Visible = false;
            txt23.Visible = false;
            txt24.Visible = false;
            lblError1.Visible = true;
            if (txt1.Text == "24" &&
                txt2.Text == "42" &&
                txt3.Text == "11" &&
                txt4.Text == "32")
            {
                lblError1.Text = "Đúng Bạn Thật Giỏi!!";
            }
            else
            {
                lblError1.Text = "Sai Rồi Bạn Bấm Vào Kiểm Tra Thử Nhé !!!";
            }
        }

        private void btnKiemTra1_Click(object sender, EventArgs e)
        {
            lblError1.Visible = false;
            txt21.Visible = true;
            txt22.Visible = true;
            txt23.Visible = true;
            txt24.Visible = true;
        }
        #endregion

        private void btnQuayLaiPhan2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
