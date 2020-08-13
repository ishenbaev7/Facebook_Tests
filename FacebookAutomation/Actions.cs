using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using FacebookAutomation.Pages;
namespace FacebookAutomation
{

    public static class Actions
    {
        
        public static void InitializeDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-notifications");
            
            Driver.driver = new ChromeDriver(options);
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
            Driver.driver.Manage().Window.Maximize();
            Driver.WaitForElementUpTo(Config.ElementsWaitingShortTimeout);
        }

    }
}
