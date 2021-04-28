using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SFS_SmokeTest
{
    public class HomePage
    {

        IWebDriver Driver;

        //Constructors 
        public HomePage(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);

        }


        //Identifiers
       

        [FindsBy(How = How.Id, Using = "sfsSearchInput")]
        public IWebElement KbSearch { get; set; }


        [FindsBy(How = How.ClassName, Using = "sfsSearchButton")]
        public IWebElement ClicktKbSearch { get; set; }

        [FindsBy(How = How.LinkText, Using = "password center")]
        public IWebElement PasswordCenter { get; set; }

        [FindsBy(How = How.LinkText, Using = "Search")]
        public IWebElement Search { get; set; }

        [FindsBy(How = How.LinkText, Using = "View")]
        public IWebElement View { get; set; }

        [FindsBy(How = How.LinkText, Using = "Ask")]
        public IWebElement Ask { get; set; }

        /// <summary>
        /// Methods for functioning on the elements.
        /// </summary>
        

        

        public void KbSearchTextBox()
        {
            KbSearch.SendKeys("ATX");
            Thread.Sleep(5000);
            ClicktKbSearch.Click();

        }

        public void PasswordCenterLink()
        {
            PasswordCenter.Click();
        }

        public void SearchLink()
        {
            Search.Click();
        }
        public void ViewLink()
        {
            View.Click();
        }

        public void AskLink()
        {
            Ask.Click();
        }

    }
}
