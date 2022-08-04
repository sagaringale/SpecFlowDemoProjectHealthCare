using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowLinkGroupDemo
{
    [Binding]
    public class LinkGroupSteps
    {
        public static IWebDriver driver;

        //        private object ExpectedConditions;

        //        private object ExpectedConditions;


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
            driver = new FirefoxDriver(@"../../../Resources");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.Navigate().GoToUrl("http://3.6.133.45:81/#/authentication/signin");
            driver.FindElement(By.XPath("//input[@formcontrolname='emailId']")).SendKeys("admin@gmail.com");
            driver.FindElement(By.XPath("//input[@formcontrolname='password']")).SendKeys("admin123");
            driver.FindElement(By.XPath("//span[contains(text(),'Login')]")).Click();
        }


        [Given(@"I click on Search Member Tab")]
        public void GivenIClickOnSearchMemberTab()
        {
            driver.FindElement(By.XPath("//span[contains(text(),'Search Member')]")).Click();
        }



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
            driver.FindElement(By.XPath("//input[@id='mat-input-8']")).SendKeys("Test1");
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.FindElement(By.XPath("//input[@id='mat-input-10']")).Click();
            driver.FindElement(By.XPath("//input[@id='mat-input-10']")).SendKeys("Test2");

            driver.FindElement(By.XPath("//body/app-root[1]/app-main-layout[1]/div[1]/app-registermember[1]/section[1]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/div[2]/div[2]/div[2]/mat-form-field[1]/div[1]/div[1]/div[4]/mat-datepicker-toggle[1]/button[1]/span[1]/*[1]")).Click();
            driver.FindElement(By.XPath("//span[@id='mat-calendar-button-0']")).Click();
            //driver.FindElement(By.XPath("//span[@id='mat-calendar-button-0']")).Click();
            driver.FindElement(By.XPath("//div[contains(text(),'2000')]")).Click();

            //driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/button[1]/div[1]")).Click();
            driver.FindElement(By.XPath("//div[contains(text(),'FEB')]")).Click();

            driver.FindElement(By.XPath("//div[contains(text(),' 2 ')]")).Click();

            driver.FindElement(By.XPath("//input[@formcontrolname='ssn']")).Click();
            String randomSSN = DateTime.UtcNow.Ticks.ToString().Substring(8);
            driver.FindElement(By.XPath("//input[@formcontrolname='ssn']")).SendKeys(randomSSN);
        }



        [When(@"I Fill all fields in contact details")]
        public void WhenIFillAllFieldsInContactDetails()
        {
            driver.FindElement(By.XPath("//input[@formcontrolname='email']")).Click();
            driver.FindElement(By.XPath("//input[@formcontrolname='email']")).SendKeys("sagar@gmail.com");
            driver.FindElement(By.XPath("//input[@formcontrolname='contactNo']")).Click();
            driver.FindElement(By.XPath("//input[@formcontrolname='contactNo']")).SendKeys("9090909090");

        }

        [When(@"I Fill all  fields in Address details")]
        public void WhenIFillAllFieldsInAddressDetails()
        {


            driver.FindElement(By.XPath("//*[@formgroupname='address']")).Click();

            driver.FindElement(By.XPath("//input[@formcontrolname='address1']")).Click();
            driver.FindElement(By.XPath("//input[@formcontrolname='address1']")).SendKeys("Pune");

            driver.FindElement(By.XPath("//input[@formcontrolname='address2']")).Click();
            driver.FindElement(By.XPath("//input[@formcontrolname='address2']")).SendKeys("Pune");




            driver.FindElement(By.XPath("//input[@formcontrolname='country']")).Click();
            driver.FindElement(By.XPath("//input[@formcontrolname='country']")).SendKeys("India");

            driver.FindElement(By.XPath("//input[@formcontrolname='country']")).SendKeys(Keys.Tab);


            driver.FindElement(By.XPath("//input[@formcontrolname='state']")).SendKeys("Maharashtra");

            driver.FindElement(By.XPath("//input[@formcontrolname='city']")).Click();
            driver.FindElement(By.XPath("//input[@formcontrolname='city']")).SendKeys("Pune");

            driver.FindElement(By.XPath("//input[@formcontrolname='zipCode']")).Click();
            driver.FindElement(By.XPath("//input[@formcontrolname='zipCode']")).SendKeys("411001");

            driver.FindElement(By.XPath("//input[@formcontrolname='zipCode']")).SendKeys(Keys.Tab);

        }


        [When(@"I Click on register button")]
        public void WhenIClickOnRegisterButton()
        {
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            driver.Close();
        }

        [When(@"I Enter the valid details to search a member")]
        public void WhenIEnterTheValidDetailsToSearchAMember()
        {
            driver.FindElement(By.XPath("//input[@formcontrolname='firstName']")).Click();

            driver.FindElement(By.XPath("//input[@formcontrolname='firstName']")).SendKeys("k");
        }

        [When(@"I Click on search button")]
        public void WhenIClickOnSearchButton()
        {
            driver.FindElement(By.XPath("//span[contains(text(),' Search ')]")).Click();
        }

        [When(@"I Click on edit icon in member  search result grid under Action column")]
        public void WhenIClickOnEditIconInMemberSearchResultGridUnderActionColumn()
        {
            driver.FindElement(By.XPath("//tbody/tr[1]/td[7]/a[2]/app-feather-icons[1]/i-feather[1]/*[1]")).Click();
            //driver.Quit();

        }


        [Given(@"I Click on Benefit plan tab")]
        public void GivenIClickOnBenefitPlanTab()
        {
            driver.FindElement(By.XPath("//span[contains(text(),'Benefit Plan')]")).Click();
        }

        [When(@"I fill in New Benefit plan details")]
        public void WhenEnterBenefitPlanDetails()
        {
            driver.FindElement(By.XPath("//input[@formcontrolname='companyName']")).SendKeys("Company-1");

            driver.FindElement(By.XPath("//input[@formcontrolname='planName']")).SendKeys("Plan-1");

            driver.FindElement(By.XPath("//mat-select[@formcontrolname='insuranceType']")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'Medical')]")).Click();

            driver.FindElement(By.XPath("//mat-select[@formcontrolname='planDuration']")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'15')]")).Click();

            driver.FindElement(By.XPath("(//*[@class='mat-datepicker-toggle-default-icon ng-star-inserted'])[1]")).Click();
            //           driver.FindElement(By.XPath("//span[@id='mat-calendar-button-0']")).Click();
            //            driver.FindElement(By.XPath("//div[contains(text(),'2022')]")).Click();
            //            driver.FindElement(By.XPath("//div[contains(text(),'AUG')]")).Click();
            driver.FindElement(By.XPath("//div[@class='mat-calendar-body-cell-content mat-focus-indicator mat-calendar-body-today']")).Click();

            //driver.FindElement(By.XPath("//input[@id='mat-radio-2-input']")).Click();

            driver.FindElement(By.XPath("//textarea[@id='mat-input-12']")).SendKeys("Sample benefit Plan");

            driver.FindElement(By.XPath("//span[contains(text(),'Add Benefit')]")).Click();

            driver.Quit();
        }


        [When(@"I Update the contact details")]
        public void WhenIUpdateTheContactDetails()
        {
            driver.FindElement(By.XPath("//input[@formcontrolname='email']")).Click();
            driver.FindElement(By.XPath("//input[@formcontrolname='email']")).SendKeys(Keys.Tab);
            driver.FindElement(By.XPath("//input[@formcontrolname='contactNo']")).SendKeys(Keys.Tab);
            driver.FindElement(By.XPath("//input[@formcontrolname='address1']")).SendKeys(Keys.Tab);
            driver.FindElement(By.XPath("//input[@formcontrolname='address2']")).SendKeys(Keys.Tab);
            driver.FindElement(By.XPath("//input[@formcontrolname='country']")).SendKeys(Keys.Tab);
            driver.FindElement(By.XPath("//input[@formcontrolname='zipCode']")).Clear();
            driver.FindElement(By.XPath("//input[@formcontrolname='zipCode']")).SendKeys("100001");
            driver.FindElement(By.XPath("//input[@formcontrolname='zipCode']")).SendKeys(Keys.Tab);
        }

        [When(@"I Click on update button")]
        public void WhenIClickOnUpdateButton()
        {
            driver.FindElement(By.XPath("//span[normalize-space()='Update']")).Click();
            //driver.FindElement(By.XPath("/html/body/app-root/app-main-layout/div/app-editmembersummary/section/div/div[2]/div/div/div/form/div[4]/div[3]/div[3]/button[1]/span[1]")).Click();
        }

        [When(@"I Left Lastname field blank")]
        public void WhenILeftLastnameFieldBlank()
        {
            driver.FindElement(By.XPath("//input[@formcontrolname='lastname']")).Clear();
            driver.FindElement(By.XPath("//input[@formcontrolname='lastname']")).SendKeys(Keys.Space);
            driver.FindElement(By.XPath("//input[@formcontrolname='lastname']")).SendKeys(Keys.Backspace);

        }
        [When(@"I Left SSN field blank")]
        public void WhenILeftSSNFieldBlank()
        {
            driver.FindElement(By.XPath("//input[@formcontrolname='ssn']")).Clear();
            driver.FindElement(By.XPath("//input[@formcontrolname='ssn']")).SendKeys(Keys.Space);
            driver.FindElement(By.XPath("//input[@formcontrolname='ssn']")).SendKeys(Keys.Backspace);

        }

        [When(@"I Fill Fields in personal details")]
        public void WhenIFillFieldsInPersonalDetails()
        {
            driver.FindElement(By.XPath("//input[@id='mat-input-8']")).Click();
            driver.FindElement(By.XPath("//input[@id='mat-input-8']")).SendKeys("Test1");
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.FindElement(By.XPath("//input[@id='mat-input-10']")).Click();
            driver.FindElement(By.XPath("//input[@id='mat-input-10']")).SendKeys("Test2");

            driver.FindElement(By.XPath("//body/app-root[1]/app-main-layout[1]/div[1]/app-registermember[1]/section[1]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/div[2]/div[2]/div[2]/mat-form-field[1]/div[1]/div[1]/div[4]/mat-datepicker-toggle[1]/button[1]/span[1]/*[1]")).Click();
            driver.FindElement(By.XPath("//span[@id='mat-calendar-button-0']")).Click();
            //driver.FindElement(By.XPath("//span[@id='mat-calendar-button-0']")).Click();
            driver.FindElement(By.XPath("//div[contains(text(),'2000')]")).Click();

            //driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/button[1]/div[1]")).Click();
            driver.FindElement(By.XPath("//div[contains(text(),'FEB')]")).Click();

            driver.FindElement(By.XPath("//div[contains(text(),' 2 ')]")).Click();
        }

        [Then(@"register button disabled state should be '([^']*)'")]
        public void ThenVerifyRegisterButtonNotVisible(string expectedButtonDisabled)
        {
            //driver.FindElements(By.XPath("//body/app-root[1]/app-main-layout[1]/div[1]/app-registermember[1]/section[1]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/div[4]/div[3]/div[3]/button[1]/span[1]"));
            String buttonDisabledStatus = driver.FindElement(By.XPath("//button[@type='submit']")).GetAttribute("disabled");
            Assert.AreEqual(expectedButtonDisabled, buttonDisabledStatus);
            driver.Quit();
        }

        [When(@"I Fill all fields in Personal Details except Last Name")]
        public void WhenIFillAllFieldsInPersonalDetailsExceptLastName()
        {
            driver.FindElement(By.XPath("//input[@id='mat-input-8']")).Click();
            driver.FindElement(By.XPath("//input[@id='mat-input-8']")).SendKeys("sagar");


            driver.FindElement(By.XPath("//body/app-root[1]/app-main-layout[1]/div[1]/app-registermember[1]/section[1]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/div[2]/div[2]/div[2]/mat-form-field[1]/div[1]/div[1]/div[4]/mat-datepicker-toggle[1]/button[1]/span[1]/*[1]")).Click();
            driver.FindElement(By.XPath("//span[@id='mat-calendar-button-0']")).Click();
            //driver.FindElement(By.XPath("//span[@id='mat-calendar-button-0']")).Click();
            driver.FindElement(By.XPath("//div[contains(text(),'2000')]")).Click();

            //driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/button[1]/div[1]")).Click();
            driver.FindElement(By.XPath("//div[contains(text(),'FEB')]")).Click();

            driver.FindElement(By.XPath("//div[contains(text(),' 2 ')]")).Click();

            driver.Quit();

        }

        [When(@"I Click on Pluse Icon")]
        public void WhenIClickOnPluseIcon()
        {
            driver.FindElement(By.XPath("//tbody/tr[1]/td[7]/a[1]/app-feather-icons[1]/i-feather[1]/*[1]")).Click();

        }

        [When(@"I Change the existing benefit plan")]
        public void WhenIChangeTheExistingBenefitPlan()
        {
            driver.FindElement(By.XPath("/html/body/app-root/app-main-layout/div/app-viewinsurancebenefit/section/div/div[3]/div/div/div[2]/div/div/table/tbody/tr[1]/td[1]/mat-radio-button/label")).Click();

            driver.FindElement(By.XPath("//mat-select[@formcontrolname='term']")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'15')]")).Click();

            driver.FindElement(By.XPath("//body/app-root[1]/app-main-layout[1]/div[1]/app-viewinsurancebenefit[1]/section[1]/div[1]/div[4]/div[1]/div[1]/form[1]/div[1]/div[2]/mat-form-field[1]/div[1]/div[1]/div[4]/mat-datepicker-toggle[1]/button[1]/span[1]/*[1]")).Click();

            driver.FindElement(By.XPath("//div[@class='mat-calendar-body-cell-content mat-focus-indicator mat-calendar-body-today']")).Click();

        }

        [Then(@"I Click and Assign Benefit Plan Button")]
        public void ThenIClickAndAssignBenefitPlanButton()
        {
            driver.FindElement(By.XPath("//body/app-root[1]/app-main-layout[1]/div[1]/app-viewinsurancebenefit[1]/section[1]/div[1]/div[4]/div[1]/div[1]/form[1]/div[2]/div[3]/button[1]/span[1]")).Click();
            driver.Close();
        }


        [When(@"I amend benefit plan")]
        public void WhenClickOnAmendBenefitPlanButton()
        {
            driver.FindElement(By.TagName("body")).SendKeys(Keys.PageDown);
            IWebElement editButton = driver.FindElement(By.XPath("//tbody/tr[1]/td[8]/button[1]/span[1]/app-feather-icons[1]/i-feather[1]/*[1]"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(editButton);
            actions.Perform();
            editButton.Click();
            driver.FindElement(By.XPath("//input[@formcontrolname='companyName']")).Clear();
            driver.FindElement(By.XPath("//input[@formcontrolname='companyName']")).SendKeys("Updated company name");
            driver.FindElement(By.XPath("//textarea[@id='mat-input-12']")).SendKeys("Sample benefit Plan");
            driver.FindElement(By.XPath("//span[contains(text(),'Update Benefit')]")).Click();

            driver.Quit();
        }
        [When(@"I Click on eye button")]
        public void WhenClickOnEyeButton()
        {
            driver.FindElement(By.XPath("//tbody/tr[1]/td[7]/a[3]/app-feather-icons[1]/i-feather[1]/*[1]")).Click();
            driver.FindElement(By.TagName("body")).SendKeys(Keys.Control + Keys.End);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement terminateButton = driver.FindElement(By.XPath("//i-feather[@class='tbl-fav-x-square']"));
            js.ExecuteScript("arguments[0].click(); ", terminateButton);
            driver.FindElement(By.XPath("//span[contains(text(),'Delete')]")).Click();
            driver.Quit();
        }

    }
}
