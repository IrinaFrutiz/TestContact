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
 
        private List<GroupData> groupCache = null;

        public List<GroupData> GetGroupList()
        {
            if (groupCache == null)
            {
                groupCache = new List<GroupData>();
                manager.Navi.GoToGroupPage();
                ICollection<IWebDriver> elements = driver.FindElements(By.CssSelector("span.group"));
                foreach (IWebDriver element in elements)
                {
                    groupCache.Add(new GroupData(element.Text)
                    {
                        Id = element.FindElement((By.TagName("input")).GetAttribute("value");
                });
            }
            return new List<GroupData>(groupCache);
        }
    
    public HelperGroup Create(GroupData group)
        { 
            CreateGroup();
            FillInfoInGroup(group);
            SubmitGroup();
            return this;
        }

        
        public HelperGroup Modification(int p, GroupData newData)
        {
            SelectGroup(p);
            InitGroupModif();
            FillInfoInGroup(newData);
            SubmitGroup();
            return this;
        }

        public int GetGroupCount()
        {
            return driver.FindElements(By.CssSelector("span.group")).Count;
        }

        public HelperGroup Remove(int p)
        {
            SelectGroup(p);
            DeleteGroup();
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
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + (index+1) + "]")).Click();
            driver.FindElement(By.Name("selected[]")).Click();
            return this;
        }

        public HelperGroup DeleteGroup()
        {
            driver.FindElement(By.XPath("(//input[@name='delete'])[2]")).Click();
            groupCache = null;
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
            groupCache = null;
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
            groupCache = null;
            return this;
        }

     

    }
}
