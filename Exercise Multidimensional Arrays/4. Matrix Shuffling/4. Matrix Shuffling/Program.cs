using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            int rows = size[0];
            int cols = size[1];

            string[,] matrix = new string[rows, cols];

            ReadMatrix(rows, cols, matrix);

            while(true)
            {
                string[] command = Console.ReadLine()
                                         .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "END")
                    break;

                if(validRange(command, matrix))
                {

                    string temp = matrix[int.Parse(command[1]), int.Parse(command[2])];

                    matrix[int.Parse(command[1]), int.Parse(command[2])] = matrix[int.Parse(command[3]), int.Parse(command[4])];

                    matrix[int.Parse(command[3]), int.Parse(command[4])] = temp;

                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }



        public static bool validRange(string[] command, string[,] matrix)
        {
            return
                command.Length == 5
                && command[0] == "swap"
                && int.Parse(command[1]) >= 0 && int.Parse(command[1]) < matrix.GetLength(0)
                && int.Parse(command[2]) >= 0 && int.Parse(command[2]) < matrix.GetLength(1)
                && int.Parse(command[3]) >= 0 && int.Parse(command[3]) < matrix.GetLength(0)
                && int.Parse(command[4]) >= 0 && int.Parse(command[4]) < matrix.GetLength(1);
        }



            public static string[,] ReadMatrix(int rows, int cols, string[,] matrix)
        {
            for (int i = 0; i < rows; i++)
            {

                string[] line = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            return matrix;
        }



        private static void PrintMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
