using OpenQA.Selenium;
using TestProject1.Commands;
using NUnit.Framework;
using System;

namespace TestProject1
{
    public class Tests 
    {
        public IWebDriver _driver;
        private string _url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _driver = BaseTest.GetWebdriver("Chrome");
            App.Launch(_driver).Site(_url).Maximize().ImplicitWait(10);
        }
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
           _driver.Quit();
           _driver.Dispose();
        }

        [Test]
        public void Test1() 
        {
            App.Login(_driver).SetUserName("Admin").SetPassword("admin123").SubmitButton();
        }
    }
}