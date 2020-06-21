using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialGrowth.Base
{
    public class TestBase
    {
        protected static IWebDriver driver = null;
        protected static int MaxWait = 10;
        protected static WebDriverWait wait;

        public static void Initialize() 
        {
            driver = DriverFactory.GetDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(MaxWait));
            driver.Navigate().GoToUrl("https://www.instagram.com/");
        }

        public static void Finalize() 
        {
            DriverFactory.DestroyDriver();
        }

        protected static void SetText(string xpath, string text) 
        {
            driver.FindElement(By.XPath(xpath)).SendKeys(text);
        }

        protected static void WaitUntil(string xpath) 
        {
            wait.Until(driver => driver.FindElement(By.XPath(xpath)));
        }

        protected static void Click(string xpath) 
        {
            driver.FindElement(By.XPath(xpath)).Click();
        }
    }
}
