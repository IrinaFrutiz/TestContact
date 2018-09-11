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

            manA.Groups.Create(group);
            manA.Auth.Logout();
        }
        [Test]
        public void Add_Empty_Group_Test()
        {
            GroupData group = new GroupData(null, null, null);

            manA.Groups.Create(group);
            manA.Auth.Logout();
        }
    }
}