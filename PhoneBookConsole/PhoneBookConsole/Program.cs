using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello From the Console PhoneBook App");
            Console.WriteLine("Select Operation");
            Console.WriteLine("1 Add Contact");
            Console.WriteLine("2 Display Contact by Number");
            Console.WriteLine("3 View All Contacts");
            Console.WriteLine("4 Sarch Contacts for given Name");
            Console.WriteLine("Press 'X to'Exait");

            var userInput = Console.ReadLine();

            var phoneBook = new PhoneBook();

            while(true)
            { 
             switch (userInput)
            {
                case "1":
                    Console.WriteLine("Contact Name");
                    var name = Console.ReadLine();

                    Console.WriteLine("Contact Number");
                    var number = Console.ReadLine();

                    var newContact = new Contact(name, number);
                    phoneBook.AddContact(newContact);


                    break;
                case "2":
                        Console.WriteLine("Contact Number to sarch : ");
                        var searchNumber = Console.ReadLine();

                        phoneBook.DisplayContact(searchNumber);

                        break;
                case "3":
                    break;
                case "4":
                        Console.WriteLine("Name Sarch Phrase");
                        var sarchPhrase = Console.ReadLine();

                        phoneBook.DisplatMatchingContacts(sarchPhrase);

                    break;
                    case "x":
                        return;
                default:
                    Console.WriteLine("Select Valid Operation");
                    break;
            }

                Console.WriteLine("Select Operation");
                userInput = Console.ReadLine();
            }
        
        }
    }
}
