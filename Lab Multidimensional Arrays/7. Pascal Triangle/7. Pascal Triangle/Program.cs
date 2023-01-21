using System;
using System.Runtime.CompilerServices;

namespace _7._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] triangle = new long[n][];

            for (int i = 0; i < triangle.Length; i++)
            {
                triangle[i] = new long[i+1];

                for (int j=0; j < triangle[i].Length; j++)
                {
                    triangle[i][j] = 0;

                    if ((isValid(i-1, j-1, triangle)) && (isValid(i - 1, j, triangle)))
                    {
                        triangle[i][j] = triangle[i-1][j-1] + triangle[i - 1][j];
                    }
                    else
                    {
                        triangle[i][j] = 1;
                    }

                }
            }

            PrintMatrix(triangle);
        }

        public static bool isValid(int i, int j, long[][] triangle)
        {
            return
                i >= 0
                && i < triangle.Length
                && j >= 0
                && j < triangle[i].Length;
        }



        private static void PrintMatrix(long[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
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
