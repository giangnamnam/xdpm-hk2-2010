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
    public partial class PHAN4_13 : Form
    {
        public PHAN4_13()
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

        private void txtDuA_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDuB_KeyPress(object sender, KeyPressEventArgs e)
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
                if (int.Parse(txtKQB1A.Text.ToString()) == (10715 * 6))
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

        private void btnKTB1C_Click(object sender, EventArgs e)
        {
            if (txtKQB1C.Text.ToString() == "")
            {
                MessageBox.Show("vui lòng điền kết quả trước");
            }
            else
            {
                if (int.Parse(txtKQB1C.Text.ToString()) == (21542 * 3))
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

        private void btnKTB1B_Click(object sender, EventArgs e)
        {
            int kq = (int)30755 / 5;
            int du = (int)30755 % 5;
            if (txtKQB1B.Text.ToString() == "")
            {
                MessageBox.Show("vui lòng điền kết quả trước");
            }
            else
            {
                if (int.Parse(txtKQB1B.Text.ToString()) == kq)
                {
                    if (txtDuA.Text.ToString() == "")
                    {
                        MessageBox.Show("Vui lòng điền số dư");
                    }
                    else
                    {
                        if (int.Parse(txtDuA.Text.ToString()) == du)
                        {
                            txtDuA.BackColor = Color.Blue;
                            txtKQB1B.BackColor = Color.Blue;
                            MessageBox.Show("kết quả đúng");
                        }
                        else
                        {
                            txtDuA.BackColor = Color.Red;
                            txtKQB1B.BackColor = Color.Red;
                            MessageBox.Show("kết quả sai");
                        }
                    }


                }
                else
                {
                    txtDuA.BackColor = Color.Red;
                    txtKQB1A.BackColor = Color.Red;
                    MessageBox.Show("kết quả sai");
                }
            }
        }

        private void btnKTB1D_Click(object sender, EventArgs e)
        {
            int kq = (int)48729 / 6;
            int du = (int)48729 % 6;
            if (txtKQB1D.Text.ToString() == "")
            {
                MessageBox.Show("vui lòng điền kết quả trước");
            }
            else
            {
                if (int.Parse(txtKQB1D.Text.ToString()) == kq)
                {
                    if (txtDuB.Text.ToString() == "")
                    {
                        MessageBox.Show("Vui lòng điền số dư");
                    }
                    else
                    {

                        if (int.Parse(txtDuB.Text.ToString()) == du)
                        {
                            txtDuB.BackColor = Color.Blue;
                            txtKQB1D.BackColor = Color.Blue;
                            MessageBox.Show("kết quả đúng");
                        }
                        else
                        {
                            txtDuB.BackColor = Color.Red;
                            txtKQB1D.BackColor = Color.Red;
                            MessageBox.Show("kết quả sai");
                        }
                    }


                }
                else
                {
                    txtDuB.BackColor = Color.Red;
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

        private void btnKTB2_Click(object sender, EventArgs e)
        {
            if (txtKQB2.Text.ToString() == "")
            {
                MessageBox.Show("vui lòng điền kết quả trước");
            }
            else
            {
                if (int.Parse(txtKQB2.Text.ToString()) == 210)
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

        private void txtKQB3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnKQB3_Click(object sender, EventArgs e)
        {
            if (txtKQB3.Text.ToString() == "")
            {
                MessageBox.Show("vui lòng điền kết quả trước");
            }
            else
            {
                if (int.Parse(txtKQB3.Text.ToString()) == 48)
                {

                    txtKQB3.BackColor = Color.Blue;
                    MessageBox.Show("kết quả đúng");
                }
                else
                {

                    txtKQB3.BackColor = Color.Red;
                    MessageBox.Show("kết quả sai");
                }

            }

        }

        private void txtB4A_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtB4B_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtB4C_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtB4D_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnKTB4_Click(object sender, EventArgs e)
        {
            txtB4A.BackColor = Color.Blue;
            txtB4A.Text = "8";
            txtB4B.BackColor = Color.Blue;
            txtB4B.Text = "15";
            txtB4C.BackColor = Color.Blue;
            txtB4C.Text = "22";
            txtB4D.BackColor = Color.Blue;
            txtB4D.Text = "29";

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            PHAN4_11 frmQL = new PHAN4_11();
            this.Hide();
            frmQL.ShowDialog();
            this.Close();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            PHAN4_12 frmQL = new PHAN4_12();
            this.Hide();
            frmQL.ShowDialog();
            this.Close();
        }

      
    }
}
