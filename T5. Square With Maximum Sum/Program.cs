using System;
using System.Linq;

namespace T5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] rowInfo = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rowInfo[j];
                }
            }

            int biggestSum = int.MinValue;

            int maxRow = -1;
            int maxCol = -1;

            bool flag = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = row; col < matrix.GetLength(1); col++)
                {
                    if (col + 1 == cols || row + 1 == rows)
                    {
                        flag = true;
                        break;
                    }

                    int currentSum = 0;

                    for (int i = row; i < row + 2; i++)
                    {
                        for (int j = col; j < col + 2; j++)
                        {
                            currentSum += matrix[i, j];
                        }
                    }

                    if (currentSum > biggestSum)
                    {
                        biggestSum = currentSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            int sum = 0;

            for (int i = maxRow; i < maxRow + 2; i++)
            {
                for (int j = maxCol; j < maxCol + 2; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                    sum += matrix[i, j];
                }

                Console.WriteLine();
            }

            Console.WriteLine(sum);
        }

        // Needs a fix (60/100), still no fail tests found.
    }
}
