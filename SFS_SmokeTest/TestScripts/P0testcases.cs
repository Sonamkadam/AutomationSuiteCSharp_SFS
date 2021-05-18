using NUnit.Framework;
using SFS_SmokeTest.BaseClass;
using SFS_SmokeTest.PagesObjects;
using System;
using System.Threading;

namespace SFS_SmokeTest.TestScripts
{
    [TestFixture]
    public class P0testcases : BaseTest
    {
        //[Test]
        //public void LoginTestCase()
        //{
        //    Console.Write("Setup");
        //    LoginPage Lp = new LoginPage(driver);
        //    Lp.ClientLoginPage("80006125", "Sonam", "WebTeam@10");
        //    // var HomeIndexPage_object = Lp.ClientLoginPage("80006125", "Sonam", "WebTeam@10");
        //    // Console.WriteLine("Login Successfully done");
        //    // var HomePage_object=HomeIndexPage_object.HomeMenulink();
        //    // Console.WriteLine("Homelink Successfully Clicked");
        //    // HomePage_object.KbSearchTextBox();
        //    // Console.WriteLine("Kbserach Successfully done");
        //    // Console.WriteLine("Fully executed");
        //    //Thread.Sleep(6000);



        //}
        //[Test]
        //public void HomeIndexMenuTestcase()
        //{
        //    HomeIndexPage hIp = new HomeIndexPage(driver);
        //    hIp.HomeMenulink();

        //}

        [Test]
        public void HomePageTestcases()
        {
            try
            {
                HomePage hp = new HomePage(driver);
                hp.AskLink();
                string actualurl = driver.Url;
                string expectedurl = "https://wdc-qa-support.atxinc.com/communities/index";

                Assert.That(actualurl, Is.EqualTo(expectedurl));
                Console.WriteLine("Pass" + actualurl);
              
                    
            }
            catch (Exception e)
            {
                Console.WriteLine("Fail" + e);
                throw;
            }
           

        }
            
        }

    }


