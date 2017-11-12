using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowTutorial___ToolsQA.Utils;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowTutorial___ToolsQA.Steps2
{
    [Binding]
    public class LogIn_Steps2
    {
        public IWebDriver driver;
        [Given(@"User is at the Home Page")]
        public void GivenUserIsAtTheHomePage()
        {
            driver = new ChromeDriver();
            driver.Url = "http://www.store.demoqa.com";
        }

        [Given(@"Navigate to LogIn Page")]
        public void GivenNavigateToLogInPage()
        {
            driver.FindElement(By.XPath(".//*[@id='account']/a")).Click();
        }

        [When(@"User enter(.*) and(.*)")]
        public void WhenUserEnterUserNameAndPassword(string username, string password)
        {
            driver.FindElement(By.Id("log")).SendKeys(username);
            driver.FindElement(By.Id("pwd")).SendKeys(password);
        }

        [When(@"User enter credentials")]
        public void WhenUserEnterCredentials(Table table)
        {
            var dictionary = TableExtensions.ToDictionary(table);
            var test = dictionary["Username"];

            driver.FindElement(By.Id("log")).SendKeys(dictionary["Username"]);
            driver.FindElement(By.Id("pwd")).SendKeys(dictionary["Password"]);
        }

        [When(@"Click on the LogIn button")]
        public void WhenClickOnTheLogInButton()
        {
            driver.FindElement(By.Id("login")).Click();
        }

        [When(@"User LogOut from the Application")]
        public void WhenUserLogOutFromTheApplication()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Successful LogIN message should display")]
        public void ThenSuccessfulLogINMessageShouldDisplay()
        {
            Thread.Sleep(5000);
            //This Checks that if the LogOut button is displayed
            true.Equals(driver.FindElement(By.XPath(".//*[@id='account_logout']/a")).Displayed);
            driver.Quit();
        }

        [Then(@"Successful LogOut message should display")]
        public void ThenSuccessfulLogOutMessageShouldDisplay()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
