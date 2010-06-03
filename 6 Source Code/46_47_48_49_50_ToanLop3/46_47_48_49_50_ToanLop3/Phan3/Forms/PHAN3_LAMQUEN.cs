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
        public string duongdan = Application.StartupPath + "\\PHAN3\\";
        public int STT = 1;

         public PHAN3_LAMQUEN()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            
        }

        private void PHAN3_LAMQUEN_Load(object sender, EventArgs e)
        {
            tabControl_.Visible = false;
            Title.Text = "LÀM QUEN CÁC SỐ TRONG PHẠM VI 10000";
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

            // Khoi tao giao dien BT1
            Bitmap bmp_BT1 = new Bitmap(duongdan + "\\HinhAnh\\LQ_BT1.png");              
            pictureBox1.Image = bmp_BT1;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = bmp_BT1;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = bmp_BT1;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = bmp_BT1;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Image = bmp_BT1;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            groupBox1.Left = tabControl_.Left + (tabControl_.Width - groupBox1.Width) / 2;
            groupBox1.Top = 89;

            tabControl_.Visible = true;
            button1.Left = rect.Right - 200;
            button1.Top = rect.Bottom - 200;
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

        private void KhoiTao_LyThuyet()
        {
        }

        private void KhoiTao_BT1()
        {
            Random r = new Random();
            int giatri = r.Next(500, 9993);
            int n = r.Next(3, 5);
            RandomSoVaoTextbox(giatri, n, textBox1, textBox2, textBox3, textBox4, textBox5, textBox6);
            giatri = r.Next(500, 9993);
            n = r.Next(3, 5);
            RandomSoVaoTextbox(giatri, n, textBox7, textBox8, textBox9, textBox10, textBox11, textBox12);
            giatri = r.Next(500, 9993);
            n = r.Next(3, 5);
            RandomSoVaoTextbox(giatri, n, textBox13, textBox14, textBox15, textBox16, textBox17, textBox18);
            giatri = r.Next(500, 9993);
            n = r.Next(2, 5);
            RandomSoVaoTextbox(giatri, n, textBox19, textBox20, textBox21, textBox22, textBox23, textBox24);
            giatri = r.Next(500, 9993);
            n = r.Next(2, 6);
            RandomSoVaoTextbox(giatri, n, textBox25, textBox26, textBox27, textBox28, textBox29, textBox30);
        }

        private void KhoiTao_BT2()
        {
        }

        private void RandomSoVaoTextbox(int giatri, int n, TextBox tb1, TextBox tb2, TextBox tb3, TextBox tb4, TextBox tb5, TextBox tb6)
        {
            tb1.Text = tb2.Text = tb3.Text = tb4.Text = tb5.Text = tb6.Text = "";
            tb1.BackColor = tb2.BackColor = tb3.BackColor = tb4.BackColor = tb5.BackColor = tb6.BackColor = Color.Pink;
            tb1.ForeColor = tb2.ForeColor = tb3.ForeColor = tb4.ForeColor = tb5.ForeColor = tb6.ForeColor = Color.White;
            tb1.Enabled = tb2.Enabled = tb3.Enabled = tb4.Enabled = tb5.Enabled = tb6.Enabled = true;

            Random r ;
            r = new Random();
            r.Next();         
            
            bool[] M = new bool[6];
            for (int i = 0; i < 6; i++)
            {
                M[i] = false;
            }

            for (int i = 0; i < n; i++)
            {
                int index ;
                index = r.Next(1, 6);                
                while (M[index - 1] == true)
                {
                    index = r.Next(1, 6);
                }
                if (M[index - 1] == false)
                    M[index - 1] = true;
                
                switch (index)
                {
                    case 1: tb1.Text = (giatri + 1).ToString();
                        tb1.Enabled = false;
                        tb1.BackColor = Color.GreenYellow;
                        tb1.ForeColor = Color.BlueViolet;
                        break;
                    case 2: tb2.Text = (giatri + 2).ToString();
                        tb2.Enabled = false;
                        tb2.BackColor = Color.GreenYellow;
                        tb2.ForeColor = Color.BlueViolet;
                        break;
                    case 3: tb3.Text = (giatri + 3).ToString();
                        tb3.Enabled = false;
                        tb3.BackColor = Color.GreenYellow;
                        tb3.ForeColor = Color.BlueViolet;
                        break;
                    case 4: tb4.Text = (giatri + 4).ToString();
                        tb4.Enabled = false;
                        tb4.BackColor = Color.GreenYellow;
                        tb4.ForeColor = Color.BlueViolet;
                        break;
                    case 5: tb5.Text = (giatri + 5).ToString();
                        tb5.Enabled = false;
                        tb5.BackColor = Color.GreenYellow;
                        tb5.ForeColor = Color.BlueViolet;
                        break;
                    case 6: tb6.Text = (giatri + 6).ToString();
                        tb6.Enabled = false;
                        tb6.BackColor = Color.GreenYellow;
                        tb6.ForeColor = Color.BlueViolet;
                        break;
                }                
            }            
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            switch (tabControl_.SelectedIndex)
            {
                case 0:
                    KhoiTao_LyThuyet();
                    break;

                case 1:
                    KhoiTao_BT1();
                    break;

                case 2:
                    KhoiTao_BT2();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        



       



    }
}
