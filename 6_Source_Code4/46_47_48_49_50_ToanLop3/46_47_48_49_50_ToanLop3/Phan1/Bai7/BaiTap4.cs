using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan1.Bai7
{
    public partial class BaiTap4 : UserControl
    {
        public BaiTap4()
        {
            InitializeComponent();
        }

        private void BaiTap4_Load(object sender, EventArgs e)
        {
            
        }

        private void btHoanThanh_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("Ban cho dung roi ^_^");
            }
            if (radioButton2.Checked == true)
            {
                MessageBox.Show("Ban cho chua chinh xac @_@");
            }
            if (radioButton3.Checked == true)
            {
                MessageBox.Show("Ban cho chua chinh xac @_@");
            }
            if(radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {
                MessageBox.Show("Ban hay chon dap an ?_?");
            }
        }

        private void tbkiemtra_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dap an la : 21 là kết quả của g; 8 là kết quả của a, c, e; 40 là kết quả d; 28 là kết quả b, f");
        }

        private void btLamlai_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
