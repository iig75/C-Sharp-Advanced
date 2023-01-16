using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            int row = size[0];
            int col = size[1];

            char[,] matrix = new char[row, col];

            ReadMatrix(row, col, matrix);

            int count = 0;

            for(int i=0; i<row-1; i++)
            {
                for(int j=0; j<col-1; j++)
                {
                    if ((matrix[i, j] == matrix[i,j+1]) && (matrix[i, j] == matrix[i+1, j]) && (matrix[i, j] == matrix[i+1, j+1]))
                    {
                        count++;
                    }
                }
            }


            Console.WriteLine(count);
        }



        public static char[,] ReadMatrix(int row, int col, char[,] matrix)
        {
            for (int i = 0; i < row; i++)
            {

                char[] line = Console.ReadLine()
                                     .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                     .Select(char.Parse)
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
