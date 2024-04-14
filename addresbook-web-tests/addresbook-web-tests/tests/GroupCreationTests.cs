﻿using System;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
     public class GroupCreationTests : AuthTestBase
    {

        [Test]
        public void GroupCreationTest()
        {
            GroupData group = new GroupData("q");
            group.Header = "q";
            group.Footer = "q";
            
            app.Navigator.GoToGroupsPage();
            app.Groups.Create(group);
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";
            
            app.Navigator.GoToGroupsPage();
            app.Groups.Create(group);
        }
    }
}
