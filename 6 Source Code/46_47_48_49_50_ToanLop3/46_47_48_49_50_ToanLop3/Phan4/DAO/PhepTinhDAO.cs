using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _46_47_48_49_50_ToanLop3.Phan4.DTO;
using System.Data;
namespace _46_47_48_49_50_ToanLop3.Phan4.DAO
{
    class PhepTinhDAO
    {
        public PhepTinhDAO() { }

        public ArrayList getPhepTinhNhan() {
            ArrayList listSo = new ArrayList();
            DataSet dataSet = new DataSet();
            PhepTinhDTO phepTinh = null;
            string database = Application.StartupPath + "\\Resources\\PhepNhan.xml";
            string schema = Application.StartupPath + "\\Resources\\PhepNhan.xsd";
            dataSet.ReadXmlSchema(schema);
            dataSet.ReadXml(database);
            DataRow[] drs = dataSet.Tables["Number"].Select("Ma > 0");
            foreach (DataRow dr in drs)
            {
                phepTinh = new PhepTinhDTO(Int32.Parse(dr["SH1"].ToString()), Int32.Parse(dr["SH2"].ToString()), Int32.Parse(dr["KQ"].ToString()));
                listSo.Add(phepTinh);
            }

            return listSo;
        } 
    }
}
