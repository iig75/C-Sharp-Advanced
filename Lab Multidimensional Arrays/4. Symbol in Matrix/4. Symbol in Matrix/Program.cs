using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            ReadMatrix(n, n, matrix);

            char key = char.Parse(Console.ReadLine());

            bool found = false;

            for(int i=0; i<n;i++)
            {
                for(int j=0; j<n; j++)
                {
                    if (matrix[i,j] == key)
                    {
                        found = true;
                        Console.WriteLine($"({i}, {j})");
                        break;
                    }
                }

                if (found)
                    break;
                
            }

            if (!found)
                Console.WriteLine($"{key} does not occur in the matrix");
        }



        public static char[,] ReadMatrix(int row, int col, char[,] matrix)
        {
            for (int i = 0; i < row; i++)
            {

                string line = Console.ReadLine();

                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            return matrix;
        }

    }
}
