using System;
using System.Linq;

namespace T6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3
            //1 2 3
            //4 5 6
            //7 8 9
            //Add 0 0 5
            //Subtract 1 1 2
            //END

            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                jaggedArray[i] = numbers;
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] cmdArgs = command.Split();

                int row = int.Parse(cmdArgs[1]);
                int col = int.Parse(cmdArgs[2]);
                int value = int.Parse(cmdArgs[3]);

                if (row < 0 || row >= rows || col < 0 || col >= jaggedArray[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    command = Console.ReadLine();
                    continue;
                }

                if (cmdArgs[0] == "Add")
                {
                    jaggedArray[row][col] += value;
                }
                else if (cmdArgs[0] == "Subtract")
                {
                    jaggedArray[row][col] -= value;
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{jaggedArray[i][j]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
