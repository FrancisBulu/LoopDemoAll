using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
   

    class Program
    {
        static void Main(string[] args)
        {
            string [] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            Console.WriteLine("The days in the week: ");
            foreach (string day in days)

            {
                Console.WriteLine(day);
            }

            string[] workingDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            Console.WriteLine("The Working days in the week: ");
            foreach (string day in workingDays)

            {
                Console.WriteLine(day);
            }
            Console.ReadKey();
        }
    }
}
