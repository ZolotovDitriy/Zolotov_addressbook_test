using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class NewContactCreations : TestBase
    {
        
        [Test]
        public void TheNewContactCreationsTest()
        {
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            GoToContactsPage();
            ContactForm contact = new ContactForm("Zolotov");
            contact.Firstnameput = "Zolotov";
            contact.Lastnameput = "Dmitrii";
            FillContactForm(contact);
            SubmitContactCreations();
            ReturnToTheContactPage();
            Logout();
        }

     }
}
