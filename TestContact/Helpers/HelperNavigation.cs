using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Addressbook
{
    public class HelperNavigation : HelperBase
    {
        public string baseURL;
        public HelperNavigation (ManagerAplication manager, string baseURL) :
            base(manager)
        { 
            this.baseURL = baseURL;
        }
        public void GoToPage()
        {
            driver.Navigate().GoToUrl(baseURL + "/addressbook/");
        }
        public void GoToHomePage()
        {
            if (driver.Url == baseURL + "/addressbook/")
            {
                return;
            }
            driver.FindElement(By.LinkText("home")).Click();
        }

        public void GoToAddNewContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }
        public void GoToGroupPage()
        {
            if (driver.Url == baseURL + "/addressbook/group.php"
                && IsElementPresent(By.Name("new"))
                {
                return;
                 }
            driver.FindElement(By.LinkText("groups")).Click();
        }
    }
}
