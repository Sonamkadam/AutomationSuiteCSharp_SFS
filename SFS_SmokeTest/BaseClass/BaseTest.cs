using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SFS_ATX.PagesObjects;
using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Text;
using System.Threading;

namespace SFS_ATX.BaseClass
{
    [TestFixture]
    public class BaseTest
    {
        public IWebDriver driver;
        public ExtentTest test = null;
        public ExtentReports extent = null;

        //Generating Extent reports
        [OneTimeSetUp]
        public void ExtentStart()
        {

            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Automation Framework\GitHub\AutomationSuiteCSharp_SFS\SFS_SmokeTest\Extent Reports\");
            extent.AttachReporter(htmlReporter);
        }

        //Launching Browser and accessing the URL using the Login 
        [SetUp]
        public void Setup()
        {
            test = extent.CreateTest("TC_001 Execution").Info("Login Testcase");
            Console.Write("Setup");
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            test.Log(Status.Info, "Launched browser");
            Thread.Sleep(3000);
            driver.Url = "https://wdc-qa-support.atxinc.com/";
            test.Log(Status.Info, "Hit WebSite");
            Console.Write("Setup");
            LoginPage Lp = new LoginPage(driver);
            Lp.ClientLoginPage("80006125", "QAtest", "WebTeam@02");
            test.Log(Status.Info, "Successfully Login");
            test.Log(Status.Pass, "Login Passed");
            HomeIndexPage hIp = new HomeIndexPage(driver);
            hIp.HomeMenulink();
            test.Log(Status.Info, "Clicked on Home Link");
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
            test.Log(Status.Info, "Closed browser");
        }

        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();
        }

    }
}
