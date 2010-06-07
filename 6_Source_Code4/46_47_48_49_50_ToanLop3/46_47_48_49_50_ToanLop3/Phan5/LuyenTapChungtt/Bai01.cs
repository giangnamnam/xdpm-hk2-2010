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
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            
        }

        private void Bai01_Load(object sender, EventArgs e)
        {

        }

        private void btnCLai_Click(object sender, EventArgs e)
        {
            txt1.Text = txt2.Text = txt3.Text = "";
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            checkBox1.Checked = checkBox2.Checked = checkBox3.Checked = checkBox4.Checked = false;
        }

        private void btnKQua_Click(object sender, EventArgs e)
        {
            lbl1.Visible=true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            checkBox4.Checked = true;
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
