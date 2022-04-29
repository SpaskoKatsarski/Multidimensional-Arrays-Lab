using System;

namespace T7._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] pascalTriangle = new long[n][];

            pascalTriangle[0] = new long[] { 1 };

            for (int i = 1; i < n; i++)
            {
                pascalTriangle[i] = new long[i + 1];

                for (int j = 0; j < i + 1; j++)
                {
                    if (j == 0 || j == i)
                    {
                        pascalTriangle[i][j] = 1;
                    }
                    else
                    {
                        pascalTriangle[i][j] = pascalTriangle[i - 1][j] + pascalTriangle[i - 1][j - 1];
                    }
                }
            }

            for (int i = 0; i < pascalTriangle.GetLength(0); i++)
            {
                for (int j = 0; j < pascalTriangle[i].Length; j++)
                {
                    Console.Write(pascalTriangle[i][j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
