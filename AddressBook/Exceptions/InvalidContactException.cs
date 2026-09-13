namespace AddressBook.Exceptions;

public class InvalidContactException : Exception
{
    public InvalidContactException(string message)
        : base(message)
    {
        
    }
}