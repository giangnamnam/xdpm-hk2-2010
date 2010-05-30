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
    public partial class Bai6_LuyenTap : Form
    {
        public Bai6_LuyenTap()
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

        private void btnKQB2A_Click(object sender, EventArgs e)
        {
            if (txtKQB2A.Text.ToString() == "")
            {
                MessageBox.Show("vui lòng điền kết quả trước");
            }
            else
            {
                if (int.Parse(txtKQB2A.Text.ToString()) == (10303 * 4 + 27854))
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

        private void txtKQB2D_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnKQB2B_Click(object sender, EventArgs e)
        {
            if (txtKQB2B.Text.ToString() == "")
            {
                MessageBox.Show("vui lòng điền kết quả trước");
            }
            else
            {
                if (int.Parse(txtKQB2B.Text.ToString()) == (21507 * 3 - 18799))
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

        private void btnKQB2C_Click(object sender, EventArgs e)
        {
            if (txtKQB2C.Text.ToString() == "")
            {
                MessageBox.Show("vui lòng điền kết quả trước");
            }
            else
            {
                if (int.Parse(txtKQB2C.Text.ToString()) == (26742 + 14031 * 5))
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

        private void btnKQB2D_Click(object sender, EventArgs e)
        {
            if (txtKQB2D.Text.ToString() == "")
            {
                MessageBox.Show("vui lòng điền kết quả trước");
            }
            else
            {
                if (int.Parse(txtKQB2D.Text.ToString()) == (81025 - 12071 * 6))
                {

                    txtKQB2D.BackColor = Color.Blue;
                    MessageBox.Show("kết quả đúng");
                }
                else
                {

                    txtKQB2D.BackColor = Color.Red;
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

        private void btnKTB3A_Click(object sender, EventArgs e)
        {
            if (txtKQB3A.Text.ToString() == "")
            {
                MessageBox.Show("vui lòng điền kết quả trước");
            }
            else
            {
                if (int.Parse(txtKQB3A.Text.ToString()) == 22000)
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

        private void btnKTB3B_Click(object sender, EventArgs e)
        {
            if (txtKQB3B.Text.ToString() == "")
            {
                MessageBox.Show("vui lòng điền kết quả trước");
            }
            else
            {
                if (int.Parse(txtKQB3B.Text.ToString()) == 24000)
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
                if (int.Parse(txtKQB3C.Text.ToString()) == 26000)
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
                if (int.Parse(txtKQB3D.Text.ToString()) == 30000)
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLTC_Click(object sender, EventArgs e)
        {
            PHAN4_13 frmLTC = new PHAN4_13();
            this.Hide();
            frmLTC.ShowDialog();
            this.Close();
        }

        private void txtKQB2A_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }





    }
}
