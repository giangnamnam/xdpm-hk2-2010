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
    public partial class Bai08 : Form
    {
        public Bai08()
        {
            InitializeComponent();
        }
        #region Ly thuyet
        private void btnLamLai_Click(object sender, EventArgs e)
        {
            btnLamLai.Visible = false;
            lblError.Visible = false;
            btnDaLamXong.Visible = true;
            txt1.Text = "7";
            txt2.Text = "14";
            txt3.Text = "21";
            txt4.Text = "28";
            txt5.Text = "35";
            txt6.Text = "42";
            txt7.Text = "49";
            txt8.Text = "56";
            txt9.Text = "63";
            txt10.Text = "70";
        }

        private void btnDaLamXong_Click(object sender, EventArgs e)
        {
            lblError.Text = "Lổi ở : ";
            btnLamLai.Visible = false;
            lblError.Visible = true;
            if (txt1.Text != "7")
            {
                lblError.Text += " ô 1  Sai ;";
            }
            if (txt2.Text != "14")
            {
                lblError.Text += " ô 2  Sai ;\n";
            }
            if (txt3.Text != "21")
            {
                lblError.Text += " ô 3  Sai ;";
            }
            if (txt4.Text != "28")
            {
                lblError.Text += " ô 4  Sai ;\n";
            }
            if (txt5.Text != "35")
            {
                lblError.Text += " ô 5  Sai ;";
            }
            if (txt6.Text != "42")
            {
                lblError.Text += " ô 6  Sai ;";
            }
            if (txt7.Text != "49")
            {
                lblError.Text += " ô 7  Sai ;\n";
            }
            if (txt8.Text != "56")
            {
                lblError.Text += " ô 8  Sai ;";
            }
            if (txt9.Text != "63")
            {
                lblError.Text += " ô 9  Sai ;\n";
            }
            if (txt10.Text != "70")
            {
                lblError.Text += " ô 10  Sai";
            }
            else if (txt1.Text == "7" &&
                txt2.Text == "14" &&
                txt3.Text == "21" &&
                txt4.Text == "28" &&
                txt5.Text == "35" &&
                txt6.Text == "42" &&
                txt7.Text == "49" &&
                txt8.Text == "56" &&
                txt9.Text == "63" &&
                txt10.Text == "70")
            {
                btnLamLai.Visible = true;
                lblError.Text = "Bạn Làm Rất Tốt !!!";
            }
            lblError.Text = lblError.Text.TrimEnd(';');
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnLamLai.Visible = true;
            lblError.Visible = false;
            btnDaLamXong.Visible = false;
            txt1.Text = "7";
            txt2.Text = "14";
            txt3.Text = "21";
            txt4.Text = "28";
            txt5.Text = "35";
            txt6.Text = "42";
            txt7.Text = "49";
            txt8.Text = "56";
            txt9.Text = "63";
            txt10.Text = "70";
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Bai1.BaiTap8 frm = new Bai1.BaiTap8();
            frm.ShowDialog();
        }

        private void btnQuayLaiPhan2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llbThucHanh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Bai1.LuyenTap.LuyenTapBT8 frm = new Bai1.LuyenTap.LuyenTapBT8();
            frm.ShowDialog();
        }
    }
}