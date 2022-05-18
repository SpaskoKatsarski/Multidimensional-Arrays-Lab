using System;

namespace PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] triangle = new long[n][];

            for (int i = 0; i < triangle.Length; i++)
            {
                triangle[i] = new long[i + 1];

                for (int j = 0; j < triangle[i].Length; j++)
                {
                    if (j == 0 || j == i)
                    {
                        triangle[i][j] = 1;
                    }
                    else
                    {
                        triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                    }
                }
            }

            for (int row = 0; row < triangle.Length; row++)
            {
                Console.WriteLine(string.Join(' ', triangle[row]));
            }
        }
    }
}
