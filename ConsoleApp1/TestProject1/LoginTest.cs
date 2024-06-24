using OpenQA.Selenium;
using TestProject1.Commands;

namespace TestProject1
{
    public class Tests 
    {
        public IWebDriver _driver;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _driver = BaseTest.GetWebdriver("Chrome");
            Console.WriteLine("OneTimeSetup");
        }
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
           _driver.Quit();
           _driver.Dispose();
           Console.WriteLine("OneTimeTearDown");

        }

        [Test]
        public void Test1()
        {
            App.Login(_driver).SetUserName();
            Console.WriteLine("Test");

        }
    }
}