﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.ElementFactory;

namespace TestProject1.Commands
{
    public class DashboardCommand
    {
        public DashboardElementFactory DashboardElementFactory;

        public DashboardCommand(IWebDriver driver)
        {
            DashboardElementFactory = new(driver);
        }
        public bool VerifyUserNavigatedToDashboardPage()
        {
            try
            {
                return DashboardElementFactory.DashboardTitlebar().Displayed;
            }
            catch
            {
                return false;
            }
        }

    }
}
