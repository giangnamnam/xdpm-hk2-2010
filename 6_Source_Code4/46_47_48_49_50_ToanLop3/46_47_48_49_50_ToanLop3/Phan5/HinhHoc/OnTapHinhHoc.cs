using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan5.HinhHoc
{
    public partial class OnTapHinhHoc : Form
    {
        public OnTapHinhHoc()
        {
            InitializeComponent();
        }



        private void Bai3_Load(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            Bai2DA.Text = "";
            Bai3DA.Text = "";
            Bai4DA.Text = "";
        }

        


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label2.Text = "6";
            label3.Text = "M";
            label4.Text = "N";

            Bai2DA.Text = "101";
            Bai3DA.Text = "386";
            Bai4DA.Text = "25";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "6")
            {
                label2.Text = "Sai";
            }
            else
            {
                label2.Text = "Đúng";
            }

            if (textBox2.Text != "M")
            {
                label3.Text = "Sai";
            }
            else
            {
                label3.Text = "Đúng";
            }

            if (textBox3.Text != "N")
            {
                label4.Text = "Sai";
            }
            else
            {
                label4.Text = "Đúng";
            }

            if (Bai2TL.Text == "101")
            {
                Bai2DA.Text = "Đúng";
            }
            else
            {
                Bai2DA.Text = "Sai";

            }

            if (Bai3TL.Text == "386")
            {
                Bai3DA.Text = "Đúng";
            }
            else
            {
                Bai3DA.Text = "Sai";
            }

            if (Bai4TL.Text == "25")
            {
                Bai4DA.Text = "Đúng";
            }
            else
            {
                Bai4DA.Text = "Sai";
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
