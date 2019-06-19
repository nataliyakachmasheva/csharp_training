using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace adressbook_web_tests
{
    public class ApplicationManager
    {
        protected IWebDriver driver;
        protected string baseURL;

        protected LoginHelper loginHelper;
        protected NavigationHelper navigator;
        protected GroupHelper groupHelper;



        public ApplicationManager()

        {
            loginHelper = new LoginHelper(driver);
            navigator = new NavigationHelper(driver, baseURL);
            groupHelper = new GroupHelper(driver);
        }

        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            
        }
      

        public LoginHelper Auth
        {
              get
              {
                return loginHelper;
              }
        }

        public NavigationHelper Navigator
        {
              get
              {
                return navigator;
              }
        }

        public GroupHelper Groups
        {
            get
            {
                return groupHelper;
            }
        }

    }
}
