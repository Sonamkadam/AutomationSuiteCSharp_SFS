using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SFS_SmokeTest.BaseClass
{
 
    public  class TestData
    {
        [Test]
        public void fileread()
        {
            FileStream fs = new FileStream("C:\\FileStreamautomation\\sonam.xls", FileMode.Open);
            fs.Close();
            Console.WriteLine("done");

        }
    }
}
