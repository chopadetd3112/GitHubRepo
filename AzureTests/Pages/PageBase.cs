using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureTests.Pages
{
    public class PageBase
    {
        public static IWebDriver driver = new ChromeDriver(Path.Combine(Directory.GetCurrentDirectory(), "Resources"));

        public static WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(5));

        public static void QuitChrome()
        {
            driver.Close();
            driver.Quit();
        }

    }
}
