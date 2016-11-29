
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using POM2.Pages;

namespace POM2.PageOperations
{
     public class LoginPageOperations
    {
        IWebDriver driver;

        public LoginPageOperations(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Login()
        {
            LoginPage loginPage = new LoginPage();
            PageFactory.InitElements(driver, loginPage);
            loginPage.UserName.SendKeys("admin");
            loginPage.Password.SendKeys("manager");
            loginPage.SubmitButton.Click();
        }
    }
}
