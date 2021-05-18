using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Text;

namespace SFS_SmokeTest.BaseClass
{
    public class Extentreport

    {
        public void reports()
        {
            ExtentReports extent = null;
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Automation Framework\GitHub\AutomationSuiteCSharp_SFS\SFS_SmokeTest\Reports\");
            extent.AttachReporter(htmlReporter);
        }
       
    }
}
