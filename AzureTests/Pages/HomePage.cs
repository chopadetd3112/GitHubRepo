using AzureTests.Helper;
using AzureTests.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureTests.Pages
{
    public class HomePage : PageBase
    {
        const string azureURL = "http://jt-dev.azurewebsites.net/#/SignUp";

        public HomePage() : base()
            {}


        #region API-s

        public static void NaviagtetoURL()
        {
            driver.Navigate().GoToUrl(azureURL);
            driver.Manage().Window.Maximize();                        
            wait.Until((d) => d.FindElement(_yourName));
        }
        public static bool ValidateLanguage()
        {
            driver.ClickOnElement(_languageDD);
            IWebElement langParent = wait.Until((d) => d.FindElement(_langParent));            
            if(englishLang.Text == "English" && dutchLang.Text == "Dutch")
                return englishLang.Displayed && dutchLang.Displayed;
            return false;
        }
        
        public static void FillForm()
        {
            if (_name.Displayed)
            {
                driver.SendKeysToElement(_yourName, "Trishna");          
                driver.SendKeysToElement(_yourOrgName, "Trishna");
                driver.SendKeysToElement(_yourEmail, "trishna.chopade@yahoo.com");  
                driver.ClickOnElement(_iAgreeCheckbox);
                driver.ClickOnElement(_getStartedButtton);                
            }
        }

        public static bool ValidateWelcomeMsg()
        {
            //IWebElement welcomeMsfPresent = wait.Until((d) => d.FindElement(_welcomeMsg));
            IWebElement welcomeMsfPresent = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(_welcomeMsg));
            return welcomeMsfPresent.Displayed;
                      
        }


        #endregion API-s

        #region WebElements

        private static IWebElement _name => driver.FindElement(_yourName);

        private static IWebElement englishLang => driver.FindElement(_langParent).FindElement(By.Id("ui-select-choices-row-1-0")).FindElement(By.XPath("//a//div[contains(.,'English')]"));
        private static IWebElement dutchLang => driver.FindElement(_langParent).FindElement(By.Id("ui-select-choices-row-1-1")).FindElement(By.XPath("//a//div[contains(.,'Dutch')]")); 
        
        private static By _yourName => By.Id("name");
        private static By _yourOrgName => By.Id("orgName");
        private static By _yourEmail => By.Id("singUpEmail");
        private static By _iAgreeCheckbox => By.XPath("//span[contains(.,'I agree to the')]");


        private static By _langParent => By.XPath("//li[@id='ui-select-choices-1']");
        private static By _langEnglish => By.XPath("//li[@id='ui-select-choices-1']//div[@id,'ui-select-choices-row-1-0']//a//div[contains(.,'English')]");
        private static By _langDutch => By.XPath("//li[@id='ui-select-choices-1']//div[@id,'ui-select-choices-row-1-1']//a//div[contains(.,'Dutch')]");
        //li id ui-select-choices-1 //div ui-select-choices-row-1-0//  div contains English
        // ui-select-choices-row-1-1 Dutch
        private static By _languageDD => By.Id("language");
        private static By _getStartedButtton => By.XPath("//button[contains(.,'Get Started')]");
        private static By _welcomeMsg => By.XPath("//span[contains(.,' A welcome email has been sent. Please check your email')]");

        #endregion WebElements
    }
}
