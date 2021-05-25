using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using SFS_ATX.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFS_ATX.TestScripts
{
   public class P0_TC_ContactUs : BaseTest
    {
        [Test]
        public void ChatLiveWithCCHExpert_HomePageTestcases()
        {
            try
            {
                test = extent.CreateTest("TC_011 Execution").Info("Validation Started for Chat live with a CCH Expert URL");
                HomePage hp = new HomePage(driver);
                String parentWindowHandle = driver.CurrentWindowHandle;
                Console.WriteLine("CurrentWindow" + parentWindowHandle);
                hp.ChatLink();
                test.Log(Status.Info, "Clicked on Chat  Link");
                List<String> listOfWindow = driver.WindowHandles.ToList();
                String ChildWindowHandle = "";
                foreach (var Handle in listOfWindow)
                {
                    Console.WriteLine("New Window " + Handle);
                    driver.SwitchTo().Window(Handle);
                    ChildWindowHandle = Handle;
                }
                driver.SwitchTo().Window(parentWindowHandle);
                driver.Close();
                driver.SwitchTo().Window(ChildWindowHandle);
                string actualurl = driver.Url;
                string page_title = driver.Title;
                Console.WriteLine("Current_Page_Title" + page_title);
                string expectedurl = "https://support-demo.cch.com/sfs/atxchat";
                Assert.That(actualurl, Is.EqualTo(expectedurl));
                Console.WriteLine("Pass" + actualurl);
                test.Log(Status.Pass, "Result is Pass");

            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Result is Fail");
                Console.WriteLine("Fail" + e);
                throw;

            }

        }
        [Test]
        public void OpenASupportCase_HomePageTestcases()
        {
            try
            {
                test = extent.CreateTest("TC_012 Execution").Info("Validation Started for Open a support case URL");
                HomePage hp = new HomePage(driver);
                String parentWindowHandle = driver.CurrentWindowHandle;
                Console.WriteLine("CurrentWindow" + parentWindowHandle);
                hp.OpenLink();
                test.Log(Status.Info, "Clicked on Open a support case  Link");
                List<String> listOfWindow = driver.WindowHandles.ToList();
                String ChildWindowHandle = "";
                foreach (var Handle in listOfWindow)
                {
                    Console.WriteLine("New Window " + Handle);
                    driver.SwitchTo().Window(Handle);
                    ChildWindowHandle = Handle;
                }
                driver.SwitchTo().Window(parentWindowHandle);
                driver.Close();
                driver.SwitchTo().Window(ChildWindowHandle);
                string actualurl = driver.Url;
                string page_title = driver.Title;
                Console.WriteLine("Current_Page_Title" + page_title);
                string expectedurl = "https://support-demo.cch.com/sfs/ContactUs.aspx";
                Assert.That(actualurl, Does.Contain(expectedurl));
                Console.WriteLine("Pass" + actualurl);
                test.Log(Status.Pass, "Result is Pass");

            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Result is Fail");
                Console.WriteLine("Fail" + e);
                throw;

            }

        }
        [Test]
        public void ClickForSupportHours_HomePageTestcases()
        {
            try
            {
                test = extent.CreateTest("TC_013 Execution").Info("Validation Started for Click for support hours URL");
                HomePage hp = new HomePage(driver);
                String parentWindowHandle = driver.CurrentWindowHandle;
                Console.WriteLine("CurrentWindow" + parentWindowHandle);
                hp.ClickLink();
                test.Log(Status.Info, "Clicked on Click for support hour  Link");
                List<String> listOfWindow = driver.WindowHandles.ToList();
                String ChildWindowHandle = "";
                foreach (var Handle in listOfWindow)
                {
                    Console.WriteLine("New Window " + Handle);
                    driver.SwitchTo().Window(Handle);
                    ChildWindowHandle = Handle;
                }
                driver.SwitchTo().Window(parentWindowHandle);
                driver.Close();
                driver.SwitchTo().Window(ChildWindowHandle);
                string actualurl = driver.Url;
                string page_title = driver.Title;
                Console.WriteLine("Current_Page_Title" + page_title);
                string expectedurl = "https://support-demo.cch.com/kb/solution/000093021";
                Assert.That(actualurl, Is.EqualTo(expectedurl));
                Console.WriteLine("Pass" + actualurl);
                test.Log(Status.Pass, "Result is Pass");

            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Result is Fail");
                Console.WriteLine("Fail" + e);
                throw;

            }

        }
    }
}
