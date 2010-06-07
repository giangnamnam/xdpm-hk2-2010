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
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
            //lblKQ.Visible = false;
            txt4.Visible = false;
            txt5.Visible = false;
            txt6.Visible = false;
            txt7.Visible = false;

        }

        private void btnLLai_Click(object sender, EventArgs e)
        {

            //lblKQ.Visible = false;
            txt4.Visible = false;
            txt5.Visible = false;
            txt6.Visible = false;
            txt7.Visible = false;

            txt0.Text = "";
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
        }

        private void btnXKQua_Click(object sender, EventArgs e)
        {
            //lblKQ.Visible = true;
            txt4.Visible = true;
            txt5.Visible = true;
            txt6.Visible = true;
            txt7.Visible = true;
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
