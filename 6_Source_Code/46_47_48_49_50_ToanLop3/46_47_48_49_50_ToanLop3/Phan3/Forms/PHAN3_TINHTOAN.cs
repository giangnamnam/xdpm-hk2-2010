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
        public string duongdan = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(Application.StartupPath)) + "\\PHAN3\\";

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

            Bitmap bmp1 = new Bitmap(duongdan + "\\HinhAnh\\tab1.jpg");
            tabPage_LyThuyet.BackgroundImage = bmp1;
            tabPage_LyThuyet.BackgroundImageLayout = ImageLayout.Stretch;

            Bitmap bmp2 = new Bitmap(duongdan + "\\HinhAnh\\tab1.jpg");
            tabPage_BaiTapSoSanh.BackgroundImage = bmp2;
            tabPage_BaiTapSoSanh.BackgroundImageLayout = ImageLayout.Stretch;

            Bitmap bmp3 = new Bitmap(duongdan + "\\HinhAnh\\tab1.jpg");
            tabPage_BaiTapPhepCong.BackgroundImage = bmp3;
            tabPage_BaiTapPhepCong.BackgroundImageLayout = ImageLayout.Stretch;

            Bitmap bmp4 = new Bitmap(duongdan + "\\HinhAnh\\tab1.jpg");
            tabPage_BaiTapPhepTru.BackgroundImage = bmp4;
            tabPage_BaiTapPhepTru.BackgroundImageLayout = ImageLayout.Stretch;

            Bitmap bmp5 = new Bitmap(duongdan + "\\HinhAnh\\tab1.jpg");
            tabPage_BaiTapPhepNhan.BackgroundImage = bmp5;
            tabPage_BaiTapPhepNhan.BackgroundImageLayout = ImageLayout.Stretch;

            Bitmap bmp6 = new Bitmap(duongdan + "\\HinhAnh\\tab1.jpg");
            tabPage_BaiTapPhepChia.BackgroundImage = bmp6;
            tabPage_BaiTapPhepChia.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Exit_MouseEnter(object sender, EventArgs e)
        {
            btn_QuayLai.ForeColor = Color.Red;
        }

        private void btn_QuayLai_MouseLeave(object sender, EventArgs e)
        {
            btn_QuayLai.ForeColor = Color.Black;
        }

        private void btn_SoSanh_Click(object sender, EventArgs e)
        {
            Bitmap bmpLyThuyetSoSanh = new Bitmap(duongdan + "\\HinhAnh\\SoSanh.jpg");
            tabPage_LyThuyet.BackgroundImage = bmpLyThuyetSoSanh;
            tabPage_LyThuyet.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btn_Cong_Click(object sender, EventArgs e)
        {
            Bitmap bmpLyThuyetCong = new Bitmap(duongdan + "\\HinhAnh\\phepcong.jpg");
            tabPage_LyThuyet.BackgroundImage = bmpLyThuyetCong;
            tabPage_LyThuyet.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Btn_Tru_Click(object sender, EventArgs e)
        {
            Bitmap bmpLyThuyettru = new Bitmap(duongdan + "\\HinhAnh\\pheptru.jpg");
            tabPage_LyThuyet.BackgroundImage = bmpLyThuyettru;
            tabPage_LyThuyet.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btn_Nhan_Click(object sender, EventArgs e)
        {
            Bitmap bmpLyThuyetnhan = new Bitmap(duongdan + "\\HinhAnh\\phepnhan.jpg");
            tabPage_LyThuyet.BackgroundImage = bmpLyThuyetnhan;
            tabPage_LyThuyet.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btn_Chia_Click(object sender, EventArgs e)
        {
            Bitmap bmpLyThuyetchia = new Bitmap(duongdan + "\\HinhAnh\\phepchia.jpg");
            tabPage_LyThuyet.BackgroundImage = bmpLyThuyetchia;
            tabPage_LyThuyet.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btn_ketquasosanh1_Click(object sender, EventArgs e)
        {
            if(txt_sosanh11.Text != ">")
            {
                txt_sosanh11.BackColor = Color.Red;
            }
            if(txt_sosanh12.Text != "<")
            {
                txt_sosanh12.BackColor = Color.Red;
            }
            if (txt_sosanh13.Text != ">")
            {
                txt_sosanh13.BackColor = Color.Red;
            }
            if (txt_sosanh14.Text != "=")
            {
                txt_sosanh14.BackColor = Color.Red;
            }
        }

        private void txt_sosanh11_TextChanged(object sender, EventArgs e)
        {
            txt_sosanh11.BackColor = Color.White;
        }

        private void txt_sosanh12_TextChanged(object sender, EventArgs e)
        {
            txt_sosanh12.BackColor = Color.White;
        }

        private void txt_sosanh13_TextChanged(object sender, EventArgs e)
        {
            txt_sosanh13.BackColor = Color.White;
        }

        private void txt_sosanh14_TextChanged(object sender, EventArgs e)
        {
            txt_sosanh14.BackColor = Color.White;
        }

        private void btn_sosanhketqua2_Click(object sender, EventArgs e)
        {
            if (txt_sosanh21.Text != ">")
            {
                txt_sosanh21.BackColor = Color.Red;
            }
            if (txt_sosanh22.Text != "=")
            {
                txt_sosanh22.BackColor = Color.Red;
            }
            if (txt_sosanh23.Text != "<")
            {
                txt_sosanh23.BackColor = Color.Red;
            }
            if (txt_sosanh24.Text != "<")
            {
                txt_sosanh24.BackColor = Color.Red;
            }
        }

        private void txt_sosanh21_TextChanged(object sender, EventArgs e)
        {
            txt_sosanh21.BackColor = Color.White;
        }

        private void txt_sosanh22_TextChanged(object sender, EventArgs e)
        {
            txt_sosanh22.BackColor = Color.White;
        }

        private void txt_sosanh23_TextChanged(object sender, EventArgs e)
        {
            txt_sosanh23.BackColor = Color.White;
        }

        private void txt_sosanh24_TextChanged(object sender, EventArgs e)
        {
            txt_sosanh24.BackColor = Color.White;
        }

        private void btn_ketqua3_Click(object sender, EventArgs e)
        {
            if (chk_A.Checked == true)
            {
                MessageBox.Show("chuc mung!! Ban da lam dung.");
            }
            else
                MessageBox.Show("Ban da chon chua dung. Xin hay chon lai!");
        }

        private void chk_A_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_A.Checked == true)
            {
                chk_B.Checked = false;
                chk_C.Checked = false;
                chk_D.Checked = false;
            }
        }

        private void chk_B_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_B.Checked == true)
            {
                chk_A.Checked = false;
                chk_C.Checked = false;
                chk_D.Checked = false;
            }
        }

        private void chk_C_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_C.Checked == true)
            {
                chk_A.Checked = false;
                chk_B.Checked = false;
                chk_D.Checked = false;
            }
        }

        private void chk_D_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_D.Checked == true)
            {
                chk_A.Checked = false;
                chk_B.Checked = false;
                chk_C.Checked = false;
            }
        }

        private void btn_ketquacong1_Click(object sender, EventArgs e)
        {
            if (txt_cong11.Text != "6829")
            {
                txt_cong11.BackColor = Color.Red;
            }
            if (txt_cong12.Text != "9261")
            {
                txt_cong12.BackColor = Color.Red;
            }
            if (txt_cong13.Text != "7075")
            {
                txt_cong13.BackColor = Color.Red;
            }
            if (txt_cong14.Text != "9043")
            {
                txt_cong14.BackColor = Color.Red;
            }
        }

        private void txt_cong11_TextChanged(object sender, EventArgs e)
        {
            txt_cong11.BackColor = Color.White;
        }

        private void txt_cong12_TextChanged(object sender, EventArgs e)
        {
            txt_cong12.BackColor = Color.White;
        }

        private void txt_cong13_TextChanged(object sender, EventArgs e)
        {
            txt_cong13.BackColor = Color.White;
        }

        private void txt_cong14_TextChanged(object sender, EventArgs e)
        {
            txt_cong14.BackColor = Color.White;
        }

        private void btn_ketquacong2_Click(object sender, EventArgs e)
        {
            if (txt_cong21.Text != "7482")
            {
                txt_cong21.BackColor = Color.Red;
            }
            if (txt_cong22.Text != "2280")
            {
                txt_cong22.BackColor = Color.Red;
            }
            if (txt_cong23.Text != "7465")
            {
                txt_cong23.BackColor = Color.Red;
            }
            if (txt_cong24.Text != "6564")
            {
                txt_cong24.BackColor = Color.Red;
            }
        }

        private void txt_cong21_TextChanged(object sender, EventArgs e)
        {
            txt_cong21.BackColor = Color.White;
        }

        private void txt_cong22_TextChanged(object sender, EventArgs e)
        {
            txt_cong22.BackColor = Color.White;
        }

        private void txt_cong23_TextChanged(object sender, EventArgs e)
        {
            txt_cong23.BackColor = Color.White;
        }

        private void txt_cong24_TextChanged(object sender, EventArgs e)
        {
            txt_cong24.BackColor = Color.White;
        }

        private void chk_congA_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_congA.Checked == true)
            {
                chk_congB.Checked = false;
                chk_congC.Checked = false;
                chk_congD.Checked = false;
            }
        }

        private void chk_congB_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_congB.Checked == true)
            {
                chk_congA.Checked = false;
                chk_congC.Checked = false;
                chk_congD.Checked = false;
            }
        }

        private void chk_congC_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_congC.Checked == true)
            {
                chk_congA.Checked = false;
                chk_congB.Checked = false;
                chk_congD.Checked = false;
            }
        }

        private void chk_congD_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_congD.Checked == true)
            {
                chk_congA.Checked = false;
                chk_congB.Checked = false;
                chk_congC.Checked = false;
            }
        }

        private void btn_ketquacong3_Click(object sender, EventArgs e)
        {
            if (chk_congB.Checked == true)
            {
                MessageBox.Show("chuc mung!! Ban da lam dung.");
            }
            else
                MessageBox.Show("Ban da chon chua dung. Xin hay chon lai!");
        }

        private void btn_ketquatru1_Click(object sender, EventArgs e)
        {
            if (txt_tru11.Text != "3458")
            {
                txt_tru11.BackColor = Color.Red;
            }
            if (txt_tru12.Text != "2655")
            {
                txt_tru12.BackColor = Color.Red;
            }
            if (txt_tru13.Text != "959")
            {
                txt_tru13.BackColor = Color.Red;
            }
            if (txt_tru14.Text != "2637")
            {
                txt_tru14.BackColor = Color.Red;
            }
        }

        private void txt_tru11_TextChanged(object sender, EventArgs e)
        {
            txt_tru11.BackColor = Color.White;
        }

        private void txt_tru12_TextChanged(object sender, EventArgs e)
        {
            txt_tru12.BackColor = Color.White;
        }

        private void txt_tru13_TextChanged(object sender, EventArgs e)
        {
            txt_tru13.BackColor = Color.White;
        }

        private void txt_tru14_TextChanged(object sender, EventArgs e)
        {
            txt_tru14.BackColor = Color.White;
        }

        private void btn_ketquatru2_Click(object sender, EventArgs e)
        {
            if (txt_tru21.Text != "3526")
            {
                txt_tru21.BackColor = Color.Red;
            }
            if (txt_tru22.Text != "5923")
            {
                txt_tru22.BackColor = Color.Red;
            }
            if (txt_tru23.Text != "3327")
            {
                txt_tru23.BackColor = Color.Red;
            }
            if (txt_tru24.Text != "1828")
            {
                txt_tru24.BackColor = Color.Red;
            }
        }

        private void txt_tru21_TextChanged(object sender, EventArgs e)
        {
            txt_tru21.BackColor = Color.White;
        }

        private void txt_tru22_TextChanged(object sender, EventArgs e)
        {
            txt_tru22.BackColor = Color.White;
        }

        private void txt_tru23_TextChanged(object sender, EventArgs e)
        {
            txt_tru23.BackColor = Color.White;
        }

        private void txt_tru24_TextChanged(object sender, EventArgs e)
        {
            txt_tru24.BackColor = Color.White;
        }

        private void chk_truA_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_truA.Checked == true)
            {
                chk_truB.Checked = false;
                chk_truC.Checked = false;
                chk_truD.Checked = false;
            }
        }

        private void chk_truB_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_truB.Checked == true)
            {
                chk_truA.Checked = false;
                chk_truC.Checked = false;
                chk_truD.Checked = false;
            }
        }

        private void chk_truC_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_truC.Checked == true)
            {
                chk_truA.Checked = false;
                chk_truB.Checked = false;
                chk_truD.Checked = false;
            }
        }

        private void chk_truD_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_truD.Checked == true)
            {
                chk_truA.Checked = false;
                chk_truB.Checked = false;
                chk_truC.Checked = false;
            }
        }

        private void btn_ketquatru3_Click(object sender, EventArgs e)
        {
            if (chk_truD.Checked == true)
            {
                MessageBox.Show("chuc mung!! Ban da lam dung.");
            }
            else
                MessageBox.Show("Ban da chon chua dung. Xin hay chon lai!");
        }

        private void btn_ketquanhan1_Click(object sender, EventArgs e)
        {
            if (txt_nhan11.Text != "2468")
            {
                txt_nhan11.BackColor = Color.Red;
            }
            if (txt_nhan12.Text != "8356")
            {
                txt_nhan12.BackColor = Color.Red;
            }
            if (txt_nhan13.Text != "6348")
            {
                txt_nhan13.BackColor = Color.Red;
            }
            if (txt_nhan14.Text != "3216")
            {
                txt_nhan14.BackColor = Color.Red;
            }
        }

        private void txt_nhan11_TextChanged(object sender, EventArgs e)
        {
            txt_nhan11.BackColor = Color.White;
        }

        private void txt_nhan12_TextChanged(object sender, EventArgs e)
        {
            txt_nhan12.BackColor = Color.White;
        }

        private void txt_nhan13_TextChanged(object sender, EventArgs e)
        {
            txt_nhan13.BackColor = Color.White;
        }

        private void txt_nhan14_TextChanged(object sender, EventArgs e)
        {
            txt_nhan14.BackColor = Color.White;
        }

        private void btn_ketquanhan2_Click(object sender, EventArgs e)
        {
            if (txt_nhan21.Text != "3069")
            {
                txt_nhan21.BackColor = Color.Red;
            }
            if (txt_nhan22.Text != "8152")
            {
                txt_nhan22.BackColor = Color.Red;
            }
            if (txt_nhan23.Text != "4852")
            {
                txt_nhan23.BackColor = Color.Red;
            }
            if (txt_nhan24.Text != "6018")
            {
                txt_nhan24.BackColor = Color.Red;
            }
        }

        private void txt_nhan21_TextChanged(object sender, EventArgs e)
        {
            txt_nhan21.BackColor = Color.White;
        }

        private void txt_nhan22_TextChanged(object sender, EventArgs e)
        {
            txt_nhan22.BackColor = Color.White;
        }

        private void txt_nhan23_TextChanged(object sender, EventArgs e)
        {
            txt_nhan23.BackColor = Color.White;
        }

        private void txt_nhan24_TextChanged(object sender, EventArgs e)
        {
            txt_nhan24.BackColor = Color.White;
        }

        private void chk_nhanA_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_nhanA.Checked == true)
            {
                chk_nhanB.Checked = false;
                chk_nhanC.Checked = false;
                chk_nhanD.Checked = false;
            }
        }

        private void chk_nhanB_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_nhanB.Checked == true)
            {
                chk_nhanA.Checked = false;
                chk_nhanC.Checked = false;
                chk_nhanD.Checked = false;
            }
        }

        private void chk_nhanC_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_nhanC.Checked == true)
            {
                chk_nhanA.Checked = false;
                chk_nhanB.Checked = false;
                chk_nhanD.Checked = false;
            }
        }

        private void chk_nhanD_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_nhanD.Checked == true)
            {
                chk_nhanA.Checked = false;
                chk_nhanB.Checked = false;
                chk_nhanC.Checked = false;
            }
        }

        private void btn_nhan3_Click(object sender, EventArgs e)
        {
            if (chk_nhanD.Checked == true)
            {

                MessageBox.Show("chuc mung!! Ban da lam dung.");
            }
            else
                MessageBox.Show("Ban da chon chua dung. Xin hay chon lai!");
        }

        private void btn_ketquachia1_Click(object sender, EventArgs e)
        {
            if (txt_chia11.Text != "806")
            {
                txt_chia11.BackColor = Color.Red;
            }
            if (txt_chia11du.Text != "0")
            {
                txt_chia11du.BackColor = Color.Red;
            }
            if (txt_chia12.Text != "505")
            {
                txt_chia12.BackColor = Color.Red;
            }
            if (txt_chia12du.Text != "1")
            {
                txt_chia12du.BackColor = Color.Red;
            }
            if (txt_chia13.Text != "402")
            {
                txt_chia13.BackColor = Color.Red;
            }
            if (txt_chia13du.Text != "5")
            {
                txt_chia13du.BackColor = Color.Red;
            }
            if (txt_chia14.Text != "466")
            {
                txt_chia14.BackColor = Color.Red;
            }
            if (txt_chia14du.Text != "0")
            {
                txt_chia14du.BackColor = Color.Red;
            }
        }

        private void txt_chia11_TextChanged(object sender, EventArgs e)
        {
            txt_chia11.BackColor = Color.White;
        }

        private void txt_chia11du_TextChanged(object sender, EventArgs e)
        {
            txt_chia11du.BackColor = Color.White;
        }

        private void txt_chia12_TextChanged(object sender, EventArgs e)
        {
            txt_chia12.BackColor = Color.White;
        }

        private void txt_chia12du_TextChanged(object sender, EventArgs e)
        {
            txt_chia12du.BackColor = Color.White;
        }

        private void txt_chia13_TextChanged(object sender, EventArgs e)
        {
            txt_chia13.BackColor = Color.White;
        }

        private void txt_chia13du_TextChanged(object sender, EventArgs e)
        {
            txt_chia13du.BackColor = Color.White;
        }

        private void txt_chia14_TextChanged(object sender, EventArgs e)
        {
            txt_chia14.BackColor = Color.White;
        }

        private void txt_chia14du_TextChanged(object sender, EventArgs e)
        {
            txt_chia14du.BackColor = Color.White;
        }

        private void chk_chiaA_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_chiaA.Checked == true)
            {
                chk_chiaB.Checked = false;
                chk_chiaC.Checked = false;
                chk_chiaD.Checked = false;
            }
        }

        private void chk_chiaB_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_chiaB.Checked == true)
            {
                chk_chiaA.Checked = false;
                chk_chiaC.Checked = false;
                chk_chiaD.Checked = false;
            }
        }

        private void chk_chiaC_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_chiaC.Checked == true)
            {
                chk_chiaA.Checked = false;
                chk_chiaB.Checked = false;
                chk_chiaD.Checked = false;
            }
        }

        private void chk_chiaD_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_chiaD.Checked == true)
            {
                chk_chiaA.Checked = false;
                chk_chiaB.Checked = false;
                chk_chiaC.Checked = false;
            }
        }

        private void btn_ketqua2_Click(object sender, EventArgs e)
        {
            if (chk_chiaA.Checked == true)
            {
                MessageBox.Show("chuc mung!! Ban da lam dung.");
            }
            else
                MessageBox.Show("Ban da chon chua dung. Xin hay chon lai!");
        }

        private void chk_chia3A_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_chia3A.Checked == true)
            {
                chk_chia3B.Checked = false;
                chk_chia3C.Checked = false;
                chk_chia3D.Checked = false;
            }
        }

        private void chk_chia3B_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_chia3B.Checked == true)
            {
                chk_chia3A.Checked = false;
                chk_chia3C.Checked = false;
                chk_chia3D.Checked = false;
            }
        }

        private void chk_chia3C_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_chia3C.Checked == true)
            {
                chk_chia3A.Checked = false;
                chk_chia3B.Checked = false;
                chk_chia3D.Checked = false;
            }
        }

        private void chk_chia3D_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_chia3D.Checked == true)
            {
                chk_chia3A.Checked = false;
                chk_chia3B.Checked = false;
                chk_chia3C.Checked = false;
            }
        }

        private void btn_ketquachia3_Click(object sender, EventArgs e)
        {
            if (chk_chia3B.Checked == true)
            {
                MessageBox.Show("chuc mung!! Ban da lam dung.");
            }
            else
                MessageBox.Show("Ban da chon chua dung. Xin hay chon lai!");
        }
    }
}
