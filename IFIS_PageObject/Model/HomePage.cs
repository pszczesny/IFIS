using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IFIS_PageObject.Model
{
    public class HomePage : Page
    {
        

        public HomePage(OpenQA.Selenium.IWebDriver selenium):
            base(selenium)

        {
            
        }

        /// <summary>
        /// Function is logging user on the web site.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="remember_me"></param>
        public void Login(string username, string password, bool remember_me)
        {
            
        }
    }
}
