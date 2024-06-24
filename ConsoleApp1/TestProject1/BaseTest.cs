using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class BaseTest
    {
        public static IWebDriver? driver;
        public static IWebDriver GetWebdriver(string browser)
        {
            switch (browser.ToLower())
            {
                case "chrome":
                    return driver = new ChromeDriver();
                case "firefox":
                    return driver = new FirefoxDriver();
                default:
                    Exception exception = new Exception("Driver Not Found for the Specified Browser");
                    throw exception;
            }
        }

    }
}
