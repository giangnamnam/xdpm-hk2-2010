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
    public partial class PHAN3_LAMQUEN : Form
    {
        public string duongdan = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(Application.StartupPath)) + "\\PHAN3\\";
        public int STT = 1;

         public PHAN3_LAMQUEN()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            
        }

        private void PHAN3_LAMQUEN_Load(object sender, EventArgs e)
        {
            tabControl_.Visible = false;
            Title.Text = "CÁC SỐ CÓ BỐN CHỮ SỐ";
            // Form hiện fullscreen
            Rectangle rect = new Rectangle();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            rect = Screen.PrimaryScreen.WorkingArea;
            this.SetBounds(0, 0, rect.Width, rect.Height);

            // Khởi tạo nền cho form
            Bitmap bmp = new Bitmap(duongdan + "\\HinhAnh\\D.jpg");
            this.BackgroundImage = bmp;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Thiết lập tiêu đề
            Title.Text = "<Tiêu đề>";
            Title.Top = 30;
            Title.Left = (rect.Width - Title.Text.Length*11) / 2; 
                        
            // Thiết lập vị trí tab
            tabControl_.Top = 100;
            tabControl_.Left = 50;
            tabControl_.Width = rect.Width - 250;
            tabControl_.Height = rect.Height - tabControl_.Top-100;

            Bitmap bmp1 = new Bitmap(duongdan + "\\HinhAnh\\tab1.jpg");
            tabPage_LyThuyet.BackgroundImage = bmp1;
            tabPage_LyThuyet.BackgroundImageLayout = ImageLayout.Stretch;

            Bitmap bmp2 = new Bitmap(duongdan + "\\HinhAnh\\tab1.jpg");
            tabPage_BaiTap.BackgroundImage = bmp2;
            tabPage_BaiTap.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox_NoiDung.BringToFront();
            pictureBox_NoiDung.Width = tabControl_.Width-200;
            pictureBox_NoiDung.Height = tabControl_.Height-200;
            pictureBox_NoiDung.Left = tabControl_.Left + 75;
            pictureBox_NoiDung.Top = tabControl_.Top - 50;
            pictureBox_NoiDung.Image = new Bitmap(duongdan + "\\HinhAnh\\LQ91.png");
            pictureBox_NoiDung.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_NoiDung.Show();

            button_Truoc.Width = 89;
            button_Truoc.Left = tabControl_.Left+ tabControl_.Width / 2 - button_Truoc.Width - 50;
            button_Truoc.Top = ( tabControl_.Height - button_Truoc.Height - 100);
            button_Sau.Width = 89;
            button_Sau.Left = button_Truoc.Right + 100;
            button_Sau.Top = button_Truoc.Top;

            button_Truoc.BackgroundImage = new Bitmap(duongdan + "\\HinhAnh\\lui.png");
            button_Truoc.BackgroundImageLayout = ImageLayout.Stretch;
            button_Sau.BackgroundImage = new Bitmap(duongdan + "\\HinhAnh\\toi.png");
            button_Sau.BackgroundImageLayout = ImageLayout.Stretch;

            tabControl_.Visible = true;
        }

        private void DoiBaiHoc()
        {            
            switch (STT)
            {
                case 1: pictureBox_NoiDung.Image = new Bitmap(duongdan + "\\HinhAnh\\LQ91.png");
                    break;
                case 2: pictureBox_NoiDung.Image = new Bitmap(duongdan + "\\HinhAnh\\LQ92.png");
                    break;
                case 3: pictureBox_NoiDung.Image = new Bitmap(duongdan + "\\HinhAnh\\LQ93.png");
                    break;
                case 4: pictureBox_NoiDung.Image = new Bitmap(duongdan + "\\HinhAnh\\LQ94.png");
                    break;
                case 5: pictureBox_NoiDung.Image = new Bitmap(duongdan + "\\HinhAnh\\LQ95.png");
                    break;
            }

        }

        private void button_Sau_Click(object sender, EventArgs e)
        {
            if (STT < 6)
                button_Truoc.Show();
            STT = (STT + 1) % 6;
            if (STT == 5)
                button_Sau.Hide();
            DoiBaiHoc();
        }

        private void button_Truoc_Click(object sender, EventArgs e)
        {
            if (STT > 0)
                button_Sau.Show();
            STT = (STT - 1) % 6;
            if (STT == 1)
                button_Truoc.Hide();
            DoiBaiHoc();

        }



       



    }
}
