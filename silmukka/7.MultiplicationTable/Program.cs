using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Answer:\n");
            Console.WriteLine("   1  2  3  4  5  6  7  8  9\n  -------------------------------");
            for (int i = 1; i < 10; i++) {
                List<int> tableRow = new List<int>();
                foreach (int multiple in Enumerable.Range(1, 10))
                    tableRow.Add(i * multiple);
                Console.WriteLine(String.Format("{0} | {1}", i, string.Join(" ", tableRow)));
            }

            Console.ReadLine();
        }
    }
}
