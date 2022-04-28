using System;
using System.Linq;

namespace T2._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3, 6
            //7  1  3  3  2  1
            //1  3  9  8  5  6
            //4  6  7  9  1  0
            //12 10 ...

            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] rowInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rowInfo[j];
                }
            }

            for (int i = 0; i < cols; i++)
            {
                int sum = 0;

                for (int j = 0; j < rows; j++)
                {
                    sum += matrix[j, i];
                }

                Console.WriteLine(sum);
            }
        }
    }
}
