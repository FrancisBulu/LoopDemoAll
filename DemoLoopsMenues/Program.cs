using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLoopsMenues
{
    class Program
    {
        static void Main(string[] args)
        {
            //string star = "**********************";
            //Console.WriteLine(star);

            //string lijn = new string('*', 80); // betere manier
            //Console.WriteLine(lijn);
            string input;
            string lijn = new string('_', 80);

            do
            {
                //Console.WriteLine("test test test");
                //Console.WriteLine("test test test");
                //Console.WriteLine("test test test");
                //Console.WriteLine("test test test");
                //Console.WriteLine("test test test");
                //Console.WriteLine("test test test");
                //Console.ReadLine();
                Console.Clear(); //---> experimenteren
                Console.WriteLine(lijn);
                Console.WriteLine("Wat wilt u doen\n1" +
                    "\tDe app afsluiten\n2" +
                    "\ttellen tot 100\n3" +
                    "\tHet aantal van een bepaald soort in een zin tellen\n4" +
                    "\tEn optelling doen");
                Console.WriteLine(lijn);
                input = Console.ReadLine();
                switch (input)
                {
                    case "2":
                        for (int i = 0; i <= 100; i++)
                        {
                            Console.WriteLine(i + " ");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Geef een zin aub");
                        string zin = Console.ReadLine().ToLower();
                        Console.WriteLine("Geef een letter aub ");
                        string letter = Console.ReadLine();
                        int aantalDezelfde = 0;
                        foreach (var c  in zin)
                        {
                            if (c == char.Parse(letter))
                            {
                                aantalDezelfde++;
                            }
                        }
                        Console.WriteLine($"De letter {letter} komt {aantalDezelfde} keer in de zin {zin} ");
                        break;
                    default:
                        break;
                }
                if (input !="1")
                {
                    Console.WriteLine("Druk enter om door te gaan");
                    Console.ReadLine();
                }

            } while (true);



        }

    }
}
