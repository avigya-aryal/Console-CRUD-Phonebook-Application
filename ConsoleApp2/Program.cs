using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Contacts.\n");
            Console.WriteLine("Press [1] To Add a Contact");
            Console.WriteLine("Press [2] To Display All the Contacts");
            Console.WriteLine("Press [3] To Update a Contact");
            Console.WriteLine("Press [4] To Delete a contact");
            Console.WriteLine("Press 'E' to exit \n");

            var userInput = Console.ReadLine();

            var phoneBook = new PhoneBook();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.Write("\nEnter contact name: ");
                        var name = Console.ReadLine();

                        Console.Write("Enter contact number: ");
                        var number = Console.ReadLine();

                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);

                        break;

                    case "2":
                        phoneBook.DisplayAllContact();
                        break;

                    case "3":

                        Console.Write("\nEnter the person's contact number to update a contact: ");
                        var searchDigits = Console.ReadLine();

                        Console.Write("Enter contact name that you want to update: ");
                        var updatedName = Console.ReadLine();

                        Console.Write("Enter the contact number that you want to update: ");
                        var updatedNumber = Console.ReadLine();

                        

                        phoneBook.update(searchDigits, updatedName, updatedNumber);
                        Console.WriteLine("Updation Sucessfull :)");

                        break;

                    case "4":

                        Console.Write("\nEnter the contact name that you want to delete: ");
                        var searchPhrase = Console.ReadLine();

                        Console.Write("Enter the contact number that you want to delete: ");
                        var searchDigit = Console.ReadLine();

                        phoneBook.DeleteMatchingContacts(searchPhrase, searchDigit);

                        Console.WriteLine("Deletion Sucessfull :)");
                        break;

                    case "E":
                        return;

                    default:
                        Console.WriteLine("Select valid operation");
                        break;
                }

                Console.Write("\nPress [ok] to continue further OR Press [E] to exit the program : ");
                var output = Console.ReadLine();

                if(output == "ok")
                {
                    Console.WriteLine("\nWelcome to Contacts.\n");
                    Console.WriteLine("Press [1] To Add a Contact");
                    Console.WriteLine("Press [2] To Display All the Contacts");
                    Console.WriteLine("Press [3] To Update a Contact");
                    Console.WriteLine("Press [4] To Delete a contact");
                    Console.WriteLine("Press 'E' to exit \n");
                    userInput = Console.ReadLine();
                }
                else if(output == "E")
                {
                    Environment.Exit(0);
                }
                else
                {

                }
                
            }

        }
    }
}
