using System;
using System.Linq;

namespace SumElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] info = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[info[0], info[1]];

            for (int i = 0; i < info[0]; i++)
            {
                int[] rowInfo = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < info[1]; j++)
                {
                    matrix[i, j] = rowInfo[j];
                }
            }

            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
