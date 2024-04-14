using System;
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

            app.Navigator.GoToGroupsPage();
            app.Groups.RemoveGroup(1, group);
        }
    }
}
