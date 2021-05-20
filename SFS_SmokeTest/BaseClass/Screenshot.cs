using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SFS_ATX.BaseClass
{
   public  class Screenshot
    {
        IWebDriver Driver;

        public MediaEntityModelProvider CaptureScreenshot(string name)
           {
            var screenshot = ((ITakesScreenshot)Driver).GetScreenshot().AsBase64EncodedString;
            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot,name).Build();
        
           }
    }
}
