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
        public static IEnumerable<AccountAddData> RandomAccountAddDataProvider()
        {
            List<AccountAddData> account = new List<AccountAddData>();
            for (int i = 0; i < 1; i++)
            {
                account.Add(new AccountAddData(GenerateRandomSting(30), GenerateRandomSting(30), GenerateRandomSting(100))
                {

                });
            }
            return account;
        }

        [Test, TestCaseSource("RandomAccountAddDataProvider")]
        public void AccountAddTest(AccountAddData account)
        {
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
