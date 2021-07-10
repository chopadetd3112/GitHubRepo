using AzureTests.Helper;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using System.Threading;
using System.Collections.ObjectModel;

namespace AzureTests.Pages
{
    public class EmailPage : PageBase
    {
        const string mailURL = "http://www.yahoo.com";

        public static void NaviagtetoURL()
        {
            driver.OpenNewBrowser();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(5);
            driver.Navigate().GoToUrl(mailURL);
            driver.Manage().Window.Maximize();
            wait.Until(ExpectedConditions.ElementIsVisible(_signIn));
            driver.ClickOnElement(_mailBtn);

        }

        public static void Login()
        {
            try
            {
                if (driver.FindElement(_signIn).Displayed)
                {
                    driver.ClickOnElement(_signIn);
                }
            }
            catch
            { }
            wait.Until(ExpectedConditions.ElementIsVisible(_username));            
            driver.SendKeysToElement(_username,"trishna.chopade@yahoo.com");
            IWebElement btn = wait.Until(ExpectedConditions.ElementIsVisible(_signInBtn));            
            driver.ClickOnElement(_signInBtn);
            Thread.Sleep(20000);

            Actions action = new Actions(driver);
            action.SendKeys(Keys.Tab).Perform();
            action.SendKeys(Keys.Tab).Perform();
            action.SendKeys(Keys.Tab).Perform();

            action.SendKeys("Yahoo@12345").Perform();
            action.SendKeys(Keys.Enter).Perform();
        }

        public static bool VerifyMailPresent()
        {            
            try
            {
                IWebElement mailParent = driver.FindElement(_mailParent);
                IWebElement mailBox = mailParent.FindElement(By.XPath("//a[contains(@href, 'https://mail.yahoo.com/?.intl=in&.lang=en-IN')]"));
                if (mailBox.Displayed)
                {
                    mailBox.Click();
                }
            }
            catch
            { }
            Thread.Sleep(10000);
            IWebElement firstemail = driver.FindElement(_firstEmail);
            ReadOnlyCollection<IWebElement> allEmails = firstemail.FindElements(By.TagName("a"));
            //First listItem contains advertisement so taking text property of second listitem below
            if (allEmails[1].Text.Contains("JabaTalks Development"))
            {
                return true;
            }
            return false;
        }


        private static IWebElement SignIn => driver.FindElement(_signIn);

        private static By _signIn => By.XPath("//a[contains(.,'Sign in')]");
        private static By _username => By.Id("login-username");
        private static By _signInBtn => By.Id("login-signin");
        private static By _mailParent => By.Id("ybar");
        private static By _firstEmail => By.XPath("//div[@class='W_6D6F H_6D6F cZ1RN91d_n o_h p_R em_N D_F']");
        private static By _mailBtn => By.XPath("//a[contains(@href, 'https://mail.yahoo.com/?.intl=in&.lang=en-IN&pspid=97684142&activity=ybar-mail')]");




    }
}
