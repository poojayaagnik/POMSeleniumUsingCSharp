
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace POM2.Pages
{
    public class LoginPage
    {
        [FindsBy(How=How.Name,Using ="username")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Name, Using = "pwd")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='submit']")]
        public IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='errormsg']")]
        public IWebElement ErrorMessage { get; set; }
    }
}
