using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using _46_47_48_49_50_ToanLop3.Phan4.DTO;

namespace _46_47_48_49_50_ToanLop3Test.Phan4.DTO
{
    [TestFixture]
    class PhepTinhDTOTest
    {
        private PhepTinhDTO phepTinhDTO;
        [SetUp]
        public void PhepTinhDTOSetup()
        {
            phepTinhDTO = new PhepTinhDTO();
        }
        [Test]
        public void ConstructorInitialization()
        {
            PhepTinhDTO part = new PhepTinhDTO(11111,5, 55555);
            Assert.AreEqual(part.SoThuNhat, 11111);
            Assert.AreEqual(part.SoThuHai, 5);
            Assert.AreEqual(part.KetQua, 55555);
        }

        [Test]
        public void PhepTinhDTOSoThuNhat()
        {

            phepTinhDTO.SoThuNhat = 23456;
            Assert.AreEqual(phepTinhDTO.SoThuNhat, 23456);
        }

        [Test]
        public void PhepTinhDTOSoThuHai()
        {
            phepTinhDTO.SoThuHai = 11359;
            Assert.AreEqual(phepTinhDTO.SoThuHai, 11359);
        }

        [Test]
        public void PhepTinhDTOSoKetQua()
        {
            phepTinhDTO.SoThuHai = 34576;
            Assert.AreEqual(phepTinhDTO.KetQua, 34576);
        }
    }
}
