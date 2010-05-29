using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _46_47_48_49_50_ToanLop3.Phan4.DAO;
using _46_47_48_49_50_ToanLop3.Phan4.DTO;

namespace _46_47_48_49_50_ToanLop3.Phan4
{
    public partial class Bai1 : Form
    {
        public int currentIndex;
        private int sizeOfXML;
        private int currentResult;
        private int tempNumber =0;
        ArrayList arrSo5ChuSo = null;
        public Bai1()
        {
            InitializeComponent();
        }

        private void btLamLai_Click(object sender, EventArgs e)
        {
            tbVietSo.Text = "";
            tbKetQua.Text = "";
            tempNumber = 0;
            lbKetQua.Text = "";
        }

        private void btKiemTra_Click(object sender, EventArgs e)
        {
            if (!tbVietSo.Text.Equals(currentResult.ToString()))
            {
                lbKetQua.Text = "Kết quả sai!";
                tbKetQua.Text = currentResult.ToString();
            }
            else
            {
                lbKetQua.Text = "Kết quả đúng";
                tbKetQua.Text = currentResult.ToString();
            }
        }

        private void Bai1_Load(object sender, EventArgs e)
        {
            currentIndex=1;
            So5ChuSoDAO so5ChuSoDAO = new So5ChuSoDAO();
            So5ChuSoDTO so5ChuSoDTO = null;
            
            arrSo5ChuSo = so5ChuSoDAO.getSo5ChuSo();
            sizeOfXML = arrSo5ChuSo.Count;
            so5ChuSoDTO = (So5ChuSoDTO)arrSo5ChuSo[0];
            lbDocSo.Text = so5ChuSoDTO.Text;
            currentResult = so5ChuSoDTO.Number;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            tempNumber = tempNumber * 10 + 1;
            tbVietSo.Text = (tempNumber).ToString();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            tempNumber = tempNumber * 10 + 2;
            tbVietSo.Text = (tempNumber ).ToString();
        }

        private void bt3_Click(object sender, EventArgs e)
        {

            tempNumber = tempNumber * 10 + 3;
            tbVietSo.Text = (tempNumber).ToString();
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            tempNumber = tempNumber * 10 + 4;
            tbVietSo.Text = (tempNumber).ToString();
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            tempNumber = tempNumber * 10 + 5;
            tbVietSo.Text = (tempNumber).ToString();
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            tempNumber = tempNumber * 10 + 6;
            tbVietSo.Text = (tempNumber).ToString();
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            tempNumber = tempNumber * 10 + 7;
            tbVietSo.Text = (tempNumber).ToString();
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            tempNumber = tempNumber * 10 + 8;
            tbVietSo.Text = (tempNumber).ToString();
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            tempNumber = tempNumber * 10 + 9;
            tbVietSo.Text = (tempNumber).ToString();
        }

        private void bt10_Click(object sender, EventArgs e)
        {
            tempNumber = tempNumber * 10;
            tbVietSo.Text = (tempNumber).ToString();
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
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentIndex < sizeOfXML)
                currentIndex++;
            else currentIndex = 0;
            So5ChuSoDTO so5ChuSoDTO = null;
            so5ChuSoDTO = (So5ChuSoDTO)arrSo5ChuSo[currentIndex-1];
            lbDocSo.Text = so5ChuSoDTO.Text;
            currentResult = so5ChuSoDTO.Number;
        }

    }
}
