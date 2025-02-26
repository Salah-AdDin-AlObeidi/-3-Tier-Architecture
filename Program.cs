using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsBusinessLayer;
namespace ContactsConsolApp2
{
    internal class Program
    {

        static void SetFinde(int ID)
        {

            clsContact contact1 = clsContact.Find(ID);

            if (contact1 != null)
            {

                Console.WriteLine(contact1._FirstName + " " + contact1.LastName) ;
                Console.WriteLine(contact1.Email);
                Console.WriteLine(contact1.Phone);
                Console.WriteLine(contact1.Address);
                Console.WriteLine(contact1.DateOfBirth);
                Console.WriteLine(contact1.CountryID);
                Console.WriteLine(contact1.ImagePath);
            }
            else
            {
                Console.WriteLine("Contact not found");
            }
        }
        static void Main(string[] args)
        {
            SetFinde(1);
            Console.ReadKey();




        }
    }
}