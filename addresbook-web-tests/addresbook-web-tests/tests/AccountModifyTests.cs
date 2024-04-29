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
            AccountAddData newAccountData = new AccountAddData("TestName123", "TestLastName123", "AnotherAddress");
            AccountAddData account = new AccountAddData("TestName", "TestLastName");

            List<AccountAddData> oldAccounts = app.AccHelp.GetAccountList();

            app.AccHelp.Modify(newAccountData, account);

            List<AccountAddData> newAccounts = app.AccHelp.GetAccountList();
            oldAccounts[0].Name = newAccountData.Name;
            oldAccounts[0].LastName = newAccountData.LastName;
            oldAccounts[0].Address = newAccountData.Address;
            oldAccounts[0].HomePhone = newAccountData.HomePhone;
            oldAccounts[0].WorkPhone = newAccountData.WorkPhone;
            oldAccounts[0].MobilePhone = newAccountData.MobilePhone;
            oldAccounts[0].Email = newAccountData.Email;
            oldAccounts[0].Email_2 = newAccountData.Email_2;
            oldAccounts[0].Email_3 = newAccountData.Email_3;

            oldAccounts.Sort();
            newAccounts.Sort();
            Assert.AreEqual(oldAccounts, newAccounts);
        }
    }
}
