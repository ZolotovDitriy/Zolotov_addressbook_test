using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;



namespace addressbook_web_tests
{
    public class ContactHelper : HelperBase
    {

       public string baseURL;

        public ContactHelper(IWebDriver driver, string baseURL) : base(driver)
        {
            this.baseURL = baseURL;
        }


        public void GoToContactsPage()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }

        public void ReturnToTheContactPage()
        {
            driver.FindElement(By.LinkText("home page")).Click();
        }

        public void SubmitContactCreations()
        {
            driver.FindElement(By.XPath("//input[21]")).Click();
        }


        public void FillContactForm(ContactForm contact)
        {
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contact.Firstnameput);
            driver.FindElement(By.Name("lastname")).Click();
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contact.Lastnameput);
        }


        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl(baseURL);
        }




    }
}
