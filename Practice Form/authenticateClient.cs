using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Form
{
    public static class AuthenticateClient
    {
        public static string Authenticate(string firstName, string lastName, string emailAddress) {

        string first = firstName;
        string last = lastName;
        string email = emailAddress;

        if (first != "" && last != "" && email != "")
        {

            Customer customer = new Customer(first, last, email);
            string message = 
                    $"Customer created! FirstName: {customer.firstName}, LastName: {customer.lastName}, Email: {customer.emailAddress}";

                return message;
                    
        } else
        {
            string message = "";

            if (string.IsNullOrEmpty(first))
                message += "First Name Cannot be null or empty. ";
            if (string.IsNullOrEmpty(last))
                message += "LastName cannot be null or empty. ";
            if (string.IsNullOrEmpty(email))
                message += "Email cannot be null or empty. ";

                return message;
        }
    }

    }
}
