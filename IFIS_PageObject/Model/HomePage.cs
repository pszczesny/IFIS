using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IFIS_PageObject.Model
{
    public class HomePage : Page
    {
        private Header header;
        private Loginbox loginbox;
        private MyAccount myaccount;

        public HomePage(OpenQA.Selenium.IWebDriver selenium) :
            base(selenium)
        {
            header = new Header(selenium);
        }

        /// <summary>
        /// Log in user on the web site using provided credentials.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="remember_me"></param>
        public void Login(string username, string password, bool remember_me)
        {
            loginbox = header.Click_Login();
            loginbox.EnterUsername(username);
            loginbox.EnterPassword(password);

            if (remember_me == true)
                loginbox.Check_Remember_Me();

            loginbox.Sign_In();

        }


        public bool amILogin(string name)
        {
            return name.Equals(header.Name);
        }

        public void Logout()
        {
            header.Click_Logout();
        }

        public bool amILoggedout(string name)
        {
            return header.Is_Login_Visible();
        }


        public void Open_MyAccount()
        {
            myaccount = header.Click_MyAccount();
        }
    }
}
