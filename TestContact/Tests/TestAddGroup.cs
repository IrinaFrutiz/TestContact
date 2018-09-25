using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;


namespace Addressbook
{
    [TestFixture]
    public class TestAddGroup : BaseTests
    {
        [Test]
        public void Add_Group_Test()
        {
            GroupData group = new GroupData("test name", "test header", "test fooder");
            manager.Navi.GoToGroupPage();
            List<GroupData> oldgroups = manager.Groups.GetGroupList();
            manager.Groups.Create(group);
            manager.Navi.GoToGroupPage();

            Assert.AreEqual(oldgroups.Count + 1, manager.Groups.GetGroupCount());

            List<GroupData> newgroups = manager.Groups.GetGroupList();
            oldgroups.Add(group);
            oldgroups.Sort();
            newgroups.Sort();
            Assert.AreEqual(oldgroups, newgroups);
        }
        [Test]
        public void Add_Empty_Group_Test()
        {
            GroupData group = new GroupData(null, null, null);

            manager.Navi.GoToGroupPage();
            List<GroupData> oldgroups = manager.Groups.GetGroupList();
            manager.Groups.Create(group);
            manager.Navi.GoToGroupPage();

            Assert.AreEqual(oldgroups.Count + 1, manager.Groups.GetGroupCount());

            List<GroupData> newgroups = manager.Groups.GetGroupList();
            oldgroups.Add(group);
            oldgroups.Sort();
            newgroups.Sort();

            Assert.AreEqual(oldgroups, newgroups);
        }
    }
}