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
    public partial class PHAN3_TINHTOAN : Form
    {
        public string duongdan = Application.StartupPath + "\\PHAN3\\";

         public PHAN3_TINHTOAN()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            
        }

        private void PHAN3_TINHTOAN_Load(object sender, EventArgs e)
        {
            // Form hi?n fullscreen
            Rectangle rect = new Rectangle();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            rect = Screen.PrimaryScreen.WorkingArea;
            this.SetBounds(0, 0, rect.Width, rect.Height);

            // Kh?i t?o n?n cho form
            Bitmap bmp = new Bitmap(duongdan + "\\HinhAnh\\D.jpg");
            this.BackgroundImage = bmp;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Thi?t l?p tiêu ??
            Title.Text = "<Tiêu ??>";
            Title.Top = 30;
            Title.Left = (rect.Width - Title.Text.Length*11) / 2; 

            // Thi?t l?p v? trí các button
            groupBox_Button.Top = 100;
            groupBox_Button.Left = rect.Width - (groupBox_Button.Width + 170);

            // Thi?t l?p v? trí tab
            tabControl_.Top = 100;
            tabControl_.Left = 10;
            tabControl_.Width = groupBox_Button.Left - 150;
            tabControl_.Height = rect.Height - tabControl_.Top-10;

            Bitmap bmp1 = new Bitmap(duongdan + "\\HinhAnh\\tab1.jpg");
            tabPage_LyThuyet.BackgroundImage = bmp1;
            tabPage_LyThuyet.BackgroundImageLayout = ImageLayout.Stretch;

            Bitmap bmp2 = new Bitmap(duongdan + "\\HinhAnh\\tab1.jpg");
            tabPage_BaiTap.BackgroundImage = bmp2;
            tabPage_BaiTap.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Exit_MouseEnter(object sender, EventArgs e)
        {
            button_QuayLai.ForeColor = Color.Red;
        }

        private void button_QuayLai_MouseLeave(object sender, EventArgs e)
        {
            button_QuayLai.ForeColor = Color.Black;
        }

       

       



    }
}
