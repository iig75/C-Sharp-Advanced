using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int n = int.Parse(Console.ReadLine());

            int row = n;
            int col = n;

            int[,] matrix = new int[row, col];

            ReadMatrix(row, col, matrix);

            int sum = 0;

            for(int i=0; i<row; i++)
            {
                sum+= matrix[i,i];
            }

            Console.WriteLine(sum);
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
