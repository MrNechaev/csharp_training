using System;
using System.Collections.Generic;
using System.Security.Cryptography;
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

            AccountAddData newAccountData = new AccountAddData("TestName123", "TestLastName123", "AnotherTestAddress");

            List<AccountAddData> oldAccounts = app.AccHelp.GetAccountList();

            if (app.AccHelp.NoAccountsToAction())
            {
                app.AccHelp.AddAccount(newAccountData);
            }

            app.AccHelp.RemoveFromEditPage();
            app.Navigator.OpenHomePage();

            List<AccountAddData> newAccounts = app.AccHelp.GetAccountList();
            Assert.AreEqual(oldAccounts.Count - 1, newAccounts.Count);
        }

        [Test]
        public void RemoveFromMainPage()
        {
            AccountAddData newAccountData = new AccountAddData("TestName123", "TestLastName123", "AnotherTestAddress");

            List<AccountAddData> oldAccounts = app.AccHelp.GetAccountList();

            if (app.AccHelp.NoAccountsToAction())
            {
                app.AccHelp.AddAccount(newAccountData);
            }

            app.AccHelp.RemoveFromMainPage();
            app.Navigator.OpenHomePage();

            List<AccountAddData> newAccounts = app.AccHelp.GetAccountList();
            Assert.AreEqual(oldAccounts.Count - 1, newAccounts.Count);
        }
    }
}
