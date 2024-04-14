using System;
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

            app.AccHelp.Modify(newAccountData, account);

        }
    }
}
