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
            if (IsloggedIn())
            {
                if (IsloggedIn(log))
                {
                    return;
                }
                Logout();
            }
            Type(By.Name("admin"), log.Username);
            Type(By.Name("secret"), log.Password);
            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }
        public void Logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }
        public bool IsloggedIn()
        {
            return IsElementPresent(By.Name("logout"));
        }

        public bool IsloggedIn(LoginData log)
        {
            return IsloggedIn()
                && driver.FindElement(By.Name("logout")).FindElement(By.TagName("b")).Text
                == "(" + log.Username + ")";
        }
    }
}
