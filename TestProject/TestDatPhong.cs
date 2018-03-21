using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BUS;
using DAO;
using DTO;

namespace TestProject
{

    [TestClass]
    public class TestDatPhong
    {

        [TestMethod]
        public void TestGetAllChiTietDatPhongSuccess()
        {
              ChiTietDatPhongBUS ctdp = new ChiTietDatPhongBUS();
              ctdp.getListChiTietDatPhongAll();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Error!")]
        public void TestGetAllChiTietDatPhongAll2()
        {
              ChiTietDatPhongBUS ctdp = new ChiTietDatPhongBUS();
              ctdp.getListChiTietDatPhongAll();
        }

    }
}
