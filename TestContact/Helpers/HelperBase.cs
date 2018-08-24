﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Addressbook
{
    public class Helper_Base : ManagerAplication
    {
        private ManagerAplication manager;
        protected IWebDriver driver;

        public Helper_Base(ManagerAplication manager)
        {
            this.manager = manager;
            this.driver = driver;
        }
    }
}