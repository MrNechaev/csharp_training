using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModficationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("rr");
            newData.Header = "rr";
            newData.Footer = "rr";

            app.Groups.Modify(1, newData);
        }
    }
}
