using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    public class AddingAccountToGroupTests : AuthTestBase
    {
        [Test]
        public void TestAddingContactToGroup()
        {

            app.AccHelp.NoAccountsToAdd();
            app.Groups.NoGroupsToAddAccounts();

            GroupData group = GroupData.GetAll()[0];
            List<ContactData> oldList = group.GetContacts();
            ContactData contact = ContactData.GetAll().Except(oldList).First();

            app.AccHelp.AddAccountToGroup(contact, group);

            List<ContactData> newList = group.GetContacts();
            oldList.Add(contact);
            newList.Sort();
            oldList.Sort();

            Assert.AreEqual(newList, oldList);

        }
    }
}
