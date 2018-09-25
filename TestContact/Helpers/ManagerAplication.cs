using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Addressbook
{
    public class ManagerAplication
    {
        protected IWebDriver driver;
        private StringBuilder verificationErrors;
        public string baseURL;

        protected HelperLogin helperLogin;
        protected HelperNavigation helperNavigation;
        protected HelperContact helperContact;
        protected HelperGroup helperGroup;
        private static ThreadLocal<ManagerAplication> app = new ThreadLocal<ManagerAplication>();
        
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
        ~ManagerAplication()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }
        public static ManagerAplication GetInstance()
        {
            if (!app.IsValueCreated)
            {
                ManagerAplication newInstance = new ManagerAplication() ;
                newInstance.Navi.GoToHomePage();
                app.Value = newInstance;
            }
            return app.Value;
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
