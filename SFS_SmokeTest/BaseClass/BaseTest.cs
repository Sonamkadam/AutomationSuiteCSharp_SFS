using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SFS_SmokeTest.PagesObjects;
using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Text;
using System.Threading;

namespace SFS_SmokeTest.BaseClass
{
    [TestFixture]
    public class BaseTest
    {
        public IWebDriver driver;
        ExtentReports extent = null;

        [SetUp]
        public void Setup()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\Skadam\Source\Repos\SFS_SmokeTestSuite\ExtentReports.html");
            extent.AttachReporter(htmlReporter);
            Console.Write("Setup");
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            driver.Url = "https://wdc-qa-support.atxinc.com/";
            Console.Write("Setup");
            LoginPage Lp = new LoginPage(driver);
            Lp.ClientLoginPage("80006125", "Sonam", "WebTeam@10");
            HomeIndexPage hIp = new HomeIndexPage(driver);
            hIp.HomeMenulink();
            //driver.Url = ConfigurationManager.AppSettings.Get("URL");
            //Console.WriteLine("URL" + url);
            //driver.Navigate().GoToUrl(url);
            Thread.Sleep(3000);
            
        }

        [TearDown]
        public void TearDown()
        {
          driver.Quit();
            Console.Write("Quit");
        }

    }
}
