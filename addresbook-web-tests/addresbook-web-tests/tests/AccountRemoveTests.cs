using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class AccountRemoveTests : TestBase
    {
        [Test]
        public void RemoveFromEditPage()
        {
            app.AccHelp.RemoveFromEditPage();
        }

        [Test]
        public void RemoveFromMainPage()
        {
            app.AccHelp.RemoveFromMainPage();
        }
    }
}
