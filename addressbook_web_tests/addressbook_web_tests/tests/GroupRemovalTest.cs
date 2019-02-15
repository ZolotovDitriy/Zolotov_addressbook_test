using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {

        [Test]
        public void TheGroupRemovalTestsTest()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToGroup();
            app.Groups.SelectGroup(1);
            app.Groups.DeleteGroup();
            app.Navigator.GoGroupPage();
        }       
    }
}
