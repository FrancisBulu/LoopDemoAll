using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopDemoAll
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                i++;
                if (i==5)
                {
                    continue;

                }
                Console.WriteLine($"");

            }
        }
    }
}
