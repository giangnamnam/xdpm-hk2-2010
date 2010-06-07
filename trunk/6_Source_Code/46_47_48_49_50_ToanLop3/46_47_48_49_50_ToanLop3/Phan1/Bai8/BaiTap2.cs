using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan1.Bai8
{
    public partial class BaiTap2 : UserControl
    {
        public BaiTap2()
        {
            InitializeComponent();
        }

        private void btHoanThanh_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Ban hay check vao dap an");
            }
            else
            {
                if (radioButton1.Checked == true)
                {
                    MessageBox.Show("Ban da chon dung ^_^");
                }
                else
                {
                    MessageBox.Show("Ban chon khong chinh xac @_@");
                }
            }
        }

        private void tbkiemtra_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dap an la : Hinh 1");
        }

        private void btLamlai_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
