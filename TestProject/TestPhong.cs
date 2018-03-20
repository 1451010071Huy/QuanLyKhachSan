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
    /// Summary description for TestPhong
    /// </summary>
    [TestClass]
    public class TestPhong
    {
        PhongBUS phongBUS;
        PhongDTO phongDTO;
        PhongDAO phongDAO;
        LoaiPhongBUS loaiPhongBUS;
        LoaiPhongDTO loaiPhongDTO;
        public TestPhong()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        [TestInitialize]
        public void setUp()
        {
            phongBUS = new PhongBUS();
            phongDTO = new PhongDTO();
            phongDAO = new PhongDAO();
            loaiPhongBUS = new LoaiPhongBUS();
            loaiPhongDTO = new LoaiPhongDTO();
        }

        [TestMethod]
        public void TestThemPhongNull()
        {
            phongDTO = null;
            int expected = phongBUS.insertPhong(phongDTO);
            int actual = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestThemPhongAccess()
        {
            phongDTO.Maphong = "C101";
            phongDTO.Maloai = "Loại 3";
            int expected = 1;
            int actual = phongBUS.insertPhong(phongDTO);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestXoaSuccess()
        {
            int expected = 1;
            int actual = phongBUS.deletePhong("C101");
            Assert.AreEqual(expected, actual);
        }

        //True khi chưa có lọa phòng này
        [TestMethod]
        public void TestLoaiPhongAccess()
        {
            loaiPhongDTO.Maloai = "Loại 5";
            loaiPhongDTO.Gia = 100000;
            loaiPhongDTO.Songuoi = 5;

            int actual = loaiPhongBUS.insertLoaiPhong(loaiPhongDTO);
            int expected = 1;

            Assert.AreEqual(expected, actual);//Trùng mã Loại phòng
        }

        [TestMethod]
        public void TestLoaiPhongSuccess()
        {
            loaiPhongDTO.Maloai = "Loại 4";
            loaiPhongDTO.Gia = 50000;
            loaiPhongDTO.Songuoi = 3;

            int actual = loaiPhongBUS.insertLoaiPhong(loaiPhongDTO);
            int expected = 1;

            Assert.AreEqual(expected, actual);//Trùng mã Loại phòng
        }

        [TestMethod]
        public void TestXoaLoaiPhong()
        {
            int actual = loaiPhongBUS.deleteLoaiPhong("Loại 5");
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestXoaLoaiPhongNull()
        {
            int actual = loaiPhongBUS.deleteLoaiPhong("");
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }
    }
}
