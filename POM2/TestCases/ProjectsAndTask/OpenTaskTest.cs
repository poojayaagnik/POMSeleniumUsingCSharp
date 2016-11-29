
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.PageObjects;
using POM2.PageOperations;

namespace POM2.TestCases.ProjectsAndTask
{
    [TestClass]
    public class OpenTaskTest:TestBase
    {
       
        LoginPageOperations loginPageOperations;

        public OpenTaskTest()
        {
            loginPageOperations = new LoginPageOperations(driver);
        }

        [TestMethod]
        public void MyTestMethod()
        {
            //TODO:I need to change the method name
            loginPageOperations.Login();
        }
       
    }
}
