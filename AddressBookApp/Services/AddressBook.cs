using AddressBook.Models;
using AddressBook.Validation;

namespace AddressBook.Services;

public class AddressBook
{
    private List<Contact> contacts = new();

    public IReadOnlyList<Contact> Contacts => contacts;

    public void AddContact(Contact contact)
    {
        ContactValidator.Validate(contact);
        
        bool alreadyExists = contacts.Any(c=>c.FirstName.Equals(contact.FirstName, StringComparison.OrdinalIgnoreCase) && c.LastName.Equals(contact.LastName, StringComparison.OrdinalIgnoreCase));

        if (alreadyExists)
        {
            Console.WriteLine("Contact already exists.");
            return;
        }
        contacts.Add(contact);
    }

    public void PrintAll()
    {
        foreach (Contact contact in contacts)
        {
            Console.WriteLine(contact);
        }
    }
    
    public void EditContact(string firstName, string lastName)
{
    Contact? contact = contacts.FirstOrDefault(c =>
        c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
        c.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase));

    if (contact == null)
    {
        Console.WriteLine("Contact not found.");
        return;
    }

    Console.Write($"Enter new first name ({contact.FirstName}): ");
    string? newFirstName = Console.ReadLine();

    Console.Write($"Enter new last name ({contact.LastName}): ");
    string? newLastName = Console.ReadLine();

    Console.Write($"Enter new address ({contact.Address}): ");
    string? newAddress = Console.ReadLine();

    Console.Write($"Enter new city ({contact.City}): ");
    string? newCity = Console.ReadLine();

    Console.Write($"Enter new state ({contact.State}): ");
    string? newState = Console.ReadLine();

    Console.Write($"Enter new zip ({contact.Zip}): ");
    string? newZip = Console.ReadLine();

    Console.Write($"Enter new phone number ({contact.PhoneNumber}): ");
    string? newPhoneNumber = Console.ReadLine();

    Console.Write($"Enter new email ({contact.Email}): ");
    string? newEmail = Console.ReadLine();

    if (!string.IsNullOrWhiteSpace(newFirstName))
        contact.FirstName = newFirstName;

    if (!string.IsNullOrWhiteSpace(newLastName))
        contact.LastName = newLastName;

    if (!string.IsNullOrWhiteSpace(newAddress))
        contact.Address = newAddress;

    if (!string.IsNullOrWhiteSpace(newCity))
        contact.City = newCity;

    if (!string.IsNullOrWhiteSpace(newState))
        contact.State = newState;

    if (!string.IsNullOrWhiteSpace(newZip))
        contact.Zip = newZip;

    if (!string.IsNullOrWhiteSpace(newPhoneNumber))
        contact.PhoneNumber = newPhoneNumber;

    if (!string.IsNullOrWhiteSpace(newEmail))
        contact.Email = newEmail;

    ContactValidator.Validate(contact);

    Console.WriteLine("Contact updated successfully.");
}
    
    
    public void DeleteContact(string firstName, string lastName)
    {
        Contact? contact = contacts.FirstOrDefault(c =>
            c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
            c.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase));

        if (contact == null)
        {
            Console.WriteLine("Contact not found.");
            return;
        }

        contacts.Remove(contact);

        Console.WriteLine("Contact deleted successfully.");
    }

}