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
    public class AccountModifyTests : AuthTestBase
    {
        [Test]
        public void AccountModifyTest()
        {
            AccountAddData newAccountData = new AccountAddData("TestName123", "TestLastName123");
            AccountAddData account = new AccountAddData("TestName", "TestLastName");

            List<AccountAddData> oldAccounts = app.AccHelp.GetAccountList();

            app.AccHelp.Modify(newAccountData, account);

            List<AccountAddData> newAccounts = app.AccHelp.GetAccountList();
            oldAccounts[0].Name = newAccountData.Name;
            oldAccounts[0].LastName = newAccountData.LastName;
            oldAccounts.Sort();
            newAccounts.Sort();
            Assert.AreEqual(oldAccounts, newAccounts);

        }
    }
}
