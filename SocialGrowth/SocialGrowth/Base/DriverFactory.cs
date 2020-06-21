using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialGrowth.Base
{
    public class DriverFactory
    {
        private static IWebDriver driver = null;

        private static void CreateDriver()
        {
            driver = new ChromeDriver();
        }

        public static IWebDriver GetDriver() 
        {
            if (driver == null) CreateDriver();
            
            return driver;
        }


        public static void DestroyDriver()
        {
            driver.Close();
        }

    }
}
