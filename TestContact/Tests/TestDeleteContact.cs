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
            manager.Contacts.DeleteContacts();
            manager.Navi.GoToHomePage();
            manager.Auth.Logout();
        }
        

    }
}
