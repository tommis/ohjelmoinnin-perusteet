using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.MultiplyUpTo
{
    class Program
    {
        delegate int del(int i, int[] table);
        static void Main(string[] args)
        {
            Console.Write("Type a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int upToNumber = userInput > 0 ? userInput : 1;

            del multiplyWithPrevious =
                (i, table) =>
                     { return (i >= 2 ? table[i-2] : 1) * i; };
        
            int[] multiplyTable = new int[upToNumber];
            for (int i=1; i <= upToNumber; i++) {
                int a = multiplyWithPrevious(i, multiplyTable);
                multiplyTable[i-1] = a;
            }

            Console.WriteLine(string.Format("Answer: {0}",
                (multiplyTable[upToNumber - 1] >= 0) ?
                      Convert.ToString(multiplyTable[upToNumber - 1]) : "Undefined"));
            Console.ReadLine();
        }
    }
}
