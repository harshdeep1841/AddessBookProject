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

    public void ViewByCityOrState()
    {
        var groups = books
            .SelectMany(book => book.Contacts)
            .GroupBy(contact => new
            {
                contact.City,
                contact.State
            });

        foreach (var group in groups)
        {
            Console.WriteLine();
            Console.WriteLine($"{group.Key.City}, {group.Key.State}");

            foreach (Contact contact in group)
            {
                Console.WriteLine($"{contact}");
            }
        }
    }

    public void CountCityOrState()
    {
        var groups = books
            .SelectMany(book => book.Contacts).GroupBy(contact => new
            {
                contact.City,
                contact.State
            });
        foreach (var group in groups)
        {
            Console.WriteLine();
            Console.WriteLine($"{group.Key.City}, {group.Key.State} , {group.Count()}");
        }
    }
    
    public List<Contact> SortByName()
    {
        return books
            .SelectMany(book => book.Contacts)
            .OrderBy(contact => contact.FirstName)
            .ThenBy(contact => contact.LastName)
            .ToList();
    }
    
    public List<Contact> SortByCity()
    {
        return books
            .SelectMany(book => book.Contacts)
            .OrderBy(contact => contact.City)
            .ToList();
    }

    public List<Contact> SortByState()
    {
        return books
            .SelectMany(book => book.Contacts)
            .OrderBy(contact => contact.State)
            .ToList();
    }

    public List<Contact> SortByZip()
    {
        return books
            .SelectMany(book => book.Contacts)
            .OrderBy(contact => contact.Zip)
            .ToList();
    }

   


}