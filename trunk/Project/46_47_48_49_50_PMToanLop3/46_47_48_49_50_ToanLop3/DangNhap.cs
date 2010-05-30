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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên");
                this.textBox1.Focus();
            }
            else
            {
               
                MucLuc frmMucLuc = new MucLuc();
                frmMucLuc.ShowDialog();
                this.Close();
               
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(new ThreadStart(GoiFormGioiThieu));
            th.Start();
            Thread.Sleep(1500);
            th.Abort();
        }
        void GoiFormGioiThieu()
        {
            frmSplash frm = new frmSplash();
            frm.ShowDialog();
        }
    }
}
