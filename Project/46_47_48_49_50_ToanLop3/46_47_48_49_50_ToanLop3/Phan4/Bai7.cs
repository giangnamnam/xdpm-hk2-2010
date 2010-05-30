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
    public partial class PHAN4_12 : Form
    {
        public PHAN4_12()
        {
            InitializeComponent();
        }

        private void txtSBC_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSC_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtB0_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtThuong_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtB1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtB2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtB3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtB4_KeyPress(object sender, KeyPressEventArgs e)
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

            lblBuoc1.Text = "* 37 chia 4 được 9, viết 9.";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblKQ.Text = "9";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblBuoc1b.Text = "9 nhân 4 bằng 36; 37 trừ 36 bằng 1.";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblB1.Text = "1";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblBuoc2.Text = "* Hạ 6 được 16; 16 chia 4 được 4; viết 4.";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblB1.Text = "16";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblKQ2.Text = "4";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblBuoc2b.Text = "4 nhân 4 bằng 16; 16 trừ 16 bằng 0.";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblB2.Text = "0";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblBuoc3.Text = "* Hạ 4; 4 chia 4 được 1, viết 1";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblB2.Text = "04";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblKQ3.Text = "1";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblBuoc3b.Text = "1 nhân 4 bằng 4; 4 trừ 4 bằng 0.";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblB3.Text = "0";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblBuoc4.Text = "* Hạ 8; 8 chia 4 được 2, viết 2";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblB3.Text = "08";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblKQ4.Text = "2";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblBuoc4b.Text = "2 nhân 4 bằng 8; 8 trừ 8 bằng 0";
            Thread.Sleep(1000);
            Application.DoEvents();
            lblB4.Text = "0";
        }

        private void btnTinhBT_Click(object sender, EventArgs e)
        {


            if (txtSBC.Text != "" && txtSC.Text != "")
            {
                int temp1, temp2;
                temp1 = int.Parse(txtSBC.Text);
                temp2 = int.Parse(txtSC.Text);
                if (temp1 >= 10000 && temp1 < 100000 && temp2 < 10)
                {
                    // MessageBox.Show("đầu vào OK");
                    txtB0.Text = "";
                    txtB1.Text = "";
                    txtB2.Text = "";
                    txtB3.Text = "";
                    txtB4.Text = "";
                    txtThuong.Text = "";
                    txtSBC.ReadOnly = true;
                    txtSC.ReadOnly = true;
                    txtThuong.ReadOnly = true;
                    txtB0.ReadOnly = true;
                    txtB1.ReadOnly = true;
                    txtB2.ReadOnly = true;
                    txtB3.ReadOnly = true;
                    txtB4.ReadOnly = true;
                    btnTinhBT.Enabled = false;


                    int sochia = int.Parse(txtSC.Text);
                    int sobichia = int.Parse(txtSBC.Text);
                    int chucngan;
                    int thuong;
                    int temp;
                    chucngan = sobichia / 10000;
                    thuong = chucngan / sochia;
                    temp = chucngan - (thuong * sochia);
                    if (thuong != 0)
                    {
                        txtThuong.Text = thuong.ToString();
                    }
                    Thread.Sleep(1000);
                    Application.DoEvents();
                    txtB0.Text = temp.ToString();
                    Thread.Sleep(1000);
                    Application.DoEvents();
                    int ngan = (sobichia % 10000) / 1000;
                    txtB0.Text = txtB0.Text + ngan.ToString();
                    Thread.Sleep(1000);
                    Application.DoEvents();
                    temp = int.Parse(txtB0.Text);
                    int tam;
                    tam = temp / sochia;
                    txtThuong.Text = txtThuong.Text + tam.ToString();
                    Thread.Sleep(1000);
                    Application.DoEvents();
                    txtB1.Text = (temp - tam * sochia).ToString();
                    Thread.Sleep(1000);
                    Application.DoEvents();
                    int tram = (sobichia % 1000) / 100;
                    txtB1.Text = txtB1.Text + tram.ToString();
                    Thread.Sleep(1000);
                    Application.DoEvents();
                    tam = int.Parse(txtB1.Text);
                    int tam1;
                    tam1 = tam / sochia;
                    txtThuong.Text = txtThuong.Text + tam1.ToString();
                    Thread.Sleep(1000);
                    Application.DoEvents();
                    txtB2.Text = (tam - tam1 * sochia).ToString();
                    Thread.Sleep(1000);
                    Application.DoEvents();
                    int chuc = (sobichia % 100) / 10;
                    txtB2.Text = txtB2.Text + chuc.ToString();
                    Thread.Sleep(1000);
                    Application.DoEvents();
                    int tam2 = int.Parse(txtB2.Text);
                    int tam3 = tam2 / sochia;
                    txtThuong.Text = txtThuong.Text + tam3.ToString();
                    Thread.Sleep(1000);
                    Application.DoEvents();
                    txtB3.Text = (tam2 - tam3 * sochia).ToString();
                    Thread.Sleep(1000);
                    Application.DoEvents();
                    int donvi = sobichia % 10;
                    txtB3.Text = txtB3.Text + donvi.ToString();
                    Thread.Sleep(1000);
                    Application.DoEvents();
                    int tam4 = int.Parse(txtB3.Text) / sochia;
                    txtThuong.Text = txtThuong.Text + tam4.ToString();
                    Thread.Sleep(1000);
                    Application.DoEvents();
                    txtB4.Text = (int.Parse(txtB3.Text) - tam4 * sochia).ToString();
                    Thread.Sleep(1000);
                    Application.DoEvents();
                    txtSBC.ReadOnly = false;
                    txtSC.ReadOnly = false;
                    txtThuong.ReadOnly = false;
                    txtB0.ReadOnly = false;
                    txtB1.ReadOnly = false;
                    txtB2.ReadOnly = false;
                    txtB3.ReadOnly = false;
                    txtB4.ReadOnly = false;
                    btnTinhBT.Enabled = true;
                    if (int.Parse(txtB4.Text) != 0)
                        lblGhiKetQua.Text = "Kết Quả: " + txtSBC.Text + " : " + txtSC.Text + " = " + txtThuong.Text + " (dư " + txtB4.Text + ")";
                    else
                        lblGhiKetQua.Text = "Kết Quả: " + txtSBC.Text + " : " + txtSC.Text + " = " + txtThuong.Text;

                }
                else
                {
                    if ((temp1 < 10000 || temp1 > 100000) && temp2 >= 10)
                        MessageBox.Show("số bị chia phải là số có 5 chữ số, số chia phải là số có 1 chữ số");
                    else
                    {
                        if (temp1 < 10000 || temp1 > 100000)
                            MessageBox.Show("số bị chia phải là số có 5 chữ số");
                        else if (temp2 >= 10)
                            MessageBox.Show("số chia phải là số có 1 chữ số");
                    }
                }
            }
            else
            {
                MessageBox.Show("chưa nhập 2 số");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuyenTap_Click(object sender, EventArgs e)
        {
            PHAN4_13 frmLTC = new PHAN4_13();
            this.Hide();
            frmLTC.ShowDialog();
            this.Close();
        }
    }
}
