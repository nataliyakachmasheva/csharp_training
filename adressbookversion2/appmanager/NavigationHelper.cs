using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace adressbook_web_tests
{
    public class NavigationHelper :HelperBase
    {
       
        private string baseURL;

        public NavigationHelper(ApplicationManager manager, string baseURL )
            :base(manager)
        {
            this.baseURL = baseURL;
        }
        public void GoToHomePage()
        {
             //driver.Navigate().GoToUrl(baseURL);
           if (driver.Url == baseURL + "/addressbook/")
             {
                 return;
             }

             driver.Navigate().GoToUrl(baseURL + "/addressbook/");

        }

        public void GoToGroupsPage()
        {
          if (driver.Url == baseURL + "/addressbook/group.php"
                && IsElementPresent(By.Name("new")))
            {
                return;
            }

          driver.FindElement(By.LinkText("groups")).Click();
        }

    }
}
