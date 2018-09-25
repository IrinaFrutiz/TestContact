using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using System.Collections.Generic;
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
            manager.Navi.GoToGroupPage();
            List<GroupData> oldgroups = manager.Groups.GetGroupList();
            manager.Groups.Remove(0);
            manager.Navi.GoToGroupPage();

            List<GroupData> newgroups = manager.Groups.GetGroupList();

            Assert.AreEqual(oldgroups.Count - 1, manager.Groups.GetGroupCount());

            oldgroups.RemoveAt(0);
            oldgroups.Sort();
            newgroups.Sort();
            Assert.AreEqual(oldgroups, newgroups);

            foreach (GroupData group in newgroups)
            {
                Assert.AreNotEqual(group.Id, oldgroups[0].Id);
            }
            manager.Auth.Logout();

        }
    }
}
