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
        public LoginPage loginPage;

        public LoginStepDefinitions( IWebDriver driver, LoginPage loginPage) 
        {
            this.driver = driver;  
            this.loginPage = loginPage;

        }




    //Stepdefinitions

  

        [Given(@"Enter the url")]
        public void GivenEnterTheUrl()
        {
            driver.Url = "https://careers.google.com/";
            Thread.Sleep(1000);
        }
        [When(@"Click on sign in button")]
        public void WhenClickOnSignInButton()
        {
           Assert.IsTrue(loginPage.SignBtn().Displayed);
           loginPage.SignBtn().Click();
           Thread.Sleep(1000);
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
            loginPage.GmailField().SendKeys("taskasignment@gmail.com");
            loginPage.NextBtn().Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            loginPage.PasswordField().SendKeys("Asdfgh#123");
                
            Thread.Sleep(1000);
            loginPage.NextBtn().Click(); 
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
            loginPage.Role().SendKeys("Software Engineer");
            Thread.Sleep(3000);
            loginPage.SetRole().Click();
            Thread.Sleep(2000);
            loginPage.Location().SendKeys("dublin");
            Thread.Sleep(3000);
            loginPage.SetLocation().Click();
            Thread.Sleep(2000);
           
        }

        [When(@"Click on the search button")]
        public void WhenClickOnTheSearchButton()
        {
            loginPage.SearchOption().Click();
            Thread.Sleep(2000);
        }
        [When(@"Click on any position to expand")]
        public void WhenClickOnAnyPositionToExpand()
        {
            loginPage.ExpandSection().Click();
            Thread.Sleep(2000);
        }
        
        [Then(@"Check that job details is expanded")]
        public void ThenCheckThatJobDetailsIsExpanded()
        {
            
        }

    }
}