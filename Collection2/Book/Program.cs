using Book;

public class Program
{
    public static void Main()
    {
        PhoneBook phoneBook = new PhoneBook();

        phoneBook.AddContact("Ayhan", "055-550-17-75");
        phoneBook.AddContact("Bayram", "055-712-12-12");

        Console.WriteLine("All Contacts:");
        foreach (var contact in phoneBook.GetAllContacts())
        {
            Console.WriteLine($"{contact.Key}:{contact.Value}");
        }
        Console.WriteLine("Remove a contact:");
        phoneBook.RemoveContact(Console.ReadLine());
        Console.WriteLine("Find a contact:");
        Console.WriteLine(phoneBook.FindContactByName(Console.ReadLine()));
       
    }
}