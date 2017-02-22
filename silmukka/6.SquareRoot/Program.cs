using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace _6.SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number\t\tSquare root\n");
            for (int i = 1; i <= 10; i++)
                Console.WriteLine(String.Format("{0}\t\t{1}", i, Convert.ToDecimal(string.Format("{0:F4}", Math.Sqrt(i)))));

            Console.ReadLine();
        }
    }
}
