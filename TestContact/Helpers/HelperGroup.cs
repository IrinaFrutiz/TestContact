using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Addressbook
{
    public class HelperGroup : HelperBase
    {
        public HelperGroup (ManagerAplication manager) 
            : base (manager)
        {
        }

        public HelperGroup Modification(int p, GroupData newData)
        {
            manager.Navi.GoToGroupPage();
            SelectGroup(p);
            InitGroupModif();
            FillInfoInGroup(newData);
            SubmitGroup();
            manager.Navi.GoToGroupPage();
            return this;
        }
        public HelperGroup Remove(int p)
        {
            manager.Navi.GoToGroupPage();
            SelectGroup(p);
            DeleteGroup();
            manager.Navi.GoToGroupPage();
            return this;
        }

        public HelperGroup Create(GroupData group)
        {
            manager.Navi.GoToGroupPage();
            CreateGroup();
            FillInfoInGroup(group);
            SubmitGroup();
            manager.Navi.GoToGroupPage();
            return this;
        }

        public HelperGroup GroupCreationTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {

            }
            //Assert.AreEqual("", verificationErrors.ToString());
            return this;
        }

 
        public HelperGroup SelectGroup(int index)
        {
            driver.FindElement(By.Name("selected[]")).Click();
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            driver.FindElement(By.Name("selected[]")).Click();
            return this;
        }

        public HelperGroup DeleteGroup()
        {
        driver.FindElement(By.XPath("(//input[@name='delete'])[2]")).Click();
            return this;
        }
        public HelperGroup InitGroupModif()
        {
            driver.FindElement(By.XPath("(//input[@name='update']")).Click();
            return this;
        }
        
        public HelperGroup SubmitGroup()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }

        public HelperGroup FillInfoInGroup(GroupData group)
        {
            Type(By.Name("group_name"), group.Name);
            Type(By.Name("group_header"), group.Header);
            Type(By.Name("group_footer"), group.Footer);
            return this;
        }

        public HelperGroup CreateGroup()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }
    }
}
