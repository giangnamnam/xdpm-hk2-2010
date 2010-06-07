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
    public partial class BDLam : Form
    {
        public BDLam()
        {
            InitializeComponent();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Text = " Tên người mua : Nga , Mỹ , Đức";
            textBox2.Text = " Đồ chơi búp bê và số lượng búp bê mà mỗ bạn mua";
            textBox3.Text = " Đồ chơi xe hơi ,giá tiền ,và số lương xe mỗi bạn mua";
            textBox4.Text = " Đồ chơi máy bay ,giá tiền và số lượng mỗi bạn mua";
            textBox5.Text = "Số tiền phải trả của mỗi bạn";
            textBox6.Text = " Bạn Nga mua 1 búp bê và 4 ô tô";
            textBox7.Text = "Bạn Mỹ mua 1 búp bê , 1 ô tô và 1 máy bay";
            textBox8.Text = " Bạn Đức mua 1 ô tô và 3 máy bay";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bai4b fr = new Bai4b();
            fr.Show();
        }

        
    }
}
