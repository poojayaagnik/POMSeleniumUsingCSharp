

using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace POM2.TestCases
{
    [TestClass]
     public class TestBase
    {
         public IWebDriver driver;

        public TestBase()
        {
            driver = new FirefoxDriver();
            driver.Url = "http://127.0.0.1/login.do";
        }
        [TestInitialize]

        public void Initialize()
        {
            driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}
