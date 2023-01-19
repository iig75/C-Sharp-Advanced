using System;
using System.Linq;

namespace _8._Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            ReadMatrix(n, matrix);

            string[] str = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int[,] bombs = new int[str.Count(), 2];

            for(int row=0; row<str.Count(); row++)
            {
                string x= str[row];

                int[] line = x.Split(",")
                              .Select(int.Parse)
                              .ToArray();

                for(int col=0; col<2; col++)
                {
                    bombs[row, col] = line[col]; 
                }
                
            }

            for(int i=0; i<bombs.Length/2; i++)
            {
                if (matrix[bombs[i, 0], bombs[i, 1]] > 0)
                {
                    explode(bombs[i, 0], bombs[i, 1], matrix);
                }
            }

            int aliveCellsCount = 0;
            int aliveCellsSum = 0;

            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    if (matrix[i,j]>0)
                    {
                        aliveCellsCount++;
                        aliveCellsSum += matrix[i, j];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {aliveCellsCount}");
            Console.WriteLine($"Sum: {aliveCellsSum}");
            PrintMatrix(matrix);  
        }



        public static int[,] ReadMatrix(int n, int[,] matrix)
        {
            for (int i = 0; i < n; i++)
            {

                int[] line = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            return matrix;
        }



        public static bool isValidCoordinates(int x, int y, int[,] matrix)
        {
            return
                x >= 0 
                && x < matrix.GetLength(0)
                && y >= 0 
                && y < matrix.GetLength(1);
        }



        public static void explode(int row, int col, int[,] matrix)
        {
            int bombStrength = matrix[row, col];

            for(int n=-1; n<2; n++)
            {
                for(int m=-1; m<2; m++)
                {
                    if (isValidCoordinates(row + n, col + m, matrix))
                    {
                        if (matrix[row + n, col + m] > 0)
                        {
                            matrix[row + n, col + m] -= bombStrength;
                        }
                    }
                }
            }
        }


        private static void PrintMatrix(int[,] matrix)
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
