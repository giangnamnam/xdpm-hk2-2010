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
    public partial class LuyenTapBT1_tieptheo_ : Form
    {
        public LuyenTapBT1_tieptheo_()
        {
            InitializeComponent();
        }

        private void LuyenTapBT1_tieptheo__Load(object sender, EventArgs e)
        {

        }
        #region Bai 1 a va b

        #endregion
        private void btnLamXongBt2_Click(object sender, EventArgs e)
        {

            lbl4a.Visible = true;
            lbl4a.Text = "Lỗi ở : ";
            if (txt1.Text != "30")
            {
                lbl4a.Text += "Ô thứ 4 ;";
            }
            if (txt2.Text != "36")
            {
                lbl4a.Text += "Ô thứ 5 ;";
            }
            if (txt3.Text != "42")
            {
                lbl4a.Text += "Ô thứ 6 ;";
            }
            if (txt4.Text != "48")
            {
                lbl4a.Text += "Ô thứ 7 ;";
            }
            else
            {
                lbl4a.Text = "Chúc Mừng !! Bạn Đã Làm Đúng !!";
            }
        }

        private void btnLamLaiBt2_Click(object sender, EventArgs e)
        {
            lbl4a.Visible = false;
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
           
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbl4a.Visible = false;
            txt1.Text = "30";
            txt2.Text = "36";
            txt3.Text = "42";
            txt4.Text = "48";
        }

        private void btnlamXong1b_Click(object sender, EventArgs e)
        {
            lbl4b.Text = "Lỗi ở : ";
            lbl4b.Visible = true;
            if (txt1b.Text != "27")
            {
                lbl4b.Text += "Ô thứ 4 ;";
            }
            if (txt2b.Text != "30")
            {
                lbl4b.Text += "Ô thứ 5 ;";
            }
            if (txt3b.Text != "33")
            {
                lbl4b.Text += "Ô thứ 6 ;";
            }
            if (txt4b.Text != "36")
            {
                lbl4b.Text += "Ô thứ 7 ;";
            }
            else
            {
                lbl4b.Text = "Chúc Mừng !! Bạn Đã Làm Đúng !!";
            }
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbl4b.Visible = false;
            txt1b.Text = "27";
            txt2b.Text = "30";
            txt3b.Text = "33";
            txt4b.Text = "36";
        }

        private void btnLamLai1b_Click(object sender, EventArgs e)
        {
            lbl4b.Visible = false;
            txt1b.Text = "";
            txt2b.Text = "";
            txt3b.Text = "";
            txt4b.Text = "";
        }

        private void btnQuayLaiPhan2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình ?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
