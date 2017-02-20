using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.AddUpTo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            int resultSum = 1;
            for (int i = 0; i <= userInput; i = i + (i + 1))
                resultSum = i;

            Console.WriteLine(string.Format("Answer: {0}",
                (resultSum >= 0) ?
                      Convert.ToString(resultSum) : "Undefined"));
            Console.ReadLine();
        }
    }
}
