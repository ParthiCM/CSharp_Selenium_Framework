using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.ElementFactory;

namespace TestProject1.Commands
{
    public class LoginCommand
    {
        public  IWebDriver _driver;
        public  LoginCommand(IWebDriver driver)
        {
            _driver = driver;
        }

        public LoginCommand SetUserName()
        {
            return this;
        }
    }
}
