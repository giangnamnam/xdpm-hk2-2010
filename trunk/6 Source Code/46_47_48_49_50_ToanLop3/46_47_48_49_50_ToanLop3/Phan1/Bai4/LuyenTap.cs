using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan1.Bai4
{
    public partial class LuyenTap : UserControl
    {
        public LuyenTap()
        {
            InitializeComponent();
        }

       

        private void LuyenTap_Load(object sender, EventArgs e)
        {

        }

        private void btLamxong_Click(object sender, EventArgs e)
        {
            String lbLoi = "";
            lbLoi = "Lỗi ở bài :";
            if (true)
            {
                if (tbvl1.Text != "242")
                {
                    lbLoi += "1 ô 1, ";
                }
                if (tbvl2.Text != "340")
                {
                    lbLoi += "1 ô 2, ";
                }

                if (tbvl3.Text != "329")
                {
                    lbLoi += "1 ô 3, ";
                }

                if (tbvl4.Text != "25")
                {
                    lbLoi += " 1 ô 4, ";
                }
                if (tbvl5.Text != "224")
                {
                    lbLoi += "2 ô 1, ";
                }
                if (tbvl6.Text != "409")
                {
                    lbLoi += "2 ô 2, ";
                }
                if (tbvl7.Text != "455")
                {
                    lbLoi += "2 ô 3, ";
                }
                if (tbvl8.Text != "220")
                {
                    lbLoi += "2 ô 4, ";
                }
                if (tbvl9.Text != "326")
                {
                    lbLoi += "3 ô 1, ";
                }
                if (tbvl10.Text != "371")
                {
                    lbLoi += "3 ô 2, ";
                }
                if (tbvl11.Text != "390")
                {
                    lbLoi += "3 ô 3, ";
                }
                if (tbvl12.Text != "735")
                {
                    lbLoi += "3 ô 4, ";
                }
                if (chb214.Checked == false)
                {
                    lbLoi += "4, ";
                }
                if (chb5c.Checked == false)
                {
                    lbLoi += "5";
                }
                if (lbLoi == "Lỗi ở bài :")
                {
                    lbLoi = "Bạn làm rất tốt!";
                    
                }
                MessageBox.Show(lbLoi);
            }
            else
            {
                lbLoi = "Bạn làm rất tốt!";
                MessageBox.Show(lbLoi);
            }
        }

        private void btKiemtra_Click(object sender, EventArgs e)
        {
            tbvl1.Text = "242";
            tbvl2.Text = "340";
            tbvl3.Text = "329";
            tbvl4.Text = "25";
            tbvl5.Text = "224";
            tbvl6.Text = "409";
            tbvl7.Text = "455";
            tbvl8.Text = "220";
            tbvl9.Text = "326";
            tbvl10.Text = "371";
            tbvl11.Text = "390";
            tbvl12.Text = "735";
          
            chbckb213.Checked = false;
            chb277.Checked = false;
            chb214.Checked = true;
            chb225.Checked = false;
            chb5a.Checked = false;
            chb5b.Checked = false;
            chb5c.Checked = true;
            chb5d.Checked = false;
            
        }

        private void btLamlai_Click(object sender, EventArgs e)
        {
            tbvl1.Text = "";
            tbvl2.Text = "";
            tbvl3.Text = "";
            tbvl4.Text = "";
            tbvl5.Text = "";
            tbvl6.Text = "";
            tbvl7.Text = "";
            tbvl8.Text = "";
            tbvl9.Text = "";
            tbvl10.Text = "";
            tbvl11.Text = "";
            tbvl12.Text = "";

            chbckb213.Checked = false;
            chb277.Checked = false;
            chb214.Checked = false;
            chb225.Checked = false;
            chb5a.Checked = false;
            chb5b.Checked = false;
            chb5c.Checked = false;
            chb5d.Checked = false;
        }

        private void chb214_Click(object sender, EventArgs e)
        {

            chbckb213.Checked = false;
            chb277.Checked = false;
            chb214.Checked = true;
            chb225.Checked = false;
            
        }

        private void chbckb213_Click(object sender, EventArgs e)
        {
            chbckb213.Checked = true;
            chb277.Checked = false;
            chb214.Checked = false;
            chb225.Checked = false;
        }

        private void chb277_Click(object sender, EventArgs e)
        {
            chbckb213.Checked = false;
            chb277.Checked = true;
            chb214.Checked = false;
            chb225.Checked = false;
        }

        private void chb225_Click(object sender, EventArgs e)
        {
            chbckb213.Checked = false;
            chb277.Checked = false;
            chb214.Checked = false;
            chb225.Checked = true;
        }

        private void chb5a_Click(object sender, EventArgs e)
        {
            chb5a.Checked = true;
            chb5b.Checked = false;
            chb5c.Checked = false;
            chb5d.Checked = false;
        }

        private void chb5b_Click(object sender, EventArgs e)
        {
            chb5a.Checked = false;
            chb5b.Checked = true;
            chb5c.Checked = false;
            chb5d.Checked = false;
        }

        private void chb5c_Click(object sender, EventArgs e)
        {
            chb5a.Checked = false;
            chb5b.Checked = false;
            chb5c.Checked = true;
            chb5d.Checked = false;
        }

        private void chb5d_Click(object sender, EventArgs e)
        {
            chb5a.Checked = false;
            chb5b.Checked = false;
            chb5c.Checked = false;
            chb5d.Checked = true;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
