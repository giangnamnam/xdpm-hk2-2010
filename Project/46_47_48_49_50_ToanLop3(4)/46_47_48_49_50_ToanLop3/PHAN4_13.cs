using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace _46_47_48_49_50_ToanLop3
{
    public partial class PHAN4_13 : Form
    {
        public PHAN4_13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblTomTat.Text = "Tóm tắt";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblTT1.Text = "Kho chứa: 27 280kg thóc";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblTT2.Text = "Thóc nếp: bằng 1/4 thóc tẻ";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblTT3.Text = "Thóc nếp:...kg?";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblTT4.Text = "Thóc tẻ:...kg?";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblGiai.Text = "bài giải";
            lblLG1.Text = "Tổng số phần là: ";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblBT1.Text = "1 + 4 = 5 (phần)";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblLG2.Text = "Số kg thóc nếp là:";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblBT2.Text = "27280 : 5 = 5456 (kg)";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblLG3.Text = "Số kg thóc tẻ là";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblBT3.Text = "5456 * 4 = 21824 (kg)";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblDS.Text = " Đáp số: Thóc nếp: 5456 kg ";
            lblDS2.Text = "        Thóc tẻ : 21824 kg";   


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (lblTomTat.Text != "")
            {
                lblTomTat.Text = "";
                lblTT1.Text = "";
                lblTT2.Text = "";
                lblTT3.Text = "";
                lblTT4.Text = "";
                lblGiai.Text = "";
                lblBT1.Text = "";
                lblBT2.Text = "";
                lblDS.Text = "";
                lblLG1.Text = "";
                lblLG2.Text = "";
                lblDS2.Text = "";
                lblBT3.Text = "";
                lblLG3.Text = "";
            }
        }

        private void btnGiaiBai2_Click(object sender, EventArgs e)
        {
            lblBai1TT.Text = "Tóm tắt";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblBai1TT1.Text = "kho chứa: 63 150 lít";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblBai1TT2.Text = "mỗi lần lấy: 10 715 lít";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblBai1TT3.Text = " 3 lần lấy: ....lit?";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblBai1TT4.Text = "trong kho còn: ...lít?";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblBaiGiai1.Text = "Bài giải";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblBai1LG1.Text = "số lít dầu lấy ra trong 3 lần là:";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblBai1BT1.Text = " 10715 x 3 = 32145 (l)";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblBai1LG2.Text = "số lít dầu còn lại trong kho là:";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblBai1BT2.Text = "63150 - 32145 = 31005 (l)";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblbai1DS.Text = "Đáp số: 31005 l";
        }

        private void btnXoaBai2_Click(object sender, EventArgs e)
        {
            if (lblBaiGiai1.Text != "")
            {
                lblBai1TT.Text = "";
                lblBai1TT1.Text = "";
                lblBai1TT2.Text = "";
                lblBai1TT3.Text = "";
                lblBai1TT4.Text = "";
                lblBaiGiai1.Text = "";
                lblBai1BT1.Text = "";
                lblBai1BT2.Text = "";
                lblbai1DS.Text = "";
                lblBai1LG1.Text = "";
                lblBai1LG2.Text = "";

            }

        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            PHAN4_11 frmNhan = new PHAN4_11();
            this.Hide();
            frmNhan.ShowDialog();
            this.Close();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            PHAN4_12 frmChia = new PHAN4_12();
            this.Hide();
            frmChia.ShowDialog();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
