using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using System.Reflection;

namespace _46_47_48_49_50_ToanLop3.Phan4
{
    public partial class SoSanh : Form
    {
        Random random;
        int DoRandomNumber(int number)
        {
            random = new Random();
            int a = random.Next(1, number);
            return a;
        }

        public SoSanh()
        {
            InitializeComponent();
        }
        int doCheckNumber()
        {
             if(int.Parse(tbNum1.Text) < int.Parse(tbNum2.Text))
            {
                return 1;
            }
             else if(int.Parse(tbNum1.Text) > int.Parse(tbNum2.Text))
                
             {
                 return 3;
             }

             else
             {
                 return 2;
             }
        }
        void reDoBkColor()
        {
            bttBang.BackColor = bttBeHon.BackColor = bttLonHon.BackColor = Color.Transparent;
            bttLonHon.Show();
            bttBeHon.Show();
            bttBang.Show();
        }
        private void bttBeHon_Click(object sender, EventArgs e)
        {
            reDoBkColor();
            if (doCheckNumber()==1)
            {
                bttBeHon.BackColor = Color.Blue;
                bttLonHon.Hide();
                bttBang.Hide();
                textBox1.Text = "Đáp án đã đúng";
            }
            else
            {
                bttBeHon.BackColor= Color.Red;
                textBox1.Text = "Đáp án chưa đúng";
            }
        }

        private void bttBang_Click(object sender, EventArgs e)
        {
            reDoBkColor();
            if (doCheckNumber() == 2)
            {
                bttBang.BackColor = Color.Blue;
                bttLonHon.Hide();
                bttBeHon.Hide();
                textBox1.Text = "Đáp án đã đúng";
            }
            else
            {
                bttBang.BackColor = Color.Red;
                textBox1.Text = "Đáp án chưa đúng";
            }
        }

        private void bttLonHon_Click(object sender, EventArgs e)
        {
            reDoBkColor();
            if (doCheckNumber() == 3)
            {
                bttLonHon.BackColor = Color.Blue;
                bttBang.Hide();
                bttBeHon.Hide();
                textBox1.Text = "Đáp án đã đúng";
            }
            else
            {
                bttLonHon.BackColor = Color.Red;
                textBox1.Text = "Đáp án chưa đúng";
            }
        }

        private void bttLamLai_Click(object sender, EventArgs e)
        {
            reDoBkColor();
            tbNum1.Text = DoRandomNumber(random.Next(99999)).ToString();
            tbNum2.Text = DoRandomNumber(random.Next(99999)).ToString();
            textBox1.Text = "";
        }

        private void SoSanh_Load(object sender, EventArgs e)
        {
            tbNum1.Text = DoRandomNumber(99999).ToString();
            tbNum2.Text = DoRandomNumber(99999).ToString();
            Microsoft.Office.Interop.Word.ApplicationClass wordApplication = new ApplicationClass();
            object o_nullobject = System.Reflection.Missing.Value;
            object o_filePath = System.IO.Directory.GetCurrentDirectory() + "\\Resources\\SoSanhSo5ChuSo.doc";
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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
