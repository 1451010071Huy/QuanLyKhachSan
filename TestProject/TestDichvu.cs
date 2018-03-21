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
        DichVuBUS dvBus = new DichVuBUS();
        DichVuDAO dvDAO = new DichVuDAO();
        DichVuDTO dvDTO = new DichVuDTO();
        public TestDichvu()
        {
            
        }
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestThemDVFail()
        {
            dvDTO = null;
            int expected = 0;
            int actual=dvBus.insertDichVu(dvDTO);
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
