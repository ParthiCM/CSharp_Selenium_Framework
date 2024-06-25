using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Commands
{
    public class LaunchCommand
    {
        IWebDriver _driver;
        public LaunchCommand(IWebDriver driver)
        {
            _driver = driver;
        }

        public LaunchCommand Site(string url)
        {
            _driver.Navigate().GoToUrl(url);
            return this;
        }
        public LaunchCommand Maximize(int? width = null , int? height = null)
        {
            if (width.Equals(null) && height.Equals(null))
            {
                _driver.Manage().Window.Size = new System.Drawing.Size(480, 320);
            }
            _driver.Manage().Window.Maximize();
            return this;
        }
        public LaunchCommand ImplicitWait(int timeoutInSeconds)
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeoutInSeconds);
            return this;
        }
    }
}
