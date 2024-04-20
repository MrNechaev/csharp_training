using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
     public class GroupRemovalTests : AuthTestBase
    {
       
        [Test]
        public void GroupRemovalTest()
        {
            GroupData group = new GroupData("Групп не было");
            group.Header = "Групп не было";
            group.Footer = "Групп не было";

            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Navigator.GoToGroupsPage();
            if (app.Groups.NoGroupsToAction())
            {
                app.Groups.Create(group);
            }
            app.Groups.RemoveGroup(0);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.RemoveAt(0);
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
