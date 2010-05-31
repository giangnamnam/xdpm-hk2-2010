using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan5.Bai1
{
    public partial class Bai03a : Form
    {
        public Bai03a()
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
            label10.Text = label11.Text = label12.Text = label9.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="6000+800+10+9")
            {
                label9.Text = "Đúng";
            }
            else
            { 
                label9.Text="Sai";
            }
            if((textBox2.Text=="2000+000+90+6")||(textBox2.Text=="2000+00+90+6")||(textBox2.Text=="2000+0+90+6"))
            {
                label10.Text = "Đúng";
            }
            else
            { 
                label10.Text="Sai";
            }
             if((textBox3.Text=="5000+200+00+4")||(textBox3.Text=="5000+200+0+4"))
            {
                label11.Text = "Đúng";
            }
            else
            { 
                label11.Text="Sai";
            }
             if((textBox4.Text=="1000+000+00+6")||(textBox2.Text=="1000+0+0+5"))
            {
                label12.Text = "Đúng";
            }
            else
            {
                label12.Text = "Sai";
            }

        }



    }
}
