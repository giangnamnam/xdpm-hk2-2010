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
    public partial class LuyenTapBT9 : Form
    {
        public LuyenTapBT9()
        {
            InitializeComponent();
        }

        private void btnXong1_Click(object sender, EventArgs e)
        {
            lbl1.Visible = true;
            if (txt1.Text == "24")
            {
                lbl1.Text = "Bạn Làm Đúng";
            }
            else
            {
                lbl1.Text = "Bạn Làm Sai!!!!!";
            }
        }

        private void btnXong2_Click(object sender, EventArgs e)
        {
            lbl1.Visible = true;
            if (txt2.Text == "40")
            {
                lbl1.Text = "Bạn Làm Đúng";
            }
            else
            {
                lbl1.Text = "Bạn Làm Sai!!!!!";
            }
        }

        private void btnXong3_Click(object sender, EventArgs e)
        {
            lbl1.Visible = true;
            if (txt3.Text == "42")
            {
                lbl1.Text = "Bạn Làm Đúng";
            }
            else
            {
                lbl1.Text = "Bạn Làm Sai!!!!!";
            }
        }

        private void btnKT_Click(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            txt11.Visible = true;
            txt22.Visible = true;
            txt33.Visible = true;
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            txt11.Visible = false;
            txt22.Visible = false;
            txt33.Visible = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnXongbt2_Click(object sender, EventArgs e)
        {
            lblErrror2.Visible = true;
            lblErrror2.Text = "Lỗi :";
            if (txta.Text!="72")
            {
                lblErrror2.Text += "Ô 1 ;";
            }
            if (txtb.Text != "98")
            {
                lblErrror2.Text += "Ô 2 ;";
            }
            if (txtc.Text != "210")
            {
                lblErrror2.Text += "Ô 3 ;";
            }
            if (txtd.Text != "203")
            {
                lblErrror2.Text += "Ô 4 ;";
            }
            else
                if (txta.Text=="72"&&
                    txtb.Text=="98"&&
                    txtc.Text=="210"&&
                    txtd.Text=="203")
                {
                    lblErrror2.Text = "Bạn Làm Đúng!!!";
                }
            lblErrror2.Text = lblErrror2.Text.TrimEnd(';');
        }

        private void btnKT2_Click(object sender, EventArgs e)
        {
            btnLL2.Visible = true;
            lblErrror2.Visible = false;
            txta.Text = "72";
            txtb.Text = "98";
            txtc.Text = "210";
            txtd.Text = "203";
        }

        private void btnLL2_Click(object sender, EventArgs e)
        {
            btnLL2.Visible = false;
            lblErrror2.Visible = false;
            txta.Text = "";
            txtb.Text = "";
            txtc.Text = "";
            txtd.Text = "";
        }

        private void btnXong3a_Click(object sender, EventArgs e)
        {
            lblError3.Visible = true;
            if (txt3a.Text == "18")
            {
                
                lblError3.Text = "Đúng";
            }
            else
            {
                lblError3.Text = "Sai";
            }
        }

        private void btnKiemTra2_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            txt3a.Text = "18";
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            button1.Visible = false;
            txt3a.Text = "";
        }

        private void btnQuayLaiPhan2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
