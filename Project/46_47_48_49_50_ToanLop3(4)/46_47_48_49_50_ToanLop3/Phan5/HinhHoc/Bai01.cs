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
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void Bai01_Load(object sender, EventArgs e)
        {
            labelA.Text = "";
            labelB.Text = "";
            labelC.Text = "";
            labelD.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxA.Text == "8")
            {
                labelA.ForeColor = Color.Green;
                labelA.Text = "Đúng";
            }
            else
            {
                labelA.ForeColor = Color.Red;
                labelA.Text = "Sai";
            }

            if (textBoxB.Text == "10")
            {
                labelB.ForeColor = Color.Green;
                labelB.Text = "Đúng";
            }
            else
            {
                labelB.ForeColor = Color.Red;
                labelB.Text = "Sai";
            }

            if (textBoxC.Text == "18")
            {
                labelC.ForeColor = Color.Green;
                labelC.Text = "Đúng";
            }
            else
            {
                labelC.ForeColor = Color.Red;
                labelC.Text = "Sai";
            }

            if (textBoxD.Text == "8")
            {
                labelD.ForeColor = Color.Green;
                labelD.Text = "Đúng";
            }
            else
            {
                labelD.ForeColor = Color.Red;
                labelD.Text = "Sai";
            }

        }

        private void Thoat_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            labelA.ForeColor = Color.Red;
            labelA.Text = "8";
            labelB.ForeColor = Color.Red;
            labelB.Text = "10";
            labelC.ForeColor = Color.Red;
            labelC.Text = "18";
            labelD.ForeColor = Color.Red;
            labelD.Text = "8";
        }

    }
}
