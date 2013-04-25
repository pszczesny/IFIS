using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using IFIS_PageObject.Paths;

namespace IFIS_PageObject.Model
{
    public static class Wait
    {
        public static void ForElementVisible(IWebDriver s, TimeSpan t, string path)
        {
            WebDriverWait wait = new WebDriverWait(s, t = new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(path)));
        }

        public static void ForElementExists(IWebDriver s, TimeSpan t, string path)
        {
            WebDriverWait wait = new WebDriverWait(s, t = new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementExists(By.XPath(path)));
        }
    }
}
