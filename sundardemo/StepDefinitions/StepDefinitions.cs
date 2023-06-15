using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;


namespace sundardemo.StepDefinitions
{
    [Binding]
    public sealed class loginStepsDefinitions
    {
        private IWebDriver driver;

        public string username = "//*[@id=\"user-name\"]";
        public string password = "//*[@id=\"password\"]";
        public string loginbutton = "//*[@id=\"login-button\"]";

        [Given(@"open the browser")]
        public void GivenOpenTheBrowser()
        {
            driver = new ChromeDriver();
        }

        [When(@"enter the URL")]
        public void WhenEnterTheURL()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"user enter username")]
        public void userenterusername()
        {
            driver.FindElement(By.XPath(username)).SendKeys("standard_user");
            Thread.Sleep(2000);
        }

        [When(@"user enter password")]
        public void userenterpassword()
        {
            driver.FindElement(By.XPath(password)).SendKeys("secret_sauce");
            Thread.Sleep(2000);
        }
        [When(@"user click on login")]
        public void userlogin()
        {
            driver.FindElement(By.XPath(loginbutton)).Click();
            Thread.Sleep(2000);
            driver.Quit();
        }

    }

}