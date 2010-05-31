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
    public partial class LuyenTapBT10 : Form
    {
        public LuyenTapBT10()
        {
            InitializeComponent();
        }

        private void LuyenTapBT10_Load(object sender, EventArgs e)
        {

        }
        #region Cau 1
        private void btnKT_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            txt21.Text = "4";
            txt22.Text = "2";
            txt23.Text = "7";
            txt24.Text = "10";
            txt25.Text = "8";
            txt26.Text = "5";
            btnLamLai2.Visible = true;
        }

        private void btnLamLai2_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            txt21.Text = "4";
            txt22.Text = "2";
            txt23.Text = "7";
            txt24.Text = "10";
            txt25.Text = "8";
            txt26.Text = "5";
            btnLamLai2.Visible = false;
        }
        private void btnDaLamXong1_Click(object sender, EventArgs e)
        {
            lblError.Visible = true;
            lblError.Text = "Lỗi ở :";
            if (txt1.Text != "4")
            {
                lblError.Text += "28 : 7 sai ;";
            }
            if (txt2.Text != "2")
            {
                lblError.Text += "14 : 7 sai ;";
            }
            if (txt3.Text != "7")
            {
                lblError.Text += "49 : 7 sai ;";
            }
            if (txt4.Text != "10")
            {
                lblError.Text += "70 : 7 sai ;";
            }
            if (txt5.Text != "8")
            {
                lblError.Text += "56 : 7 sai ;";
            }
            if (txt6.Text != "5")
            {
                lblError.Text += "35 : 7 sai ;";
            }
            else
                if (txt1.Text == "4" &&
            txt2.Text == "2" &&
            txt3.Text == "7" &&
            txt4.Text == "10" &&
            txt5.Text == "8" &&
            txt6.Text == "5")
                {
                    lblError.Text += "Bạn Đã Làm Đúng";
                }
            lblError.Text = lblError.Text.TrimEnd(';');
        }

        #endregion
        #region Cau 2
        private void btnKT2a_Click(object sender, EventArgs e)
        {
            lblError2a.Visible = false;
            richTextBox1.Visible = true;
            btnLamLai2a.Visible = true;
            txt2a.Text = "5";
        }

        private void btnLamLai2a_Click(object sender, EventArgs e)
        {
            lblError2a.Visible = false;
            richTextBox1.Visible = false;
            btnLamLai2a.Visible = false;
            txt2a.Text = "";
        }

        private void btnXong2a_Click(object sender, EventArgs e)
        {
            lblError2a.Visible = true;
            if (txt2a.Text == "5")
            {
                lblError2a.Text = "Đúng";
            }
            else
            {
                lblError2a.Text = "Sai";
            }
        }
        #endregion

        private void btnXong3_Click(object sender, EventArgs e)
        {
            lbl3a.Visible = true;
            lbl3a.Text = "Đúng";
        }

        private void btnXong31_Click(object sender, EventArgs e)
        {
            lbl3b.Visible = true;
            lbl3b.Text = "Sai";
        }

        private void btnLamLai3_Click(object sender, EventArgs e)
        {
            lbl3a.Visible = false;
            lbl3b.Visible = false;
        }

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


    }
}
