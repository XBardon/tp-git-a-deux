using System;
using System.IO;

namespace InfraDev_FX
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person p1 = new Person();

            Console.Write("Your firstname : ");
            p1.Firstname = Console.ReadLine();
            Console.Write("Your lastname : ");
            p1.Lastname= Console.ReadLine(); 

            Console.Write($"Your firstname is {p1.Firstname} and your lastname is {p1.Lastname}.");
            
        }
    }
}
