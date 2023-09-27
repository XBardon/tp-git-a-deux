using System;
using System.IO;

namespace InfraDev_FX
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person myPerson = new Person();

            Console.Write("Your firstname : ");
            myPerson.Firstname = Console.ReadLine();
            Console.Write("Your lastname : ");
            myPerson.Lastname= Console.ReadLine();

            Console.Write(" === \n");
            int x = 0;
            do{ 
            Console.Write($"Your firstname is {myPerson.Firstname} and your lastname is {myPerson.Lastname}.\n");
                x++;
            }
            while (x < 2);
        }
    }
}
