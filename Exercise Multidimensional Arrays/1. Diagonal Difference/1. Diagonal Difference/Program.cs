using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            ReadMatrix(n, n, matrix);

            int d1 = 0;
            int d2 = 0;

            for(int i=0; i<n; i++)
            {
                d1 += matrix[i,i];
                d2 += matrix[n-i-1, i];  
            }

            Console.WriteLine(Math.Abs(d1-d2));
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
