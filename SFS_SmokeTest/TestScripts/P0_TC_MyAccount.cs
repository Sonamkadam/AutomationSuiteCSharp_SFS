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
   public class P0_TC_MyAccount : BaseTest
   {
        [Test]
        public void MyAccount_HomePageTestcases()
        {
            try
            {
                test = extent.CreateTest("TC_009 Execution").Info("Validation Started for Manage My Account URL");
                HomePage hp = new HomePage(driver);
                String parentWindowHandle = driver.CurrentWindowHandle;
                Console.WriteLine("CurrentWindow" + parentWindowHandle);
                hp.ManageLink();
                test.Log(Status.Info, "Clicked on Manage Link");
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
                string expectedurl = "https://qa-ngmyaccount.gsdwkglobal.com/myaccount/#/saml?idp=atx";
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
        public void BankProductEnrollment_HomePageTestcases()
        {
            try
            {
                test = extent.CreateTest("TC_010 Execution").Info("Validation Started for Bank Product enrollment URL");
                HomePage hp = new HomePage(driver);
                hp.BankLink();
                test.Log(Status.Info, "Clicked on Bank Link");
                string actualurl = driver.Url;
                string page_title = driver.Title;
                Console.WriteLine("Current_Page_Title" + page_title);
                string expectedurl = "https://wdc-qa-support.atxinc.com/myinformation/myinformation";
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
