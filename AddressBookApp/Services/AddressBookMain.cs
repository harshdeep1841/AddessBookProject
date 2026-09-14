using AddressBook.Models;

namespace AddressBook.Services;

public class AddressBookMain
{
    private List<AddressBook> books = new();

    public void AddAddressBook(AddressBook addressBook)
    {
        books.Add(addressBook);
    }

    public int GetTotalContactCount()
    {
        return books.Sum(book => book.Contacts.Count);
    }
    
    public List<Contact> SearchByCity(string city)
    {
        return books
            .SelectMany(book => book.Contacts)
            .Where(contact =>
                contact.City.Equals(city, StringComparison.OrdinalIgnoreCase))
            .ToList();
        
    }

}