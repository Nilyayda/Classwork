using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceFor1shirt = double.Parse(Console.ReadLine());
            int shirts = int.Parse(Console.ReadLine());
            int jackets = int.Parse(Console.ReadLine());
            int pants = int.Parse(Console.ReadLine());
            int sweaters = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double priceFor1jacket = priceFor1shirt + (0.4 * priceFor1shirt);
            double priceFor1pants = priceFor1jacket - (0.2 * priceFor1jacket);
            double priceFor1sweater = priceFor1pants - 10;
            double order = (shirts * priceFor1shirt) + (jackets * priceFor1jacket) + (pants * priceFor1pants) + (sweaters * priceFor1sweater);
            if (order <= budget)  
            {
                double left = 1000 - order;
                Console.WriteLine("Yes! {0:F2} leva left.", left);
            }
            else
            {
                double need = order - budget;
                Console.WriteLine("No! {0:F2} leva needed.", need);
            }
            Console.ReadKey();
        }
    }
}
