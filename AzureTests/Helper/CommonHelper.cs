using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureTests.Helper
{
    public static class CommonHelper
    {

        public static IWebElement CreateWebElement(this IWebDriver driver, By by)
        {
            IWebElement element = null;
            
            element = driver.FindElement(by);
            
            return element;
        }

        public static void OpenNewBrowser(this IWebDriver driver)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }
    }
}
