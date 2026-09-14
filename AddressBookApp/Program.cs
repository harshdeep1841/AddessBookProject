using AddressBook.Exceptions;
using AddressBook.Models;
using AddressBook.Services;

AddressBook.Services.AddressBook book1 = new AddressBook.Services.AddressBook();

AddressBook.Services.AddressBook book2 = new AddressBook.Services.AddressBook();

AddressBookMain main = new AddressBookMain();


main.AddAddressBook(book1);
main.AddAddressBook(book2);


while (true)
{
    Console.WriteLine();
    Console.WriteLine("===== ADDRESS BOOK =====");
    Console.WriteLine("1. Add Contact");
    Console.WriteLine("2. Edit Contact");
    Console.WriteLine("3. Delete Contact");
    Console.WriteLine("4. Show All Contacts");
    Console.WriteLine("5. Total Contact Count");
    Console.WriteLine("6. Search by City");
    Console.WriteLine("7. Search by State");
    Console.WriteLine("8. Visit by State Or City");
    Console.WriteLine("0. Exit");
    Console.Write("Enter your choice: ");

    string? choice = Console.ReadLine();

    if (choice == "0")
    {
        break;
    }

    else if (choice == "1")
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

            book1.AddContact(contact);

            Console.WriteLine("Contact added successfully.");
        }
        catch (InvalidContactException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    else if (choice == "2")
    {
        Console.Write("Enter first name of contact to edit: ");
        string firstName = Console.ReadLine()!;

        Console.Write("Enter last name of contact to edit: ");
        string lastName = Console.ReadLine()!;

        try
        {
            book1.EditContact(firstName, lastName);
        }
        catch (InvalidContactException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    else if (choice == "3")
    {
        Console.Write("Enter first name of contact to delete: ");
        string firstName = Console.ReadLine()!;

        Console.Write("Enter last name of contact to delete: ");
        string lastName = Console.ReadLine()!;

        book1.DeleteContact(firstName, lastName);
    }

    else if (choice == "4")
    {
        Console.WriteLine();
        Console.WriteLine("===== ALL CONTACTS =====");

        foreach (Contact contact in book1.Contacts)
        {
            Console.WriteLine(contact);
        }
    }

    else if (choice == "5")
    {
        Console.WriteLine(
            $"Total contacts: {main.GetTotalContactCount()}"
        );
    }

    else if (choice == "6")
    {
        Console.Write("Enter city to search: ");
        string city = Console.ReadLine()!;

        List<Contact> results = main.SearchByCity(city);

        if (results.Count == 0)
        {
            Console.WriteLine("No contacts found.");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"Contacts found in {city}:");

            foreach (Contact contact in results)
            {
                Console.WriteLine(contact);
            }
        }
    }

    else if (choice == "7")
    {
        Console.Write("Enter city to search: ");
        string city = Console.ReadLine()!;

        List<Contact> results = main.SearchByCity(city);

        if (results.Count == 0)
        {
            Console.WriteLine("No contacts found.");
        }
        else
        {
            Console.WriteLine();
            
            Console.WriteLine($"Contacts found in {city}:");

            foreach (Contact contact in results)
            {
                Console.WriteLine(contact);
            }
        }
    }
    
    else if (choice == "8")
    {
        Console.WriteLine("Contacts Grouped by City or State");
        main.ViewByCityOrState();
    }

    else
    {
        Console.WriteLine("Invalid choice.");
    }
}