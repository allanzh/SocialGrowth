using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SocialGrowth.Base;

namespace SocialGrowth
{
    [TestClass]
    public class Main
    {
        public IWebDriver driver;

        [TestInitialize]
        public void Setup() 
        {
            driver = DriverFactory.GetDriver();
            driver.Navigate().GoToUrl("https://google.com");
        }

        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestCleanup]
        public void Cleanup() 
        {
            DriverFactory.DestroyDriver();
        }

    }
}
