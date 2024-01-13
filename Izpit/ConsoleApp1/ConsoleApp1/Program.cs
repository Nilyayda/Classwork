using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rentPrice = int.Parse(Console.ReadLine());
            int foodPrice = rentPrice * 3;
            double drinksPrice = foodPrice - foodPrice * 0.2;
            double decorations = 0.1 * (foodPrice + drinksPrice);
            double payment = rentPrice + foodPrice + drinksPrice + decorations;
            Console.WriteLine("{0:F2}", payment);

            Console.ReadKey();
        }
    }
}
