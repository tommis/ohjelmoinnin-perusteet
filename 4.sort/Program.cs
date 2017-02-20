using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = new int[3];

            Console.Write("Type first number: ");
            arrayOfNumbers[0] = int.Parse(Console.ReadLine());
            Console.Write("Type second number: ");
            arrayOfNumbers[1] = int.Parse(Console.ReadLine());
            Console.Write("Type third number: ");
            arrayOfNumbers[2] = int.Parse(Console.ReadLine());

            Array.Sort(arrayOfNumbers);

             foreach (int i in arrayOfNumbers) { 
                Console.WriteLine(i);
            }
            

            Console.ReadKey();
            
        }
    }
}
