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
   public class Applicationmanager
    {
        protected IWebDriver driver;
        protected string baseURL;



        public LoginHelper loginHelper;
        public NavigationHelper navigator;
        public GroupHelper groupHelper;
        public ContactHelper contactHelper;

        public Applicationmanager()
        {

            driver = new FirefoxDriver();
            baseURL = "http://localhost/addressbook/addressbook";

            loginHelper = new LoginHelper(driver);
            navigator = new NavigationHelper(driver, baseURL);
            groupHelper = new GroupHelper(driver);
            contactHelper = new ContactHelper(driver, baseURL);
        }

        public void Stop()
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

        public LoginHelper Auth
        {
            get
            {
                return loginHelper;
            }

        }

        public NavigationHelper Navigator
        {
            get
            {
                return navigator;
            }
        }


        public GroupHelper Groups
        {
            get
            {
                return groupHelper;
            }
        }
        public ContactHelper ContactHelp
        {
            get
            {
                return contactHelper;
            }
        }
    }




}
