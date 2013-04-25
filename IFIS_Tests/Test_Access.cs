using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using IFIS_PageObject;
using IFIS_PageObject.Model;
using IFIS_Tests.Credentials;

namespace IFIS_Tests
{
    [TestFixture]
    public class Test_Access
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            Browser.Open();
        }

        [TestFixtureTearDown]
        public void Cleanup()
        {
            Browser.Close();
        }

        [Test]
        public void Login_Logout()
        {
            HomePage page = Browser.GoTo.HomePage();
            page.Login(Logins.USERNAME_VALID, Logins.PASSWORD_VALID, true);

            Assert.IsTrue(page.amILogin(Logins.NAME_VALID)); 

            page.Logout();

            Assert.IsTrue(page.amILoggedout(Logins.NAME_VALID));

        }


        [Test]
        public void My_Account()
        {
            HomePage page = Browser.GoTo.HomePage();
            page.Login(Logins.USERNAME_VALID, Logins.PASSWORD_VALID, true);
            Assert.IsTrue(page.amILogin(Logins.NAME_VALID));

            page.Open_MyAccount();

        }
    }

}
