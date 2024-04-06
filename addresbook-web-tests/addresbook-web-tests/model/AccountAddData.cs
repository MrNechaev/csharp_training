using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class AccountAddData
    {
        private string name;
        private string lastName;

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
