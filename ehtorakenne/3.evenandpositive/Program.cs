using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.evenandpositive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number: ");
            int result = Convert.ToInt32(Console.ReadLine());

            string isEven = result % 2 == 0 ? "even" : "uneven";
            string signess = result >= 0 ? "positive" : "negative";

            string output = string.Format("number {0} {1} and {2}", result, isEven, signess);

            Console.WriteLine(output);

            Console.ReadKey();

        }
    }
}
