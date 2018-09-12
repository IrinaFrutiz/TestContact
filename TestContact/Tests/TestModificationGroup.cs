using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Addressbook
{
    [TestFixture]
    public class TestModificationGroup : BaseTests 
    {
        public void Modification_Group_Test()
        {

            GroupData newData = new GroupData("test name", "test header", "test fooder");
            newData.Name = "new test name";
            newData.Header = null;
            newData.Footer = "new1";

            manager.Groups.Modification(1, newData);
            manager.Auth.Logout();
        }
    }
}
