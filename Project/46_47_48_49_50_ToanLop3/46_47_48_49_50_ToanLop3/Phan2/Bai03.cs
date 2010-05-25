using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan2
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private void Bai02_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDaLamXong_Click(object sender, EventArgs e)
        {
            lblError.Text = "Lổi ở : ";
            lblError.Visible = true;
            if (txt1.Text != "48")
            {
                lblError.Text += " 24 x 2  sai ;";
            }
            if (txt2.Text != "88")
            {
                lblError.Text += "  22 x 4  sai ;";
            }
            if (txt3.Text != "55")
            {
                lblError.Text += "  11 x 5  sai ;";
            }
            if (txt4.Text != "99")
            {
                lblError.Text += "  33 x 3  sai ;";
            }
            if (txt5.Text != "80")
            {
                lblError.Text += " 20 x 4  sai ;";
            }
            else
            {
                lblError.Text = "Chúc Mừng Bạn!!Bạn Đã Làm Đúng";
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            btnDaLamXong.Visible = true;
            lblError.Visible = false;
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            
        }

        private void btnQuayLaiPhan2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llbThucHanh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Phan2.Bai1.BaiTap3 frm = new Phan2.Bai1.BaiTap3();
            frm.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblError.Visible = false;
            btnDaLamXong.Visible = false;
            txt1.Text = "48";
            txt2.Text = "88";
            txt3.Text = "55";
            txt4.Text = "99";
            txt5.Text = "80";
        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }
    }
}
