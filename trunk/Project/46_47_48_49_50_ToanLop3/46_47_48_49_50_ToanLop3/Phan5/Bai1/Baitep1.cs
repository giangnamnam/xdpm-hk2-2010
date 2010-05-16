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
    public partial class Baitap1 : Form
    {
        public Baitap1()
        {
            InitializeComponent();
        }

        private void Bai01_Load(object sender, EventArgs e)
        {
            
            
        }

        private void BtQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLamXong_Click(object sender, EventArgs e)
        {
            if (tbVietSo1.Text == "45913")
            {
                tbVietSo1.Text = "Đúng";

            }
            else
            {
                tbVietSo1.Text = "45913";
            }

            ///////////////////////
            if (tbVietSo2.Text == "63721")
            {
                tbVietSo2.Text = "Đúng";

            }
            else
            {
                tbVietSo1.Text = "63721";
            }

            /////////////////////////
            if (tbVietSo3.Text == "47533")
            {
                tbVietSo3.Text = "Đúng";

            }
            else
            {
                tbVietSo1.Text = "47533";
            }

            //////////////////////////////////
            if (tbVietChu1.Text == "bốn mươi lăm nghìn chín trăm mười ba")
            {
                tbVietChu1.Text = "Đúng";

            }
            else
            {
                tbVietChu1.Text = "bốn mươi lăm nghìn chín trăm mười ba";
            }
            //////////////////////////////

            if (tbVietChu2.Text == "sáu mươi ba nghìn bảy trăm hai mươi mốt")
            {
                tbVietChu2.Text = "Đúng";

            }
            else
            {
                tbVietChu2.Text = "sáu mươi ba nghìn bảy trăm hai mươi mốt";
            }
            //////////////////////////

            if (tbVietChu3.Text == "bốn mươi bảy nghìn năm trăm ba mươi ba")
            {
                tbVietChu3.Text = "Đúng";

            }
            else
            {
                tbVietChu1.Text = "bốn mươi bảy nghìn năm trăm ba mươi ba";
            }

        }

        private void btLamLai_Click(object sender, EventArgs e)
        {
            tbVietSo1.Text = "";
            tbVietSo2.Text = "";
            tbVietSo3.Text = "";
            tbVietChu1.Text = "";
            tbVietChu2.Text = "";
            tbVietChu3.Text = "";
        }

        private void tbVietSo2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btQuaylai_Click_1(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
