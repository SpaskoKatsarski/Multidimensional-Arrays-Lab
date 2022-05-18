using System;

namespace SymbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] rowInfo = Console.ReadLine().ToCharArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rowInfo[j];
                }
            }

            char symbolToSearchFor = char.Parse(Console.ReadLine());

            int row = -1;
            int col = -1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == symbolToSearchFor)
                    {
                        row = i;
                        col = j;

                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            if (row == -1 && col == -1)
            {
                Console.WriteLine($"{symbolToSearchFor} does not occur in the matrix");
            }
        }
    }
}
