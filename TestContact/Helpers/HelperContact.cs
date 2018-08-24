using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Addressbook
{
    public class HelperContact
    {
        private IWebDriver driver;
        public HelperContact (IWebDriver driver)
        { this.driver = driver; }
        public void AddContactInfo(ContactsData con)
        {
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(con.Firstname);
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(con.Lastname);
            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }
        public void SelectContact(int number)
        {
            driver.FindElement(By.Id("//input[@class='center[]'])[" + number + "]")).Click();
            //x-path voprosu //*[@id="maintable"]/tbody/tr[2]/td[1]
        }
    }
}
