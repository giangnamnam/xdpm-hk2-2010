using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using _46_47_48_49_50_ToanLop3.Phan4.DTO;
namespace _46_47_48_49_50_ToanLop3.Phan4.DAO
{
    class So5ChuSoDAO
    {
        public So5ChuSoDAO() {
            
            
        }

        public ArrayList getSo5ChuSo () 
        {
            ArrayList listSo = new ArrayList();
            DataSet dataSet = new DataSet();
            So5ChuSoDTO so5ChuSo = null;
            string database = Application.StartupPath + "\\Resources\\so5chuso.xml";
            string schema = Application.StartupPath + "\\Resources\\so5chuso.xsd";
            dataSet.ReadXmlSchema(schema);
            dataSet.ReadXml(database);
            DataRow[] drs = dataSet.Tables["Number"].Select("Code > 0");
            foreach (DataRow dr in drs)
            {
                so5ChuSo = new So5ChuSoDTO(dr["Text"].ToString(), Int32.Parse(dr["Integer"].ToString()));
                listSo.Add(so5ChuSo);
            }
            
            return listSo;
        }
    }
}
