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
    class Header
    {
        private IWebDriver selenium;

        #region
        [FindsBy(How = How.XPath, Using = Locators.HEADER_LOGIN_LINK_PATH)]
        private IWebElement header_login_link;

        [FindsBy(How = How.XPath, Using = Locators.HEADER_NAME_DISPLAY)] 
        private IWebElement header_name_disp;

        [FindsBy(How = How.XPath, Using = Locators.HEADER_LOGOUT_LINK_PATH)] 
        private IWebElement header_logout_link;

        [FindsBy(How = How.XPath, Using = Locators.HEADER_MYACCOUNT_LINK_PATH)] 
        private IWebElement header_myaccount_link;
        #endregion

        public Header(IWebDriver selenium)
        {
            this.selenium = selenium;
            PageFactory.InitElements(selenium, this);
        }


        internal Loginbox Click_Login()
        {
            header_login_link.Click();
            Wait.ForElementVisible(selenium, Urls.DEFAULT_TIMEOUT,Locators.LOGINBOX_USERNAME_FIELD_PATH);
            return new Loginbox(selenium);
        }


        public string Name
        {
            
            get { return selenium.FindElement(By.XPath(Locators.HEADER_NAME_DISPLAY)).Text; }
        }

        internal void Click_Logout()
        {
            header_logout_link.Click();
        }

        internal bool Is_Login_Visible()
        {
            return header_login_link.Displayed;
        }

        internal MyAccount Click_MyAccount()
        {
            header_myaccount_link.Click();
            return new MyAccount(selenium);
        }
    }
}
