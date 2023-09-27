using System;
using System.IO;

namespace InfraDev_FX
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person p1 = new Person("toto", "tata");

            Console.WriteLine(p1);
        
            string _firstname;// = Console.ReadLine("Please enter a firstname :");
            string _lastname;// = Console.ReadLine("Please enter a lastname :");

            string a;
            Console.Write("Veuillez taper : ");
            a = Console.ReadLine();
            Console.WriteLine("tatapé : " + a);
        }

    }
}
