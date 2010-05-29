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
    public partial class BaiTap6 : Form
    {
        public BaiTap6()
        {
            InitializeComponent();
        }

        private void BaiTap5_Load(object sender, EventArgs e)
        {

        }
        #region  bai 1
        private void btnDaLam1_Click(object sender, EventArgs e)
        {
            txt5.Visible = false;
            txt6.Visible = false;
            txt7.Visible = false;
            txt8.Visible = false;
            lblError.Visible = true;
            if (txt1.Text == "12" &&
                txt2.Text == "42" &&
                txt3.Text == "11" &&
                txt4.Text == "12")
            {
                lblError.Text = "Đúng Bạn Thật Giỏi!!";
            }
            else
            {
                lblError.Text = "Sai Rồi Bạn Bấm Vào Kiểm Tra Thử Nhé !!!";
            }
        }

        private void btnKiemTra1_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            txt5.Visible = true;
            txt6.Visible = true;
            txt7.Visible = true;
            txt8.Visible = true;
        }
        #endregion
     
        #region  Bai 2
        private void btnKiemTra2_Click(object sender, EventArgs e)
        {
            lblError2.Visible = false;
            txt21.Visible = true;
            txt22.Visible = true;
            txt23.Visible = true;
            txt24.Visible = true;
        }

        private void btnDaLam2_Click(object sender, EventArgs e)
        {
            txt21.Visible = false;
            txt22.Visible = false;
            txt23.Visible = false;
            txt24.Visible = false;
            lblError2.Visible = true;
            if (txt1.Text == "23" &&
                txt2.Text == "12" &&
                txt3.Text == "12" &&
                txt4.Text == "24")
            {
                lblError.Text = "Đúng Bạn Thật Giỏi!!";
            }
            else
            {
                lblError.Text = "Sai Rồi Bạn Bấm Vào Kiểm Tra Thử Nhé !!!";
            }
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

        private void btnQuayLaiPhan2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llbThucHanh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          //  LuyenTap.LuyenTapBT6 frm = new LuyenTap.LuyenTapBT6();
            //frm.ShowDialog();
        }
        
    }
}
