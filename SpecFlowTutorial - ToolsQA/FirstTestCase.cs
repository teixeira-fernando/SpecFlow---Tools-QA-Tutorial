using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SpecFlowTutorial___ToolsQA
{

    [TestClass]
    public class FirstTestCase
    {

        [TestMethod]
        public void Login()
        {
            IWebDriver driver = new ChromeDriver();

            //Launch the Online Store Website
            driver.Url = "http://www.store.demoqa.com";

            // Find the element that's ID attribute is 'account'(My Account) 
            driver.FindElement(By.XPath(".//*[@id='account']/a")).Click();

            // Find the element that's ID attribute is 'log' (Username)
            // Enter Username on the element found by above desc.
            driver.FindElement(By.Id("log")).SendKeys("FernandoTeste");

            // Find the element that's ID attribute is 'pwd' (Password)
            // Enter Password on the element found by the above desc.
            driver.FindElement(By.Id("pwd")).SendKeys("12345678");

            // Now submit the form.
            driver.FindElement(By.Id("login")).Click();

            Thread.Sleep(5000);

            // Find the element that's ID attribute is 'account_logout' (Log Out)
            driver.FindElement(By.XPath(".//*[@id='account_logout']/a")).Click();

            // Close the driver
            driver.Quit();
        }
    }
}
