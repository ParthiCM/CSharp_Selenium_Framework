using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using TestProject1.ElementFactory;

namespace TestProject1.Commands
{
    public class PlayGroundCommand
    {
        public LeafPlayGroundElementFactory LeafPlayGroundElementFactory;
        public Actions action;
        public IWebDriver __driver;

        public PlayGroundCommand(IWebDriver driver)
        {
            __driver = driver;
            LeafPlayGroundElementFactory = new(driver);
            action = new Actions(driver);
        }

        public string getCurrentWindow()
        {
            return __driver.CurrentWindowHandle;
        }
        public List<string> getAllWindows()
        {
            return __driver.WindowHandles.ToList();
        }

        public void SwitchToWindow(string windowURL, string currentWindow, List<string> allWindows)
        {

            Console.WriteLine($"Total Number of Windows is {allWindows.Count}");
            foreach (var item in allWindows)
            {
                Console.WriteLine($"Current Window ID is {item}");
                __driver.SwitchTo().Window(item);
                if (__driver.Url.Trim().Equals(windowURL))
                {
                    Console.WriteLine($"Switch to Window {item} & Its URL {__driver.Url.Trim().Equals(windowURL)}");
                    return;
                }
                else
                {
                    __driver.SwitchTo().Window(currentWindow);
                }
            }
        }
        public PlayGroundCommand OpenWindows()
        {
            if (!LeafPlayGroundElementFactory.Windows().Displayed)
            {
                action.ScrollToElement(LeafPlayGroundElementFactory.Windows());
            }
            LeafPlayGroundElementFactory.Windows().Click();
            return this;
        }

        public PlayGroundCommand ClickHomepageWindow()
        {
            LeafPlayGroundElementFactory.OpenHomePage().Click();
            return this;
        }
        public PlayGroundCommand ClickMultipleWindows()
        {
            LeafPlayGroundElementFactory.OpenMultipleWindows().Click();
            return this;
        }
        public PlayGroundCommand ClickCannotCloseParentWindow()
        {
            LeafPlayGroundElementFactory.CannotCloseParentWindow().Click();
            return this;
        }
        public PlayGroundCommand ClickWaitForFewSecondsLink()
        {
            LeafPlayGroundElementFactory.WaitForFewSeconds().Click();
            return this;
        }
        public bool VerifyHeaderDisplayedInWindow(string headerTag, string textToverify)
        {
            try
            {
                return LeafPlayGroundElementFactory.GetAllHeaders(headerTag).Contains(textToverify);
            }
            catch
            {
                return false;
            }
        }
    }
}
