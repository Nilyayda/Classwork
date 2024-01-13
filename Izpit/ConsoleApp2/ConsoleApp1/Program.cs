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
            int nights = int.Parse(Console.ReadLine());
            string destination = Console.ReadLine().ToLower();
            string roomType = Console.ReadLine().ToLower();

            if (nights >= 1 && nights <= 20)
            {
                if (destination == "maldives")
                {
                    if (roomType == "beach villa")
                    {
                        int price = 380;
                        double rent = nights * price;
                        Console.WriteLine("They have to spend {0:f2} leva.", rent);
                    }
                    if (roomType == "apartment")
                    {
                        int price = 450;
                        double rent = nights * price;
                        Console.WriteLine("They have to spend {0:f2} leva.", rent);
                    }
                }
                if (destination == "bora bora")
                {
                    if (roomType == "beach villa")
                    {
                        int price = 350;
                        double rent = nights * price;
                        Console.WriteLine("They have to spend {0:f2} leva.", rent);
                    }
                    if (roomType == "apartment")
                    {
                        int price = 420;
                        double rent = nights * price;
                        Console.WriteLine("They have to spend {0:f2} leva.", rent);
                    }
                }
                if (destination == "singapore")
                {
                    if (roomType == "beach villa")
                    {
                        int price = 390;
                        double rent = nights * price;
                        Console.WriteLine("They have to spend {0:f2} leva.", rent);
                    }
                    if (roomType == "apartment")
                    {
                        int price = 490;
                        double rent = nights * price;
                        Console.WriteLine("They have to spend {0:f2} leva.", rent);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
