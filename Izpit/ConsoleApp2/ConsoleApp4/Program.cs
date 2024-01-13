using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counting = 0;

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    for (int k = 1; k < 10; k++)
                    {
                        for (int l = 1; l < 10; l++)
                        {
                            for (int m = 1; m < 10; m++)
                            {
                                if (i + j + k == n && l % 2 == 0 && m == 1)  
                                {
                                    Console.WriteLine($"{i}{j}{k}{l}{m} ");
                                    counting++; 
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Count of winner numbers: {0}", counting);
            Console.ReadKey();
        }
    }
}
