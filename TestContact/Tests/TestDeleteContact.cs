using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Addressbook
{
    [TestFixture]
    public class TestDeleteContact : BaseTests
    {
        
        [Test]
        public void DeleteContact()
        {
            //manA.Contacts.SelectContact(10);
            //DeleteContacts();
            manA.Navi.GoToHomePage();
            manA.Auth.Logout();
        }
        //public void DeleteContacts()
       // {
        //    driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
        //    Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(), "^Delete 1 addresses[\\s\\S]$"));
       // }
       // private string CloseAlertAndGetItsText()
        //{
         //   try
          //  {
           //     IAlert alert = driver.SwitchTo().Alert();
           //     string alertText = alert.Text;
           //     if (acceptNextAlert)
           //     {
           //         alert.Accept();
           //     }
           //     else
           //     {
           //         alert.Dismiss();
           //     }
           //     return alertText;
           // }
           // finally
           // {
           //     acceptNextAlert = true;
           // }
        
    }
}
