using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for(int row = 0; row < size; row++)
            {
                int[] numbers = Console.ReadLine()
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                            .Select(n => int.Parse(n))
                            .ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = numbers[col]; 
                } 
            }
            int primaryDiagonal = 0; // номер на ред = номер на колона
            int secondaryDiagonal = 0; // номер на колона = size -1 -номера на реда

            for (int row = 0; row <= size - 1; row++)
            {
                for (int col = 0; col <= size - 1; col++)
                {
                    int element = matrix[row, col];
                    if( row == col) //>> елементът е на главния диагонал
                    {
                        primaryDiagonal += element;
                    }

                    if( col == size - 1 - row) //елементът е на второстепенния диагонал
                    {
                        secondaryDiagonal += element;
                    }
                }
            }

            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));

        }
    }
}
