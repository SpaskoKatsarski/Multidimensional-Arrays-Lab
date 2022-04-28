using System;

namespace T4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int[,] symbols = new int[length, length];

            if (length != 0)
            {
                for (int i = 0; i < symbols.GetLength(0); i++)
                {
                    char[] rowInfo = Console.ReadLine().ToCharArray();

                    for (int j = 0; j < symbols.GetLength(1); j++)
                    {
                        symbols[i, j] = rowInfo[j];
                    }
                }
            }

            char symbolToSearch = char.Parse(Console.ReadLine());

            int row = -1;
            int col = -1;

            bool isFound = false;

            for (int i = 0; i < symbols.GetLength(0); i++)
            {
                for (int j = 0; j < symbols.GetLength(1); j++)
                {
                    if (symbols[i, j] == symbolToSearch)
                    {
                        row = i;
                        col = j;

                        isFound = true;
                        break;
                    }
                }

                if (isFound)
                {
                    break;
                }
            }

            if (row == -1 || col == -1)
            {
                Console.WriteLine($"{symbolToSearch} does not occur in the matrix ");
            }
            else
            {
                Console.WriteLine($"({row}, {col})");
            }
        }
    }
}
