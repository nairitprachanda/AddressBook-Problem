using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Address_Book
{
    class Address_book
    {
        private Dictionary<string, Contacts> address_book = new Dictionary<string, Contacts>();
        public void AddContact(string FirstName, string LastName, string address, string city, string state, int zip, long PhoneNumber, string email)
        {
            Contacts contact = new Contacts();
            contact.FirstName = FirstName;
            contact.LastName = LastName;
            contact.address = address;
            contact.city = city;
            contact.state = state;
            contact.zip = zip;
            contact.PhoneNumber = PhoneNumber;
            contact.email = email;
            address_book.Add(contact.FirstName, contact);

        }
        public void ViewContact()
        {
            foreach (KeyValuePair<string, Contacts> item in address_book)
            {
                Console.WriteLine("First Name: " + item.Value.FirstName);
                Console.WriteLine("Last Name: " + item.Value.LastName);
                Console.WriteLine("Address: " + item.Value.address);
                Console.WriteLine("City: " + item.Value.city);
                Console.WriteLine("State: " + item.Value.state);
                Console.WriteLine("Zip: " + item.Value.zip);
                Console.WriteLine("Phone Number: " + item.Value.PhoneNumber);
                Console.WriteLine("Email: " + item.Value.email);
            }
        }
    }
}
