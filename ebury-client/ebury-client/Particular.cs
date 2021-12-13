using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebury_client
{
    class accountHolder
    {
        public name name;
        public addresses addresses;

        public accountHolder(string firstName, string lastName, string city,
            string street, string number, string postalCode, string country)
        {
            this.name = new name(firstName, lastName);
            this.addresses = new addresses(city, street, number, postalCode, country);
        }

        public override string ToString()
        {
            return "(" + name.firstName + ", " + name.lastName + ", " + addresses.city + ", " + addresses.street
                + ", " + addresses.number + ", " + addresses.postalCode + ", " + addresses.country+ ")";
        }
    }
}
