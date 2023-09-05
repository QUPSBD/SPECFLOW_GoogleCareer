using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using CareerGoogle.Pages;
using System.Collections.ObjectModel;

namespace CareerGoogle.StepDefinitions
{
    [Binding]
    public sealed class LoginStepDefinitions
    {
        private IWebDriver driver;

        //Locators
        By signBtn = By.XPath("//a[@class='gc-account-menu-bar__sign-in gc-h-larger-tap-target']");
        By gmailField = By.XPath("//input[@id='identifierId']");
        By nextBtn = By.XPath("//span[normalize-space()='Next']");
        By passField = By.Name("Passwd");
        By role = By.XPath("//input[@id='inline-search-input-query']");
        By setRole = By.XPath("//li[@id='autocomplete-result-213-0']");
        By location = By.XPath("//input[@id='inline-search-input-location']");
        By setLocation = By.XPath("//li[@id='autocomplete-result-214-0']");
        By searchOption = By.XPath("//button[@type='submit']");
        By expand = By.XPath("//li[contains(text(),'Currently pursuing a Bachelor’s, Master’s, or PhD ')]");





        // Methods
        public LoginStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement SignBtn()
        {
            return driver.FindElement(signBtn);
        }
        public IWebElement GmailField()
        {
            return (IWebElement)driver.FindElement(gmailField);
        }
        public IWebElement NextBtn()
        {
            return (IWebElement)driver.FindElement(nextBtn);
        }
        public IWebElement PasswordField()
        {
            return (IWebElement)driver.FindElement(passField);
        }
        public IWebElement Role()
        {
            return (IWebElement)driver.FindElement(role);
        }
        public IWebElement SetRole()
        {
            return (IWebElement)driver.FindElement(setRole);
        }
        public IWebElement Location()
        {
            return (IWebElement)driver.FindElement(location);
        }
        public IWebElement SetLocation()
        {
            return (IWebElement)driver.FindElement(setLocation);
        }
        public IWebElement SearchOption()
        {
            return (IWebElement)driver.FindElement(searchOption);
        }
        public IWebElement ExpandSection()
        {
            return (IWebElement)driver.FindElement(expand);
        }


    //Stepdefinitions

    [Given(@"Open browser")]
        public void GivenOpenBrowser()
        {
            //driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
        }

        [Given(@"Enter the url")]
        public void GivenEnterTheUrl()
        {
            driver.Url = "https://careers.google.com/";
        }
        [When(@"Click on sign in button")]
        public void WhenClickOnSignInButton()
        {
           SignBtn().Click();
        }

        [Then(@"Check that user switch to new window")]
        public void ThenCheckThatUserSwitchToNewWindow()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.Manage().Window.Maximize();
        }

        [When(@"enter email and click next")]
        public void WhenEnterEmailAndClickNext()
        {
            GmailField().SendKeys("taskasignment@gmail.com");
            NextBtn().Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            PasswordField().SendKeys("Asdfgh#123");
            Thread.Sleep(1000);
            NextBtn().Click(); 
        }

        [Then(@"Check that user is in login page")]
        public void ThenCheckThatUserIsInLoginPage()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Thread.Sleep(4000);
        }

        [When(@"select role and location")]
        public void AndSelectRoleAndLocation()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Role().SendKeys("Software Engineer");
            Thread.Sleep(3000);
            SetRole().Click();
            Thread.Sleep(2000);
            Location().SendKeys("dublin");
            Thread.Sleep(3000);
            SetLocation().Click();
            Thread.Sleep(2000);
           
        }

        [When(@"Click on the search button")]
        public void WhenClickOnTheSearchButton()
        {
            SearchOption().Click();
            Thread.Sleep(2000);
        }
        [When(@"Click on any position to expand")]
        public void WhenClickOnAnyPositionToExpand()
        {
            ExpandSection().Click();
            Thread.Sleep(2000);
        }
        
        [Then(@"Check that job details is expanded")]
        public void ThenCheckThatJobDetailsIsExpanded()
        {
            
        }

    }
}