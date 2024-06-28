using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.Utilities;

namespace TestProject1.ElementFactory
{
    public class LeafPlayGroundElementFactory
    {
        IWebDriver? _driver;
        WebDriverWait wait;
        public LeafPlayGroundElementFactory(IWebDriver driver)
        {
            _driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }
        public IWebElement Windows()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(XpathConstructor.constructXpath(TagName.Href,SiteUrls.Windows))));
        }
        public IWebElement OpenHomePage()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(By.Id(ID.Home)));
        }
        public IWebElement OpenMultipleWindows() 
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(XpathConstructor.constructXpath("onclick", "openWindows()"))));
        }
        public IWebElement CannotCloseParentWindow() 
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(XpathConstructor.constructXpathWithText("Can't close the parent window"))));
        }
        public IWebElement WaitForFewSeconds() 
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(XpathConstructor.constructXpathWithText("Wait for 2 new Windows to open"))));
        }
        //public IWebElement windowHandle() 
        //{

        //}
        
    }
}
