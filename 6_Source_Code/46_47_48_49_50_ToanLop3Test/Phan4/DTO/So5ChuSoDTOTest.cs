using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _46_47_48_49_50_ToanLop3.Phan4.DTO;
using NUnit.Framework;
using NUnit.Framework.Constraints;
namespace _46_47_48_49_50_ToanLop3Test.Phan4.DTO
{
    [TestFixture]
    class So5ChuSoDTOTest
    {
        private So5ChuSoDTO so5ChuSoDTO;
        [SetUp]
        public void So5ChuSoDTOSetup()
        {
            so5ChuSoDTO = new So5ChuSoDTO();
        }
        [Test]
        public void ConstructorInitialization()
        {
            So5ChuSoDTO part = new So5ChuSoDTO( "Mười một nghìn ba trăm năm mươi chín", 11359);
            Assert.AreEqual(part.Text ,"Mười một nghìn ba trăm năm mươi chín");
            Assert.AreEqual(part.Number ,11359);
        }
    
        [Test]
        public void So5ChuSoDTOText()
        {
            
            so5ChuSoDTO.Text = "Mười một nghìn ba trăm năm mươi chín";
            Assert.AreEqual(so5ChuSoDTO.Text, "Mười một nghìn ba trăm năm mươi chín");
        }

        [Test]
        public void So5ChuSoDTONumber()
        {
            so5ChuSoDTO.Number = 11359;
            Assert.AreEqual(so5ChuSoDTO.Number, 11359);
        }

    }
}
