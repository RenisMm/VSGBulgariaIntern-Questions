using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSGInternQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(lastLetters(" "));
        }

        static string lastLetters(string word)
        {
            Console.Write("Please enter a word: ");
            word = "";
            do
            {
                word = Console.ReadLine();
                if (word.Length < 2 || word.Length > 100)
                {
                    Console.WriteLine($"The length of the word must be between: 2 and 100");
                }
            } while (word.Length < 2 || word.Length > 100);

            string lastLetter = word.Substring(word.Length - 1, 1);
            string otherLetter = word.Substring(word.Length - 2, 1);

            return lastLetter + " " + otherLetter;
        }
    }
}
