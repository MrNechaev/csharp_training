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
     public class AccountAddTests : AuthTestBase
    {

        [Test]
        public void AccountAddTest()
        {
            AccountAddData account = new AccountAddData("TestName", "TestLastName", "TestAddress");

            List<AccountAddData> oldAccounts = app.AccHelp.GetAccountList();

            app.AccHelp.AddAccount(account);

            Assert.AreEqual(oldAccounts.Count + 1, app.AccHelp.GetAccountCount());

            List<AccountAddData> newAccounts = app.AccHelp.GetAccountList();
            oldAccounts.Add(account);
            oldAccounts.Sort();
            newAccounts.Sort();
            Assert.AreEqual(oldAccounts, newAccounts);
        }
    }
}
