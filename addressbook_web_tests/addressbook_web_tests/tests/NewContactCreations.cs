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
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.contactHelper.GoToContactsPage();
            ContactForm contact = new ContactForm("Zolotov");
            contact.Firstnameput = "Zolotov";
            contact.Lastnameput = "Dmitrii";
            app.contactHelper.FillContactForm(contact);
            app.contactHelper.SubmitContactCreations();
            app.contactHelper.ReturnToTheContactPage();
            app.Auth.Logout();
        }

     }
}
