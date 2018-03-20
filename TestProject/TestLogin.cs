using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quanlykhachsan;

using BUS;
using DTO;
using DAO;

namespace TestProject
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class TestLogin
    {
        public TestLogin()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        LoginBUS lgBUS = new LoginBUS();
        FormMain frmMail = new FormMain();
        FormMain form = new FormMain();
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
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
        public void TestMaHoaFail()
        {
            
            string expected = "manhhuy";
            string actual = form.MaHoa("manhhuy");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMaHoaSuccess()
        {
            string expected = "CYoaTmZOZox5+iAVgDc3wQ==";
            string actual = form.MaHoa("manhhuy");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLoginSuccess()
        {
            IList<LoginDTO> iList = lgBUS.Login("admin", frmMail.MaHoa("admin"));
            Assert.AreEqual(1, iList.Count());
        }

        [TestMethod]
        public void TestLoginFail()
        {
            IList<LoginDTO> iList = lgBUS.Login("admin", frmMail.MaHoa("mksai"));
            Assert.AreEqual(1, iList.Count());
        }

        [TestMethod]
        public void TestLoginNull() {
            IList<LoginDTO> iList = lgBUS.Login("", frmMail.MaHoa(""));
            Assert.AreEqual(1, iList.Count());
        }

    }
}
