﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _46_47_48_49_50_ToanLop3.Phan5
{
    public partial class CacSoDen100ktt : Form
    {
        public CacSoDen100ktt()
        {
            InitializeComponent();
        }

        private void Bai1_Click(object sender, EventArgs e)
        {
            Phan5.BaiOnTap2.Bai01 fr = new Phan5.BaiOnTap2.Bai01();
            fr.Show();
        }
    }
}
