using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Form
{
    public class Customer
    {
        public string firstName { get; }
        public string lastName { get; }
        public string emailAddress { get; }

        public Customer(string first, string last, string email)
        {
            firstName = first;
            lastName = last;
            emailAddress = email;
        }
    }
}
