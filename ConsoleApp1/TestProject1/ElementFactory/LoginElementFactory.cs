using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.ElementFactory
{
    internal class LoginElementFactory
    {
        IWebDriver _driver;
        public LoginElementFactory(IWebDriver driver)
        {
            _driver = driver;
        }

        public LoginElementFactory UserName()
        {
            return this;
        }
    }
}
