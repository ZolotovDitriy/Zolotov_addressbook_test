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
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            GoToGroup();
            SelectGroup(1);
            DeleteGroup();
            GoGroupPage();
        }       
    }
}
