using AventStack.ExtentReports;
using NUnit.Framework;
using SFS_ATX.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFS_ATX.TestScripts
{
    [TestFixture]
    public class P0_TC_FindAnswers : BaseTest
    {

        [Test]
        public void KBSearchLink_HomePageTestcases()
        {
            try
            {
                test = extent.CreateTest("TC_006 Execution").Info("Validation Started for KB Search Link URL");
                HomePage hp = new HomePage(driver);
                String parentWindowHandle = driver.CurrentWindowHandle;
                Console.WriteLine("CurrentWindow" + parentWindowHandle);
                hp.SearchLink();
                test.Log(Status.Info, "Clicked on Search Link");
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
                string expectedurl = "https://support-demo.cch.com/sfs";
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
        public void ViewLink_HomePageTestcases()
        {
            try
            {
                test = extent.CreateTest("TC_007 Execution").Info("Validation Started for View Link URL");
                HomePage hp = new HomePage(driver);
                String parentWindowHandle = driver.CurrentWindowHandle;
                Console.WriteLine("CurrentWindow" + parentWindowHandle);
                hp.ViewLink();
                test.Log(Status.Info, "Clicked on Search Link");
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
                string expectedurl = "https://support-demo.cch.com/videolibrary/sfs#/";
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

        public void Ask_Link_HomePageTestcases()
        {
            try
            {
                test = extent.CreateTest("TC_008 Execution").Info("Validation Started for Ask URL");
                HomePage hp = new HomePage(driver);
                hp.AskLink();
                test.Log(Status.Info, "Clicked on Ask link");
                string actualurl = driver.Url;
                string expectedurl = "https://wdc-qa-support.atxinc.com/communities/index";
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

