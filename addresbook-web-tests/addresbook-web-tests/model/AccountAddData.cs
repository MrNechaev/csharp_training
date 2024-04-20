using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class AccountAddData : IEquatable<AccountAddData>, IComparable<AccountAddData>
    {
        private string name;
        private string lastName;

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
            return name == other.name;
        }

        public int GetHashCode()
        {
            return name.GetHashCode();
        }

        public override string ToString()
        {
            return "name=" + name;
        }

        public int CompareTo(AccountAddData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }

            return name.CompareTo(other.name);
        }

        public AccountAddData(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
    }

    
}
