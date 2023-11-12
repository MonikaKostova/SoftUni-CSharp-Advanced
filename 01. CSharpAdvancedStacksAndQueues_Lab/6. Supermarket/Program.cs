using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue <string> clients = new Queue<string>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Paid")
                {
                    while (clients.Any())
                    {
                        Console.WriteLine(clients.Dequeue());
                    }
                }
                else
                {
                    clients.Enqueue(input);
                }
            }

            Console.WriteLine($"{clients.Count} people remaining.");
        }
    }
}
