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
    public class TestModificationGroup : BaseTests 
    {
        public void Modification_Group_Test()
        {

            GroupData newData = new GroupData("test name", "test header", "test fooder");
            newData.Name = "new test name";
            newData.Header = "new0";
            newData.Footer = "new1";

            manager.Navi.GoToGroupPage();
            List<GroupData> oldgroups = manager.Groups.GetGroupList();
            GroupData oldData = oldgroups[0];
            manager.Groups.Modification(0, newData);
            manager.Navi.GoToGroupPage();

            List<GroupData> newgroups = manager.Groups.GetGroupList();

            Assert.AreEqual(oldgroups, manager.Groups.GetGroupCount());

            oldgroups[0].Name = newData.Name;
            oldgroups.Sort();
            newgroups.Sort();
            Assert.AreEqual(oldgroups, newgroups);

            foreach (GroupData group in newgroups)
            {
                if (group.Id == oldData.Id)
                {
                    Assert.AreEqual(newData.Name, group.Name);
                }
            }
            manager.Auth.Logout();
        }
    }
}
