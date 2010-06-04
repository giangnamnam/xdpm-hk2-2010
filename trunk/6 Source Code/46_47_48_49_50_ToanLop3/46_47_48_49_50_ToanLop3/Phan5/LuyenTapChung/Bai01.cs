using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan5.LuyenTapChung
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void Bai01_Load(object sender, EventArgs e)
        {

        }

        private void btnLXong_Click(object sender, EventArgs e)
        {

            if (txta.Text == "76245")
            {
                lbl1.Text = "Đúng";
            }
            else
            {
                lbl1.Text = "Sai";
            }
            if ((txtb.Text == "51807"))
            {
                lbl2.Text = "Đúng";
            }
            else
            {
                lbl2.Text = "Sai";
            }
            if ((txtc.Text == "90900"))
            {
                lbl3.Text = "Đúng";
            }
            else
            {
                lbl3.Text = "Sai";
            }
            if ((txtd.Text == "22002"))
            {
                lbl4.Text = "Đúng";
            }
            else
            {
                lbl4.Text = "Sai";
            }

        }

        private void btnLLai_Click(object sender, EventArgs e)
        {

            txta.Text = txtb.Text = txtc.Text = txtd.Text = "";
            lbl1.Text = lbl2.Text = lbl3.Text = lbl4.Text = "";
        }

        private void btnKQua_Click(object sender, EventArgs e)
        {

            lbl1.Text = "76245";
            lbl2.Text = "51807";
            lbl3.Text = "90900";
            lbl4.Text = "22002";
        }

        private void btnQLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

       
    }
}
