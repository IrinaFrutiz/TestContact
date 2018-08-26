using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Addressbook
{
    public class HelperLogin : HelperBase
    {
        public HelperLogin (ManagerAplication manager) :
            base(manager)
        {  }
        public void Login(LoginData log)
        {
            Type(By.Name("user"), log.Username);
            Type(By.Name("pass"), log.Password);
            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }
        public void Logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }
    }
}
