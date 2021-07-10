using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureTests.Helper
{
    public static class ActionHelper
    {
        public static void SendKeysToElement(this IWebDriver driver, By by, string value)
        {
            IWebElement element = driver.CreateWebElement(by);
            element.SendKeys(value);            
        }

        public static void ClickOnElement(this IWebDriver driver, By by)
        {
            IWebElement element = driver.CreateWebElement(by);
            element.Click();
        }
    }
}
