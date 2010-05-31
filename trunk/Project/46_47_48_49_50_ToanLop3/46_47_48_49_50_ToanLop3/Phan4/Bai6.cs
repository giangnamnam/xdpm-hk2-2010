using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace _46_47_48_49_50_ToanLop3.Phan4
{
    public partial class PHAN4_11 : Form
    {
        public PHAN4_11()
        {
            InitializeComponent();
        }

        private void txtTS1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtNho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtTS2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtKQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void Tinh_Click(object sender, EventArgs e)
        {
            lblB1.Text = "3 nhân 3 bằng 9, viết 9.";
            Thread.Sleep(2000);
            Application.DoEvents();
            lblDonVi.Text = "9";
            Thread.Sleep(2000);
            Application.DoEvents();
            lblB2.Text = "3 nhân 7 bằng 21, viết 1 nhớ 2.";

            Thread.Sleep(2000);
            Application.DoEvents();
            lblChuc.Text = "1";
            // lblDonVi.Text = "19";
            Thread.Sleep(2000);
            Application.DoEvents();
            lblB3.Text = "3 nhân 2 bằng 6, thêm 2 bằng 8, viết 8";
            Thread.Sleep(2000);
            Application.DoEvents();
            lblTram.Text = "8";
            // lblDonVi.Text = "819";
            Thread.Sleep(2000);
            Application.DoEvents();
            lblB4.Text = "3 nhân 4 bằng 12, viết 2 nhớ 1";
            Thread.Sleep(2000);
            Application.DoEvents();
            lblNgan.Text = "2";
            //lblDonVi.Text = "2819";
            Thread.Sleep(2000);
            Application.DoEvents();
            lblB5.Text = "3 nhân 1 bằng 3, thêm 1 bằng 4, viết 4.";
            Thread.Sleep(2000);
            Application.DoEvents();
            lblChucNgan.Text = "4";
            // lblDonVi.Text = "42819";
        }

        private void btnTinhBT_Click(object sender, EventArgs e)
        {

            if (txtTS1.Text != "" && txtTS2.Text != "")
            {
                int temp1, temp2;
                temp1 = int.Parse(txtTS1.Text);
                temp2 = int.Parse(txtTS2.Text);
                if (temp1 >= 10000 && temp1 < 100000 && temp2 < 10)
                {
                    // MessageBox.Show("đầu vào OK");
                    txtKQ.Text = "";
                    txtNho.Text = "";
                    txtNho.Enabled = false;
                    txtTS1.Enabled = false;
                    txtTS2.Enabled = false;
                    txtKQ.Enabled = false;
                    btnTinhBT.Enabled = false;
                    int sodu = 0;
                    int donvi;
                    donvi = int.Parse(txtTS1.Text) % 10;
                    donvi = int.Parse(txtTS2.Text) * donvi;
                    if (donvi >= 10)
                    {
                        sodu = donvi / 10;
                        donvi = donvi % 10;
                    }
                    else
                    {
                        sodu = 0;
                    }
                    txtKQ.Text = donvi.ToString();
                    Thread.Sleep(1000);
                    Application.DoEvents();
                    txtNho.Text = sodu.ToString();
                    Thread.Sleep(1000);
                    Application.DoEvents();
                    int chuc;
                    chuc = (int.Parse(txtTS1.Text) % 100) / 10;
                    chuc = int.Parse(txtTS2.Text) * chuc;
                    chuc = chuc + sodu;
                    if (chuc >= 10)
                    {
                        sodu = chuc / 10;
                        chuc = chuc % 10;
                    }
                    else
                    {
                        sodu = 0;
                    }
                    txtKQ.Text = chuc.ToString() + txtKQ.Text;
                    Thread.Sleep(1000);
                    Application.DoEvents();
                    txtNho.Text = sodu.ToString();
                    Thread.Sleep(1000);
                    Application.DoEvents();
                    int tram;
                    tram = (int.Parse(txtTS1.Text) % 1000) / 100;
                    tram = int.Parse(txtTS2.Text) * tram;
                    tram = tram + sodu;
                    if (tram >= 10)
                    {
                        sodu = tram / 10;
                        tram = tram % 10;
                    }
                    else
                    {
                        sodu = 0;
                    }
                    txtKQ.Text = tram.ToString() + txtKQ.Text;
                    Thread.Sleep(1000);
                    Application.DoEvents();
                    txtNho.Text = sodu.ToString();
                    Thread.Sleep(1000);
                    Application.DoEvents();
                    int ngan;
                    ngan = (int.Parse(txtTS1.Text) % 10000) / 1000;
                    ngan = int.Parse(txtTS2.Text) * ngan;
                    ngan = ngan + sodu;
                    if (ngan >= 10)
                    {
                        sodu = ngan / 10;
                        ngan = ngan % 10;
                    }
                    else
                    {
                        sodu = 0;
                    }

                    txtKQ.Text = ngan.ToString() + txtKQ.Text;
                    Thread.Sleep(2000);
                    Application.DoEvents();
                    txtNho.Text = sodu.ToString();
                    Thread.Sleep(1000);
                    Application.DoEvents();

                    int chucngan;
                    chucngan = (int.Parse(txtTS1.Text)) / 10000;
                    chucngan = int.Parse(txtTS2.Text) * chucngan;
                    chucngan = chucngan + sodu;
                    txtKQ.Text = chucngan.ToString() + txtKQ.Text;
                    Thread.Sleep(1000);
                    Application.DoEvents();
                    lblGhiKetQua.Text = "Kết Quả: " + txtTS1.Text + " X " + txtTS2.Text + " = " + txtKQ.Text;
                    txtNho.Text = "0";
                    txtNho.Enabled = true;
                    txtTS1.Enabled = true;
                    txtTS2.Enabled = true;
                    txtKQ.Enabled = true;
                    btnTinhBT.Enabled = true;

                }
                else
                {
                    if ((temp1 < 10000 || temp1 > 100000) && temp2 >= 10)
                        MessageBox.Show("thừa số thứ nhất phải là số có 5 chữ số, thừa số 2 chỉ có 1 chữ số");
                    else
                    {
                        if (temp1 < 10000 || temp1 > 100000)
                            MessageBox.Show("thừa số 1 phải là số có 5 chữ số");
                        else if (temp2 >= 10)
                            MessageBox.Show("thừa số 2 phải là số có 1 chữ số");
                    }
                }
            }
            else
            {
                MessageBox.Show("chưa nhập 2 số");
            }
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLT_Click(object sender, EventArgs e)
        {
            Bai6_LuyenTap frmLT = new Bai6_LuyenTap();
            //PHAN4_13 frmLTC = new PHAN4_13();
            this.Hide();
            frmLT.ShowDialog();
            this.Close();
        }

        private void txtKQB1A_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtKQB1B_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtKQB1C_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtKQB1D_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

       

        


        private void btnKTB1A_Click(object sender, EventArgs e)
        {
            if (txtKQB1A.Text.ToString() == "")
            {
                MessageBox.Show("vui lòng điền kết quả trước");
            }
            else
            {
                if (int.Parse(txtKQB1A.Text.ToString()) == (21526 * 3))
                {

                    txtKQB1A.BackColor = Color.Blue;
                    MessageBox.Show("kết quả đúng");
                }
                else
                {

                    txtKQB1A.BackColor = Color.Red;
                    MessageBox.Show("kết quả sai");
                }

            }
        }

        private void btnKTB1B_Click(object sender, EventArgs e)
        {
            if (txtKQB1B.Text.ToString() == "")
            {
                MessageBox.Show("vui lòng điền kết quả trước");
            }
            else
            {
                if (int.Parse(txtKQB1B.Text.ToString()) == (40729 * 2))
                {

                    txtKQB1B.BackColor = Color.Blue;
                    MessageBox.Show("kết quả đúng");
                }
                else
                {

                    txtKQB1B.BackColor = Color.Red;
                    MessageBox.Show("kết quả sai");
                }
            }
        }

        private void btnKTB1C_Click(object sender, EventArgs e)
        {
            if (txtKQB1C.Text.ToString() == "")
            {
                MessageBox.Show("vui lòng điền kết quả trước");
            }
            else
            {
                if (int.Parse(txtKQB1C.Text.ToString()) == (17092 * 4))
                {

                    txtKQB1C.BackColor = Color.Blue;
                    MessageBox.Show("kết quả đúng");
                }
                else
                {

                    txtKQB1C.BackColor = Color.Red;
                    MessageBox.Show("kết quả sai");
                }
            }
        }

        private void btnKTB1D_Click(object sender, EventArgs e)
        {
            if (txtKQB1D.Text.ToString() == "")
            {
                MessageBox.Show("vui lòng điền kết quả trước");
            }
            else
            {
                if (int.Parse(txtKQB1D.Text.ToString()) == (15180 * 5))
                {

                    txtKQB1D.BackColor = Color.Blue;
                    MessageBox.Show("kết quả đúng");
                }
                else
                {

                    txtKQB1D.BackColor = Color.Red;
                    MessageBox.Show("kết quả sai");
                }
            }
        }

       

      
       
        private void txtKQB2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKQB2.Text.ToString() == "")
            {
                {
                    MessageBox.Show("vui lòng điền kết quả trước");
                }
            }
            else
            {
                if (int.Parse(txtKQB2.Text.ToString()) == (27150*2 + 27150))
                {

                    txtKQB2.BackColor = Color.Blue;
                    MessageBox.Show("kết quả đúng");
                }
                else
                {

                    txtKQB2.BackColor = Color.Red;
                    MessageBox.Show("kết quả sai");
                }
            }
        }

        private void txtBai2A_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

        }

        private void txtbai2B_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtBai2C_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void btnBai2A_Click(object sender, EventArgs e)
        {
            if (txtBai2A.Text.ToString() == "")
            {
                {
                    MessageBox.Show("vui lòng điền kết quả trước");
                }
            }
            else
            {
                if (int.Parse(txtBai2A.Text.ToString()) == (19091 * 5))
                {

                    txtBai2A.BackColor = Color.Blue;
                    MessageBox.Show("kết quả đúng");
                }
                else
                {

                    txtBai2A.BackColor = Color.Red;
                    MessageBox.Show("kết quả sai");
                }
            }
        }

        private void btnBai2B_Click(object sender, EventArgs e)
        {
            if (txtbai2B.Text.ToString() == "")
            {
                {
                    MessageBox.Show("vui lòng điền kết quả trước");
                }
            }
            else
            {
                if (int.Parse(txtbai2B.Text.ToString()) == (13070 * 6))
                {

                    txtbai2B.BackColor = Color.Blue;
                    MessageBox.Show("kết quả đúng");
                }
                else
                {

                    txtbai2B.BackColor = Color.Red;
                    MessageBox.Show("kết quả sai");
                }
            }
        }

        private void btnBai2C_Click(object sender, EventArgs e)
        {
            if (txtBai2C.Text.ToString() == "")
            {
                {
                    MessageBox.Show("vui lòng điền kết quả trước");
                }
            }
            else
            {
                if (int.Parse(txtBai2C.Text.ToString()) == (10709 * 7))
                {

                    txtBai2C.BackColor = Color.Blue;
                    MessageBox.Show("kết quả đúng");
                }
                else
                {

                    txtBai2C.BackColor = Color.Red;
                    MessageBox.Show("kết quả sai");
                }
            }
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }
    }
}
