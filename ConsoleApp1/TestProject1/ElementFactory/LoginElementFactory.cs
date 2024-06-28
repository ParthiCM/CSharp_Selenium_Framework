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
    public class LoginElementFactory
    {
        IWebDriver? _driver;
        WebDriverWait wait;
        public LoginElementFactory(IWebDriver driver)
        {
            _driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }
        public IWebElement UserName()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(By.Name(Name.Username)));
        }
        public IWebElement Password()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(By.Name(Name.Password)));
        }
        public IWebElement LoginButton()
        {
            return _driver.FindElement(By.XPath(XpathConstructor.constructXpath(TagName.Button, "type", "submit")));
        }
    }
}
