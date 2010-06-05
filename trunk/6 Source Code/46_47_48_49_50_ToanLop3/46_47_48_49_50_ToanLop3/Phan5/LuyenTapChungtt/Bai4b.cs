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
    public partial class Bai4b : Form
    {
        public Bai4b()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            txt1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Bạn Nga phải trả là: 1 x 12000 + 4 x 2000 = 20000 đồng";
            textBox2.Text = "Bạn Mỹ phải trả là: 1 x 12000 + 1 x 2000 + 1 x 6000 = 20000 đồng";
            textBox3.Text = "Bạn Đức phải trả là: 1 x 2000 + 3 x 6000 = 20000 đồng";
            txt1.Text = "Em có thể mua ô tô , máy bay ,búp bê với số lượng là 1 cái";
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
    }
}
