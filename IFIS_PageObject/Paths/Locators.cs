using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IFIS_PageObject.Paths
{
    public static class Locators
    {
        //Loginbox elements XPaths  
        public const string LOGINBOX_USERNAME_FIELD_PATH = "//*[@id=\"ctl00_ucLoginInfo_tbUsername\"]";
        public const string LOGINBOX_PASSWORD_FIELD_PATH = "//*[@id=\"ctl00_ucLoginInfo_tbPassword\"]";
        public const string LOGINBOX_REMEMBER_ME_CHECKBOX_PATH = "//*[@id=\"ctl00_ucLoginInfo_cbRememberMe\"]";
        public const string LOGINBOX_SIGN_IN_BUTTON_PATH = "//*[@id=\"ctl00_ucLoginInfo_btnSubmit\"]";
        public const string LOGINBOX_FORGOTTEN_PASSWORD_LINK_PATH = "//a[@class='forgotten']";
        public const string LOGINBOX_CLOSE_BUTTON_PATH = "//*[@id=\"cboxClose\"]";

        //Header elements XPaths
        public const string HEADER_LOGIN_LINK_PATH = "//li[@class='dropdown']/a";
        public const string HEADER_NAME_DISPLAY = "//li[@class='logged-in-info']/span";
        public const string HEADER_LOGOUT_LINK_PATH = "//*[@id='ctl00_ucLoginInfo_btnLogout']";
        public const string HEADER_MYACCOUNT_LINK_PATH = "//*[@id='ctl00_ucLoginInfo_ctl00_rptTopMenu_ctl02_lnkItemMenu']";

        //MyAccount elemens
        public const string MYACCOUNT_HEADER_PATH = "//*[@class='main-header']/span";

    }

}
