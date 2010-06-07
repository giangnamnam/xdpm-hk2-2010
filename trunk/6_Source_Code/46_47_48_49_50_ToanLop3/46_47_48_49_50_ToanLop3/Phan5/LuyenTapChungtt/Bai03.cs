using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan5.LuyenTapChungtt
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
            label3.Visible = false;
            txt2.Visible = false;
        }

        private void btnLLai_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Visible = false;
            label3.Visible = false;
        }

        private void btnBGiai_Click(object sender, EventArgs e)
        {
            txt2.Visible = true;
            label3.Visible = true;
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
