using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
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

            int sum = 0;

            for (int i = 0; i < row; i++)
            {
                int[] rows = Console.ReadLine()
                                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();

                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = rows[j];
                }
            }

            for(int i=0; i<row; i++)
            {
                for(int j=0; j<col; j++)
                {
                    sum+= matrix[i, j];
                }
            }

            Console.WriteLine(row);
            Console.WriteLine(col);
            Console.WriteLine(sum);
        }
    }
}
