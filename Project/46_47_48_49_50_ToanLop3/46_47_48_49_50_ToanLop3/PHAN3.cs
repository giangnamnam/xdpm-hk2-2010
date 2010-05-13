using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3
{
    public partial class PHAN3 : Form
    {
        public string duongdan = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(Application.StartupPath)) + "\\PHAN3\\";

         public PHAN3()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void PHAN3_Load(object sender, EventArgs e)
        {
            // Form hiện fullscreen
            Rectangle rect = new Rectangle();
            this.FormBorderStyle = FormBorderStyle.None;
         //   this.TopMost = true;
            rect = Screen.PrimaryScreen.WorkingArea;
            this.SetBounds(0, 0, rect.Width, rect.Height);

            // Khởi tạo nền cho form
            Bitmap bmp = new Bitmap(duongdan + "\\HinhAnh\\nen_chinh.jpg");
            this.BackgroundImage = bmp;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Thiết lập tiêu đề
            Title.Text = "CÁC SỐ TRONG PHẠM VI 10 000";
            Title.Top = 30;
            Title.Left = (rect.Width - Title.Text.Length * 11) / 2; 

            // Vị trí button
            groupBox_Button.Top=(rect.Height-groupBox_Button.Height)/2;
            groupBox_Button.Left = 300;
            
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PHAN3_LAMQUEN f1 = new PHAN3_LAMQUEN();
            f1.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PHAN3_TINHTOAN f2 = new PHAN3_TINHTOAN();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PHAN3_MORONG f3 = new PHAN3_MORONG();
            f3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PHAN3_ONTAP f4 = new PHAN3_ONTAP();
            f4.ShowDialog();
        }

        private void button_Exit_MouseEnter(object sender, EventArgs e)
        {
            button_Exit.ForeColor = Color.Red;
        }

        private void button_Exit_MouseLeave(object sender, EventArgs e)
        {
            button_Exit.ForeColor = Color.Black;
        }





    }
}
