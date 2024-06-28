using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Utilities
{
    public  class CommanHelperMethods
    {
        public  IWebDriver? driver;
        public CommanHelperMethods(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void CaptureScreenShot(string filePath, string screenshotName)
        {
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();

            var dir = $"{filePath}\\{screenshotName}";
            ss.SaveAsFile($"{dir}.png");
        }
    }
}
