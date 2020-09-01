using System;

namespace Uppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ditt namn");

            string namn = Console.ReadLine();

            Console.WriteLine("Ditt namn är: " + namn);

            Console.WriteLine("Din ålder:");

            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your age is: " + age);
            Console.WriteLine("Om du är vid liv skrov ja, om du är död skriv nej");

            bool alive = true;
            var pulscheck = Console.ReadLine();

            if (pulscheck == "ja")
            {
                alive = true;

            }
            else
            {
                alive = false;
            }
            if (alive == true)
            {
                Console.WriteLine("Ditt namn är " + namn);
                Console.WriteLine("Din ålder är " + age);
                Console.WriteLine("Du är vid liv");
            }
            else
            {
                Console.WriteLine("Ditt namn är" + namn);
                Console.WriteLine("Din ålder är" + age);
                Console.WriteLine("Du är död");
            }
        }
    }
}
