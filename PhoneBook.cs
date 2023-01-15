using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class PhoneBook
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        public void AddContact(Contact contact) // dodanie kontaktu
        { 
            Contacts.Add(contact);
        }

        private void DisplayContactDetails(Contact contact) // metoda pomocnicza wyswietlajaca szczegoly kontaktu
        {
            Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
        }

        private void DisplayContactsDetails(List<Contact> contacts) // metoda pomocnicza wyswietlajaca listę kontaktów
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }

        public void DisplayContact(string number) // wyszukanie kontaktu po frazie
        {
            var contact = Contacts.FirstOrDefault(c => c.Number == number); // predykat

            if (contact == null) 
            {
                Console.WriteLine("Contact not found");
            }
            else 
            {
               DisplayContactDetails(contact);
            }
        }

        public void DisplayAllContacts() 
        {
            DisplayContactsDetails(Contacts);
        }

        public void DisplayMachingContacts(string searchPharse)
        {
            var machingContacts = Contacts.Where(c => c.Name.Contains(searchPharse)).ToList();
            DisplayContactsDetails(machingContacts);
        }
    }
}
