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
    public partial class PHAN4_5ChuSo : Form
    {
        public PHAN4_5ChuSo()
        {
            InitializeComponent();
        }
        Random random;
        int m_ChucNghin, m_Nghin, m_Tram, m_Chuc, m_DonVi, m_SoVietRa;
        String m_ChuoiSo;
        string ChuoiCuoicung = "";

        void DoRandomNumber()
        {
            random = new Random();
            m_SoVietRa = 0;

            m_SoVietRa = random.Next(10000, 99999);
        }
        string DoCreateString(int iNum, int iIndex)
        {
            switch (iNum)
            {
                case 0:
                    {
                        if (iIndex == 2)
                            return "không ";
                        else
                            if (iIndex == 3)
                                return "lẻ ";
                            else
                                return "";
                        break;
                    }

                case 1:
                    {
                        if (iIndex == 0 || iIndex == 3)
                        {
                            return "mười ";
                        }
                        else if (iIndex == 4 )
                        {
                            return "mốt";
                        }
                        else if(iIndex == 1)
                        {
                            return "mốt ";
                        }
                        else
                        {
                            return "một ";
                        }
                        break;
                    }
                case 2:
                    {
                        return "hai ";
                        break;
                    }
                case 3:
                    {
                        return "ba ";
                        break;
                    }
                case 4:
                    {
                        return "bốn ";
                        break;
                    }
                case 5:
                    {
                        return "năm ";
                        break;
                    }
                case 6:
                    {
                        return "sáu ";
                        break;
                    }
                case 7:
                    {
                        return "bảy ";
                        break;
                    }
                case 8:
                    {
                        return "tám ";
                        break;
                    }
                case 9:
                    {
                        return "chín ";
                        break;
                    }
                default:
                    return "";
                    break;
            }
        }

        string DoCreateDocSoString(int iNum, int iIndex)
        {
            if (iIndex == 0)
                if (iNum == 1)
                    return "";
                else
                    return "mươi ";
            if (iIndex == 1)
                return "nghìn ";
            if (iIndex == 2)
                return "trăm ";
            if (iIndex == 3)
                if (iNum == 1 || iNum == 0)
                    return "";
                else
                    return "mươi ";
            return "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DoRandomNumber();
            string ChuoiSo = m_SoVietRa.ToString();
            tbChucNghin.BackColor = Color.White;
            tbNghin.BackColor = Color.White;
            tbTram.BackColor = Color.White;
            tbChuc.BackColor = Color.White;
            tbDonVi.BackColor = Color.White;
            tbSo.BackColor = Color.White;
            tbChu.BackColor = Color.White;
            tbChu.Enabled = true;
            tbChu.Text = "";
            tbSo.Text = m_SoVietRa.ToString();
            tbSo.Enabled = false;
            tbChucNghin.Text = ChuoiSo[0].ToString();
            tbChucNghin.Enabled = false;
            tbNghin.Text = ChuoiSo[1].ToString();
            tbNghin.Enabled = false;
            tbTram.Text = ChuoiSo[2].ToString();
            tbTram.Enabled = false;
            tbChuc.Text = ChuoiSo[3].ToString();
            tbChuc.Enabled = false;
            tbDonVi.Text = ChuoiSo[4].ToString();
            tbDonVi.Enabled = false;
            //tbChu.Text = DoCreateDocSoString(int.Parse(ChuoiSo[0].ToString()));
            int stringLength = ChuoiSo.Length;
            if (m_SoVietRa % 1000 == 0)
            {
                stringLength = 2;
            }
            else if (m_SoVietRa % 100 == 0)
            {
                stringLength = 3;
            }
            for (int i = 0; i < stringLength; i++)
            {
                if (i == 4 && (int.Parse(ChuoiSo[3].ToString()) == 0 || int.Parse(ChuoiSo[3].ToString()) == 1))
                {
                    ChuoiCuoicung += DoCreateString(int.Parse(ChuoiSo[i].ToString()), -1);
                }
                else
                {
                    ChuoiCuoicung += DoCreateString(int.Parse(ChuoiSo[i].ToString()), i);
                }
                ChuoiCuoicung += DoCreateDocSoString(int.Parse(ChuoiSo[i].ToString()), i);
            }
            ChuoiCuoicung.Trim();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoRandomNumber();
            string ChuoiSo = m_SoVietRa.ToString();
            int stringLength = ChuoiSo.Length;
            tbChu.BackColor = Color.White;
            tbChucNghin.BackColor = Color.White;
            tbChucNghin.Enabled = true;
            tbChucNghin.Text = "";
            tbNghin.BackColor = Color.White;
            tbNghin.Enabled = true;
            tbNghin.Text = "";
            tbTram.BackColor = Color.White;
            tbTram.Enabled = true;
            tbTram.Text = "";
            tbChuc.BackColor = Color.White;
            tbChuc.Enabled = true;
            tbChuc.Text = "";
            tbDonVi.BackColor = Color.White;
            tbDonVi.Enabled = true;
            tbDonVi.Text = "";
            tbSo.BackColor = Color.White;
            tbSo.Enabled = true;
            tbSo.Text = "";
            if (m_SoVietRa % 1000 == 0)
            {
                stringLength = 2;
            }
            else if (m_SoVietRa % 100 == 0)
            {
                stringLength = 3;
            }
            for (int i = 0; i < stringLength; i++)
            {
                if (i == 4 && (int.Parse(ChuoiSo[3].ToString()) == 0 || int.Parse(ChuoiSo[3].ToString()) == 1))
                {
                    ChuoiCuoicung += DoCreateString(int.Parse(ChuoiSo[i].ToString()), -1);
                }
                else
                {
                    ChuoiCuoicung += DoCreateString(int.Parse(ChuoiSo[i].ToString()), i);
                }
                ChuoiCuoicung += DoCreateDocSoString(int.Parse(ChuoiSo[i].ToString()), i);
            }
            ChuoiCuoicung.Trim();
            tbChu.Text = ChuoiCuoicung;
            tbChu.Enabled = false;
            m_ChucNghin = ChuoiSo[0];
            m_Nghin = ChuoiSo[1];
            m_Tram = ChuoiSo[2];
            m_Chuc = ChuoiSo[3];
            m_DonVi = ChuoiSo[4];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string testString = ChuoiCuoicung.Substring(0, ChuoiCuoicung.Length - 1);
            if (tbSo.Enabled == false)
                if (testString == tbChu.Text)
                {
                    tbChu.BackColor = Color.Blue;
                    tbChu.Enabled = false;
                    textBox1.Text = "Đáp án đã đúng";
                }
                else
                {
                    tbChu.BackColor = Color.Red;
                    textBox1.Text = "Đáp án chưa đúng, đáp án đúng:" + ChuoiCuoicung;
                }
            else
            {
                int kq = 0;
                if (m_ChucNghin.ToString() != tbChucNghin.Text)
                {
                    kq = 1;
                    tbChucNghin.BackColor = Color.Red;
                }
                else
                {
                    tbChucNghin.BackColor = Color.Blue;
                    tbChucNghin.Enabled = false;
                }
                if (m_Nghin.ToString() != tbNghin.Text)
                {
                    kq = 1;
                    tbNghin.BackColor = Color.Red;
                }
                else
                {
                    tbNghin.BackColor = Color.Blue;
                    tbNghin.Enabled = false;
                }
                if (m_Tram.ToString() != tbTram.Text)
                {
                    kq = 1;
                    tbTram.BackColor = Color.Red;
                }
                else
                {
                    tbTram.BackColor = Color.Blue;
                    tbTram.Enabled = false;
                }
                if (m_Chuc.ToString() != tbChuc.Text)
                {
                    kq = 1;
                    tbChuc.BackColor = Color.Red;
                }
                else
                {
                    tbChuc.BackColor = Color.Blue;
                    tbChuc.Enabled = false;
                }
                if (m_DonVi.ToString() != tbDonVi.Text)
                {
                    kq = 1;
                    tbDonVi.BackColor = Color.Red;
                }
                else
                {
                    tbDonVi.BackColor = Color.Blue;
                    tbDonVi.Enabled = false;
                }
                if (m_SoVietRa.ToString() != tbSo.Text)
                {
                    kq = 1;
                    tbSo.BackColor = Color.Red;
                }
                else
                {
                    tbSo.BackColor = Color.Blue;
                    tbSo.Enabled = false;
                }
                if (kq == 0) textBox1.Text = "Đáp án đã đúng";
                else textBox1.Text = "Đáp án chưa đúng";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
