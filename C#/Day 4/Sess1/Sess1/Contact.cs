using System;
using System.Collections.Generic;
using System.Text;

namespace Sess1
{
    struct Contact
    {
        public Contact(string name, string phone)
        {
            this.Name = name;
            this.Phone = phone;
        }
        public string Name;
        public string Phone;
    }
}
