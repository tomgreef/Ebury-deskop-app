using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebury_client
{
    class Particular
    {
        public string firstName, lastName, birthDate, city, street, number, postalCode, country, nif;

        public Particular(string firstName, string lastName, string birthDate, string city,
            string street, string number, string postalCode, string country, string nif)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate.Substring(0, 10);
            this.city = city;
            this.street = street;
            this.number = number;
            this.postalCode = postalCode;
            this.country = country;
            this.nif = nif;
        }

        public override string ToString()
        {
            return "(" + firstName + ", " + lastName + ", " + birthDate + ", " + city + ", " + street + ", " +
                number + ", " + postalCode + ", " + country + ", " + nif + ")";
        }
    }
}
