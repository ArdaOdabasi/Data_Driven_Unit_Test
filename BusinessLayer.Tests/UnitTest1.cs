using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BusinessLayer.Tests
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Users.xml", "User", DataAccessMethod.Sequential)]
        [TestMethod]
        public void DataTest()
        {
            var Manager = new UserManager();

            var Ad = TestContext.DataRow["ad"].ToString();

            var Mail = TestContext.DataRow["mail"].ToString();

            var Telefon = TestContext.DataRow["telefon"].ToString();

            var Sonuc = Manager.AddUser(Ad, Mail, Telefon);

            Assert.IsTrue(Sonuc);
        }
    }
}
