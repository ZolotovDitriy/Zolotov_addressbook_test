using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_tests
{
    public class TestBase
    {

        protected Applicationmanager app;

        [SetUp]
        public void SetupTest()
        {
            app = new Applicationmanager();
        }

        [TearDown]
        public void TeardownTest()
        {
            app.Stop();
        }


    }

}
