using System;
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
            app.AccHelp.AddAccount(account);
        }
    }
}
