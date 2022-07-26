using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using SpecFlowLinkGroupDemo.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using Xunit;
using SpecFlow.Assist.Dynamic;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowLinkGroupDemo
{
    [Binding]
    public class LinkGroupSteps
    {
        private IWebDriver driver;


        private Actions actions => new Actions(driver);


        [Given(@"I open the Health Care home page")]
        public void WhenIOpenTheHomePage()
        {
            driver = new ChromeDriver(@"../../../Resources");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://3.6.133.45:81/#/authentication/signin");
            
        }
        
        [When(@"Enter username the '([^']*)' element")]
        public void WhenEnterUsernameTheElement(string username)
        {
            driver.FindElement(By.XPath("//input[@formcontrolname='emailId']")).SendKeys("admin@gmail.com");
        }

        [When(@"Enter the '([^']*)' element")]
        public void WhenEnterTheElement(string password)
        {
            driver.FindElement(By.XPath("//input[@formcontrolname='password']")).SendKeys("admin123");
        }

        [When(@"I click on sign in button")]
        public void WhenIClickOnSignInButton()
        {
            driver.FindElement(By.XPath("//span[contains(text(),'Login')]")).Click();
            driver.Quit();

        }

        [Given(@"I click on Search Member Tab")]
        public void GivenIClickOnSearchMemberTab()
        {
            driver.FindElement(By.XPath("//span[contains(text(),'Search Member')]")).Click();
        }

        [When(@"I enter the Account Number")]
        public void WhenIEnterTheAccountNumber()
        {
            driver.FindElement(By.XPath("//input[@formcontrolname='firstName']")).SendKeys("sagar");
        }

        [When(@"I Click on Search Button")]
        public void WhenIClickOnSearchButton()
        {
            driver.FindElement(By.XPath("//span[contains(text(),' Search ')]")).Click();
        }

        [When(@"I Verify Member List Details")]
        public void WhenIVerifyMemberListDetails()
        {
            string actualvalue = driver.FindElement(By.XPath("//th[contains(text(),'Id')]")).Text;
            Assert.True(actualvalue.Contains("Id"), actualvalue + " doesn't contains 'Not ID'");
            driver.Quit();
        }

    }



}
