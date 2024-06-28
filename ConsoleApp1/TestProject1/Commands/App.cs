using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Commands
{
    public static class App
    {

        public static LoginCommand Login(IWebDriver driver)
        {
            return new LoginCommand(driver);
        }
        public static LaunchCommand Launch(IWebDriver driver)
        {
            return new LaunchCommand(driver);
        }
        public static DashboardCommand Dashboard(IWebDriver driver)
        {
            return new DashboardCommand(driver);
        }

    }
}
