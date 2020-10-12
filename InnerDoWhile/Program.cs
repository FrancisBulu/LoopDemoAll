using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                int j = 1;
                do
                {
                    Console.WriteLine($" i= {i} j= {j}");
                    j++;
                } while (j <= 3);
                i++;
            } while (i <= 2);
            Console.ReadKey();
        }
 
    }
}
