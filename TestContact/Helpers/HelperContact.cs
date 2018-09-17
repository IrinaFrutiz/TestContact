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
        public HelperContact AddContactInfo(ContactsData con)
        {
            Type(By.Name("firstname"), con.Firstname);
            Type(By.Name("lastname"), con.Lastname);
            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
            return this;
        }
        public HelperContact SelectContact()
        {
            driver.FindElement(By.CssSelector("input[name=\"selected[]\"]")).Click();
            return this;
        }
        public HelperContact DeleteContacts()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            driver.SwitchTo().Alert().Accept();
            return this;
        }
    }
}
