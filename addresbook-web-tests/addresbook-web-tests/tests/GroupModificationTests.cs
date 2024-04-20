using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModficationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("Изменил имя");
            newData.Header = "Изменил хэдер";
            newData.Footer = "Изменил футтер";

            GroupData group = new GroupData("Групп не было");
            group.Header = "Групп не было";
            group.Footer = "Групп не было";

            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Navigator.GoToGroupsPage();
            if (app.Groups.NoGroupsToAction())
            {
                app.Groups.Create(group);
            }

            app.Groups.Modify(0, newData);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups[0].Name = newData.Name;
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
