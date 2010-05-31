using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan1.Bai_11
{
    public partial class BaiTap3 : UserControl
    {
        public BaiTap3()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btLamLai_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void btXemKetQua_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void tbHoanThanh_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false )
            {
                MessageBox.Show("Bạn hãy chọn đáp án");
            }
            else
            {
                if (radioButton1.Checked == true)
                {
                    MessageBox.Show("Bạn chọn đúng rồi ^_^ chúc mừng nha");
                }
                else
                {
                    MessageBox.Show("Bạn chọn chưa chính xác ");
                }
            }
        }
    }
}
