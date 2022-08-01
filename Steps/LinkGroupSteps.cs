using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using Xunit;
using SpecFlow.Assist.Dynamic;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium.Support.UI;
using NPOI.SS.Formula.Functions;
using Rhino.Mocks.Constraints;

namespace SpecFlowLinkGroupDemo
{
    [Binding]
    public class LinkGroupSteps
    {
        private IWebDriver driver;
        private object ExpectedConditions;

        private Actions actions => new Actions(driver);


        [Given(@"I open the Health Care home page")]
        public void WhenIOpenTheHomePage()
        {
            driver = new ChromeDriver(@"../../../Resources");
            driver.Manage().Window.Maximize();
      
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);

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
        [Given(@"I Login Application")]
        public void GivenILoginApplication()
        {
            driver = new ChromeDriver(@"../../../Resources");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.Navigate().GoToUrl("http://3.6.133.45:81/#/authentication/signin");
            driver.FindElement(By.XPath("//input[@formcontrolname='emailId']")).SendKeys("admin@gmail.com");
            driver.FindElement(By.XPath("//input[@formcontrolname='password']")).SendKeys("admin123");
            driver.FindElement(By.XPath("//span[contains(text(),'Login')]")).Click();
        }

       /* [Given(@"I click on Search Member Tab")]
        public void GivenIClickOnSearchMemberTab()
        {
            driver.FindElement(By.XPath("//span[contains(text(),'Search Member')]")).Click();
        }*/

        /*[When(@"I Enter Enrolled Account Number")]
        public void WhenIEnterTheAccountNumber()
        {
            driver.FindElement(By.XPath("//input[@formcontrolname='account']")).Click();
               
            driver.FindElement(By.XPath("//input[@formcontrolname='account']")).SendKeys("sagar");
        }*/

       
        [Given(@"I Enter First Name which in enrolled for the given Account Number")]
        public void GivenIEnterFirstNameWhichInEnrolledForTheGivenAccountNumber()
        {
            driver.FindElement(By.XPath("//input[@id='mat-input-3']")).Click();

            driver.FindElement(By.XPath("//input[@id='mat-input-3']")).SendKeys("sagar");
        }

        [Given(@"I Enter Last Name which in enrolled for the given Account Number")]
        public void GivenIEnterLastNameWhichInEnrolledForTheGivenAccountNumber()
        {
            driver.FindElement(By.XPath("//input[@id='mat-input-5']")).Click();

            driver.FindElement(By.XPath("//input[@id='mat-input-5']")).SendKeys("ss");
        }

        [Given(@"I Enter contact no which in enrolled for the given Account Number")]
        public void GivenIEnterContactNoWhichInEnrolledForTheGivenAccountNumber()
        {
            driver.FindElement(By.XPath("//input[@formcontrolname='contactNo']")).Click();

            driver.FindElement(By.XPath("//input[@formcontrolname='contactNo']")).SendKeys("7856458452");
        }


        [Given(@"I Click on Search button")]
        public void GivenIClickOnSearchButton()
        {
            driver.FindElement(By.XPath("//span[contains(text(),' Search ')]")).Click();
            driver.Quit();
        }


      /*  [When(@"I Verify Member List Details")]
        public void WhenIVerifyMemberListDetails()
        {
            string actualvalue = driver.FindElement(By.XPath("//th[contains(text(),'Id')]")).Text;
            Assert.True(actualvalue.Contains("Id"), actualvalue + " doesn't contains 'Not ID'");
            driver.Quit();
        } */



        [When(@"I Enter Enrolled No which in not Account Number")]
        public void WhenIEnterThenotAccountNumber()
        {
            driver.FindElement(By.XPath("//input[@formcontrolname='firstName']")).Click();

            driver.FindElement(By.XPath("//input[@formcontrolname='firstName']")).SendKeys("sagar");
        }


        [Given(@"I Enter First Name which in not enrolled for the given Account Number")]
        public void GivenIEnterFirstNameWhichInNotEnrolledForTheGivenAccountNumber()
        {
            driver.FindElement(By.XPath("//input[@formcontrolname='firstName']")).Click();

            driver.FindElement(By.XPath("//input[@formcontrolname='firstName']")).SendKeys("sagar");
        }

        [Given(@"I Enter Last Name which in not enrolled for the given Account Number")]
        public void GivenIEnterLastNameWhichInNotEnrolledForTheGivenAccountNumber()
        {
            driver.FindElement(By.XPath("//input[@formcontrolname='lastname']")).Click();

            driver.FindElement(By.XPath("//input[@formcontrolname='lastname']")).SendKeys("ss");
        }

        [Given(@"I Enter contact no which in not enrolled for the given Account Number")]
        public void GivenIEnterContactNoWhichInNotEnrolledForTheGivenAccountNumber()
        {
            driver.FindElement(By.XPath("//input[@formcontrolname='contactNo']")).Click();

            driver.FindElement(By.XPath("//input[@formcontrolname='contactNo']")).SendKeys("7856458452");
        }


        [Given(@"I Click on Search Validate button")]
        public void GivenIClickOnSearchValidateButton()
        {
            driver.FindElement(By.XPath("//span[contains(text(),' Search ')]")).Click();
            driver.Quit();
        }

        [Given(@"I Navigate to the member registration page")]
        public void GivenINavigateToTheMemberRegistrationPage()
        {
            
            
            driver.FindElement(By.XPath("/html/body/app-root/app-main-layout/app-sidebar/div/aside/div/ul/li[3]/a/span")).Click();
        }

        [When(@"I Fill all fields in Personal Details")]
        public void WhenIFillAllFieldsInPersonalDetails()
        {
            driver.FindElement(By.XPath("//input[@id='mat-input-8']")).Click();
            driver.FindElement(By.XPath("//input[@id='mat-input-8']")).SendKeys("sagar");
            driver.Quit();
        }

        [When(@"I Fill all  fields in Address details")]
        public void WhenIFillAllFieldsInAddressDetails()
        {
            throw new PendingStepException();
        }

        [When(@"I Fill all fields in contact details")]
        public void WhenIFillAllFieldsInContactDetails()
        {
            throw new PendingStepException();
        }

        [When(@"I Enter SSN")]
        public void WhenIEnterSSN()
        {
            throw new PendingStepException();
        }

        [When(@"I Select the benefit plan")]
        public void WhenISelectTheBenefitPlan()
        {
            throw new PendingStepException();
        }

        [When(@"I Click on register button")]
        public void WhenIClickOnRegisterButton()
        {
            throw new PendingStepException();
        }





    }



}
