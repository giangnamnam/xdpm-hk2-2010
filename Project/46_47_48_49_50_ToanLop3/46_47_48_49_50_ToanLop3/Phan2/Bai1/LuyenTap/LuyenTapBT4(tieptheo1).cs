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
    public partial class LuyenTapBT4_tieptheo1_ : Form
    {
        public LuyenTapBT4_tieptheo1_()
        {
            InitializeComponent();
        }
        #region  Bai 3
        private void llbKiemTraBt3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            chk3.Checked = true; btnLamLaiBt3.Visible = true; btnDaLamBt3.Visible = false;
        }

        private void btnDaLamBt3_Click(object sender, EventArgs e)
        {
            lblBt3.Visible = true; btnLamLaiBt3.Visible = false;
            if (chk2.Checked == false && chk3.Checked == true && chk7.Checked == false && chk5.Checked == false)
            {
                lblBt3.Text = "Bạn Đã Chọn Đúng !!";
                btnLamLaiBt3.Visible = true;
            }
            else
            {
                lblBt3.Text = "Bạn Đã Chọn Sai !!! Hãy Chọn Lại ";
            }
        }

        private void btnLamLaiBt3_Click(object sender, EventArgs e)
        {
            btnDaLamBt3.Visible = true; chk2.Checked = false;
            chk3.Checked = false; chk7.Checked = false;
            chk5.Checked = false;
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

        private void LuyenTapBT4_tieptheo1__Load(object sender, EventArgs e)
        {
        }
        #region Bai 4
        private void btn1_Click(object sender, EventArgs e)
        {

            if (chksai.Checked == true)
            {
                lbl1.Visible = true;
                lbl1.Text = "Không Đúng Rồi !!!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (chkdung1.Checked == true)
            {
                lbl2.Visible = true;
                lbl2.Text = "Rất Đúng !!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (chkdung2.Checked == true)
            {
                lbl3.Visible = true;
                lbl3.Text = "Rất Đúng !!";
            }
        }
        #endregion
       
    }
}
