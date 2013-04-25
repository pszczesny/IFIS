using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using IFIS_PageObject.Paths;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace IFIS_PageObject.Model
{
    class MyAccount
    {
        private IWebDriver selenium;

        #region Fields
        [FindsBy(How = How.XPath, Using = Locators.MYACCOUNT_HEADER_PATH)]
        private IWebElement main_header;

        #endregion

        public MyAccount(IWebDriver selenium)
        {
            this.selenium = selenium;
            PageFactory.InitElements(selenium, this);
        }

        public bool IsItOpen()
        {
            return main_header.Displayed;
        }

        internal MyAccount OpenViaHeader()
        {
            main_header.Click();
            Wait.ForElementVisible(selenium, Urls.DEFAULT_TIMEOUT, Locators.MYACCOUNT_HEADER_PATH);
            return new MyAccount(selenium);
        }
    }
}
