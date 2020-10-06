using System;

namespace Address_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            Address_book address_book = new Address_book();
            address_book.AddContact ("nairit", "prachanda", "Sivaji nagar", "visakhapatnam", "AP", 530046, 8179263777, "nanana") ;
            address_book.ViewContact();
        }
    }
}
