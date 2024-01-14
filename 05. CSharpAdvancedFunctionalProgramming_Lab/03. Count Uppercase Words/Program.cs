using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Func<string, bool> filter = text => Char.IsUpper(text[0]);

            string[] words = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            words = words.Where(filter)
                          .ToArray();

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
