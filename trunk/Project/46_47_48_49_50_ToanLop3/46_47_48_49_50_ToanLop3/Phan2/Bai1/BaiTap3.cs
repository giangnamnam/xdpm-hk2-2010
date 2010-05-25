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
    public partial class BaiTap3 : Form
    {
        public BaiTap3()
        {
            InitializeComponent();
        }

        private void BaiTap3_Load(object sender, EventArgs e)
        {

        }
        #region Cau 1 a
        private void btnDaLamBt1a_Click(object sender, EventArgs e)
        {
            lblError1a.Text = "Lổi từ trái qua phải : ";
            lblError1a.Visible = true;
            if (txt1.Text != "94")
            {
                lblError1a.Text += " Câu Đầu Tiên sai ;";
            }
            if (txt2.Text != "75")
            {
                lblError1a.Text += " Câu Thứ 2 Sai ;";
            }
            if (txt3.Text != "96")
            {
                lblError1a.Text += " Câu Thứ 3 Sai ;";
            }
            if (txt4.Text != "72")
            {
                lblError1a.Text += " Câu Thứ 4 Sai ;";
            }
            else
            {
                lblError1a.Text = "Chúc Mừng Bạn!!Bạn Đã Làm Đúng";
            }
        }

        private void btnLamLaiBt1a_Click(object sender, EventArgs e)
        {
            lblError1a.Visible = false;
            btnDaLamBt1a.Visible = true;
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";

        }

        private void llbKiemTra1a_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblError1a.Visible = false;
            btnDaLamBt1a.Visible = false;
            txt1.Text = "94";
            txt2.Text = "75";
            txt3.Text = "96";
            txt4.Text = "72";
        }
        #endregion
        #region Bai 1 b
        private void btnDaLamBt1b_Click(object sender, EventArgs e)
        {
            lblError1b.Text = "Lổi từ trái qua phải : ";
            lblError1b.Visible = true;
            if (txt1b.Text != "168")
            {
                lblError1b.Text += " Câu Đầu Tiên sai ;";
            }
            if (txt2b.Text != "144")
            {
                lblError1b.Text += " Câu Thứ 2 Sai ;";
            }
            if (txt3b.Text != "410")
            {
                lblError1b.Text += " Câu Thứ 3 Sai ;";
            }
            if (txt4b.Text != "297")
            {
                lblError1b.Text += " Câu Thứ 4 Sai ;";
            }
            else
            {
                lblError1b.Text = "Chúc Mừng Bạn!!Bạn Đã Làm Đúng";
            }
        }

        private void btnLamLaiBt1b_Click(object sender, EventArgs e)
        {
            lblError1b.Visible = false;
            btnDaLamBt1b.Visible = true;
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
        }

        private void lblKiemTra1b_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblError1b.Visible = false;
            btnDaLamBt1b.Visible = false;
            txt1b.Text = "168";
            txt2b.Text = "144";
            txt3b.Text = "410";
            txt4b.Text = "297";
        }
        #endregion
        #region Bai 2
        private void btnLamXong2_Click(object sender, EventArgs e)
        {
            lblError2.Visible = true;
            if (chk70.Checked == true && chk48.Checked == false && chk87.Checked == false && chk89.Checked == false)
            {
                lblError2.Text = "Bạn Đã Chọn Đúng !!";
            }
            else
            {
                lblError2.Text = "Bạn Đã Chọn Sai !!! Hãy Chọn Lại ";
            }
        }

        private void lblKiemTra2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnLamXong2.Visible = false;
            chk70.Checked = true; chk48.Checked = false; chk87.Checked = false; chk89.Checked = false;
        }

        private void btnLamLai2_Click(object sender, EventArgs e)
        {
            btnLamXong2.Visible = true;
            chk70.Checked = false; chk48.Checked = false; chk87.Checked = false; chk89.Checked = false;
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

        private void llbThucHanh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Phan2.Bai1.LuyenTap.LuyenTapBT3 frm = new Phan2.Bai1.LuyenTap.LuyenTapBT3();
            frm.ShowDialog();
        }
        
        
 
    }
}
