﻿using System;
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
    public class BaseTests 
    {
        protected ManagerAplication manager;

        [SetUp]
        public void SetupTest()
        {
            manager = TestSuiteFixture.manager;
        }
    }
}
