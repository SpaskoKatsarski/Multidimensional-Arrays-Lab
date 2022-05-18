using System;
using System.Linq;

namespace SumColumsFromMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] info = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[info[0], info[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] rowInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rowInfo[j];
                }
            }



            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int currColSum = 0;

                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    currColSum += matrix[j, i];
                }

                Console.WriteLine(currColSum);
            }
        }
    }
}
