using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAO;
using DTO;
using Quanlykhachsan;
using BUS;
namespace TestProject
{
    /// <summary>
    /// Summary description for TestDichvu
    /// </summary>
    [TestClass]
    public class TestDichvu
    {
        DichVuBUS dvBus;
        DichVuDAO dvDAO;
        DichVuDTO dvDTO;
        public TestDichvu()
        {

        }

        [TestInitialize]
        public void setUp()
        {
            dvBus = new DichVuBUS();
            dvDAO = new DichVuDAO();
            dvDTO = new DichVuDTO();
        }

        [TestMethod]
        public void TestThemDVFail()
        {
            dvDTO = null;
            int expected = 0;
            int actual = dvBus.insertDichVu(dvDTO);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestThemDVSuccess()
        {
            dvDTO.Donvitinh = "chai";
            dvDTO.Gia = 10000;
            dvDTO.Madichvu = "SD";
            dvDTO.Tendichvu = "Sting dâu";
            int expected = 1;
            int actual = dvBus.insertDichVu(dvDTO);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestSuaDVFail()
        {
            dvDTO = null;
            int expected = 0;
            int actual = dvBus.updateDichVu(dvDTO);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestSuaDVSuccess()
        {
            dvDTO.Donvitinh = "chai";
            dvDTO.Gia = 9000;
            dvDTO.Madichvu = "SD";
            dvDTO.Tendichvu = "Sting Đỏ";
            int expected = 1;
            int actual = dvBus.updateDichVu(dvDTO);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestXoaDVFail()
        {
            int actual = dvBus.deleteDichVu("D3");
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestXoaDVSuccess()
        {
            int actual = dvBus.deleteDichVu("SD");
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }
    }
}
