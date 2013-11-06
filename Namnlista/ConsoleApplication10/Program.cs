using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namnlista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Lagmedlem> myPersons = new List<Lagmedlem>();

            while (true)
            {
                Console.WriteLine("Tryck A för att lägga till en ny lagmedlem\n"
                                + "Tryck B för att skriva ut alla i listan\n"
                                + "Tryck X för att avsluta");

                string val = Console.ReadLine().ToLower();

                switch (val)
                {
                    case "a":

                        Lagmedlem nytt = new Lagmedlem();
                        Console.WriteLine("Namn?");
                        nytt.namn = Console.ReadLine();

                        Console.WriteLine("Nickname?");
                        nytt.nick = Console.ReadLine();

                        Console.WriteLine("Ålder?");
                        nytt.alder = int.Parse(Console.ReadLine());

                        Console.WriteLine("Kön?");
                        nytt.kon = Console.ReadLine();

                        Console.WriteLine("Adress?");
                        nytt.adress = Console.ReadLine();

                        Console.WriteLine("Spel?");
                        nytt.spel = Console.ReadLine();

                        Console.WriteLine("Hur aktiv?");
                        nytt.aktiv = Console.ReadLine();

                        myPersons.Add(nytt);
                        break;
                    case "b":
                        foreach (Lagmedlem p in myPersons)
                        {
                            Console.WriteLine(p + "\n");
                        }
                        break;
                    default:
                        Console.WriteLine("Du gjorde inte ett korrekt val.");
                        Console.Clear();
                        break;
                    case "x":
                        Environment.Exit(0);
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
