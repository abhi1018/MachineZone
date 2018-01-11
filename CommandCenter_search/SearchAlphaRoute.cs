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
    //suite ID: 21177

    public class SearchAlphaRoute
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

        //Inner Route

        [TestMethod]


        public void SearchInnerRoute()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.FindElement(By.ClassName("navigator-header-search")).SendKeys("Inner");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//a[@href = '/routes/INN']")).Click();

        }

        [TestMethod]

        public void SearchINNERRoute()
        {
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.FindElement(By.ClassName("navigator-header-search")).SendKeys("INNER");
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//a[@href = '/routes/INN']")).Click();

        }

        [TestMethod]

        public void SearchinnerRoute()
        {
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.FindElement(By.ClassName("navigator-header-search")).SendKeys("inner");
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//a[@href = '/routes/INN']")).Click();

        }

        [TestMethod]

        public void SearchinnRoute()
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.FindElement(By.ClassName("navigator-header-search")).SendKeys("inn");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//a[@href = '/routes/INN']")).Click();

        }


        [TestMethod]

        public void SearchINNRoute()
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.FindElement(By.ClassName("navigator-header-search")).SendKeys("INN");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//a[@href = '/routes/INN']")).Click();

        }

        //Outer route
        [TestMethod]


        public void SearchOuterRoute()
        {
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.FindElement(By.ClassName("navigator-header-search")).SendKeys("Outer");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//a[@href = '/routes/OUT']")).Click();

        }


        [TestMethod]


        public void SearchOUTERRoute()
        {
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.FindElement(By.ClassName("navigator-header-search")).SendKeys("OUTER");
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//a[@href = '/routes/OUT']")).Click();

        }


        [TestMethod]


        public void SearchouterRoute()
        {
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.FindElement(By.ClassName("navigator-header-search")).SendKeys("outer");
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//a[@href = '/routes/OUT']")).Click();

        }


        [TestMethod]


        public void SearchoutRoute()
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.FindElement(By.ClassName("navigator-header-search")).SendKeys("out");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//a[@href = '/routes/OUT']")).Click();

        }


        [TestMethod]


        public void SearchOUTRoute()
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.FindElement(By.ClassName("navigator-header-search")).SendKeys("OUT");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//a[@href = '/routes/OUT']")).Click();

        }

        //City Link

        [TestMethod]


        public void SearchCityRoute()
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.FindElement(By.ClassName("navigator-header-search")).SendKeys("City");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//a[@href = '/routes/CTY']")).Click();

        }

        [TestMethod]


        public void SearchCITYRoute()
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.FindElement(By.ClassName("navigator-header-search")).SendKeys("CITY");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//a[@href = '/routes/CTY']")).Click();

        }

        [TestMethod]


        public void SearchcityRoute()
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.FindElement(By.ClassName("navigator-header-search")).SendKeys("city");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//a[@href = '/routes/CTY']")).Click();

        }

        [TestMethod]


        public void SearchctyRoute()
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.FindElement(By.ClassName("navigator-header-search")).SendKeys("cty");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//a[@href = '/routes/CTY']")).Click();

        }

        [TestMethod]


        public void SearchCTYRoute()
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.FindElement(By.ClassName("navigator-header-search")).SendKeys("CTY");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//a[@href = '/routes/CTY']")).Click();

        }

        //Sky Bus service

        [TestMethod]


        public void SearchSkybusRoute()
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.FindElement(By.ClassName("navigator-header-search")).SendKeys("Skybus");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//a[@href = '/routes/SKY']")).Click();

        }

        [TestMethod]


        public void SearchSKYBUSRoute()
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.FindElement(By.ClassName("navigator-header-search")).SendKeys("SKYBUS");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//a[@href = '/routes/SKY']")).Click();

        }

        [TestMethod]


        public void SearchskybusRoute()
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.FindElement(By.ClassName("navigator-header-search")).SendKeys("skybus");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//a[@href = '/routes/SKY']")).Click();

        }

        [TestMethod]


        public void SearchskyRoute()
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.FindElement(By.ClassName("navigator-header-search")).SendKeys("sky");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//a[@href = '/routes/SKY']")).Click();

        }

        [TestMethod]


        public void SearchSKYRoute()
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.FindElement(By.ClassName("navigator-header-search")).SendKeys("SKY");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//a[@href = '/routes/SKY']")).Click();

        }

        //Northern Express

        [TestMethod]


        public void SearchNortherExpressRoute()
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.FindElement(By.ClassName("navigator-header-search")).SendKeys("Northern Express");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//a[@href = '/routes/NEX']")).Click();

        }

        [TestMethod]


        public void SearchnortherexpressRoute()
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.FindElement(By.ClassName("navigator-header-search")).SendKeys("northern express");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//a[@href = '/routes/NEX']")).Click();

        }

        [TestMethod]


        public void SearchNexRoute()
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.FindElement(By.ClassName("navigator-header-search")).SendKeys("Nex");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//a[@href = '/routes/NEX']")).Click();

        }

        [TestMethod]


        public void SearchNEXRoute()
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.FindElement(By.ClassName("navigator-header-search")).SendKeys("NEX");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//a[@href = '/routes/NEX']")).Click();

        }

        [TestMethod]


        public void SearchnexRoute()
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            driver.FindElement(By.ClassName("navigator-header-search")).SendKeys("nex");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//a[@href = '/routes/NEX']")).Click();

        }
    }
}

