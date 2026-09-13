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

        contacts.Add(contact);
    }

    public void PrintAll()
    {
        foreach (Contact contact in contacts)
        {
            Console.WriteLine(contact);
        }
    }
}