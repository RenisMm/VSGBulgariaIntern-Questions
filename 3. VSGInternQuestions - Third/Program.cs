using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.VSGInternQuestions___Third
{
    class Program
    {
        static int countDuplicate(int[] numbers)
        {
            Array.Sort(numbers);

            int count = 0;
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;

                    if (numbers[i + 1] == numbers[i + 2])
                    {
                        count--;
                    }
                }
            }

            Console.WriteLine("The count of dublicated numbers is: ");
            return count;
        }

        static void Main(string[] args)
        {
            #region Array Creation
            Console.Write("Please enter a size of the array: ");
            int size = Int32.Parse(Console.ReadLine());

            if (size < 3 || size > 1000)
            {
                Console.WriteLine("The input should be between 3 and 1000!");
            }

            int[] numbers = new int[size];
            Console.WriteLine();

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Please enter a number with index {i}: ");
                int number = Int32.Parse(Console.ReadLine());
                if (number < 1 || number > 1000)
                {
                    Console.WriteLine("The input should be between 1 and 1000!");
                }
                numbers[i] = number;
            }
            #endregion
            Console.WriteLine();
            Console.WriteLine(countDuplicate(numbers));
        }
    }
}
