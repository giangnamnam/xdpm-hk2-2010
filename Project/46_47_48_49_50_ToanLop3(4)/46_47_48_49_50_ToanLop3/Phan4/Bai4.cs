﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan4
{
    public partial class TinhDienTichFrm : Form
    {
        Random random;
        int cr,cd;
        int h = 10;
        int g = 0;
        public TinhDienTichFrm()
        {
            InitializeComponent();
        }

        int DoRandom(int number)
        {
            random = new Random();
            int a = random.Next(1, number);
            return a;
        }

        private void TinhDienTichFrm_Load(object sender, EventArgs e)
        {
            cr = DoRandom(9);
            cd = DoRandom(99);
            while (cd <= cr) cd = DoRandom(99);
            textBox1.BackColor = Color.White;
            textBox1.Text = cr.ToString();
            textBox1.Enabled = false;
            textBox2.BackColor = Color.White;
            textBox2.Text = cd.ToString();
            textBox2.Enabled = false;
            textBox5.BackColor = Color.White;
            textBox6.BackColor = Color.White;
            while ((h > 9) & ((h % 4) != 0)) h = random.Next(1, 36);
            if (h < 10)
            {
                if ((h % 4) != 0)
                {
                    textBox5.Text = h.ToString();
                    textBox5.Enabled = false;
                    g = 1;
                }
                else
                {
                    g = random.Next(1, 2);
                    if (g == 1)
                    {
                        textBox5.Text = h.ToString();
                        textBox5.Enabled = false;
                    }
                    else
                    {
                        textBox6.Text = h.ToString();
                        textBox6.Enabled = false;
                    }
                }
            }
            else
            {
                textBox6.Text = h.ToString();
                textBox6.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kq = 0;
            if (((cr + cd) * 2).ToString() != textBox3.Text)
            {
                textBox3.BackColor = Color.Red;
                kq = 1;
            }
            else
            {
                textBox3.BackColor = Color.Blue;
                textBox3.Enabled = false;
            }
            if ((cr * cd).ToString() != textBox4.Text)
            {
                textBox4.BackColor = Color.Red;
                kq = 1;
            }
            else
            {
                textBox4.BackColor = Color.Blue;
                textBox4.Enabled = false;
            }
            if (g == 1)
            {
                if ((h * 4).ToString() != textBox6.Text)
                {
                    textBox6.BackColor = Color.Red;
                    kq = 1;
                }
                else
                {
                    textBox6.BackColor = Color.Blue;
                    textBox6.Enabled = false;
                }
                if ((h * h).ToString() != textBox7.Text)
                {
                    textBox7.BackColor = Color.Red;
                    kq =1;
                }
                else
                {
                    textBox7.BackColor = Color.Blue;
                    textBox7.Enabled = false;
                }
                if (((cr * cd) + (h * h)).ToString() != textBox9.Text)
                {
                    textBox9.BackColor = Color.Red;
                    kq = 1;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                    textBox9.Enabled = false;
                }
            }
            else
            {
                if ((h / 4).ToString() != textBox5.Text)
                {
                    textBox5.BackColor = Color.Red;
                    kq = 1;
                }
                else
                {
                    textBox5.BackColor = Color.Blue;
                    textBox5.Enabled = false;
                }
                if ((h * h / 16).ToString() != textBox7.Text)
                {
                    textBox7.BackColor = Color.Red;
                    kq = 1;
                }
                else
                {
                    textBox7.BackColor = Color.Blue;
                    textBox7.Enabled = false;
                }
                if (((cr * cd) + (h * h / 16)).ToString() != textBox9.Text)
                {
                    textBox9.BackColor = Color.Red;
                    kq = 1;
                }
                else
                {
                    textBox9.BackColor = Color.Blue;
                    textBox9.Enabled = false;
                }
            }
            if (kq == 0) textBox8.Text = "Đáp án đã đúng";
            else textBox8.Text = "Đáp án chưa đúng";
        }

        private void button2_Click(object sender, EventArgs e)
        {
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
            textBox6.BackColor = Color.White;
            textBox6.Enabled = true;
            textBox7.Text = "";
            textBox7.BackColor = Color.White;
            textBox7.Enabled = true;
            textBox8.Text = "";
            textBox9.Text = "";
            textBox9.BackColor = Color.White;
            textBox9.Enabled = true;
   
            cr = DoRandom(9);
            cd = DoRandom(99);
            while (cd <= cr) cd = DoRandom(99);
            textBox1.Text = cr.ToString();
            textBox1.Enabled = false;
            textBox2.Text = cd.ToString();
            textBox2.Enabled = false;
            h = 10;
            g = 0;
            while ((h > 9) & ((h % 4) != 0)) h = random.Next(1, 36);
            if (h < 10)
            {
                if ((h % 4) != 0)
                {
                    textBox5.Text = h.ToString();
                    textBox5.Enabled = false;
                    g = 1;
                }
                else
                {
                    g = random.Next(1, 2);
                    if (g == 1)
                    {
                        textBox5.Text = h.ToString();
                        textBox5.Enabled = false;
                    }
                    else
                    {
                        textBox6.Text = h.ToString();
                        textBox6.Enabled = false;
                    }
                }
            }
            else
            {
                textBox6.Text = h.ToString();
                textBox6.Enabled = false;
            }
        }

        
    }
}
