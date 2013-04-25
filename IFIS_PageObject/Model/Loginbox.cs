using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using IFIS_PageObject.Paths;
using OpenQA.Selenium.Support.PageObjects;

namespace IFIS_PageObject.Model
{
    class Loginbox
    {
        
        private IWebDriver selenium;

        #region Fields 
        [FindsBy(How = How.XPath, Using = Locators.LOGINBOX_USERNAME_FIELD_PATH)]
        private IWebElement username_field;

        [FindsBy(How = How.XPath, Using = Locators.LOGINBOX_PASSWORD_FIELD_PATH)]        
        private IWebElement password_field;

        [FindsBy(How = How.XPath, Using = Locators.LOGINBOX_SIGN_IN_BUTTON_PATH)]
        private IWebElement sign_in_button;

        [FindsBy(How = How.XPath, Using = Locators.LOGINBOX_REMEMBER_ME_CHECKBOX_PATH)]
        private IWebElement rem_me_checkbox;
        #endregion

        public Loginbox(IWebDriver selenium)
        {
            this.selenium = selenium;
            PageFactory.InitElements(selenium, this);
        }

        internal void EnterUsername (string username = "")
        {
            username_field.SendKeys(username);
        }

        internal void EnterPassword(string password = "")
        {
            password_field.SendKeys(password);
        }

        internal void Check_Remember_Me(bool remember_me = false)
        { 

            if (rem_me_checkbox.Selected != true)
                rem_me_checkbox.Click();
        }

        internal void Sign_In()
        {
            sign_in_button.Click();
            Wait.ForElementVisible(selenium, Urls.DEFAULT_TIMEOUT, Locators.HEADER_LOGOUT_LINK_PATH);
        }
    }
}
