using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.AddUpToWithNegativeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            int resultSum = 0;
            for (int i = (userInput >= 0 ? 0 : userInput); i <= (userInput < 0 ? 0 : userInput); i++)
                resultSum = resultSum + i;

            Console.WriteLine(string.Format("Answer: {0}", Convert.ToString(resultSum)));

            Console.ReadLine();
        }
    }
}
