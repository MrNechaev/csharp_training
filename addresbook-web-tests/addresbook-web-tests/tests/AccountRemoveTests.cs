﻿using System;
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

            app.AccHelp.RemoveFromEditPage(newAccountData);
        }

        [Test]
        public void RemoveFromMainPage()
        {
            AccountAddData newAccountData = new AccountAddData("TestName123", "TestLastName123");

            app.AccHelp.RemoveFromMainPage(newAccountData);
        }
    }
}
