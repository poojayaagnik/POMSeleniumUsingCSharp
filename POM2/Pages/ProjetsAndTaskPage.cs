
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace POM2.Pages
{
    public class ProjectsAndTaskPage
    {
        
        [FindsBy(How=How.XPath,Using= "//input[@value='Add New Tasks']")]
            public IWebElement AddNewTask { get; set; }

        [FindsBy(How=How.Name, Using = "customerProject")]
            public IWebElement Customer { get; set; }

        [FindsBy(How=How.Name, Using = "customerProject.shownProject")]
            public IWebElement Project { get; set; }

        [FindsBy(How=How.Name, Using = "searchTasks")]
            public IWebElement ShowTasks { get; set; }

    }
}
