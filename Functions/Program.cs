using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi:");
            string userFamilyName = Console.ReadLine();
            Console.WriteLine("Sisesta sünniaasta:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            Greetings(userName, userFamilyName, userAge);
        }

        private static void Greetings(string someString, string someString2, int someInt)
        {
            Console.WriteLine($"Tere, {someString} {someString2}!");
            Console.WriteLine($"Oled {2021 - someInt} aastat vana.");
        }

    }
}
