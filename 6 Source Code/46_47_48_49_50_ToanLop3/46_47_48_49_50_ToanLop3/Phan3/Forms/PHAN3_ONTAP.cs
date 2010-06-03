using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Xml;
namespace _46_47_48_49_50_ToanLop3
{
    public partial class PHAN3_ONTAP : Form
    {
        public string duongdan = Application.StartupPath + "\\PHAN3\\";
        public string pheptinh="+";
        public int DapAn1, DapAn2;

         public PHAN3_ONTAP()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            
        }

        private void PHAN3_ONTAP_Load(object sender, EventArgs e)
        {
            tabControl_.Visible = false;
            tabControl_.SelectedTab = tabPage_LyThuyet;
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
            Title.Text = "Ôn Tập";
            Title.Top = 30;
            Title.Left = (rect.Width - Title.Text.Length*11) / 2; 

            // Thiết lập vị trí các button
            groupBox_Button.Top = 100;
            groupBox_Button.Left = rect.Width - (groupBox_Button.Width + 70);                

            // Thiết lập vị trí tab
            tabControl_.Top = 100;
            tabControl_.Left = 10;
            tabControl_.Width = groupBox_Button.Left - 50;
            tabControl_.Height = rect.Height - tabControl_.Top-10;
            
            Bitmap bmp1 = new Bitmap(duongdan + "\\HinhAnh\\tab1.jpg");
            tabPage_Tinh2So.BackgroundImage = bmp1;
            tabPage_Tinh2So.BackgroundImageLayout = ImageLayout.Stretch;

            Bitmap bmp2 = new Bitmap(duongdan + "\\HinhAnh\\tab1.jpg");
            tabPage_TinhNham.BackgroundImage = bmp2;
            tabPage_TinhNham.BackgroundImageLayout = ImageLayout.Stretch;

            Bitmap bmp3 = new Bitmap(duongdan + "\\HinhAnh\\tab1.jpg");
            tabPage_ToanDo.BackgroundImage = bmp3;
            tabPage_ToanDo.BackgroundImageLayout = ImageLayout.Stretch;

            KhoiTao_Tinh2So(pheptinh);

            groupBox1.Left = tabPage_Tinh2So.Left+150;
            groupBox2.Left = groupBox1.Right + 50;
            groupBox3.Left = groupBox2.Right + 50;
            groupBox4.Left = groupBox2.Left / 2 + 75;
            groupBox5.Left = groupBox4.Right + 50;

            tabControl_.SelectedTab = tabPage_Tinh2So;

            button_TiepTuc.Left = groupBox2.Left + 100;
            button_TiepTuc.Top = tabPage_Tinh2So.Bottom - 120;

            button_KetQua.Top = button_TiepTuc.Top;
            button_KetQua.Left = button_TiepTuc.Left - 250;                     

            button_KetQua.BackColor = Color.Transparent;
            button_TiepTuc.BackColor = Color.Transparent;

            button_KetQua.Top = tabPage_Tinh2So.Bottom - 30;
            button_KetQua.Left = tabPage_Tinh2So.Right / 3;

            button_TiepTuc.Left = button_KetQua.Right + 100;
            button_TiepTuc.Top = button_KetQua.Top;
            tabControl_.Visible = true;            
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

        private void button_TiepTuc_Click(object sender, EventArgs e)
        {
            switch (tabControl_.SelectedIndex)
            {
                case 0:
                    KhoiTao_Tinh2So(pheptinh);
                    break;

                case 1:
                    KhoiTao_TinhNham(pheptinh);
                    break;
                    
                case 2:
                    KhoiTao_ToanDo();
                    break;
            }
        }

        ////////////////////////////////////////////////
        private void KhoiTao_Tinh2So(string dau)
        {
            button_TiepTuc.Show();
            button_KetQua.Show();
            Random x = new Random();            
            x.Next(0, 10000);            
            
            _Dau1.Text = dau;
            _AB1.Text = "";
            _DapAn1.Text = "";

            
            _Dau2.Text = dau;
            _AB2.Text = "";
            _DapAn2.Text = "";

            
            _Dau3.Text = dau;
            _AB3.Text = "";
            _DapAn3.Text = "";

           
            _Dau4.Text = dau;
            _AB4.Text = "";
            _DapAn4.Text = "";

            _Dau5.Text = dau;
            _AB5.Text = "";
            _DapAn5.Text = "";
            
            _A1.Text = x.Next(0, 10000).ToString();
            _A2.Text = x.Next(0, 10000).ToString();
            _A3.Text = x.Next(0, 10000).ToString();
            _A4.Text = x.Next(0, 10000).ToString();
            _A5.Text = x.Next(0, 10000).ToString();

            int _temp1, _temp2, _temp3, _temp4, _temp5;
            switch (dau)
            {                    
                case "+":
                    _temp1 = 10000 - int.Parse(_A1.Text);
                    _B1.Text = x.Next(0, _temp1).ToString();

                    _temp2 = 10000 - int.Parse(_A2.Text);
                    _B2.Text = x.Next(0, _temp2).ToString();

                    _temp3 = 10000 - int.Parse(_A3.Text);
                    _B3.Text = x.Next(0, _temp3).ToString();

                    _temp4 = 10000 - int.Parse(_A4.Text);
                    _B4.Text = x.Next(0, _temp4).ToString();

                    _temp5 = 10000 - int.Parse(_A5.Text);
                    _B5.Text = x.Next(0, _temp5).ToString();
                    break;

                case "-":
                    _B1.Text = x.Next(0, 10000).ToString();
                    _B2.Text = x.Next(0, 10000).ToString();
                    _B3.Text = x.Next(0, 10000).ToString();
                    _B4.Text = x.Next(0, 10000).ToString();
                    _B5.Text = x.Next(0, 10000).ToString();

                    if (int.Parse(_A1.Text) < int.Parse(_B1.Text))
                    {
                        string temp = _A1.Text;
                        _A1.Text = _B1.Text;
                        _B1.Text = temp;
                    }
                    if (int.Parse(_A2.Text) < int.Parse(_B2.Text))
                    {
                        string temp = _A2.Text;
                        _A2.Text = _B2.Text;
                        _B2.Text = temp;
                    }
                    if (int.Parse(_A3.Text) < int.Parse(_B3.Text))
                    {
                        string temp = _A3.Text;
                        _A3.Text = _B3.Text;
                        _B3.Text = temp;
                    }
                    if (int.Parse(_A4.Text) < int.Parse(_B4.Text))
                    {
                        string temp = _A4.Text;
                        _A4.Text = _B4.Text;
                        _B4.Text = temp;
                    }
                    if (int.Parse(_A5.Text) < int.Parse(_B5.Text))
                    {
                        string temp = _A5.Text;
                        _A5.Text = _B5.Text;
                        _B5.Text = temp;
                    }
                    break;

                case "x":
                    _B1.Text = x.Next(2, 10).ToString();
                    _B2.Text = x.Next(2, 10).ToString();
                    _B3.Text = x.Next(2, 10).ToString();
                    _B4.Text = x.Next(2, 10).ToString();
                    _B5.Text = x.Next(2, 10).ToString();
                    
                     _temp1 = 10000 / int.Parse(_B1.Text);
                    _A1.Text = x.Next(0, _temp1).ToString();

                    _temp2 = 10000 / int.Parse(_B2.Text);
                    _A2.Text = x.Next(0, _temp2).ToString();

                    _temp3 = 10000 / int.Parse(_B3.Text);
                    _A3.Text = x.Next(0, _temp3).ToString();

                    _temp4 = 10000 / int.Parse(_B4.Text);
                    _A4.Text = x.Next(0, _temp4).ToString();

                    _temp5 = 10000 / int.Parse(_B5.Text);
                    _A5.Text = x.Next(0, _temp5).ToString();
                    break;
                    
                case ":":
                    _B1.Text = x.Next(2, 10).ToString();
                    _B2.Text = x.Next(2, 10).ToString();
                    _B3.Text = x.Next(2, 10).ToString();
                    _B4.Text = x.Next(2, 10).ToString();
                    _B5.Text = x.Next(2, 10).ToString();
                    break;
            }              
        }

        private void KhoiTao_TinhNham(string dau)
        {
            
            button_TiepTuc.Show();
            button_KetQua.Show();
            Random x = new Random();
            x.Next(0, 10000);

            _pheptinh1.Text = dau;
            _xy1.Text = "";
            _DapAnXY1.Text = "";
            _Du1.Text = "";


            _pheptinh2.Text = dau;
            _xy2.Text = "";
            _DapAnXY2.Text = "";
            _Du2.Text = "";

            _pheptinh3.Text = dau;
            _xy3.Text = "";
            _DapAnXY3.Text = "";
            _Du3.Text = "";

            _pheptinh4.Text = dau;
            _xy4.Text = "";
            _DapAnXY4.Text = "";
            _Du4.Text = "";

            _pheptinh5.Text = dau;
            _xy5.Text = "";
            _DapAnXY5.Text = "";
            _Du5.Text = "";

            _x1.Text = x.Next(0, 5000).ToString();
            _x2.Text = x.Next(0, 5000).ToString();
            _x3.Text = x.Next(0, 5000).ToString();
            _x4.Text = x.Next(0, 5000).ToString();
            _x5.Text = x.Next(0, 5000).ToString();

            _Du1.Hide();
            _Du2.Hide();
            _Du3.Hide();
            _Du4.Hide();
            _Du5.Hide();

            label_Du1.Hide();
            label_Du2.Hide();
            label_Du3.Hide();
            label_Du4.Hide();
            label_Du5.Hide();

            switch (dau)
            {
                case "+":
                    _y1.Text = x.Next(0, 5000).ToString();
                    _y2.Text = x.Next(0, 5000).ToString();
                    _y3.Text = x.Next(0, 5000).ToString();
                    _y4.Text = x.Next(0, 5000).ToString();
                    _y5.Text = x.Next(0, 5000).ToString();
                    break;

                case "-":
                    _y1.Text = x.Next(0, 10000).ToString();
                    _y2.Text = x.Next(0, 10000).ToString();
                    _y3.Text = x.Next(0, 10000).ToString();
                    _y4.Text = x.Next(0, 10000).ToString();
                    _y5.Text = x.Next(0, 10000).ToString();

                    if (int.Parse(_x1.Text) < int.Parse(_y1.Text))
                    {
                        string temp = _x1.Text;
                        _x1.Text = _y1.Text;
                        _y1.Text = temp;
                    }
                    if (int.Parse(_x2.Text) < int.Parse(_y2.Text))
                    {
                        string temp = _x2.Text;
                        _x2.Text = _y2.Text;
                        _y2.Text = temp;
                    }
                    if (int.Parse(_x3.Text) < int.Parse(_y3.Text))
                    {
                        string temp = _x3.Text;
                        _x3.Text = _y3.Text;
                        _y3.Text = temp;
                    }
                    if (int.Parse(_x4.Text) < int.Parse(_y4.Text))
                    {
                        string temp = _x4.Text;
                        _x4.Text = _y4.Text;
                        _y4.Text = temp;
                    }
                    if (int.Parse(_x5.Text) < int.Parse(_y5.Text))
                    {
                        string temp = _x5.Text;
                        _x5.Text = _y5.Text;
                        _y5.Text = temp;
                    }
                    break;

                case "x":
                    _y1.Text = x.Next(2, 10).ToString();
                    _y2.Text = x.Next(2, 10).ToString();
                    _y3.Text = x.Next(2, 10).ToString();
                    _y4.Text = x.Next(2, 10).ToString();
                    _y5.Text = x.Next(2, 10).ToString();

                    int _temp1, _temp2, _temp3, _temp4, _temp5;
                    _temp1 = 10000 / int.Parse(_y1.Text);
                    _x1.Text = x.Next(0, _temp1).ToString();

                    _temp2 = 10000 / int.Parse(_y2.Text);
                    _x2.Text = x.Next(0, _temp2).ToString();

                    _temp3 = 10000 / int.Parse(_y3.Text);
                    _x3.Text = x.Next(0, _temp3).ToString();

                    _temp4 = 10000 / int.Parse(_y4.Text);
                    _x4.Text = x.Next(0, _temp4).ToString();

                    _temp5 = 10000 / int.Parse(_y5.Text);
                    _x5.Text = x.Next(0, _temp5).ToString();
                    break;
                                        
                case ":":
                    _y1.Text = x.Next(2, 10).ToString();
                    _y2.Text = x.Next(2, 10).ToString();
                    _y3.Text = x.Next(2, 10).ToString();
                    _y4.Text = x.Next(2, 10).ToString();
                    _y5.Text = x.Next(2, 10).ToString();

                    _Du1.Show();
                    _Du2.Show();
                    _Du3.Show();
                    _Du4.Show();
                    _Du5.Show();

                    label_Du1.Show();
                    label_Du2.Show();
                    label_Du3.Show();
                    label_Du4.Show();
                    label_Du5.Show();

                    break;
            }

        }

        private void KhoiTao_ToanDo()
        {
            button_TiepTuc.Show();
            button_KetQua.Show();
            label_DeBai1.Text = "";
            label_DeBai2.Text = "";
            label_DonVi1.Text = "";
            label_DonVi2.Text = "";
            _TraLoi1.Text = "";
            _TraLoi2.Text = "";
            _TraLoiDung1.Text = "";
            _TraLoiDung2.Text = "";

            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(duongdan + "\\DuLieu\\CSDL_ToanDo3.xml");
                int n;
                Random r = new Random();
                foreach (DataTable tbl in ds.Tables)
                {
                    n = tbl.Rows.Count;

                    int k = r.Next(0, n - 1);
                    DataRow dr = tbl.Rows[k];
                    label_DeBai1.Text = dr["NoiDung"].ToString();
                    label_DonVi1.Text = dr["DONVI"].ToString();
                    DapAn1 = int.Parse(dr["DAPAN"].ToString());

                    int t;
                    t = r.Next(0, n - 1);
                    while (t == k)
                    {
                        t = r.Next(0, n - 1);
                    }
                    dr = tbl.Rows[t];
                    label_DeBai2.Text = dr["NoiDung"].ToString();
                    label_DonVi2.Text = dr["DONVI"].ToString();
                    DapAn2 = int.Parse(dr["DAPAN"].ToString());
                }
            }
            catch
            {
                return;
            }

        }
        private void KhoiTao_LyThuyet()
        {
            button_KetQua.Hide();
            button_TiepTuc.Hide();
            switch (pheptinh)
            {
                case "+":
                    tabPage_LyThuyet.BackgroundImage = new Bitmap(duongdan + "\\HinhAnh\\phepcong.jpg");
                    
                    break;
                case "-":
                    tabPage_LyThuyet.BackgroundImage = new Bitmap(duongdan + "\\HinhAnh\\pheptru.jpg");
                    break;
                case "x":
                    tabPage_LyThuyet.BackgroundImage = new Bitmap(duongdan + "\\HinhAnh\\phepnhan.jpg");
                    break;
                case ":":
                    tabPage_LyThuyet.BackgroundImage = new Bitmap(duongdan + "\\HinhAnh\\phepchia.jpg");
                    break;
                    
            }
            tabPage_LyThuyet.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void tabControl__Selected(object sender, TabControlEventArgs e)
        {
            switch (tabControl_.SelectedIndex)
            {
                case 0:
                    KhoiTao_Tinh2So(pheptinh);
                    break;

                case 1:
                    KhoiTao_TinhNham(pheptinh);
                    break;

                case 2:
                    KhoiTao_ToanDo();
                    break;
                case 3:
                    KhoiTao_LyThuyet();
                    break;
            }
            
        }
        
        
        
        private void button_KetQua_Click(object sender, EventArgs e)
        {
            switch (tabControl_.SelectedIndex)
            {
                case 0:
                    KiemTra_Tinh2So();
                    break;

                case 1:
                    KiemTra_TinhNham();
                    break;

                case 2:
                    KiemTra_ToanDo();
                    break;
            }

        }

        // Ham tra ve so luong dap an SAI
        private int KiemTra_Tinh2So()
        {
            
            int a1;
            int b1;
            a1 = int.Parse(_A1.Text);
            b1 = int.Parse(_B1.Text);

            int a2;
            int b2;
            a2 = int.Parse(_A2.Text);
            b2 = int.Parse(_B2.Text);

            int a3;
            int b3;
            a3 = int.Parse(_A3.Text);
            b3 = int.Parse(_B3.Text);

            int a4;
            int b4;
            a4 = int.Parse(_A4.Text);
            b4 = int.Parse(_B4.Text);

            int a5;
            int b5;
            a5 = int.Parse(_A5.Text);
            b5 = int.Parse(_B5.Text);

            int count = 0;

            switch (pheptinh)
            {
                case "+":
                    if ((a1 + b1).ToString() != _AB1.Text)
                    {
                        _DapAn1.Text = " Đáp Án : " + (a1 + b1).ToString();
                        count++;
                    }
                    if ((a2 + b2).ToString() != _AB2.Text)
                    {
                        _DapAn2.Text = " Đáp Án : " + (a2 + b2).ToString();
                        count++;
                    }
                    if ((a3 + b3).ToString() != _AB3.Text)
                    {
                        _DapAn3.Text = " Đáp Án : " + (a3 + b3).ToString();
                        count++;
                    }
                    if ((a4 + b4).ToString() != _AB4.Text)
                    {
                        _DapAn4.Text = " Đáp Án : " + (a4 + b4).ToString();
                        count++;
                    }
                    if ((a5 + b5).ToString() != _AB5.Text)
                    {
                        _DapAn5.Text = " Đáp Án : " + (a5 + b5).ToString();
                        count++;
                    }
                    break;

                case "-":
                    if ((a1 - b1).ToString() != _AB1.Text)
                    {
                        _DapAn1.Text = " Đáp Án : " + (a1 - b1).ToString();
                        count++;
                    }
                    if ((a2 - b2).ToString() != _AB2.Text)
                    {
                        _DapAn2.Text = " Đáp Án : " + (a2 - b2).ToString();
                        count++;
                    }
                    if ((a3 - b3).ToString() != _AB3.Text)
                    {
                        _DapAn3.Text = " Đáp Án : " + (a3 - b3).ToString();
                        count++;
                    }
                    if ((a4 - b4).ToString() != _AB4.Text)
                    {
                        _DapAn4.Text = " Đáp Án : " + (a4 - b4).ToString();
                        count++;
                    }
                    if ((a5 - b5).ToString() != _AB5.Text)
                    {
                        _DapAn5.Text = " Đáp Án : " + (a5 - b5).ToString();
                        count++;
                    }
                    break;

                case "x":
                    if ((a1 * b1).ToString() != _AB1.Text)
                    {
                        _DapAn1.Text = " Đáp Án : " + (a1 * b1).ToString();
                        count++;
                    }
                    if ((a2 * b2).ToString() != _AB2.Text)
                    {
                        _DapAn2.Text = " Đáp Án : " + (a2 * b2).ToString();
                        count++;
                    }
                    if ((a3 * b3).ToString() != _AB3.Text)
                    {
                        _DapAn3.Text = " Đáp Án : " + (a3 * b3).ToString();
                        count++;
                    }
                    if ((a4 * b4).ToString() != _AB4.Text)
                    {
                        _DapAn4.Text = " Đáp Án : " + (a4 * b4).ToString();
                        count++;
                    }
                    if ((a5 * b5).ToString() != _AB5.Text)
                    {
                        _DapAn5.Text = " Đáp Án : " + (a5 * b5).ToString();
                        count++;
                    }
                    break;

                case ":":
                    if ((a1 / b1).ToString() != _AB1.Text)
                    {
                        _DapAn1.Text = " Đáp Án : " + (a1 / b1).ToString() + " dư " + (a1 - (a1 / b1) * b1).ToString();
                        count++;
                    }
                    if ((a2 / b2).ToString() != _AB2.Text)
                    {
                        _DapAn2.Text = " Đáp Án : " + (a2 / b2).ToString() + " dư " + (a2 - (a2 / b2) * b2).ToString();
                        count++;
                    }
                    if ((a3 / b3).ToString() != _AB3.Text)
                    {
                        _DapAn3.Text = " Đáp Án : " + (a3 / b3).ToString() + " dư " + (a3 - (a3 / b3) * b3).ToString();
                        count++;
                    }
                    if ((a4 / b4).ToString() != _AB4.Text)
                    {
                        _DapAn4.Text = " Đáp Án : " + (a4 / b4).ToString() + " dư " + (a4 - (a4 / b4) * b4).ToString();
                        count++;
                    }
                    if ((a5 / b5).ToString() != _AB5.Text)
                    {
                        _DapAn5.Text = " Đáp Án : " + (a5 / b5).ToString() + " dư " + (a5 - (a5 / b5) * b5).ToString();
                        count++;
                    }
                    break;
            }
            return count;
        }

        private int KiemTra_TinhNham()
        {
            int a1;
            int b1;
            a1 = int.Parse(_x1.Text);
            b1 = int.Parse(_y1.Text);

            int a2;
            int b2;
            a2 = int.Parse(_x2.Text);
            b2 = int.Parse(_y2.Text);

            int a3;
            int b3;
            a3 = int.Parse(_x3.Text);
            b3 = int.Parse(_y3.Text);

            int a4;
            int b4;
            a4 = int.Parse(_x4.Text);
            b4 = int.Parse(_y4.Text);

            int a5;
            int b5;
            a5 = int.Parse(_x5.Text);
            b5 = int.Parse(_y5.Text);

            int count = 0;

            switch (pheptinh)
            {
                case "+":
                    if ((a1 + b1).ToString() != _xy1.Text)
                    {
                        _DapAnXY1.Text = " Đáp Án : " + (a1 + b1).ToString();
                        count++;
                    }
                    if ((a2 + b2).ToString() != _xy2.Text)
                    {
                        _DapAnXY2.Text = " Đáp Án : " + (a2 + b2).ToString();
                        count++;
                    }
                    if ((a3 + b3).ToString() != _xy3.Text)
                    {
                        _DapAnXY3.Text = " Đáp Án : " + (a3 + b3).ToString();
                        count++;
                    }
                    if ((a4 + b4).ToString() != _xy4.Text)
                    {
                        _DapAnXY4.Text = " Đáp Án : " + (a4 + b4).ToString();
                        count++;
                    }
                    if ((a5 + b5).ToString() != _xy5.Text)
                    {
                        _DapAnXY5.Text = " Đáp Án : " + (a5 + b5).ToString();
                        count++;
                    }
                    break;

                case "-":
                    if ((a1 - b1).ToString() != _xy1.Text)
                    {
                        _DapAnXY1.Text = " Đáp Án : " + (a1 - b1).ToString();
                        count++;
                    }
                    if ((a2 - b2).ToString() != _xy2.Text)
                    {
                        _DapAnXY2.Text = " Đáp Án : " + (a2 - b2).ToString();
                        count++;
                    }
                    if ((a3 - b3).ToString() != _xy3.Text)
                    {
                        _DapAnXY3.Text = " Đáp Án : " + (a3 - b3).ToString();
                        count++;
                    }
                    if ((a4 - b4).ToString() != _xy4.Text)
                    {
                        _DapAnXY4.Text = " Đáp Án : " + (a4 - b4).ToString();
                        count++;
                    }
                    if ((a5 - b5).ToString() != _xy5.Text)
                    {
                        _DapAnXY5.Text = " Đáp Án : " + (a5 - b5).ToString();
                        count++;
                    }
                    break;

                case "x":
                    if ((a1 * b1).ToString() != _xy1.Text)
                    {
                        _DapAnXY1.Text = " Đáp Án : " + (a1 * b1).ToString();
                        count++;
                    }
                    if ((a2 * b2).ToString() != _xy2.Text)
                    {
                        _DapAnXY2.Text = " Đáp Án : " + (a2 * b2).ToString();
                        count++;
                    }
                    if ((a3 * b3).ToString() != _xy3.Text)
                    {
                        _DapAnXY3.Text = " Đáp Án : " + (a3 * b3).ToString();
                        count++;
                    }
                    if ((a4 * b4).ToString() != _xy4.Text)
                    {
                        _DapAnXY4.Text = " Đáp Án : " + (a4 * b4).ToString();
                        count++;
                    }
                    if ((a5 * b5).ToString() != _xy5.Text)
                    {
                        _DapAnXY5.Text = " Đáp Án : " + (a5 * b5).ToString();
                        count++;
                    }
                    break;

                case ":":
                    if ((a1 / b1).ToString() != _xy1.Text )
                    {
                        _DapAnXY1.Text = " Đáp Án : " + (a1 / b1).ToString() + " dư " + (a1 - (a1/b1)*b1).ToString() ;
                        count++;
                    }
                    if ((a2 / b2).ToString() != _xy2.Text)
                    {
                        _DapAnXY2.Text = " Đáp Án : " + (a2 / b2).ToString() + " dư " + (a2 - (a2 / b2) * b2).ToString();
                        count++;
                    }
                    if ((a3 / b3).ToString() != _xy3.Text)
                    {
                        _DapAnXY3.Text = " Đáp Án : " + (a3 / b3).ToString() + " dư " + (a3 - (a3 / b3) * b3).ToString();
                        count++;
                    }
                    if ((a4 / b4).ToString() != _xy4.Text)
                    {
                        _DapAnXY4.Text = " Đáp Án : " + (a4 / b4).ToString() + " dư " + (a4 - (a4 / b4) * b4).ToString();
                        count++;
                    }
                    if ((a5 / b5).ToString() != _xy5.Text)
                    {
                        _DapAnXY5.Text = " Đáp Án : " + (a5 / b5).ToString() + " dư " + (a5 - (a5 / b5) * b5).ToString();
                        count++;
                    }
                    break;
            }
            return count;
        }

        private int KiemTra_ToanDo()
        {
            int count = 0;
            if (DapAn1.ToString() != _TraLoi1.Text)
            {
                _TraLoiDung1.Text = "Đáp Án : " + DapAn1.ToString();
                count++;
            }

            if (DapAn2.ToString() != _TraLoi2.Text)
            {
                _TraLoiDung2.Text = "Đáp Án : " + DapAn2.ToString();
                count++;
            }
            return count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pheptinh = "+";
            switch (tabControl_.SelectedIndex)
            {
                case 0:
                    KhoiTao_Tinh2So(pheptinh);
                    break;

                case 1:
                    KhoiTao_TinhNham(pheptinh);
                    break;

                case 3:
                    KhoiTao_LyThuyet();
                    break;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pheptinh = "-";
            switch (tabControl_.SelectedIndex)
            {
                case 0:
                    KhoiTao_Tinh2So(pheptinh);
                    break;

                case 1:
                    KhoiTao_TinhNham(pheptinh);
                    break;
                case 3:
                    KhoiTao_LyThuyet();
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pheptinh = "x";
            switch (tabControl_.SelectedIndex)
            {
                case 0:
                    KhoiTao_Tinh2So(pheptinh);
                    break;

                case 1:
                    KhoiTao_TinhNham(pheptinh);
                    break;
                case 3:
                    KhoiTao_LyThuyet();
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pheptinh = ":";
            switch (tabControl_.SelectedIndex)
            {
                case 0:
                    KhoiTao_Tinh2So(pheptinh);
                    break;

                case 1:
                    KhoiTao_TinhNham(pheptinh);
                    break;
                case 3:
                    KhoiTao_LyThuyet();
                    break;
            }
        }

        private void button_KetQua_MouseEnter(object sender, EventArgs e)
        {
            button_KetQua.ForeColor = Color.Red;
        }

        private void button_KetQua_MouseLeave(object sender, EventArgs e)
        {
            button_KetQua.ForeColor = Color.Pink;
        }

        private void button_TiepTuc_MouseEnter(object sender, EventArgs e)
        {
            button_TiepTuc.ForeColor = Color.Red;
        }

        private void button_TiepTuc_MouseLeave(object sender, EventArgs e)
        {
            button_TiepTuc.ForeColor = Color.Pink;
        }

        private void tabPage_KetThuc_Click(object sender, EventArgs e)
        {

        }

        private void tabPage_Tinh2So_Click(object sender, EventArgs e)
        {

        }








    }
}
