
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using POM2.Pages;
using System.Threading;

namespace POM2.TestCases
{
    /// <summary>
    /// Test cases for login page.
    /// </summary>
    [TestClass]
     public class LoginPageTest:TestBase
    {
        LoginPage loginPage;
        ProjectsAndTaskPage projectAndTask;

        public LoginPageTest()
        {
             loginPage = new LoginPage();
             projectAndTask = new ProjectsAndTaskPage();
        }

        [TestMethod]
        public void VerifyLogin()
        {
            PageFactory.InitElements(driver, loginPage);
            loginPage.UserName.SendKeys("admin");
            loginPage.Password.SendKeys("manager");
            loginPage.SubmitButton.Click();
            Thread.Sleep(2000);
            PageFactory.InitElements(driver, projectAndTask);
            Assert.IsTrue(projectAndTask.AddNewTask.Displayed);       
        }

        [TestMethod]
        public void VerifyLoginNoName()
        {
            PageFactory.InitElements(driver, loginPage);
            loginPage.Password.SendKeys("manager");
            loginPage.SubmitButton.Click();
            Assert.IsTrue(loginPage.ErrorMessage.Displayed);
        }

        [TestMethod]
        public void VerifyLoginNoPassword()
        {
            PageFactory.InitElements(driver, loginPage);
            loginPage.UserName.SendKeys("admin");
            loginPage.SubmitButton.Click();
            Assert.IsTrue(loginPage.ErrorMessage.Displayed);
        }
    }
}
