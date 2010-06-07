using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan5.BaiOnTap2
{
    public partial class Bai05 : Form
    {
        public Bai05()
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

        private void Bai05_Load(object sender, EventArgs e)
        {
            label7.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton3.Checked)
            {
                label7.Text = "Chúc Mừng Bạn Đã Trả Lời Đúng!";
                label7.Text.GetType();
                label7.BackColor=Color.FromArgb(23,123,231);
            }
            else
            {
                label7.Text = "Bạn đã trả lời sai rồi!";
                label7.Text.GetType();
                label7.BackColor = Color.FromArgb(231, 123, 231);
            }
        }


    }
}
