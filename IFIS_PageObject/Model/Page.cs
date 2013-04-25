using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IFIS_PageObject.Model
{
    public class Page
    {
        private OpenQA.Selenium.IWebDriver selenium;
   
        public Page(OpenQA.Selenium.IWebDriver selenium)
        {
            this.selenium = selenium;
        }
    }
}
