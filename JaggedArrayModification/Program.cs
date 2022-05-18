using System;
using System.Linq;

namespace JaggedArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfRows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[countOfRows][];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                int[] rowInfo = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                jaggedArray[i] = rowInfo;
            }

            while (true)
            {
                string[] cmd = Console.ReadLine().Split();

                if (cmd[0] == "END")
                {
                    break;
                }
                else if (cmd[0] == "Add")
                {
                    int row = int.Parse(cmd[1]);
                    int col = int.Parse(cmd[2]);
                    int value = int.Parse(cmd[3]);

                    if (row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length)
                    {
                        jaggedArray[row][col] += value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else if (cmd[0] == "Subtract")
                {
                    int row = int.Parse(cmd[1]);
                    int col = int.Parse(cmd[2]);
                    int value = int.Parse(cmd[3]);

                    if (row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length)
                    {
                        jaggedArray[row][col] -= value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine(string.Join(' ', jaggedArray[i]));
            }
        }
    }
}
