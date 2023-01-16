using System;
using System.Linq;

namespace _3._Maximal_Sum
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

            int[,] matrix = new int[row, col];

            ReadMatrix(row, col, matrix);

            int max = int.MinValue;
            int sum = 0;

            int[,] result = new int[3, 3];

            for(int i=0; i<row-2; i++)
            {
                for(int j=0; j<col-2; j++)
                {
                    sum = 0;
                    for(int z=0; z<3; z++)
                    {
                        for(int zz=0; zz<3; zz++)
                        {
                            sum += matrix[i + z, j + zz];

                        }
                    }

                    if(sum>max)
                    {
                        max = sum;

                        for (int z = 0; z < 3; z++)
                        {
                            for (int zz = 0; zz < 3; zz++)
                            {
                                result[z,zz] = matrix[i + z, j + zz];

                            }
                        }
                    }
                }
            }

            Console.WriteLine("Sum = "+max);

            for (int z = 0; z < 3; z++)
            {
                for (int zz = 0; zz < 3; zz++)
                {
                    Console.Write(result[z, zz] + " ");
                }
                Console.WriteLine();
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
