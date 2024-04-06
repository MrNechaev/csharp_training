using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class AccountModifyTests : TestBase
    {
        [Test]
        public void AccountModifyTest()
        {
            AccountAddData newAccountData = new AccountAddData("TestName123", "TestLastName123");
            
            app.AccHelp.Modify(newAccountData);

        }
    }
}
