using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGoogle.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;
        public LoginPage loginPage;

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
        public LoginPage(IWebDriver driver)
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
    }
}
