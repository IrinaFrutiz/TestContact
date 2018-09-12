using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
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

            manager.Groups.Create(group);
            manager.Auth.Logout();
        }
        [Test]
        public void Add_Empty_Group_Test()
        {
            GroupData group = new GroupData(null, null, null);

            manager.Groups.Create(group);
            manager.Auth.Logout();
        }
    }
}