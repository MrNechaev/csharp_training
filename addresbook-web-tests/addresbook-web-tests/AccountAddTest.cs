﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
     public class AccountAddTests : TestBase
    {

        [Test]
        public void AccountAddTest()
        {
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            InitAccoutAdd();
            AccountAddData account = new AccountAddData("TestName", "TestLastName");
            FillNewAccountInfo(account);
            SubmitAccountAdd();
        }
    }
}
