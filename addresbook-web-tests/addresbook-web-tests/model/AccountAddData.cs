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
        private string accountProperties;

        public AccountAddData()
        {
            
        }

        public AccountAddData(string name, string lastName, string address)
        {
            Name = name;
            LastName = lastName;
            Address = address;
        }       


        public string Name { get; set; }

        public string LastName { get; set; }
        public string Address { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string WorkPhone { get; set; }
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
                    return (Name + " " + LastName + "\r\n" + Address).Trim();
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
