using System;
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
            GroupData newData = new GroupData("rr");
            newData.Header = "rr";
            newData.Footer = "rr";

            GroupData group = new GroupData("Групп не было");
            group.Header = "Групп не было";
            group.Footer = "Групп не было";

            app.Navigator.GoToGroupsPage();
            app.Groups.Modify(1, newData, group);
        }
    }
}
