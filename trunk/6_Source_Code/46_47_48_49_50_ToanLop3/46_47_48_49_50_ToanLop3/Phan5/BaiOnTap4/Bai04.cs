using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan5.BaiOnTap4
{
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bai04_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = radioButton4.Checked = false;
            label6.Text = "";
            label6.BackColor = Color.FromArgb(192,192,255);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = radioButton4.Checked = false;
            label6.Text = "";
            label6.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                label6.Text = "Chúc mừng bạn đã trả lời đúng câu hỏi!!!";
                label6.BackColor = Color.FromArgb(255,255,128);

            } 
            else
            {
                label6.Text = "Tiếc quá!! Bạn trả lời sai rồi";
                label6.BackColor = Color.FromArgb(255, 255, 128);
            }
        }
    }
}
