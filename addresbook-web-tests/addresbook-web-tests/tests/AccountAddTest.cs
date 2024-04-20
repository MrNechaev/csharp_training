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
            AccountAddData account = new AccountAddData("TestName", "TestLastName");

            List<AccountAddData> oldAccounts = app.AccHelp.GetAccountList();

            app.AccHelp.AddAccount(account);

            List<AccountAddData> newAccounts = app.AccHelp.GetAccountList();
            Assert.AreEqual(oldAccounts.Count + 1, newAccounts.Count);
        }
    }
}
