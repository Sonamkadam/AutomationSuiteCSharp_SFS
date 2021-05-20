using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SFS_ATX
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

        [FindsBy(How = How.LinkText, Using = "Manage")]
        public IWebElement Manage { get; set; }

        [FindsBy(How = How.LinkText, Using = "Bank")]
        public IWebElement Bank{ get; set; }

        [FindsBy(How = How.LinkText, Using = "Chat")]
        public IWebElement Chat { get; set; }

        [FindsBy(How = How.LinkText, Using = "Open")]
        public IWebElement Open { get; set; }

        [FindsBy(How = How.LinkText, Using = "Click")]
        public IWebElement Click { get; set; }

        [FindsBy(How = How.XPath, Using = "//img[@title='Download Tax Preparation Products, Tax Program Updates, PCR Payroll Products, PCR Program Updates']")]
        public IWebElement ATXProgramDownload { get; set; }
        /// <summary>
        /// Methods for functioning on the elements.
        /// </summary>

        public void KbSearchTextBox(String value)
        {
            KbSearch.SendKeys(value);
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

        public void ManageLink()
        {
            Manage.Click();

        }

        public void BankLink()
        {
            Bank.Click();
        }

        public void ChatLink()
        {
            Chat.Click();
        }

        public void OpenLink()
        {
            Open.Click();
        }

        public void ClickLink()
        {
            Click.Click();
        }

        public void ATXProgramDownloadsLink()
        {
            ATXProgramDownload.Click();
        }




    }
}
