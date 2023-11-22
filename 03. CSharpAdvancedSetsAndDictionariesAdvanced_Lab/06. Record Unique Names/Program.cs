using System;
using System.Collections.Generic;

namespace _06._Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine()); //брой на имена
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();
                names.Add(name); //добавя само име, което все още го няма
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
