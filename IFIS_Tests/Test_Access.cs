using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using IFIS_PageObject;
using IFIS_PageObject.Model;


namespace IFIS_Tests
{
    [TestFixture]
    public class Test_Access
    {
        [SetUp]
        public void Setup()
        {
            Browser.Open();
        }

        [TearDown]
        public void Cleanup()
        {
            Browser.Close();
        }

        [TestCase]
        public void TestMethod1()
        {
            HomePage page = Browser.GoTo.HomePage();
            page.Login("name", "password", true);
            Assert.IsTrue(page.amILogin());
            
        }
    }
}
