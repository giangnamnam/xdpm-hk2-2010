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
    public partial class DaySoFrm : Form
    {
        Random random;
        int temp = 1;
        int DoRandomInt(int number)
        {
            random = new Random();
            int a = random.Next(1, number);
            return a;
        }
        int DoRandomLong(int number)
        {
            random = new Random();
            int a = random.Next(10000, number);
            return a;
        }
        int a,b;
        long So;
        
        public DaySoFrm()
        {
            InitializeComponent();
        }

        private void btLamTiep_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.BackColor = Color.White;
            textBox1.Enabled = true;
            textBox2.Text = "";
            textBox2.BackColor = Color.White;
            textBox2.Enabled = true;
            textBox3.Text = "";
            textBox3.BackColor = Color.White;
            textBox3.Enabled = true;
            textBox4.Text = "";
            textBox4.BackColor = Color.White;
            textBox4.Enabled = true;
            textBox5.Text = "";
            textBox5.BackColor = Color.White;
            textBox5.Enabled = true;
            textBox6.Text = "";
            temp = 1;
            _Random();
            int c;
            b = a;
            while (b == a) b = DoRandomInt(5);
            long ChucNghin = So / 10000;
            long Nghin = (So - (ChucNghin * 10000)) / 1000;
            long Tram = (So - (ChucNghin * 10000) - (Nghin * 1000)) / 100;
            long Chuc = (So - (ChucNghin * 10000) - (Nghin * 1000) - (Tram * 100)) / 10;
            long DonVi = So - (ChucNghin * 10000) - (Nghin * 1000) - (Tram * 100) - (Chuc * 10);
            if (DonVi == 0)
                if (Chuc == 0)
                    if (Tram == 0)
                        if (Nghin == 0)
                            if (ChucNghin - a < 5) c = 5;
                            else c = 4;
                        else if (Nghin - a < 5) c = 4;
                             else if (ChucNghin == 9) c = 3;
                                  else c = 4;
                    else if (Tram - a < 5) c = 3;
                         else if ((ChucNghin == 9) & (Nghin == 9)) c = 2;
                              else c = 3;
                else if (Chuc - a < 5) c = 2;
                     else if ((ChucNghin == 9) & (Nghin == 9) & (Tram == 9)) c = 1;
                          else c = 2;
            else c = 1;

            int d;
            if (ChucNghin - a < 5) d = 5;
            else if (ChucNghin != 9) d = 4;
                 else if (Nghin - a < 5) d = 4;
                      else if (Nghin != 9) d = 3;
                           else if (Tram - a < 5) d = 3;
                                else if (Tram != 9) d = 2;
                                     else if (Chuc - a < 5) d = 2;
                                          else d = 1;

            int h = random.Next(c, d);
            for (int i = 1; i < h; i++)
                temp = temp * 10;
            So = (So / temp) * temp;

            switch (a)
            {
                case 1:
                    {
                        textBox1.Text = So.ToString();
                        textBox1.Enabled = false;
                        break;
                    }
                case 2:
                    {
                        textBox2.Text = So.ToString();
                        textBox2.Enabled = false;
                        break;
                    }
                case 3:
                    {
                        textBox3.Text = So.ToString();
                        textBox3.Enabled = false;
                        break;
                    }
                case 4:
                    {
                        textBox4.Text = So.ToString();
                        textBox4.Enabled = false;
                        break;
                    }
                case 5:
                    {
                        textBox5.Text = So.ToString();
                        textBox5.Enabled = false;
                        break;
                    }
                default:
                    break;
            }

            long So1 = So + (b - a) * temp;
            switch (b)
            {
                case 1:
                    {
                        textBox1.Text = So1.ToString();
                        textBox1.Enabled = false;
                        break;
                    }
                case 2:
                    {
                        textBox2.Text = So1.ToString();
                        textBox2.Enabled = false;
                        break;
                    }
                case 3:
                    {
                        textBox3.Text = So1.ToString();
                        textBox3.Enabled = false;
                        break;
                    }
                case 4:
                    {
                        textBox4.Text = So1.ToString();
                        textBox4.Enabled = false;
                        break;
                    }
                case 5:
                    {
                        textBox5.Text = So1.ToString();
                        textBox5.Enabled = false;
                        break;
                    }
                default:
                    break;
            }
        }

        //public void KiemTraGioiHan(long iSo, int iSoChia, int a, ref bool bFlag)
        //{
        //    long n = iSo / iSoChia;
        //    if (n - a > 4)
        //    {
        //        bFlag = true;
        //    }
        //}
         public void _Random()
            {
                a = DoRandomInt(5);
                So = DoRandomLong(99995);
            }
         private void DaySoFrm_Load(object sender, EventArgs e)
         {
             _Random();
             int c;
             b = a;
             while (b == a) b = DoRandomInt(5);
             long ChucNghin = So / 10000;
             long Nghin = (So - (ChucNghin * 10000)) / 1000;
             long Tram = (So - (ChucNghin * 10000) - (Nghin * 1000)) / 100;
             long Chuc = (So - (ChucNghin * 10000) - (Nghin * 1000) - (Tram * 100)) / 10;
             long DonVi = So - (ChucNghin * 10000) - (Nghin * 1000) - (Tram * 100) - (Chuc * 10);
             if (DonVi == 0)
                 if (Chuc == 0)
                     if (Tram == 0)
                         if (Nghin == 0)
                             if (ChucNghin - a < 5) c = 5;
                             else c = 4;
                         else if (Nghin - a < 5) c = 4;
                              else if (ChucNghin == 9) c = 3;
                                   else c = 4;
                     else if (Tram - a < 5) c = 3;
                          else if ((ChucNghin == 9) & (Nghin == 9)) c = 2;
                               else c = 3;
                 else if (Chuc - a < 5) c = 2;
                      else if ((ChucNghin == 9) & (Nghin == 9) & (Tram == 9)) c = 1;
                           else c = 2;
             else c = 1;

             int d;
             if (ChucNghin - a < 5) d = 5;
             else if (ChucNghin != 9) d = 4;
                  else if (Nghin - a < 5) d = 4;
                       else if (Nghin != 9) d = 3;
                            else if (Tram - a < 5) d = 3;
                                 else if (Tram != 9) d = 2;
                                      else if (Chuc - a < 5) d = 2;
                                           else d = 1;

             int h = random.Next(c,d);
             for (int i = 1; i < h; i++)
                 temp = temp * 10;
             So = (So / temp) * temp;

             textBox1.BackColor = Color.White;
             textBox2.BackColor = Color.White;
             textBox3.BackColor = Color.White;
             textBox4.BackColor = Color.White;
             textBox5.BackColor = Color.White;
             switch (a)
             {
                 case 1:
                     {
                         textBox1.Text = So.ToString();
                         textBox1.Enabled = false;
                         break;
                     }
                 case 2:
                     {
                         textBox2.Text = So.ToString();
                         textBox2.Enabled = false;
                         break;
                     }
                 case 3:
                     {
                         textBox3.Text = So.ToString();
                         textBox3.Enabled = false;
                         break;
                     }
                 case 4:
                     {
                         textBox4.Text = So.ToString();
                         textBox4.Enabled = false;
                         break;
                     }
                 case 5:
                     {
                         textBox5.Text = So.ToString();
                         textBox5.Enabled = false;
                         break;
                     }
                 default:
                     break;
             }

             long So1 = So + (b - a) * temp;
             switch (b)
             {
                 case 1:
                     {
                         textBox1.Text = So1.ToString();
                         textBox1.Enabled = false;
                         break;
                     }
                 case 2:
                     {
                         textBox2.Text = So1.ToString();
                         textBox2.Enabled = false;
                         break;
                     }
                 case 3:
                     {
                         textBox3.Text = So1.ToString();
                         textBox3.Enabled = false;
                         break;
                     }
                 case 4:
                     {
                         textBox4.Text = So1.ToString();
                         textBox4.Enabled = false;
                         break;
                     }
                 case 5:
                     {
                         textBox5.Text = So1.ToString();
                         textBox5.Enabled = false;
                         break;
                     }
                 default:
                     break;
             }
         }


            //int SoChia = 1;
            //long temp = So[a - 1];
            //while(temp >= 10)
            //{
            //    temp = temp / 10;
            //    SoChia = SoChia * 10;
            //}

            //int i = 0;
            //bool bFlagGioiHan;
            //temp = So[a - 1];
            //while (temp > 0)
            //{
            //    bFlagGioiHan = false;
            //    KiemTraGioiHan(temp, SoChia, a, ref bFlagGioiHan);
            //    if(bFlagGioiHan == true)
            //    {
            //        i++;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //    if (i == 5)
            //    {
            //        DaySoFrm_Load(sender, e);
            //        break;
            //    }
            //    long n = temp - (temp % SoChia);
            //    temp = temp - n;
            //    SoChia = SoChia / 10;
            //}
        
        private void button1_Click(object sender, EventArgs e)
        {
            int kq=0;
            if ((So + (1-a) * temp).ToString() != textBox1.Text) 
            {
                textBox1.BackColor = Color.Red;
                kq = 1;
            }
            else if ((a!=1) & (b!=1))
            {
                textBox1.BackColor = Color.Blue;
                textBox1.Enabled = false;
            }
            if ((So + (2 - a) * temp).ToString() != textBox2.Text)
            {
                textBox2.BackColor = Color.Red;
                kq = 1;
            }
            else if ((a != 2) & (b != 2))
            {
                textBox2.BackColor = Color.Blue;
                textBox2.Enabled = false;
            }
            if ((So + (3 - a) * temp).ToString() != textBox3.Text)
            {
                textBox3.BackColor = Color.Red;
                kq = 1;
            }
            else if ((a != 3) & (b != 3))
            {
                textBox3.BackColor = Color.Blue;
                textBox3.Enabled = false;
            }
            if ((So + (4 - a) * temp).ToString() != textBox4.Text)
            {
                textBox4.BackColor = Color.Red;
                kq = 1;
            }
            else if ((a != 4) & (b != 4))
            {
                textBox4.BackColor = Color.Blue;
                textBox4.Enabled = false;
            }
            if ((So + (5 - a) * temp).ToString() != textBox5.Text)
            {
                textBox5.BackColor = Color.Red;
                kq = 1;
            }
            else if ((a != 5) & (b != 5))
            {
                textBox5.BackColor = Color.Blue;
                textBox5.Enabled = false;
            }
            if (kq == 1) textBox6.Text = "Đáp án chưa đúng";
            else textBox6.Text = "Đáp án đã đúng";
        }
         
    }
}
