using AddressBook.Exceptions;
using AddressBook.Models;



AddressBook.Services.AddressBook addressBook = new AddressBook.Services.AddressBook();
while (true)
{
    Console.WriteLine();
    Console.WriteLine("===== ADDRESS BOOK =====");
    Console.WriteLine("1. Add Contact");
    Console.WriteLine("2. Show All Contacts");
    Console.WriteLine("0. Exit");
    Console.Write("Enter your choice: ");

    string? choice = Console.ReadLine();

    if (choice == "0")
    {
        break;
    }

    if (choice == "1")
    {
        try
        {
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine()!;

            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine()!;

            Console.Write("Enter address: ");
            string address = Console.ReadLine()!;

            Console.Write("Enter city: ");
            string city = Console.ReadLine()!;

            Console.Write("Enter state: ");
            string state = Console.ReadLine()!;

            Console.Write("Enter zip: ");
            string zip = Console.ReadLine()!;

            Console.Write("Enter phone number: ");
            string phoneNumber = Console.ReadLine()!;

            Console.Write("Enter email: ");
            string email = Console.ReadLine()!;

            Contact contact = new Contact(
                firstName,
                lastName,
                address,
                city,
                state,
                zip,
                phoneNumber,
                email
            );

            addressBook.AddContact(contact);

            Console.WriteLine("Contact added successfully.");
        }
        catch (InvalidContactException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
    else if (choice == "2")
    {
        addressBook.PrintAll();
    }
    else
    {
        Console.WriteLine("Invalid choice.");
    }
}