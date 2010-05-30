using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan1
{
    public partial class Bai05 : UserControl
    {
        public Bai05()
        {
            InitializeComponent();
        }

        private void Bai05_Load(object sender, EventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tbvl4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbvl_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbkq10_TextChanged(object sender, EventArgs e)
        {

        }

        private void btLamxong_Click(object sender, EventArgs e)
        {
            String lbLoi = "";
            lbLoi = "Lỗi ở bài :";
            if (true)
            {
                if (tbvl1.Text != "12")
                {
                    lbLoi += "1 ô 1, ";
                }
                if (tbvl2.Text != "21")
                {
                    lbLoi += "1 ô 2, ";
                }

                if (tbvl3.Text != "15")
                {
                    lbLoi += "1 ô 3, ";
                }

                if (tbvl4.Text != "24")
                {
                    lbLoi += " 1 ô 4, ";
                }
                if (tbvl5.Text != "12")
                {
                    lbLoi += "1 ô 5, ";
                }
                if (tbvl6.Text != "16")
                {
                    lbLoi += "1 ô 6, ";
                }
                if (tbvl7.Text != "8")
                {
                    lbLoi += "1 ô 7, ";
                }
                if (tbvl8.Text != "18")
                {
                    lbLoi += "1 ô 8, ";
                }
                if (tbvl9.Text != "12")
                {
                    lbLoi += "1 ô 9, ";
                }
                if (tbvl10.Text != "28")
                {
                    lbLoi += "1 ô 10, ";
                }
                if (tbvl11.Text != "36")
                {
                    lbLoi += "1 ô 11, ";
                }
                if (tbvl12.Text != "16")
                {
                    lbLoi += "1 ô 12, ";
                }
                if (tbvl13.Text != "30")
                {
                    lbLoi += "1 ô 13, ";
                }
                if (tbvl14.Text != "20")
                {
                    lbLoi += "1 ô 14, ";
                }

                if (tbvl15.Text != "35")
                {
                    lbLoi += "1 ô 15, ";
                }

                if (tbvl16.Text != "45")
                {
                    lbLoi += " 1 ô 16, ";
                }
                if (tbvl17.Text != "200")
                {
                    lbLoi += "1 ô 17, ";
                }
                if (tbvl18.Text != "800")
                {
                    lbLoi += "1 ô 18, ";
                }
                if (tbvl19.Text != "500")
                {
                    lbLoi += "1 ô 19, ";
                }
                if (tbvl20.Text != "600")
                {
                    lbLoi += "1 ô 20, ";
                }
                if (tbvl21.Text != "800")
                {
                    lbLoi += "1 ô 21, ";
                }
                if (tbvl22.Text != "500")
                {
                    lbLoi += "1 ô 22, ";
                }
                if (tbvl23.Text != "25 + 18")
                {
                    lbLoi += "2 ô 1, ";
                }
                if (tbvl24.Text != "43")
                {
                    lbLoi += "2 ô 2, ";
                }
                if (tbvl25.Text != "35 - 26")
                {
                    lbLoi += "2 ô 3, ";
                }
                if (tbvl26.Text != "9")
                {
                    lbLoi += "2 ô 4, ";
                }
                if (tbvl27.Text != "4 x 9")
                {
                    lbLoi += "2 ô 5, ";
                }
                if (tbvl28.Text != "36")
                {
                    lbLoi += "2 ô 6, ";
                }
                if (chb225.Checked == false)
                {
                    lbLoi += "3, ";
                }
                if (chb5b.Checked == false)
                {
                    lbLoi += "4";
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
            tbvl1.Text = "12";
            tbvl2.Text = "21";
            tbvl3.Text = "15";
            tbvl4.Text = "24";
            tbvl5.Text = "12";
            tbvl6.Text = "16";
            tbvl7.Text = "8";
            tbvl8.Text = "18";
            tbvl9.Text = "12";
            tbvl10.Text = "28";
            tbvl11.Text = "36";
            tbvl12.Text = "16";
            tbvl13.Text = "30";
            tbvl14.Text = "20";
            tbvl15.Text = "35";
            tbvl16.Text = "45";
            tbvl17.Text = "200";
            tbvl18.Text = "800";
            tbvl19.Text = "500";
            tbvl20.Text = "600";
            tbvl21.Text = "800";
            tbvl22.Text = "500";
            tbvl23.Text = "25 + 18";
            tbvl24.Text = "43";
            tbvl25.Text = "35 - 26";
            tbvl26.Text = "9";
            tbvl27.Text = "4 x 9";
            tbvl28.Text = "36";
            
            chbckb213.Checked = false;
            chb277.Checked = false;
            chb214.Checked = false;
            chb225.Checked = true;
            chb5a.Checked = false;
            chb5b.Checked = true;
            chb5c.Checked = false;
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
            tbvl13.Text = "";
            tbvl14.Text = "";
            tbvl15.Text = "";
            tbvl16.Text = "";
            tbvl17.Text = "";
            tbvl18.Text = "";
            tbvl19.Text = "";
            tbvl20.Text = "";
            tbvl21.Text = "";
            tbvl22.Text = "";
            tbvl23.Text = "";
            tbvl24.Text = "";
            tbvl25.Text = "";
            tbvl26.Text = "";
            tbvl27.Text = "";
            tbvl28.Text = "";

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

        private void chb225_Click(object sender, EventArgs e)
        {
            chbckb213.Checked = false;
            chb277.Checked = false;
            chb214.Checked = false;
            chb225.Checked = true;
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

        private void chb5a_Click(object sender, EventArgs e)
        {
            chb5a.Checked = true;
            chb5b.Checked = false;
            chb5c.Checked = false;
            chb5d.Checked = false;
        }

        private void chb5b_CheckedChanged(object sender, EventArgs e)
        {

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

      
       
    }
}
