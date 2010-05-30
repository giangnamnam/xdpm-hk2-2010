using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan4
{
    public partial class Bai7_LuyenTap : Form
    {
        public Bai7_LuyenTap()
        {
            InitializeComponent();
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

        private void txtKQB2A_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtKQB2B_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtKQB2C_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnKQB1A_Click(object sender, EventArgs e)
        {
            int kq = (int)15273 / 3;
            int du = (int)15273 % 3;
            if (txtKQB1A.Text.ToString() == "")
            {
                MessageBox.Show("vui lòng điền kết quả trước");
            }
            else
            {
                if (int.Parse(txtKQB1A.Text.ToString()) == kq)
                {
                    if (txtDu1A.Text.ToString() == "")
                    {
                        MessageBox.Show("Vui lòng điền số dư");
                    }
                    else
                    {
                        if (int.Parse(txtDu1A.Text.ToString()) == du)
                        {
                            txtDu1A.BackColor = Color.Blue;
                            txtKQB1A.BackColor = Color.Blue;
                            MessageBox.Show("kết quả đúng");
                        }
                        else
                        {
                            txtDu1A.BackColor = Color.Red;
                            txtKQB1A.BackColor = Color.Red;
                            MessageBox.Show("kết quả sai");
                        }
                    }


                }
                else
                {
                    txtDu1A.BackColor = Color.Red;
                    txtKQB1A.BackColor = Color.Red;
                    MessageBox.Show("kết quả sai");
                }
            }
        }

        private void btnKTB1B_Click(object sender, EventArgs e)
        {
            int kq = (int)18842 / 4;
            int du = (int)18842 % 4;
            if (txtKQB1B.Text.ToString() == "")
            {
                MessageBox.Show("vui lòng điền kết quả trước");
            }
            else
            {
                if (int.Parse(txtKQB1B.Text.ToString()) == kq)
                {
                    if (txtDu1B.Text.ToString() == "")
                    {
                        MessageBox.Show("Vui lòng điền số dư");
                    }
                    else
                    {

                        if (int.Parse(txtDu1B.Text.ToString()) == du)
                        {
                            txtDu1B.BackColor = Color.Blue;
                            txtKQB1B.BackColor = Color.Blue;
                            MessageBox.Show("kết quả đúng");
                        }
                        else
                        {
                            txtDu1B.BackColor = Color.Red;
                            txtKQB1B.BackColor = Color.Red;
                            MessageBox.Show("kết quả sai");
                        }
                    }


                }
                else
                {
                    txtDu1B.BackColor = Color.Red;
                    txtKQB1B.BackColor = Color.Red;
                    MessageBox.Show("kết quả sai");
                }
            }
        }

        private void btnKTB1C_Click(object sender, EventArgs e)
        {

            int kq = (int)36083 / 4;
            int du = (int)36083 % 4;
            if (txtKQB1C.Text.ToString() == "")
            {
                MessageBox.Show("vui lòng điền kết quả trước");
            }
            else
            {
                if (int.Parse(txtKQB1C.Text.ToString()) == kq)
                {
                    if (txtDu1A.Text.ToString() == "")
                    {
                        MessageBox.Show("Vui lòng điền số dư");
                    }
                    else
                    {
                        if (int.Parse(txtDu1C.Text.ToString()) == du)
                        {
                            txtDu1C.BackColor = Color.Blue;
                            txtKQB1C.BackColor = Color.Blue;
                            MessageBox.Show("kết quả đúng");
                        }
                        else
                        {
                            txtDu1C.BackColor = Color.Red;
                            txtKQB1C.BackColor = Color.Red;
                            MessageBox.Show("kết quả sai");
                        }
                    }

                }
                else
                {
                    txtDu1C.BackColor = Color.Red;
                    txtKQB1C.BackColor = Color.Red;
                    MessageBox.Show("kết quả sai");
                }
            }
        }

        private void btnKTB2A_Click(object sender, EventArgs e)
        {
            if (txtKQB2A.Text.ToString() == "")
            {
                MessageBox.Show("vui lòng điền kết quả trước");
            }
            else
            {
                if (int.Parse(txtKQB2A.Text.ToString()) == 5000)
                {

                    txtKQB2A.BackColor = Color.Blue;
                    MessageBox.Show("kết quả đúng");
                }
                else
                {

                    txtKQB2A.BackColor = Color.Red;
                    MessageBox.Show("kết quả sai");
                }
            }
        }

        private void btnKTB2B_Click(object sender, EventArgs e)
        {
            if (txtKQB2B.Text.ToString() == "")
            {
                MessageBox.Show("vui lòng điền kết quả trước");
            }
            else
            {
                if (int.Parse(txtKQB2B.Text.ToString()) == 6000)
                {

                    txtKQB2B.BackColor = Color.Blue;
                    MessageBox.Show("kết quả đúng");
                }
                else
                {

                    txtKQB2B.BackColor = Color.Red;
                    MessageBox.Show("kết quả sai");
                }
            }
        }

        private void btnKTB2C_Click(object sender, EventArgs e)
        {
            if (txtKQB2C.Text.ToString() == "")
            {
                MessageBox.Show("vui lòng điền kết quả trước");
            }
            else
            {
                if (int.Parse(txtKQB2C.Text.ToString()) == 8000)
                {

                    txtKQB2C.BackColor = Color.Blue;
                    MessageBox.Show("kết quả đúng");
                }
                else
                {

                    txtKQB2C.BackColor = Color.Red;
                    MessageBox.Show("kết quả sai");
                }
            }
        }

        private void btnKTB3A_Click(object sender, EventArgs e)
        {
            if (txtKQB3A.Text.ToString() == "")
            {
                MessageBox.Show("vui lòng điền kết quả trước");
            }
            else
            {
                if (int.Parse(txtKQB3A.Text.ToString()) == (69218 - 26736 / 3))
                {

                    txtKQB3A.BackColor = Color.Blue;
                    MessageBox.Show("kết quả đúng");
                }
                else
                {

                    txtKQB3A.BackColor = Color.Red;
                    MessageBox.Show("kết quả sai");
                }
            }
        }

        private void txtKQB3A_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtKQB3B_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtKQB3C_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtKQB3D_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnKTB3B_Click(object sender, EventArgs e)
        {
            if (txtKQB3B.Text.ToString() == "")
            {
                MessageBox.Show("vui lòng điền kết quả trước");
            }
            else
            {
                if (int.Parse(txtKQB3B.Text.ToString()) == (30507 + 27876 / 3))
                {

                    txtKQB3B.BackColor = Color.Blue;
                    MessageBox.Show("kết quả đúng");
                }
                else
                {

                    txtKQB3B.BackColor = Color.Red;
                    MessageBox.Show("kết quả sai");
                }
            }
        }

        private void btnKTB3C_Click(object sender, EventArgs e)
        {
            if (txtKQB3C.Text.ToString() == "")
            {
                MessageBox.Show("vui lòng điền kết quả trước");
            }
            else
            {
                if (int.Parse(txtKQB3C.Text.ToString()) == ((35281 + 51645) / 2))
                {

                    txtKQB3C.BackColor = Color.Blue;
                    MessageBox.Show("kết quả đúng");
                }
                else
                {

                    txtKQB3C.BackColor = Color.Red;
                    MessageBox.Show("kết quả sai");
                }
            }
        }

        private void btnKTB3D_Click(object sender, EventArgs e)
        {
            if (txtKQB3D.Text.ToString() == "")
            {
                MessageBox.Show("vui lòng điền kết quả trước");
            }
            else
            {
                if (int.Parse(txtKQB3D.Text.ToString()) == ((45405 - 8221) / 4))
                {

                    txtKQB3D.BackColor = Color.Blue;
                    MessageBox.Show("kết quả đúng");
                }
                else
                {

                    txtKQB3D.BackColor = Color.Red;
                    MessageBox.Show("kết quả sai");
                }
            }
        }

        private void btbLTC_Click(object sender, EventArgs e)
        {
            PHAN4_13 frmLTC = new PHAN4_13();
            this.Hide();
            frmLTC.ShowDialog();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
