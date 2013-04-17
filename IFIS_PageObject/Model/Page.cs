using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IFIS_PageObject.Model
{
    class Page
    {
        private OpenQA.Selenium.IWebDriver selenium;


        Header header;


        public Page(OpenQA.Selenium.IWebDriver selenium)
        {
            this.selenium = selenium;
        }
    }
}
