using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] matrix = new int[n][];

            for (int i = 0;i < n; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }
            int diagonalSum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                diagonalSum += matrix[row][row];
            }
            Console.WriteLine(diagonalSum);
        }
    }  
}
    
