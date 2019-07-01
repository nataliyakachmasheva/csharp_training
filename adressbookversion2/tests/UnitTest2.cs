using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace adressbook_web_tests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]

        public void TestMethod1()
        {
            IWebDriver driver = null;
            int attempt = 0;

            do

            {
                System.Threading.Thread.Sleep(1000);
                attempt++;
            }
            while (driver.FindElements(By.Id("test")).Count == 0 && attempt < 60);
        }
    }
}
