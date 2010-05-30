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
    public partial class LuyenTapBT3_tieptheo_ : Form
    {
        public LuyenTapBT3_tieptheo_()
        {
            InitializeComponent();
        }
        #region Bai 1
        private void btnDaLamBt1_Click(object sender, EventArgs e)
        {
            lblError1.Text = "Lổi ở : ";
            lblError1.Visible = true;
            if (txt1.Text != "98")
            {
                lblError1.Text += " Ô  Thứ Nhất ;";
            }
            if (txt2.Text != "108")
            {
                lblError1.Text += " Ô  Thứ 2 ;";
            }
            if (txt3.Text != "342")
            {
                lblError1.Text += " Ô  Thứ 3 ;";
            }
            if (txt4.Text != "90")
            {
                lblError1.Text += " Ô  Thứ 4 ;";
            }
            if (txt5.Text != "192")
            {
                lblError1.Text += " Ô  Thứ 5 ;";
            }
            else
            {
                lblError1.Text = "Chúc Mừng Bạn!!Bạn Đã Làm Đúng";
            }
        }

        private void llbKiemTra1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnDaLamBt1.Visible = false;
            lblError1.Visible = false;
            txt1.Text = "98";
            txt2.Text = "108";
            txt3.Text = "342";
            txt4.Text = "90";
            txt5.Text = "192";
        }

        private void btnLamLaiBt1_Click(object sender, EventArgs e)
        {
            btnDaLamBt1.Visible = true;
            lblError1.Visible = false;
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
        }
        #endregion

        #region Bai 2
        private void btnDaLamXong2_Click(object sender, EventArgs e)
        {
            lblError2.Text = "Lổi ở : ";
            lblError2.Visible = true;
            if (txt1a.Text != "76")
            {
                lblError2.Text += " Ô  Thứ Nhất Câu a ;";
            }
            if (txt2a.Text != "162")
            {
                lblError2.Text += " Ô  Thứ 2 Câu a;";
            }
            if (txt1b.Text != "212")
            {
                lblError2.Text += " Ô  Thứ Nhất Câu b ;";
            }
            if (txt2b.Text != "225")
            {
                lblError2.Text += " Ô  Thứ 2 Câu b ;";
            }
            else
                if(txt1a.Text == "76"&&
            txt2a.Text == "162"&&
            txt1b.Text == "212"&&
            txt2b.Text == "225")
            {
                lblError2.Text = "Chúc Mừng Bạn!!Bạn Đã Làm Đúng";
            }
        }

        private void btnLamLai2_Click(object sender, EventArgs e)
        {
            btnDaLamXong2.Visible = true;
            lblError2.Visible = false;
            txt1a.Text = "";
            txt2a.Text = "";
            txt1b.Text = "";
            txt2b.Text = "";
        }

        private void lblKiemTra2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnDaLamXong2.Visible = false;
            lblError2.Visible = false;
            txt1a.Text = "76";
            txt2a.Text = "162";
            txt1b.Text = "212";
            txt2b.Text = "225";
        }

        private void llbThucHanh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LuyenTapBT3_tieptheo1_ frm = new LuyenTapBT3_tieptheo1_();
            frm.ShowDialog();
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
        #endregion
       
    }
}
