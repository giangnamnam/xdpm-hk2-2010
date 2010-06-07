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

        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuyenTap_Click(object sender, EventArgs e)
        {
            //Bai7_LuyenTap frmLT = new Bai7_LuyenTap();
            //this.Hide();
            //frmLT.ShowDialog();
            //this.Close();
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

        private void btnKTB1A_Click(object sender, EventArgs e)
        {
            if (txtKQB1A.Text.ToString() == "")
            {
                MessageBox.Show("vui lòng điền kết quả trước");
            }
            else
            {
                if (int.Parse(txtKQB1A.Text.ToString()) == (84848 / 4))
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
                if (int.Parse(txtKQB1B.Text.ToString()) == (24693 / 3))
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
                if (int.Parse(txtKQB1C.Text.ToString()) == (23436 / 3))
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
                if (int.Parse(txtKQB2.Text.ToString()) == (36550 - 36550 / 5))
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

        private void btnTiepTheo_Click(object sender, EventArgs e)
        {
            //Bai7_tieptheo_ frmTT = new Bai7_tieptheo_();
            //this.Hide();
            //frmTT.ShowDialog();
            //this.Close();
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
