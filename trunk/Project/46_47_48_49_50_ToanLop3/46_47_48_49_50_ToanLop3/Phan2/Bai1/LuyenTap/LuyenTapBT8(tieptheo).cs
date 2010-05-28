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
    public partial class LuyenTapBT8_tieptheo_ : Form
    {
        public LuyenTapBT8_tieptheo_()
        {
            InitializeComponent();
        }

        private void btnDaLam4_Click(object sender, EventArgs e)
        {
            lblError4.Visible = true;
            btnLamLai4.Visible = false;
            if (txt1.Text!="7" && txt2.Text!="4")
            {
                lblError4.Text = "Sai câu a ;";
            }
            if (txt3.Text != "4" && txt4.Text != "7")
            {
                lblError4.Text += "Sai câu b ;";
            }
            else if (
                txt1.Text=="7" && 
                txt2.Text=="4"&&
                txt3.Text == "4" && 
                  txt4.Text == "7")
            {
                lblError4.Text = "Bạn Đã Làm Đúng!!!";
                btnLamLai4.Visible = true;
                btnDaLam4.Visible = false;
            }
            lblError4.Text = lblError4.Text.TrimEnd(';');
        }

        private void btnLamLai4_Click(object sender, EventArgs e)
        {
            btnLamLai4.Visible = false;
            btnDaLam4.Visible = true;
            lblError4.Visible = false;
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnLamLai4.Visible = true;
            btnDaLam4.Visible = false;
            lblError4.Visible = false;
            txt1.Text = "7";
            txt2.Text = "4";
            txt3.Text = "4";
            txt4.Text = "7";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
