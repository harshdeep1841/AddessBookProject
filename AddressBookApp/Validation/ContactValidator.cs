using System.Text.RegularExpressions;
using AddressBook.Exceptions;
using AddressBook.Models;

namespace AddressBook.Validation;

public class ContactValidator
{
    public static bool IsValidName(string name)
    {
        return Regex.IsMatch(name, @"^[A-Z][a-zA-Z]{2,}$");
    }

    public static bool IsValidAddressPart(string value)
    {
        return Regex.IsMatch(value, @"^.{4,}$");
    }

    public static bool IsValidZip(string zip)
    {
        return Regex.IsMatch(zip, @"^[0-9]{6}$");
    }

    public static bool IsValidPhone(string phone)
    {
        return Regex.IsMatch(phone, @"^[0-9]{10}$");
    }

    public static bool IsValidEmail(string email)
    {
        return Regex.IsMatch(email,
            @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
    }
    
    
    public static void Validate(Contact contact)
    {
        if (!IsValidName(contact.FirstName))
            throw new InvalidContactException(
                "First name must start with a capital letter and be at least 3 characters.");

        if (!IsValidName(contact.LastName))
            throw new InvalidContactException(
                "Last name must start with a capital letter and be at least 3 characters.");

        if (!IsValidAddressPart(contact.Address))
            throw new InvalidContactException(
                "Address must contain at least 4 characters.");

        if (!IsValidAddressPart(contact.City))
            throw new InvalidContactException(
                "City must contain at least 4 characters.");

        if (!IsValidAddressPart(contact.State))
            throw new InvalidContactException(
                "State must contain at least 4 characters.");

        if (!IsValidZip(contact.Zip))
            throw new InvalidContactException(
                "Zip must contain exactly 6 digits.");

        if (!IsValidPhone(contact.PhoneNumber))
            throw new InvalidContactException(
                "Phone number must contain exactly 10 digits.");

        if (!IsValidEmail(contact.Email))
            throw new InvalidContactException(
                "Email format is invalid.");
    }
}