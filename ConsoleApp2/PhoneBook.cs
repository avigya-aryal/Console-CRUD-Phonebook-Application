using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class PhoneBook
    {
        // in this phonebook, the contacts are stored in list.
        private List<Contact> contactList { get; set; } = new List<Contact>();  

        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.name}, {contact.number}");
        }

        public void AddContact(Contact contact)
        {
            contactList.Add(contact);
        }

        public void DisplayAllContact()
        {
            foreach (var contact in contactList)
            {
                DisplayContactDetails(contact);
            }
        }

        /* the lamda expression is used here to search for a number that resides in 
         * contactlist, if the residing number matches with the searched digits,
         * the contact is then updated, the same logic can be seen in delete contacts too */
        public void update(string searchDigits, string updatedName, string updatedNumber)
        {
            var matchingContacts = contactList.Where(c => c.number == searchDigits).FirstOrDefault();
            matchingContacts.name = updatedName;
            matchingContacts.number = updatedNumber;
        }

        public void DeleteContact(Contact contact)
        {
            contactList.Remove(contact);
        }

        public void DeleteMatchingContacts(string searchPhrase, string searchDigit)
        {
            var matchingContacts = contactList.Where(c => c.name == searchPhrase && c.number == searchDigit).ToList();
            foreach (var contact in matchingContacts)
            {
                DeleteContact(contact);
            }
        }
    }
}
