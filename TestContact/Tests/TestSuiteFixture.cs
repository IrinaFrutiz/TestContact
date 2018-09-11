using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Addressbook
{
    [SetUpFixture]
    public class TestSuiteFixture
    {
        
        [SetUp]
        public void InitAppManager()
        {
            ManagerAplication manA = new ManagerAplication.GetInstance();

            manA.Navi.GoToPage();
            manA.Auth.Login(new LoginData("admin", "secret"));
        }
        
    }
}
