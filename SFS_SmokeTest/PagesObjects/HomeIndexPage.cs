using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SFS_SmokeTest.PagesObjects
{
   public class HomeIndexPage
    {
        IWebDriver Driver;

       
        public HomeIndexPage(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How = How.LinkText, Using = "Home")]
        public IWebElement HomeMenu { get; set; }


        public HomePage HomeMenulink()
        {
            HomeMenu.Click();
            return new HomePage(Driver);
        }
    }
}
