using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DAO;
using DTO;
using BUS;
using Quanlykhachsan;
namespace TestProject
{
    /// <summary>
    /// Summary description for TestKH
    /// </summary>
    [TestClass]
    public class TestKH
    {
        KhachHangBUS khBUS;
        KhachHangDTO khDTO;
        FormKhachHang frmKH;

        public TestKH()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        [TestInitialize]
        public void setUp()
        {
            khBUS = new KhachHangBUS();
            khDTO = new KhachHangDTO();
            frmKH = new FormKhachHang();

            khDTO.Makhachhang = "KH0133";
            khDTO.Tenkhachhang = "Nguyen Quang";
            khDTO.Gioitinh = false;
            khDTO.CMND_PASSPORT = "123456789";
            khDTO.Diachi = "456 Nguyen Huu Canh";
            khDTO.Coquan = "CA";
            khDTO.Sodienthoai = "01689478911";
            khDTO.Email = "abc@gmail.com";
        }

        [TestMethod]
        public void TestThemKHSuccess()
        {
            int expected = 1;
            int actual = khBUS.insertKhachHang(khDTO);
            Assert.AreEqual(expected, actual);
        }
        //Khach Hang da them 1 lan roi
        [TestMethod]
        public void TestThemKHFail()
        {
            int expected = 0;
            int actual = khBUS.insertKhachHang(khDTO);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestXoaKHSuccess()
        {
            int expected = 1;
            int actual = khBUS.deleteKhachHang(khDTO.Makhachhang);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestXoaKHFail()
        {
            int expected = 1;
            int actual = khBUS.deleteKhachHang("KH000000");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSuaKHSuccess()
        {
            khDTO.Makhachhang = "KH0133";
            khDTO.Tenkhachhang = "Nguyen Van X";
            khDTO.Gioitinh = true;
            khDTO.CMND_PASSPORT = "123456789";
            khDTO.Diachi = "123 Nguyen Huu Canh";
            khDTO.Coquan = "CAA";
            khDTO.Sodienthoai = "01698178888";
            khDTO.Email = "daaX@gmail.com";

            int expected = khBUS.updateKhachHang(khDTO);
            int actual = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSuaKHFail()
        {
            khDTO.Makhachhang = "KTI123123";
            khDTO.Tenkhachhang = "Nguyen Van X";
            khDTO.Gioitinh = true;
            khDTO.CMND_PASSPORT = "123456789";
            int expected = khBUS.updateKhachHang(khDTO);
            int actual = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKHNull() {
            Boolean check = frmKH.kiemtraFormKH("", "", "");
            Assert.IsTrue(check);
        }

        [TestMethod]
        public void TestKHNotNull()
        {
            Boolean check = frmKH.kiemtraFormKH("KH123", "Nguyen Van XX", "123456789");
            Assert.IsFalse(check);
        }
    }
}
