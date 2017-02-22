using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.evenUnevenAndNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());


            var numbers = new { even = new List<int>(), uneven = new List<int>()};
            for (int i = (userInput >= 0 ? 0 : userInput); i <= (userInput < 0 ? 0 : userInput); i++) {
                if (i % 2 == 0)
                    numbers.even.Add(i);
                else
                    numbers.uneven.Add(i);
            }

            if (numbers.even.Count() == 0 ) return;

            Console.WriteLine(string.Format("Answer:\n\n even {0}={1}\n uneven {2}={3}",
                string.Join<int>("+", numbers.even), numbers.even.Sum(),
                string.Join<int>("+", numbers.uneven), numbers.uneven.Sum()));

            Console.ReadLine();
        }
    }
}
