using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace Addressbook
{
    [TestFixture]
    public class TestAddContacts : BaseTests
    {
        

        [Test]
        public void AddNewContactTest()
        {
            manager.Navi.GoToAddNewContact();
            ContactsData con = new ContactsData("aaa", "bbb");
            con.Lastname = "111";
            con.Firstname = "222";
            manager.Contacts.AddContactInfo(con);
            manager.Navi.GoToHomePage();
            manager.Auth.Logout();
        }
    }
}
