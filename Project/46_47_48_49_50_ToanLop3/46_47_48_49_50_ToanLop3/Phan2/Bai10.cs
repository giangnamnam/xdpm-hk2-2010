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
    public partial class Bai10 : Form
    {
        public Bai10()
        {
            InitializeComponent();
        }

        private void btnDaLamXong_Click(object sender, EventArgs e)
        {
            lblError.Text = "Lổi ở : ";
            btnLamLai.Visible = false;
            lblError.Visible = true;
            
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
            else if (
                txt5.Text == "5" &&
                txt6.Text == "6" &&
                txt7.Text == "7" &&
                txt8.Text == "8" &&
                txt9.Text == "9" &&
                txt10.Text == "10")
            {
                btnLamLai.Visible = true;
                btnDaLamXong.Visible = false;
                lblError.Text = "Bạn Làm Rất Tốt !!!";
            }
            lblError.Text = lblError.Text.TrimEnd(';');
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
             btnLamLai.Visible = false;
            lblError.Visible = false;
            btnDaLamXong.Visible = true;
            txt5.Text = "5";
            txt6.Text = "6";
            txt7.Text = "7";
            txt8.Text = "8";
            txt9.Text = "9";
            txt10.Text = "10";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnLamLai.Visible = true;
            lblError.Visible = false;
            btnDaLamXong.Visible = false;
            txt5.Text = "5";
            txt6.Text = "6";
            txt7.Text = "7";
            txt8.Text = "8";
            txt9.Text = "9";
            txt10.Text = "10";
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
