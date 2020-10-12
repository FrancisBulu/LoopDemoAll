using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int no = 5;
            for (int i = 0; i <=5; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(i); // writeLine geeft iets anders
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        
    }
}
