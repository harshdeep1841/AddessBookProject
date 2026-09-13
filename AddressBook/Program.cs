using AddressBook.Exceptions;
using AddressBook.Models;
using AddressBook.Validation;

try
{
    Contact contact = new Contact(
        "John",
        "Doe",
        "12 MG Road",
        "Pune",
        "Maharashtra",
        "411001",
        "9876543210",
        "john.doe@mail.com"
    );

    ContactValidator.Validate(contact);

    Console.WriteLine("Contact is valid.");
    Console.WriteLine(contact);
}
catch (InvalidContactException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}