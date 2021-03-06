﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_tests
{
    public class NavigationHelper : HelperBase
    {

        public string baseURL;
        

        public NavigationHelper(IWebDriver driver, string baseURL) : base(driver)
        {
            this.baseURL = baseURL;
        }



        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl(baseURL);
        }




        public void GoGroupPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
        }




        public void GoToGroup()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }



        public void GoToGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();

        }




        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl(baseURL);
        }

    }
}
