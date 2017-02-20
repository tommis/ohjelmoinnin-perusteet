using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.evenoruneven
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int input = Int32.Parse(Console.ReadLine()) % 2;

            if (input == 0)
            {
                Console.WriteLine("Number is even");
            }
            else if (input != 0)
            {
                Console.WriteLine("Number is not even");
            }

            Console.ReadKey();

        }
    }
}
