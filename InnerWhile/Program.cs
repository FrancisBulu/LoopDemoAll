using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int x = 0;

            while (i <= 2)
            {
                Console.WriteLine("I'm coming for outer loop");
                while (x < 3)
                {
                    Console.WriteLine("I'm coming for inner loop");
                    x++;
                }
                i++;
                x = 0;
            }
            Console.ReadKey();
        }
    }
}
