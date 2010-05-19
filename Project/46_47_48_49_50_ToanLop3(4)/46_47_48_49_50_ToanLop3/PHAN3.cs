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
        public int[] _X = {  30,  30, 430, 430 };
        public int[] _Y = { 130, 530, 530, 130 };
        
        public int i1 = 0;
        public int i2 = 1;
        public int i3 = 2;
        public int i4 = 3;
        public int delta = 5;

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
         //   groupBox_Button.Top=(rect.Height-groupBox_Button.Height)/2;
         //   groupBox_Button.Left = 300;

            groupBox_Button.Hide();

            BongBongBay();
            timer1.Interval = 10;
            timer1.Start();

            button_TamBiet.Left = 250;
            button_TamBiet.Top = 400;

        }

        private void BongBongBay()
        {
            //Creating circle path
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            //path.AddEllipse(10, 10, 155, 155);
            path.AddEllipse(10, 14, 180, 177);

            //bong bong 1
            button_bongbong1.FlatStyle = FlatStyle.Standard;
            button_bongbong1.Width = 200;
            button_bongbong1.Height = 200;
            button_bongbong1.Text = "";//Tập Làm Quen";
            button_bongbong1.TextAlign = ContentAlignment.TopLeft;
            button_bongbong1.Region = new Region(path);
            button_bongbong1.BackgroundImage = new Bitmap(duongdan + "\\HinhAnh\\lamquen1.png");
            button_bongbong1.BackgroundImageLayout = ImageLayout.None;
            button_bongbong1.Left = _X[i1];
            button_bongbong1.Top = _Y[i1];

            //bong bong 2
            button_bongbong2.FlatStyle = FlatStyle.Standard;
            button_bongbong2.Width = 200;
            button_bongbong2.Height = 200;
            button_bongbong2.Text = "";//Tập Làm Quen";
            button_bongbong2.TextAlign = ContentAlignment.TopLeft;
            button_bongbong2.Region = new Region(path);
            button_bongbong2.BackgroundImage = new Bitmap(duongdan + "\\HinhAnh\\tinhtoan1.png");
            button_bongbong2.BackgroundImageLayout = ImageLayout.None;
            button_bongbong2.Left = _X[i2];
            button_bongbong2.Top = _Y[i2];

            //bong bong 3
            button_bongbong3.FlatStyle = FlatStyle.Standard;
            button_bongbong3.Width = 200;
            button_bongbong3.Height = 200;
            button_bongbong3.Text = "";//Tập Làm Quen";
            button_bongbong3.TextAlign = ContentAlignment.TopLeft;
            button_bongbong3.Region = new Region(path);
            button_bongbong3.BackgroundImage = new Bitmap(duongdan + "\\HinhAnh\\morong1.png");
            button_bongbong3.BackgroundImageLayout = ImageLayout.None;
            button_bongbong3.Left = _X[i3];
            button_bongbong3.Top = _Y[i3];

            //bong bong 4
            button_bongbong4.FlatStyle = FlatStyle.Standard;
            button_bongbong4.Width = 200;
            button_bongbong4.Height = 200;
            button_bongbong4.Text = "";//Tập Làm Quen";
            button_bongbong4.TextAlign = ContentAlignment.TopLeft;
            button_bongbong4.Region = new Region(path);
            button_bongbong4.BackgroundImage = new Bitmap(duongdan + "\\HinhAnh\\ontap1.png");
            button_bongbong4.BackgroundImageLayout = ImageLayout.None;
            button_bongbong4.Left = _X[i4];
            button_bongbong4.Top = _Y[i4];
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            // 4 dinh hinh vuong
            if (button_bongbong1.Left == _X[i2] && button_bongbong1.Top == _Y[i2])
            {               
                int temp = i1;
                i1 = i2;
                i2 = i3;
                i3 = i4;
                i4 = temp;

                return;                
            }

            // canh thu 1 : canh ngang duoi
            if (button_bongbong1.Left < _X[i2])
            {
                button_bongbong1.Left += delta;
                button_bongbong2.Top -= delta;
                button_bongbong3.Left -= delta;
                button_bongbong4.Top += delta;

                if (button_bongbong1.Left > _X[i2])
                {
                    button_bongbong1.Left = _X[i2];
                    button_bongbong2.Top = _Y[i3];
                    button_bongbong3.Left = _X[i4];
                    button_bongbong4.Top = _Y[i1];
                }
                return;
            }

            // canh thu 3 : canh ngang tren
            if (button_bongbong1.Left > _X[i2])
            {
                button_bongbong1.Left -= delta;
                button_bongbong2.Top += delta;
                button_bongbong3.Left += delta;
                button_bongbong4.Top -= delta;

                if (button_bongbong1.Left < _X[i2])
                {
                    button_bongbong1.Left = _X[i2];
                    button_bongbong2.Top = _Y[i3];
                    button_bongbong3.Left = _X[i4];
                    button_bongbong4.Top = _Y[i1];
                }
                return;
            }

            // canh thu 4 : canh doc trai
            if (button_bongbong1.Top < _Y[i2])
            {
                button_bongbong1.Top += delta;
                button_bongbong2.Left += delta;
                button_bongbong3.Top -= delta;
                button_bongbong4.Left -= delta;

                if (button_bongbong1.Top > _Y[i2])
                {
                    button_bongbong1.Top = _Y[i2];
                    button_bongbong2.Left = _X[i3];
                    button_bongbong3.Top = _Y[i4];
                    button_bongbong4.Left = _X[i1];
                }
                return;
            }

            // canh thu 2 : canh doc phai
            if (button_bongbong1.Top > _Y[i2])
            {
                button_bongbong1.Top -= delta;
                button_bongbong2.Left -= delta;
                button_bongbong3.Top += delta;
                button_bongbong4.Left += delta;

                if (button_bongbong1.Top < _Y[i2])
                {
                    button_bongbong1.Top = _Y[i2];
                    button_bongbong2.Left = _X[i3];
                    button_bongbong3.Top = _Y[i4];
                    button_bongbong4.Left = _X[i1];
                }
                return;
            }
            
        }

        private void button_bongbong1_Click(object sender, EventArgs e)
        {
            PHAN3_LAMQUEN f1 = new PHAN3_LAMQUEN();
            f1.ShowDialog();
        }

        private void button_bongbong2_Click(object sender, EventArgs e)
        {
            PHAN3_TINHTOAN f2 = new PHAN3_TINHTOAN();
            f2.ShowDialog();
        }

        private void button_bongbong3_Click(object sender, EventArgs e)
        {
            PHAN3_MORONG f3 = new PHAN3_MORONG();
            f3.ShowDialog();
        }

        private void button_bongbong4_Click(object sender, EventArgs e)
        {
            PHAN3_ONTAP f4 = new PHAN3_ONTAP();
            f4.ShowDialog();
        }

        private void button_bongbong1_MouseEnter(object sender, EventArgs e)
        {
            ThayDoiTocDo(true);
            DoiHinh(button_bongbong1, "lamquen2.png");
        }

        private void button_bongbong1_MouseLeave(object sender, EventArgs e)
        {
            ThayDoiTocDo(false);
            DoiHinh(button_bongbong1, "lamquen1.png");
        }

        private void button_bongbong2_MouseEnter(object sender, EventArgs e)
        {
            ThayDoiTocDo(true);
            DoiHinh(button_bongbong2, "tinhtoan2.png");
        }

        private void button_bongbong2_MouseLeave(object sender, EventArgs e)
        {
            ThayDoiTocDo(false);
            DoiHinh(button_bongbong2, "tinhtoan1.png");
        }

        private void button_bongbong3_MouseEnter(object sender, EventArgs e)
        {
            ThayDoiTocDo(true);
            DoiHinh(button_bongbong3, "morong2.png");
        }

        private void button_bongbong3_MouseLeave(object sender, EventArgs e)
        {
            ThayDoiTocDo(false);
            DoiHinh(button_bongbong3, "morong1.png");
        }

        private void button_bongbong4_MouseEnter(object sender, EventArgs e)
        {
            ThayDoiTocDo(true);
            DoiHinh(button_bongbong4, "ontap2.png");
        }

        private void button_bongbong4_MouseLeave(object sender, EventArgs e)
        {
            ThayDoiTocDo(false);
            DoiHinh(button_bongbong4, "ontap1.png");
        }

        private void ThayDoiTocDo(bool flag)
        {
            if (flag == true)
            {
                delta = 2;
                timer1.Interval = 50;
            }
            else
            {
                delta = 5;
                timer1.Interval = 10;
            }
        }

        private void DoiHinh(Button btn, string TenHinh)
        {
            Bitmap bmp = new Bitmap(duongdan + "\\HinhAnh\\" + TenHinh);
            btn.BackgroundImage = bmp;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button_TamBiet_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
