using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSGInternPrep_Fourth_Question
{
    class Program
    {
        static void Main(string[] args)
        {
            fizzBuzz(1);
        }

        static void fizzBuzz(int n)
        {
            Console.Write("Please enter a number: ");
            n = Int32.Parse(Console.ReadLine());
            if (n < 0 || n > 2 * Math.Pow(10, 5))
            {
                Console.WriteLine($"The input should be between: 0 and {2 * Math.Pow(10, 5)}");
                return;
            }
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");

                }
                else if (i % 3 != 0 && i % 5 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}


