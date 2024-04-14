using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class AccountRemoveTests : AuthTestBase
    {
        [Test]
        public void RemoveFromEditPage()
        {

            AccountAddData newAccountData = new AccountAddData("TestName123", "TestLastName123");

            if (app.AccHelp.NoAccountsToAction())
            {
                app.AccHelp.AddAccount(newAccountData);
            }

            app.AccHelp.RemoveFromEditPage();
        }

        [Test]
        public void RemoveFromMainPage()
        {
            AccountAddData newAccountData = new AccountAddData("TestName123", "TestLastName123");

            if (app.AccHelp.NoAccountsToAction())
            {
                app.AccHelp.AddAccount(newAccountData);
            }

            app.AccHelp.RemoveFromMainPage();
        }
    }
}
