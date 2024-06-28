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
    public class DashboardElementFactory
    {
        IWebDriver? _driver;
        WebDriverWait wait;
        public DashboardElementFactory(IWebDriver driver)
        {
            _driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }
        public IWebElement DashboardTitlebar()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(ClassName.topbar_header_title))).FindElement(By.Name(TagName.H6));
        }
        
    }
}
