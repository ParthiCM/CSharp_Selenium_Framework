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
        public LoginElementFactory LoginElementFactory;

        public LoginCommand(IWebDriver driver)
        {
            LoginElementFactory = new(driver);
        }

        public LoginCommand SetUserName(string username)
        {
            LoginElementFactory.UserName().SendKeys(username);
            return this;
        }
        public LoginCommand SetPassword(string password)
        {
            LoginElementFactory.Password().SendKeys(password);
            return this;
        }
        public LoginCommand SubmitButton()
        {
            LoginElementFactory.LoginButton().Click();
            return this;
        }
    }
}
