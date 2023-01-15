namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("##### PhoneBook #####");

            Console.WriteLine("1. Add contact");
            Console.WriteLine("2. Display contact by number");
            Console.WriteLine("3. Display all contacts");
            Console.WriteLine("4. Search contacts");
            Console.WriteLine("0. Exit");

            var userInput = Console.ReadLine();

            var phoneBook = new PhoneBook();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Insert number");
                        var number = Console.ReadLine();
                        Console.WriteLine("Insert name");
                        var name = Console.ReadLine();

                        var newContact = new Contact(name, number);

                        phoneBook.AddContact(newContact);
                        break;

                    case "2":
                        Console.WriteLine("Insert number");
                        var numberToSearch = Console.ReadLine();

                        phoneBook.DisplayContact(numberToSearch);

                        break;

                    case "3":
                        phoneBook.DisplayAllContacts();
                        break;

                    case "4":
                        Console.WriteLine("Insert search phrase:");
                        var searchPhrase = Console.ReadLine();

                        phoneBook.DisplayMachingContacts(searchPhrase);
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }
                Console.WriteLine("Select operation:");
                userInput = Console.ReadLine();
            }        
        }
    }
}