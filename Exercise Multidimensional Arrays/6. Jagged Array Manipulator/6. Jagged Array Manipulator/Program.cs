using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] matrix = new int[n][];

            ReadMatrix(n, matrix);

            for(int i=0; i<n-1;  i++)
            {
                if (matrix[i].Length == matrix[i+1].Length)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j] *= 2;
                        matrix[i+1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j] /= 2;
                    }

                    for (int j = 0; j < matrix[i+1].Length; j++)
                    {
                        matrix[i+1][j] /= 2;
                    }
                }                
            }

            while(true)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "End")
                    break;

                if (command[0] == "Add")
                {
                    if (ValidCoordinates(int.Parse(command[1]), int.Parse(command[2]), matrix))
                    {
                        matrix[int.Parse(command[1])][int.Parse(command[2])] += int.Parse(command[3]);
                    }
                }


                if (command[0] == "Subtract")
                {
                    if (ValidCoordinates(int.Parse(command[1]), int.Parse(command[2]), matrix))
                    {
                        matrix[int.Parse(command[1])][int.Parse(command[2])] -= int.Parse(command[3]);
                    }
                }

            }

            PrintMatrix(n, matrix);
        }



        public static void ReadMatrix(int n, int[][] matrix)
        {
            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();
            }
        }



        public static bool ValidCoordinates(int x, int y, int[][] matrix)
        {
            return
                x >= 0
                && x < matrix.Length
                && y >= 0
                && y < matrix[x].Length;
        }



        private static void PrintMatrix(int n, int[][] matrix)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }

                Console.WriteLine();
            }
        }

    }
}
