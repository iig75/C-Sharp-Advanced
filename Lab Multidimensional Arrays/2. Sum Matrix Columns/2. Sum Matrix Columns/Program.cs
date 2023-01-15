using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
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

            int sum = 0;

            for(int i=0; i<col; i++)
            {
                sum = 0;

                for(int j=0; j<row; j++)
                {
                    sum += matrix[j,i];
                }

                Console.WriteLine(sum);
            }            
        }

        public static int[,] ReadMatrix(int row, int col, int[,] matrix)
        {
            for (int i = 0; i < row; i++)
            {

                int[] line = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
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
