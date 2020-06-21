using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SocialGrowth.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialGrowth.PageObjects
{
    public class LoginPage : TestBase
    {
        private static string xpath;

        public static void SetUsername(string username)
        {
            xpath = "//input[@name='username']";
            WaitUntil(xpath);
            SetText(xpath, username);
        }

        public static void SetPassword(string password)
        {
            xpath = "//input[@name='password']";
            SetText(xpath, password);
        }

        public static void ClickSubmit() 
        {
            xpath = "//button[@type='submit']";
            Click(xpath);
        }
        
    }
}
