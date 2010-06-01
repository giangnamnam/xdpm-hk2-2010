using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan5.LuyenTapChung_1
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
            //lblKQ.Visible = false;
            txt4.Visible = false;
            txt5.Visible = false;
            txt6.Visible = false;
            txt7.Visible = false;

        }

        private void txt0_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bai2_Load(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            //lblKQ.Visible = true;
            txt4.Visible = true;
            txt5.Visible = true;
            txt6.Visible = true;
            txt7.Visible = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lblKQ.Visible = false;
            txt4.Visible = false;
            txt5.Visible = false;
            txt6.Visible = false;
            txt7.Visible = false;

            txt0.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
           
        }
    }
}
