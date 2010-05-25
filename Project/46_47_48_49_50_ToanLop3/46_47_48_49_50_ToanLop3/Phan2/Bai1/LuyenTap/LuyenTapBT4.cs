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
    public partial class LuyenTapBT4 : Form
    {
        public LuyenTapBT4()
        {
            InitializeComponent();
        }

        private void LuyenTapBT3_Load(object sender, EventArgs e)
        {

        }
        #region Bai 3
        private void btnDaLamBt1b_Click(object sender, EventArgs e)
        {
            lblError3a.Text = "";
            lblError3b.Text = "";
            lblError3a.Visible = true;
            lblError3b.Visible = true;
            if (txt72.Text != "72")
            {
                lblError3a.Text += "Không Đúng ";
            }
            if (txt92.Text != "92")
            {
                lblError3b.Text += "Không Đúng";
            }
            else
            {
                lblError3a.Text = "Chúc Mừng Bạn!!Bạn Đã Làm Đúng";
                lblError3b.Text = "Chúc Mừng Bạn!!Bạn Đã Làm Đúng";
            }
        }

        private void btnLamLaiBt1b_Click(object sender, EventArgs e)
        {
            btnDaLamBt1b.Visible = true;
            lblError3a.Visible = false;
            lblError3b.Visible = false;
            txt72.Text = "";
            txt92.Text = "";
        }

        private void lblKiemTra1b_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnDaLamBt1b.Visible = false;
            lblError3a.Visible = false;
            lblError3b.Visible = false;
            txt72.Text = "72";
            txt92.Text = "92";
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

        private void llbThucHanh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LuyenTapBT3_tieptheo_ frm = new LuyenTapBT3_tieptheo_();
            frm.ShowDialog();
        }
    }
}
