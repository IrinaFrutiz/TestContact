using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Addressbook
{
    public class ManagerAplication
    {
        public IWebDriver driver;
        private StringBuilder verificationErrors;
        public string baseURL;
        public bool acceptNextAlert = true;

        protected HelperLogin helperLogin;
        protected HelperNavigation helperNavigation;
        protected HelperContact helperContact;
        protected HelperGroup helperGroup;

            ~ManagerAplication()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {

            }
            //Assert.AreEqual("", verificationErrors.ToString());
        }


        private static ThreadLocal<ManagerAplication> manager = new ThreadLocal<ManagerAplication>();

        public ManagerAplication ()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = @"c:\Ira\soft\Soft_for_test\FirefoxPortableESR\FirefoxPortable.exe";
            options.UseLegacyImplementation = true;
            driver = new FirefoxDriver(options);
            baseURL = "http://localhost";
            verificationErrors = new StringBuilder();

            helperLogin = new HelperLogin(this);
            helperNavigation = new HelperNavigation(this, baseURL);
            helperContact = new HelperContact(this);
            helperGroup = new HelperGroup(this);
        }

        public static ManagerAplication GetInstance()
        {
            if (!manager.IsValueCreated)
            {
                manager.Value = new ManagerAplication();
            }
            return manager.Value;
        }

        public IWebDriver Driver
        {
            get
            {
                return driver;
            } 
        }

        public HelperLogin Auth
        {
            get
            {
                return helperLogin;
            }
        }
        public HelperNavigation Navi
        {
            get
            {
                return helperNavigation;
            }
        }
        public HelperContact Contacts
        {
            get
            {
                return helperContact;
            }
        }
        public HelperGroup Groups
        {
            get
            {
                return helperGroup;
            }
        }
    }
}
