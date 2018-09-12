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
    public class HelperContact : HelperBase
    {
        public HelperContact(ManagerAplication manager)
            : base(manager)
        {
        }
        public void AddContactInfo(ContactsData con)
        {
            Type(By.Name("firstname"), con.Firstname);
            Type(By.Name("lastname"), con.Lastname);
            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }
        public void SelectContact(int number)
        {
            driver.FindElement(By.XPath("//input[@name='selected[]'])[" + number + "]")).Click();
            //x-path voprosu //*[@id="maintable"]/tbody/tr[2]/td[1]
        }
    }
}
