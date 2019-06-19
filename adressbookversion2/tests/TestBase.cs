using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace adressbook_web_tests
{
    public class TestBase 
    {
        

      /*  protected LoginHelper loginHelper;
        protected NavigationHelper navigator;
        protected GroupHelper groupHelper;*/

        protected ApplicationManager app;

        [SetUp]
        public void SetupTest()
        {
            /* driver = new FirefoxDriver();
             baseURL = "http://localhost/addressbook";
             verificationErrors = new StringBuilder();

             loginHelper = new LoginHelper(driver);
             navigator = new NavigationHelper(driver, baseURL);
             groupHelper = new GroupHelper(driver);*/

            app = new ApplicationManager();
        }

        [TearDown]
        public void TeardownTest()
        {
            app.Stop();
        }

               
    }
}
