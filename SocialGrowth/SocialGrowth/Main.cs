using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SocialGrowth.Base;
using SocialGrowth.PageObjects;

namespace SocialGrowth
{
    [TestClass]
    public class Main
    {
        [TestInitialize]
        public void Setup() 
        {
            TestBase.Initialize();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Login();
            Thread.Sleep(15000);
        }

        private void Login()
        {
            LoginPage.SetUsername("");
            LoginPage.SetPassword("");
            LoginPage.ClickSubmit();
        }

        [TestCleanup]
        public void Cleanup() 
        {
            TestBase.Finalize();
        }

    }
}
