using OpenQA.Selenium;
using TestProject1.Commands;
using NUnit.Framework;
using System;
using TestProject1.Utilities;

namespace TestProject1.Test
{
    public class MutipleWindowTest
    {
        public IWebDriver _driver;
        private string _url = SiteUrls.Playground;
        CommanHelperMethods helper;


        [SetUp]
        public void Setup()
        {
            _driver = BaseTest.GetWebdriver("Chrome");
            helper = new CommanHelperMethods(_driver);
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
            var CurrentWindow = App.Windows(_driver).getCurrentWindow();
            App.Windows(_driver).OpenWindows().ClickHomepageWindow().getCurrentWindow();
            var AllWindows = App.Windows(_driver).getAllWindows();
            App.Windows(_driver).SwitchToWindow(SiteUrls.Playground, CurrentWindow, AllWindows);
            Assert.IsTrue(App.Windows(_driver).VerifyHeaderDisplayedInWindow(TagName.H1, FormText.LocatorsAndSeleniumInteractions));
            App.Launch(_driver).Maximize();
            helper.CaptureScreenShot($"{Directory.GetCurrentDirectory()}\\Screenshot", "NewWindow"); // capture current window
            helper.MakeElemScreenshot(_driver,_driver.FindElement(By.CssSelector("[class='wp-heading']")),$"{Directory.GetCurrentDirectory()}\\Screenshot", "Wholebody"); // capture the specific element
        }
    }
}