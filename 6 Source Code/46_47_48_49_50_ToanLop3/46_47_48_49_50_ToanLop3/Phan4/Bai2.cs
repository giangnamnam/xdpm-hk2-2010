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
using Microsoft.Office.Interop.Word;
using System.Reflection;

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
            tbR.Visible = true;
            if(tbTempR.Text.Equals(phepTinhDTO.KetQua.ToString())){
                tbR.BackColor = Color.Blue;
                tbR.Text = phepTinhDTO.KetQua.ToString();
            }
            else {
                //labelKetQua.Text = "Kết quả sai!";
                tbR.Text = phepTinhDTO.KetQua.ToString();
                tbR.BackColor = Color.Red;
            }
        }

        private void btLamLai_Click(object sender, EventArgs e)
        {
            tempNumber = 0;
            tbTempR.Text = "";
            tbR.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PhepTinhDTO phepTinhDTO = null;
            

            phepTinhDTO = (PhepTinhDTO)arrPhepTinh[currentIndex];
            tbTemp1.Text = phepTinhDTO.SoThuNhat.ToString();
            tbTemp2.Text = phepTinhDTO.SoThuHai.ToString();
            if (currentIndex < sizeOfXML-1)
                currentIndex++;
            else currentIndex = 0;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Bai2_Load(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.ApplicationClass wordApplication = new ApplicationClass();
            object o_nullobject = System.Reflection.Missing.Value;
            object o_filePath = System.IO.Directory.GetCurrentDirectory() + "\\Resources\\PhepNhan.doc";
            object o_format = Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatHTML;
            object o_encoding = Microsoft.Office.Core.MsoEncoding.msoEncodingUTF8;
            object o_endings = Microsoft.Office.Interop.Word.WdLineEndingType.wdCRLF;
            object o_Readonly = true;
            Microsoft.Office.Interop.Word.Document doc = wordApplication.Documents.Open(ref o_filePath,
            ref o_nullobject, ref o_Readonly, ref o_nullobject, ref o_nullobject, ref o_nullobject,
            ref o_nullobject, ref o_nullobject, ref o_nullobject, ref o_nullobject, ref o_nullobject, ref o_nullobject, ref o_nullobject, ref o_nullobject,
            ref o_nullobject, ref o_nullobject);


            doc.ActiveWindow.Selection.WholeStory();

            doc.ActiveWindow.Selection.Copy();

            IDataObject data = Clipboard.GetDataObject();

            txtLyThuyet.Text = data.GetData(DataFormats.UnicodeText).ToString();

            doc.Close(ref o_nullobject, ref o_nullobject, ref o_nullobject);
            wordApplication.Quit(ref o_nullobject, ref o_nullobject, ref o_nullobject);


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
