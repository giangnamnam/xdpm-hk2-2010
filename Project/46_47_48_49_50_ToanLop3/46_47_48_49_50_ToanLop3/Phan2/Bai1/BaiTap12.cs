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
    public partial class BaiTap12 : Form
    {
        public BaiTap12()
        {
            InitializeComponent();
        }

        private void BaiTap12_Load(object sender, EventArgs e)
        {

        }
        #region bai 1
        private void btnDaLamXong_Click(object sender, EventArgs e)
        {
            lblError1.Text = "Lổi ở : ";
            lblError1.Visible = true;
            if (txt1.Text != "7")
            {
                lblError1.Text += " Ô  Thứ Nhất ;";
            }
            if (txt2.Text != "5")
            {
                lblError1.Text += " Ô  Thứ 2 ;";
            }
            if (txt3.Text != "4")
            {
                lblError1.Text += " Ô  Thứ 3 ;";
            }
            if (txt4.Text != "7")
            {
                lblError1.Text += " Ô  Thứ 4 ;";
            }
            else
                if (txt1.Text == "7" &&
                    txt2.Text == "5" &&
                    txt3.Text == "4" &&
                    txt4.Text == "7")
                {
                    lblError1.Text = "Chúc Mừng Bạn!!Bạn Đã Làm Đúng";
                }
            lblError1.Text = lblError1.Text.TrimEnd(';');
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            lblError1.Visible = false;
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
        }

        private void llbKiemTra1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblError1.Visible = false;
            txt1.Text = "7";
            txt2.Text = "5";
            txt3.Text = "4";
            txt4.Text = "7";
        }

        #endregion
        #region bai 2
        private void btnDaLam2a_Click(object sender, EventArgs e)
        {
            lblError2a.Visible = true;
            if (txt21.Text != "6")
            {
                lblError2a.Text = "Sai";
            }
            else
            {
                lblError2a.Text = "Đúng";
            }
        }

        private void btnDaLam2b_Click(object sender, EventArgs e)
        {
            lblError2b.Visible = true;
            if (txt22.Text != "9")
            {
                lblError2b.Text = "Sai";
            }
            else
            {
                lblError2b.Text = "Đúng";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblError2a.Visible = false;
            lblError2b.Visible = false;
            dapan1.Visible = true;
            dapan2.Visible = true;
            txt21.Text = "6";
            txt22.Text = "9";

        }

        private void btnLamLai2_Click(object sender, EventArgs e)
        {
            lblError2b.Visible = false;
            lblError2a.Visible = false;
            dapan1.Visible = false;
            dapan2.Visible = false;
            txt21.Text = "";
            txt22.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btnDung3c_Click(object sender, EventArgs e)
        {
            lblError2c.Visible = true;
            if (txt2c.Text != "7")
            {
                lblError2c.Text = "Sai";
            }
            else
            {
                lblError2c.Text = "Đúng";
            }
        }

        private void btnDung3d_Click(object sender, EventArgs e)
        {
            lblError2d.Visible = true;
            if (txt2d.Text != "10")
            {
                lblError2d.Text = "Sai";
            }
            else
            {
                lblError2d.Text = "Đúng";
            }
        }

        private void btnLamLai3_Click(object sender, EventArgs e)
        {
            lblError2c.Visible = false;
            lblError2d.Visible = false;
            dapan3.Visible = false;
            dapan4.Visible = false;
            txt2c.Text = "";
            txt2d.Text = "";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblError2c.Visible = false;
            lblError2d.Visible = false;
            dapan3.Visible = true;
            dapan4.Visible = true;
            txt2c.Text = "7";
            txt2d.Text = "10";
        }

        private void llbThucHanh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LuyenTap.LuyenTapBT12 frm = new LuyenTap.LuyenTapBT12();
            frm.ShowDialog();
        }
        #endregion
       
    }
}
