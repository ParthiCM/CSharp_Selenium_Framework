using OpenQA.Selenium;
using TestProject1.Commands;
using NUnit.Framework;
using System;
using TestProject1.Utilities;

namespace TestProject1
{
    public class Tests 
    {
        public IWebDriver _driver;
        private string _url = SiteUrls.OrangeHRMSiteURL;

        [SetUp]
        public void Setup()
        {
            _driver = BaseTest.GetWebdriver("Chrome");
            App.Launch(_driver).Site(_url).Maximize().ImplicitWait(10);
        }
        [TearDown]
        public void Teardown()
        {
           _driver.Quit();
           _driver.Dispose();
        }

        [Test]
        public void TC_01_VerifyUserAbleToLandOnDashboardPageWithValidCredentials() 
        {
            App.Login(_driver).SetUserName(FormText.username).SetPassword(FormText.Password).SubmitButton();
            Assert.IsTrue(App.Dashboard(_driver).VerifyUserNavigatedToDashboardPage(), "Unxpected Error while Landing on the Dashboard page");
        }
        [Test]
        public void TC_02_VerifyUserNotAbleToLoginWithoutUserName() 
        {
            App.Login(_driver).SetUserName(string.Empty).SetPassword(FormText.Password).SubmitButton();
            Assert.IsFalse(App.Dashboard(_driver).VerifyUserNavigatedToDashboardPage(), "Security Issue, User should not allowed to Login");
        }
        [Test]
        public void TC_03_VerifyUserNotAbleToLoginWithoutUserNameAndPassword() 
        {
            App.Login(_driver).SetUserName(string.Empty).SetPassword(string.Empty).SubmitButton();
            Assert.IsFalse(App.Dashboard(_driver).VerifyUserNavigatedToDashboardPage(), "Security Issue, User should not allowed to Login");
        }
        [Test]
        public void TC_04_VerifyUserNotAbleToLoginWithoutPassword() 
        {
            App.Login(_driver).SetUserName(FormText.username).SetPassword(string.Empty).SubmitButton();
            Assert.IsFalse(App.Dashboard(_driver).VerifyUserNavigatedToDashboardPage(), "Security Issue, User should not allowed to Login");
        }
    }
}