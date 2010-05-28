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
    public partial class LuyenTapBT12 : Form
    {
        public LuyenTapBT12()
        {
            InitializeComponent();
        }

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
                if (txt1.Text == "7"&&
                    txt1.Text == "5"&&
                    txt1.Text == "4"&&
                    txt1.Text == "7")
            {
                lblError1.Text = "Chúc Mừng Bạn!!Bạn Đã Làm Đúng";
            }
            lblError1.Text = lblError1.Text.TrimEnd(';');
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txt1.Text = "7";
                    txt1.Text = "5";
                    txt1.Text = "4";
                    txt1.Text = "7";
        }
    }
}
