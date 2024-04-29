using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class AccountAddData : IEquatable<AccountAddData>, IComparable<AccountAddData>
    {
        private string allPhones;
        private string allEmails;
        private string accountProperties;

        public AccountAddData()
        {
            
        }

        public AccountAddData(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
            Address = "TestAddress";
            MobilePhone = "11111111";
            WorkPhone = "22222222";
            HomePhone = "33333333";
            Email = "email 1";
            Email_2 = "email 2";
            Email_3 = "email 3";
        }

        public AccountAddData(string name, string lastName, string address)
        {
            Name = name;
            LastName = lastName;
            Address = address;
            MobilePhone = "121212";
            WorkPhone = "32323223";
            HomePhone = "600000000";
            Email = "wrong email";
            Email_2 = "wrong email 2";
            Email_3 = "wrong email 3";
        }


        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string MobilePhone { get; set; }
        public string WorkPhone { get; set; }
        public string HomePhone { get; set; }
        public string Email { get; set; }
        public string Email_2 { get; set; }
        public string Email_3 { get; set; }

       
        public string AllPhones 
        { 
            get 
            {
                if (allPhones != null)
                {
                    return allPhones;
                }
                else
                {
                    return (CleanUp(HomePhone) + CleanUp(MobilePhone) + CleanUp(WorkPhone)).Trim();
                }
            } 
            set
            {
                allPhones = value;
            }
        }

        public string AllPhonesFromProperties
        {
            get
            {
                if (AllPhonesFromProperties != null)
                {
                    return AllPhonesFromProperties;
                }
                else
                { 
                    if (string.IsNullOrEmpty(HomePhone) && string.IsNullOrEmpty(MobilePhone) && string.IsNullOrEmpty(WorkPhone))
                    {
                        return "";
                    }
                    return (HomePhone + MobilePhone + WorkPhone) + "\r\n";
                }
            }
            set
            {
                AllPhonesFromProperties = value;
            }
        }

        public string AllEmails
        {
            get
            {
                if (allEmails != null)
                {
                    return allEmails;
                }
                else
                {
                    return (CleanUp(Email) + CleanUp(Email_2) + CleanUp(Email_3)).Trim();
                }
            }
            set
            {
                allEmails = value;
            }
        }

        public string AccountProperties
        {
            get
            {
                if (accountProperties != null)
                {
                    return accountProperties;
                }
                else
                {
                    return (Name + " " + LastName + "\r\n" + Address + "\r\n\r\nH: "
                            + HomePhone + "\r\nM: " + MobilePhone + "\r\nW: " + WorkPhone + "\r\n\r\n"
                            + Email + "\r\n" + Email_2 + "\r\n" + Email_3).Trim();
                }
            }
            set
            {
                accountProperties = value;
            }
        }

        private string CleanUp(string phone)
        {
            if (phone == null || phone == "")
            {
                return "";
            }

            return Regex.Replace(phone, "[ -()]", "") + "\r\n";
        }

        public bool Equals(AccountAddData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }
            return Name == other.Name && LastName == other.LastName;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override string ToString()
        {
            return "name" + Name + "\nlastname" + LastName + "\naddress" + Address;
        }

        public int CompareTo(AccountAddData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }
            int compareResult = LastName.CompareTo(other.LastName);
            if (compareResult != 0) {
                return compareResult; }
            return Name.CompareTo(other.Name);
        }

      

    }
}
