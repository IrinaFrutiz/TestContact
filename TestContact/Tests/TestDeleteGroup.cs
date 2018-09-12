using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Addressbook
{
    [TestFixture]
    public class TestDeleteGroup : BaseTests

    {
        [Test]
        public void Delete_Group_Test()
        {
            manager.Groups.Remove(1);
            manager.Auth.Logout();
        }
    }
}
