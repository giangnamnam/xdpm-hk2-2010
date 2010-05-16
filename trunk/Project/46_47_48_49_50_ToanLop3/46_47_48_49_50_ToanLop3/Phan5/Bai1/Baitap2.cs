using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan5.Bai1
{
    public partial class Baitap2 : Form
    {
        public Baitap2()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btLamXong_Click(object sender, EventArgs e)
        {
            if (tbDocSo1.Text == "Chín mươi bảy nghìn một trăm bốn mươi lăm")
            {
                tbDocSo1.Text = "Đúng";
            }
            else
            {
                tbDocSo1.Text = "Chín mươi bảy nghìn một trăm bốn mươi lăm";
            }
            if (tbDocSo2.Text=="Sáu mươi ba nghìn hai trăm mười một")
            {
                tbDocSo2.Text="Đúng";
            }
            else
            {
                tbDocSo2.Text="Sáu mươi ba nghìn hai trăm mười một";

            }
            if((tbVietSo1.Text=="27150")||(tbVietSo1.Text=="27 150"))
            {
                tbVietSo1.Text = "Đúng";
            }
            else
            {
                tbVietSo1.Text = "27 150";
            }
            if((tbVietSo2.Text=="89371")||(tbVietSo2.Text=="89 371"))
            {
                tbVietSo2.Text = "Đúng";
            }
            else
            { 
                tbVietSo2.Text="89371";
            }
        }

        private void btLamLai_Click(object sender, EventArgs e)
        {
            tbVietSo1.Text = "";
            tbDocSo1.Text = "";
            tbVietSo2.Text = "";
            tbDocSo2.Text = "";
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
