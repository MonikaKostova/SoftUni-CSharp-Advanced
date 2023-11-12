using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> evenNumbers = new Queue<int>(Console.ReadLine()
                                                    .Split()
                                                    .Select(int.Parse)
                                                    .Where(i => i % 2 == 0));
            Console.WriteLine(string.Join(", ", evenNumbers));
        }
    }
}