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
    public partial class Bai2 : Form
    {
        public int currentIndex =0;
        private int sizeOfXML;
        private int tempNumber = 0;
        ArrayList arrPhepTinh = null;
        public Bai2()
        {
            InitializeComponent();
        }

        private void btKiemTra_Click(object sender, EventArgs e)
        {
            PhepTinhDTO phepTinhDTO = (PhepTinhDTO)arrPhepTinh[currentIndex];
            if(tbTempR.Text.Equals(phepTinhDTO.KetQua.ToString())){ 
                labelKetQua.Text = "Kết quả đúng!";
                gbR.Visible = true;
                tbRsh1.Text = phepTinhDTO.SoThuNhat.ToString();
                tbRsh2.Text = phepTinhDTO.SoThuHai.ToString();
                tbR.Text = phepTinhDTO.KetQua.ToString();
            }
            else {
                labelKetQua.Text = "Kết quả sai!";
                gbR.Visible = true;
                tbRsh1.Text = phepTinhDTO.SoThuNhat.ToString();
                tbRsh2.Text = phepTinhDTO.SoThuHai.ToString();
                tbR.Text = phepTinhDTO.KetQua.ToString();
            }
        }

        private void btLamLai_Click(object sender, EventArgs e)
        {
            tempNumber = 0;
            gbR.Visible = false;
            tbTempR.Text = "";
            labelKetQua.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PhepTinhDTO phepTinhDTO = null;
            if (currentIndex < sizeOfXML)
                currentIndex++;
            else currentIndex = 0;

            phepTinhDTO = (PhepTinhDTO)arrPhepTinh[currentIndex];
            tbTemp1.Text = phepTinhDTO.SoThuNhat.ToString();
            tbTemp2.Text = phepTinhDTO.SoThuHai.ToString();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Bai2_Load(object sender, EventArgs e)
        {
            PhepTinhDAO phepTinhDAO = new PhepTinhDAO();
            PhepTinhDTO phepTinhDTO = new PhepTinhDTO();

            arrPhepTinh = phepTinhDAO.getPhepTinhNhan();
            sizeOfXML = arrPhepTinh.Count;
            phepTinhDTO = (PhepTinhDTO)arrPhepTinh[0];
            tbTemp1.Text = phepTinhDTO.SoThuNhat.ToString();
            tbTemp2.Text = phepTinhDTO.SoThuHai.ToString();

            
        }

        private void bt10_Click(object sender, EventArgs e)
        {

        }

        private void bt9_Click(object sender, EventArgs e)
        {

        }

        private void bt8_Click(object sender, EventArgs e)
        {

        }

        private void bt7_Click(object sender, EventArgs e)
        {

        }

        private void bt6_Click(object sender, EventArgs e)
        {

        }

        private void bt5_Click(object sender, EventArgs e)
        {

        }

        private void bt4_Click(object sender, EventArgs e)
        {

        }

        private void bt3_Click(object sender, EventArgs e)
        {

        }

        private void bt2_Click(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {

        }

        private void bt1_Click_1(object sender, EventArgs e)
        {
            tempNumber = tempNumber * 10 + 1;
            tbTempR.Text = (tempNumber).ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void bt2_Click_1(object sender, EventArgs e)
        {
            tempNumber = tempNumber * 10 + 2;
            tbTempR.Text = (tempNumber).ToString();
        }

        private void bt3_Click_1(object sender, EventArgs e)
        {
            tempNumber = tempNumber * 10 + 3;
            tbTempR.Text = (tempNumber).ToString();
        }

        private void bt4_Click_1(object sender, EventArgs e)
        {
            tempNumber = tempNumber * 10 + 4;
            tbTempR.Text = (tempNumber).ToString();
        }

        private void bt5_Click_1(object sender, EventArgs e)
        {
            tempNumber = tempNumber * 10 + 5;
            tbTempR.Text = (tempNumber).ToString();
        }

        private void bt6_Click_1(object sender, EventArgs e)
        {
            tempNumber = tempNumber * 10 + 6;
            tbTempR.Text = (tempNumber).ToString();
        }

        private void bt7_Click_1(object sender, EventArgs e)
        {
            tempNumber = tempNumber * 10 + 7;
            tbTempR.Text = (tempNumber).ToString();
        }

        private void bt8_Click_1(object sender, EventArgs e)
        {
            tempNumber = tempNumber * 10 + 8;
            tbTempR.Text = (tempNumber).ToString();
        }

        private void bt9_Click_1(object sender, EventArgs e)
        {
            tempNumber = tempNumber * 10 + 9;
            tbTempR.Text = (tempNumber).ToString();
        }

        private void bt10_Click_1(object sender, EventArgs e)
        {
            tempNumber = tempNumber * 10 ;
            tbTempR.Text = (tempNumber).ToString();
        }

        private void tbRsh1_TextChanged(object sender, EventArgs e)
        {

        }

        

    }
}
