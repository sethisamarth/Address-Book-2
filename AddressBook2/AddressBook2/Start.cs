using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook2
{
    class Start
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book System!");
            Console.WriteLine("1.Enter to add the details");
            Console.WriteLine("2.Enter to modify the details");
            Console.WriteLine("3.Listing the details..");
            Console.WriteLine("4.Remove the details");
            Console.WriteLine("Enter a option");
            switch (Console.ReadLine())
            {
                case "1":
                    AddressBook.AddressBook.GetPerson();
                    AddressBook.AddressBook.ListingPeople();
                    break;
                case "2":
                    AddressBook.AddressBook.GetPerson();
                    AddressBook.AddressBook.Modify();
                    AddressBook.AddressBook.ListingPeople();
                    break;
                case "3":
                    AddressBook.AddressBook.GetPerson();
                    AddressBook.AddressBook.ListingPeople();
                    break;
                case "4":
                    AddressBook.AddressBook.GetPerson();
                    AddressBook.AddressBook.RemovePeople();

                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;
            }
        }
    }
}
