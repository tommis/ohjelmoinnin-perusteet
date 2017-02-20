using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.TicketPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList acceptedDiscounts = new ArrayList(); 

            Console.Write("Age: ");
            decimal age = decimal.Parse(Console.ReadLine());
            Console.Write("Mtk [Y/N]: ");
            bool isMtk = Console.ReadLine() == "y" ? true : false;
            Console.Write("Soldier [Y/N]: ");
            bool isSoldier = Console.ReadLine() == "y" ? true : false;
            Console.Write("Student [Y/N]: ");
            bool isStudent = Console.ReadLine() == "y" ? true : false;

            decimal ageDiscount =
                (age < 7.0M) ? 0.0M :
                     (7.0M < age) ?
                       (age < 15.0M) ? 0.50M :
                         (age >= 65.0M ? 0.50M : 1.0M) : 1.0M;
            acceptedDiscounts.Add(ageDiscount);

            if (isMtk && isStudent)
                acceptedDiscounts.Add(0.15M + 0.45M);
            else if (isMtk)
                acceptedDiscounts.Add(0.15M);
            else if (isStudent)
                acceptedDiscounts.Add(0.45M);

            if (isSoldier)
                acceptedDiscounts.Add(0.50M);

            int[] acceptedDiscountsArray = new int[] { };

            acceptedDiscounts.Sort();
            acceptedDiscounts.CopyTo(acceptedDiscountsArray);

            decimal ticketPrice = 16.0M - (16.0M * acceptedDiscountsArray[0]);

            Console.WriteLine(string.Format("Price {0}, accepted discount{1}", ticketPrice, acceptedDiscounts[0]));

            Console.ReadKey();
        }
    }
}
