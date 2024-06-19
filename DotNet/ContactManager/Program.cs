using System.Text.Json;

namespace ContactManager
{
    class Program
    {
        static void Main(string[] args)
        {
            // määritetään tietokantatiedoston nimi ja alustetaan lista, johon tiedot luetaan
            string filePath = "contacts.json";
            List<Contact> contacts = [];

            // yritetään lukea JSON-tiedosto levystä, jos se löytyy
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                contacts = JsonSerializer.Deserialize<List<Contact>>(json) ?? [];
            }

            while (true)
            {
                Console.WriteLine("Contact Manager");
                Console.WriteLine("1. Add a new contact");
                Console.WriteLine("2. List all contacts");
                Console.WriteLine("3. Search contacts by name");
                Console.WriteLine("4. Delete a contact");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                
                switch (Console.ReadLine())
                {
                    case "1":
                        AddContact(contacts, filePath);
                        break;
                    case "2":
                        ListContacts(contacts);
                        break;
                    case "3":
                        SearchContacts(contacts);
                        break;
                    case "4":
                        DeleteContact(contacts, filePath);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void AddContact(List<Contact> contacts, string filePath)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine() ?? "";
            Console.Write("Enter email: ");
            string email = Console.ReadLine() ?? "";
            Console.Write("Enter phone: ");
            string phone = Console.ReadLine() ?? "";

            contacts.Add(new Contact { Name = name, Email = email, Phone = phone });
            File.WriteAllText(filePath, JsonSerializer.Serialize(contacts));
        }

        static void ListContacts(List<Contact> contacts)
        {
            Console.WriteLine("Contacts:");
            foreach (var contact in contacts.OrderBy(c => c.Name))
            {
                Console.WriteLine($"Name: {contact.Name}, Email: {contact.Email}, Phone: {contact.Phone}");
            }
        }

        static void SearchContacts(List<Contact> contacts)
        {
            Console.Write("Enter name to search: ");
            string searchName = Console.ReadLine() ?? "";
            var matchingContacts = contacts.Where(c => c.Name.Contains(searchName, StringComparison.OrdinalIgnoreCase)).ToList();

            if (matchingContacts.Any())
            {
                Console.WriteLine("Matching contacts:");
                foreach (var contact in matchingContacts)
                {
                    Console.WriteLine($"Name: {contact.Name}, Email: {contact.Email}, Phone: {contact.Phone}");
                }
            }
            else
            {
                Console.WriteLine("No contacts found.");
            }
        }

        static void DeleteContact(List<Contact> contacts, string filePath)
        {
            Console.Write("Enter name of the contact to delete: ");
            string nameToDelete = Console.ReadLine() ?? "";
            var contactToDelete = contacts.FirstOrDefault(c => c.Name.Equals(nameToDelete, StringComparison.OrdinalIgnoreCase));

            if (contactToDelete != null)
            {
                contacts.Remove(contactToDelete);
                File.WriteAllText(filePath, JsonSerializer.Serialize(contacts));
                Console.WriteLine("Contact deleted.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }
    }

    class Contact
    {
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
    }
}
