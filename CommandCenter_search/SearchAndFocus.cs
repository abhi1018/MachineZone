using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace CommandCenter_search
{
    [TestClass]
    public class SearchAndFocus
    {


        protected static IWebDriver driver;


        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            driver = new ChromeDriver(@"C:\Users\abhiband1\Documents\drivers\");
            driver.Navigate().GoToUrl("https://stg.command.satori.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);

            driver.FindElement(By.Id("username")).SendKeys("cc_staging@mz.com");
            driver.FindElement(By.Id("password")).SendKeys("SmartCity2017!");
            driver.FindElement(By.XPath("//span[contains(text(),'Log in')]")).Click();
        }

        [ClassCleanup]
        public static void TearDown()
        {
            //driver.Quit();
        }


        [TestMethod]
        public void jamescook()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.FindElement(By.ClassName("navigator-header-search")).SendKeys("36 James Cook Crescent, Remuera");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.FindElement(By.XPath("//a[@index = '1' and @href = '/addresses/ChIJQTHSP3FIDW0RIpXDphCaGmQ']")).Click();
        }
    }
}
