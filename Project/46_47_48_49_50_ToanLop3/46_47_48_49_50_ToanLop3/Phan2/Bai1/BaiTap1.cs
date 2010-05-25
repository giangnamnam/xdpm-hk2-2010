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
    public partial class BaiTap1 : Form
    {
        public BaiTap1()
        {
            InitializeComponent();
        }

        private void BaiTap1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        #region Bài 1
        private void btnDaLamXong_Click(object sender, EventArgs e)
        {
            lblError.Text = "Lổi ở : ";
            lblError.Visible = true;
            if (txt1.Text != "24")
            {
                lblError.Text += " 6 x 4  sai ;";
            }
            if (txt2.Text != "36")
            {
                lblError.Text += "  6 x 6  sai ;\n";
            }
            if (txt3.Text != "48")
            {
                lblError.Text += "  6 x 8  sai ;";
            }
            if (txt4.Text != "6")
            {
                lblError.Text += "  6 x 1  sai ;\n";
            }
            if (txt5.Text != "18")
            {
                lblError.Text += " 6 x 3  sai ;";
            }
            if (txt6.Text != "30")
            {
                lblError.Text += " 6 x 5  sai ;";
            }
            if (txt7.Text != "54")
            {
                lblError.Text += " 6 x 9  sai ;\n";
            }
            if (txt8.Text != "12")
            {
                lblError.Text += " 6 x 2  sai ;";
            }
            if (txt9.Text != "42")
            {
                lblError.Text += " 6 x 7  sai ;\n";
            }
            if (txt10.Text != "60")
            {
                lblError.Text += " 6 x 10  sai ;";
            }
            if (txt11.Text != "0")
            {
                lblError.Text += " 0 x 6  sai ;\n";
            }
            if (txt12.Text != "0")
            {
                lblError.Text += " 6 x 0  sai ;";
            }
            else
            {
                lblError.Text = "Bạn Làm Rất Tốt !!!";
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt61.Visible = true; txt63.Visible = true; txt65.Visible = true; txt67.Visible = true; txt69.Visible = true;
            txt62.Visible = true; txt64.Visible = true; txt66.Visible = true; txt68.Visible = true; txt610.Visible = true;
            txt611.Visible = true; txt612.Visible = true;
            txt61.Text = "24";
            txt62.Text = "36";
            txt63.Text = "48";
            txt64.Text = "6";
            txt65.Text = "18";
            txt66.Text = "30";
            txt67.Text = "54";
            txt68.Text = "12";
            txt69.Text = "42";
            txt610.Text = "60";
            txt611.Text = "0";
            txt612.Text = "0";

        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            txt61.Visible = false; txt63.Visible = false; txt65.Visible = false; txt67.Visible = false; txt69.Visible = false;
            txt62.Visible = false; txt64.Visible = false; txt66.Visible = false; txt68.Visible = false; txt610.Visible = false;
            txt611.Visible = false; txt612.Visible = false;
            txt61.Text = " ";
            txt62.Text = " ";
            txt63.Text = " ";
            txt64.Text = " ";
            txt65.Text = " ";
            txt66.Text = " ";
            txt67.Text = " ";
            txt68.Text = " ";
            txt69.Text = " ";
            txt610.Text = " ";
            txt611.Text = " ";
            txt612.Text = " ";
        }

        #endregion
        #region Bai 2
        private void btnBT2_Click(object sender, EventArgs e)
        {
            lblLoiBT2.Visible = true;
            if (chk25.Checked == false &&chk14.Checked == false && chk30.Checked == true && chk32.Checked == false)
            {
                lblLoiBT2.Text = "Bạn Đã Chọn Đúng !!";
            }
            else
            {
                lblLoiBT2.Text = "Bạn Đã Chọn Sai !!! Hãy Chọn Lại ";
            }
        }

        private void btnBT2LamLai_Click(object sender, EventArgs e)
        {
            btnBT2.Visible = true;
            lblLoiBT2.Visible = false;
            chk25.Checked = false; chk14.Checked = false; chk30.Checked = false; chk32.Checked = false;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnBT2.Visible = false;
            chk30.Checked = true; chk25.Checked = false; chk14.Checked = false; chk32.Checked = false;
        }
        #endregion
        #region Bai 3
        private void bntBT2Ok_Click(object sender, EventArgs e)
        {
            lblLoiBT3.Visible = true;
            lblLoiBT3.Text = "Lỗi ở : ";
            if (txtLa24.Text != "24")
            {
                lblLoiBT3.Text += "Ô thứ 4 ;";
            }
            if (txtLa30.Text != "30")
            {
                lblLoiBT3.Text += "Ô thứ 5 ;";
            }
            if (txtLa42.Text != "42")
            {
                lblLoiBT3.Text += "Ô thứ 7 ;";
            }
            if (txtLa48.Text != "48")
            {
                lblLoiBT3.Text += "Ô thứ 8 ;";
            }
            if (txtLa54.Text != "54")
            {
                lblLoiBT3.Text += "Ô thứ 9";
            }
            else
            {
                lblLoiBT3.Text = "Chúc Mừng !! Bạn Đã Làm Đúng !!";
            }
        }

        private void btnLLBt2_Click(object sender, EventArgs e)
        {
            bntBT2Ok.Visible = true;
            lblLoiBT3.Visible = false;
            txtLa24.Text = " ";
            txtLa30.Text = "";
            txtLa42.Text = "";
            txtLa48.Text = "";
            txtLa54.Text = "";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bntBT2Ok.Visible = false;
            txtLa24.Text = "24";
            txtLa30.Text = "30";
            txtLa42.Text = "42";
            txtLa48.Text = "48";
            txtLa54.Text = "54";
        }
        #endregion
        
        private void llbThucHanh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Phan2.Bai1.LuyenTap.LuyenTapBT1 frm = new Phan2.Bai1.LuyenTap.LuyenTapBT1();
            frm.ShowDialog();
        }
    }
}
