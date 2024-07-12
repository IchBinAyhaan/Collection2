
namespace Book
{
    public class PhoneBook
        {
            private Dictionary<string, string> contacts = new Dictionary<string, string>();

        public void AddContact(string name, string phoneNumber)
        {
            contacts[name] = phoneNumber;
        }

        public void RemoveContact(string name)
        {
            contacts.Remove(name);
        }

        public string FindContactByName(string name)
            {
             if (contacts.ContainsKey(name))
             {
                 return contacts[name];
             }
             else
             {
                return null;
             }
             }
             public Dictionary<string, string> GetAllContacts()
              {
                return contacts;
              }
        }
}

