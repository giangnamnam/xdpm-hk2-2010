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
    public partial class LuyenTapBT3_tieptheo1_ : Form
    {
        public LuyenTapBT3_tieptheo1_()
        {
            InitializeComponent();
        }

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

        private void btnDaLamBt3_Click(object sender, EventArgs e)
        {
            lblError3.Visible = true;
            if (chk144.Checked == true && chk154.Checked == false && chk184.Checked == false && chk188.Checked == false)
            {
                lblError3.Text = "Bạn Đã Chọn Đúng !!";
            }
            else
            {
                lblError3.Text = "Bạn Đã Chọn Sai !!! Hãy Chọn Lại ";
            }
        }

        private void llbKiemTraBt3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnDaLamBt3.Visible = false;
            chk144.Checked = true; chk154.Checked = false; chk184.Checked = false; chk188.Checked = false;
        }

        private void btnLamLaiBt3_Click(object sender, EventArgs e)
        {
            btnDaLamBt3.Visible = true;
            chk144.Checked = false; chk154.Checked = false; chk184.Checked = false; chk188.Checked = false;
        }
    }
}
