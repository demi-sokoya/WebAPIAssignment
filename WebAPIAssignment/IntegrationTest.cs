using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace IntegrationTestPractice
{
    [TestClass]
    public class IntegrationTest
    {
        private IWebDriver _webDriver;

        [TestInitialize]
        public void Startup()
        {

            new DriverManager().SetUpDriver(new ChromeConfig());
            _webDriver = new ChromeDriver();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(true);
        }

        [TestCleanup]
        public void Shutdown()
        {
            _webDriver.Quit();
        }
    }
}
