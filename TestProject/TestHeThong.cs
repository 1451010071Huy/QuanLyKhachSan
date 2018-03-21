using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Quanlykhachsan;
using BUS;
using DAO;
using DTO;

namespace TestProject
{
    [TestClass]
    public class TestHeThong
    {
        FormHeThong frmHeThong;
        NhanVienBUS nvBUS;

        [TestInitialize]
        public void setUp()
        {
            frmHeThong = new FormHeThong();
            nvBUS = new NhanVienBUS();
        }
        [TestMethod]
        public void TestDangKiUserNull()
        {
            bool expected = frmHeThong.kiemtra("", "");
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void TestDangKiUserNotNull()
        {
            bool expected = frmHeThong.kiemtra("thanh", "cong");
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void TestTenTaiKhoanLonHon16KT()
        {
            bool expected = frmHeThong.kiemtra("nguyenvanthanhnam", "daihocmo");
            Assert.IsFalse(expected);
        }

        [TestMethod]
        public void TestTenTaiKhoanPassHon16KT()
        {
            bool expected = frmHeThong.kiemtra("daihocmo", "nguyenvanthanhnam");
            Assert.IsFalse(expected);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestTimNhanVien()
        {
            nvBUS.getListLikeNhanVienByID("KhongBaoGioCoNgoaiLe");
        }


    }
}
