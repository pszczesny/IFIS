using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using IFIS_PageObject.Model;
using IFIS_PageObject.Paths;

namespace IFIS_PageObject
{
    public class Browser
    {
        private static IWebDriver selenium = null;


        public static void Open()
        {
            init();
            selenium.Manage().Window.Maximize();
        }

        private static void init()
        {
            if (selenium == null)
            {
                selenium = new FirefoxDriver();
            }
        }

        public static void Close()
        {
            if (selenium != null)
            {
                selenium.Close();
                selenium.Quit();
                selenium.Dispose();

                selenium = null;
            }
        }

        public static class GoTo
        {


            public static HomePage HomePage()
            {
                selenium.Navigate().GoToUrl(Urls.HOME_PAGE);
                return new HomePage(selenium);
            }
        }

    }
}
