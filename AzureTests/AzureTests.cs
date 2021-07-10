using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using AzureTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace AzureTests
{
    [TestClass]
    public class AzureTests 
    {

        [TestMethod]
        public void SignUpForFlightSearchScenario()
        {
            HomePage.NaviagtetoURL();
            Assert.IsTrue(HomePage.ValidateLanguage(), "English and Dutch languages are not present in Language dropdown");
            HomePage.FillForm();
            Assert.IsTrue(HomePage.ValidateWelcomeMsg(), "Welcome Message is not displayed after sign up");
            Console.WriteLine("Sign Up successful");
            EmailPage.NaviagtetoURL();
            EmailPage.Login();
            Assert.IsTrue(EmailPage.VerifyMailPresent(), "Verification if the email is present in mailbox is failed");
            Console.WriteLine("Email Verification successful");
        }
        
        [TestInitialize()]
        public void MyTestInitialize()
        {
            Console.WriteLine("Initialize");
        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
            Console.WriteLine("Quit");
            PageBase.QuitChrome();
        }


    }
}
