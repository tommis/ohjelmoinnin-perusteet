using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Int32.Parse(Console.ReadLine());

            if (input < 0) {
                Console.WriteLine("Number is negative");
            }
            else if (input >= 0)
            {
                Console.WriteLine("Number is positive");
            }
        }
    }
}
