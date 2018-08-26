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
            manA.Navi.GoToAddNewContact();
            ContactsData con = new ContactsData("aaa", "bbb");
            con.Lastname = "111";
            con.Firstname = "222";
            manA.Contacts.AddContactInfo(con);
            manA.Navi.GoToHomePage();
            manA.Auth.Logout();
        }
    }
}
