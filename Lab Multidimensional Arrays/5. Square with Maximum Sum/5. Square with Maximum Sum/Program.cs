using System;
using System.Linq;

namespace _5._Square_with_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            int row = size[0];
            int col = size[1];

            int[,] matrix = new int[row, col];

            ReadMatrix(row, col, matrix);

            int max = int.MinValue;
            
            int[,] data = new int[2,2];

            for(int i=0; i<row-1; i++)
            {
                for (int j = 0; j < col - 1; j++)
                {
                    int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];

                    if (sum > max)
                    {
                        max = sum;
                        data[0,0] = matrix[i, j];
                        data[0,1] = matrix[i, j + 1];
                        data[1,0] = matrix[i+1, j];
                        data[1,1] = matrix[i+1, j+1];
                    }
                }
            }

            PrintMatrix(data);

            Console.WriteLine(max);
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



        public static int[,] ReadMatrix(int row, int col, int[,] matrix)
        {
            for (int i = 0; i < row; i++)
            {

                int[] line = Console.ReadLine()
                                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();

                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            return matrix;
        }

    }
}
