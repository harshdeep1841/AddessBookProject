using AddressBook.Exceptions;
using AddressBook.Models;
using AddressBook.Services;


// AddressBook.Services.AddressBook addressBook = new AddressBook.Services.AddressBook();
// while (true)
// {
//     Console.WriteLine();
//     Console.WriteLine("===== ADDRESS BOOK =====");
//     Console.WriteLine("1. Add Contact");
//     Console.WriteLine("2. Edit Contact");
//     Console.WriteLine("3. Delete Contact");
//     Console.WriteLine("4. Show All Contacts");
//     Console.WriteLine("0. Exit");
//     Console.Write("Enter your choice: ");
//
//     string? choice = Console.ReadLine();
//
//     if (choice == "0")
//     {
//         break;
//     }
//
//     else if (choice == "1")
//     {
//         try
//         {
//             Console.Write("Enter first name: ");
//             string firstName = Console.ReadLine()!;
//
//             Console.Write("Enter last name: ");
//             string lastName = Console.ReadLine()!;
//
//             Console.Write("Enter address: ");
//             string address = Console.ReadLine()!;
//
//             Console.Write("Enter city: ");
//             string city = Console.ReadLine()!;
//
//             Console.Write("Enter state: ");
//             string state = Console.ReadLine()!;
//
//             Console.Write("Enter zip: ");
//             string zip = Console.ReadLine()!;
//
//             Console.Write("Enter phone number: ");
//             string phoneNumber = Console.ReadLine()!;
//
//             Console.Write("Enter email: ");
//             string email = Console.ReadLine()!;
//
//             Contact contact = new Contact(
//                 firstName,
//                 lastName,
//                 address,
//                 city,
//                 state,
//                 zip,
//                 phoneNumber,
//                 email
//             );
//
//             addressBook.AddContact(contact);
//
//             Console.WriteLine("Contact added successfully.");
//         }
//         catch (InvalidContactException ex)
//         {
//             Console.WriteLine($"Error: {ex.Message}");
//         } 
//         
//     }
//     
//     else if (choice == "2")
//     {
//        Console.Write("Enter first name of contact to edit: ");
//        string firstName = Console.ReadLine()!;
//
//        Console.Write("Enter last name of contact to edit: ");
//        string lastName = Console.ReadLine()!;
//
//        try
//        {
//            addressBook.EditContact(firstName, lastName);
//        }
//        catch (InvalidContactException ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}");
//        }
//     }
//     
//     else if (choice == "3")
//     {
//         Console.Write("Enter first name of contact to delete: ");
//         string firstName = Console.ReadLine()!;
//
//         Console.Write("Enter last name of contact to delete: ");
//         string lastName = Console.ReadLine()!;
//
//         addressBook.DeleteContact(firstName, lastName);
//     }
//     
//     else if (choice == "4")
//     {
//         addressBook.PrintAll();
//     }
//     else
//     {
//         Console.WriteLine("Invalid choice.");
//     }
// }


AddressBook.Services.AddressBook book1 = new AddressBook.Services.AddressBook();

book1.AddContact(new Contact(
    "John",
    "Doe",
    "12 MG Road",
    "Pune",
    "Maharashtra",
    "411001",
    "9876543210",
    "john@mail.com"
));

book1.AddContact(new Contact(
    "Alice",
    "Smith",
    "45 FC Road",
    "Pune",
    "Maharashtra",
    "411002",
    "9876543211",
    "alice@mail.com"
));

AddressBook.Services.AddressBook book2 = new AddressBook.Services.AddressBook();

book2.AddContact(new Contact(
    "Bob",
    "Johnson",
    "10 Park Street",
    "Delhi",
    "Delhi",
    "110001",
    "9876543212",
    "bob@mail.com"
));


AddressBookMain main = new AddressBookMain();

main.AddAddressBook(book1);
main.AddAddressBook(book2);

Console.WriteLine(
    $"Total contacts: {main.GetTotalContactCount()}"
);