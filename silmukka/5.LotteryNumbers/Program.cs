using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.LotteryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Answer: ");

            Random rnd = new Random();


            /* TODO */

            for (int i = 1; i <= 20; i++)
                Console.WriteLine(String.Format("Row {0}: {1}", i, rnd.Next(1, 50)));

            Console.ReadLine();
        }
    }
}
